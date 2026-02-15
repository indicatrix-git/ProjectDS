using DevExpress.XtraEditors.Controls;
using PCB.Base;
using PCB.Data;
using PCB.Data.CustomObjects;
using PCB.Report;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public partial class frmObjednavkaPolozkaDetail : frmBaseDetail
    {
        public frmObjednavkaPolozkaDetail()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (((objednavka_polozka)this.entityObject).stav_objednavka_id == (int)stav_objednavka.Value.SpustenaDoVyroby)
            {
                if (!HasPravoZapis(prava.Value.ObchodObjednavky))
                {
                    base.setReadonly(cs);
                }
            }

            if (!HasPravoZapis(prava.Value.ObchodObjednavky, prava.Value.TechnologieObjednavky, prava.Value.TPVObjednavky))
            {
                base.setReadonly(cs);
            }

            btnZavrit.Enabled = true;
            btnTechnickaDokumentace.Enabled = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            if (this.FormMode == mode.novy && this.entityObject == null)
            {
                this.entityObject = new objednavka_polozka();
                ((objednavka_polozka)this.entityObject).cenik = this.DBContext.ceniks.OrderBy(i => i.datum).FirstOrDefault();
                ((objednavka_polozka)this.entityObject).stav_objednavka_id = this.DBContext.stav_objednavkas.Where(i => i.stav_objednavka_id == (int)stav_objednavka.Value.ZalozenaPredanoDoTPV).First().stav_objednavka_id;
            }

            if (this.FormMode == mode.novy && this.entityObject != null)
            {
                ((objednavka_polozka)this.entityObject).stav_objednavka = this.DBContext.stav_objednavkas.Where(i => i.stav_objednavka_id == ((objednavka_polozka)this.entityObject).stav_objednavka_id).First();
            }

            this.ObjednavkaPolozkaBindingSource.DataSource = this.entityObject;
            this.uzivatelBindingSource.DataSource = this.DBContext.uzivatels;
            this.plosnyspojdruhBindingSource.DataSource = this.DBContext.plosny_spoj_druhs;
            this.termintypBindingSource.DataSource = this.DBContext.termin_typs;
            this.plosnyspojspecifikaceBindingSource.DataSource = this.DBContext.plosny_spoj_specifikaces.ToList();
            this.dopravaBindingSource.DataSource = this.DBContext.dopravas.ToList();
            this.cenikBindingSource.DataSource = this.DBContext.ceniks.ToList();

            if (((objednavka_polozka)this.entityObject).produkt != null)
            {
                txtPlochaDPS.Enabled = false;
            }


        }


        private void btnNapovedaTechPridavky_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Technologický přídavek\Tech_pridavek.jpg");

        }

        private void btnNapovedaALPlechy_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Počet Al plechů pro laminaci\Al_plechy.jpg");

        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                ((objednavka_polozka)this.entityObject).zadal_id = this.PrihlasenyUzivatelId;
                ((objednavka_polozka)this.entityObject).d_zadal = PCB.Data.DBHelper.DateTimeNow();
                this.DBContext.objednavka_polozkas.AddObject(((objednavka_polozka)this.entityObject));

                if (((objednavka_polozka)this.entityObject).termin_vyroby != null)
                {
                    kapacita k = new kapacita();
                    k.objednavka_polozka_id = ((objednavka_polozka)this.entityObject).objednavka_polozka_id;
                    k.pocet_ks = ((objednavka_polozka)this.entityObject).PocetksCelkem;
                    k.uzivatel_id = this.PrihlasenyUzivatelId;
                    k.datum = DateTime.Parse(((objednavka_polozka)this.entityObject).termin_vyroby.Value.ToString(DBHelper.FormatDatumCasNula));
                    k.d_zapsano = DBHelper.DateTimeNow();
                    this.DBContext.kapacitas.AddObject(k);
                }

            }
            else
            {
                int pocetZmen = 0;
                if (((objednavka_polozka)this.entityObject).termin_vyroby != null)
                {

                    foreach (kapacita k in this.DBContext.kapacitas.Where(item => item.objednavka_polozka_id == ((objednavka_polozka)this.entityObject).objednavka_polozka_id))
                    {
                        pocetZmen++;
                        k.datum = DateTime.Parse(((objednavka_polozka)this.entityObject).termin_vyroby.Value.ToString(DBHelper.FormatDatumCasNula));
                    }

                    if (pocetZmen == 0) // neexistuje zaznam o kapacite
                    {
                        kapacita k = new kapacita();
                        k.objednavka_polozka_id = ((objednavka_polozka)this.entityObject).objednavka_polozka_id;
                        k.pocet_ks = ((objednavka_polozka)this.entityObject).PocetksCelkem;
                        k.uzivatel_id = this.PrihlasenyUzivatelId;
                        k.datum = DateTime.Parse(((objednavka_polozka)this.entityObject).termin_vyroby.Value.ToString(DBHelper.FormatDatumCasNula));
                        k.d_zapsano = DBHelper.DateTimeNow();
                        this.DBContext.kapacitas.AddObject(k);
                    }

                }




            }




            base.SaveData();
        }


        private void btnEditNazevDPS_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmProduktSeznam seznam = new frmProduktSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((objednavka_polozka)this.entityObject).produkt_id = ((produkt)seznam.entityObject).produkt_id;
                ((objednavka_polozka)this.entityObject).plocha_dps = ((produkt)seznam.entityObject).plocha;
                ((objednavka_polozka)this.entityObject).plosny_spoj_specifikace_id = ((produkt)seznam.entityObject).plosny_spoj_specifikace_id;
                ((objednavka_polozka)this.entityObject).majitel_zakaznik_id = ((produkt)seznam.entityObject).zakaznik_id;

                txtPlochaDPS.Enabled = false;
            }
        }

        private void btnEditZakaznik_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmZakaznikSeznam seznam = new frmZakaznikSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((objednavka_polozka)this.entityObject).majitel_zakaznik_id = ((zakaznik)seznam.entityObject).zakaznik_id;
            }
        }

        private void btnEditNabidka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmNabidkaPolozkaSeznam seznam = new frmNabidkaPolozkaSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                btnEditNabidka.Text = ((nabidka_polozka)seznam.entityObject).d_sestaveno.Value.ToString("d.MM.yyyy");
                ((objednavka_polozka)this.entityObject).nabidka_polozka_id = ((nabidka_polozka)seznam.entityObject).nabidka_polozka_id;
            }
        }

        private void btnUlozit_ItemClick(object sender, EventArgs e)
        {
            this.Valid();
            if (this.isValid)
            {
                btnEditZakaznik.Focus();

                frmObjednavkaPolozkaWorkflow workflow = new frmObjednavkaPolozkaWorkflow();
                if (workflow.ShowForm(this) == DialogResult.OK)
                {
                    if (workflow.Stav != 0)
                    {
                        ((objednavka_polozka)this.entityObject).stav_objednavka = this.DBContext.stav_objednavkas.Where(i => i.stav_objednavka_id == workflow.Stav).First();
                    }

                    this.SaveData();
                    //this.Ulozit();
                    this.Close();
                }
            }
        }

        private void btnZavrit_ItemClick(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnPruvodky_ItemClick(object sender, EventArgs e)
        {
            frmPruvodkaSeznam frm = new frmPruvodkaSeznam();
            frm.ShowForm(this);
        }

        private void btnKapacita_ItemClick(object sender, EventArgs e)
        {
            if (((objednavka_polozka)this.entityObject).produkt != null)
            {
                frmKapacitaVyrobyDetail frm = new frmKapacitaVyrobyDetail();
                if (frm.ShowDetail(this, this.entityObject) == System.Windows.Forms.DialogResult.OK)
                {
                    ((objednavka_polozka)this.entityObject).termin_vyroby = ((objednavka_polozka)frm.entityObject).termin_vyroby;
                }
            }
        }

        private void btnZobrazitCenu_ItemClick(object sender, EventArgs e)
        {
            ObjednavkaCenik cenik = new ObjednavkaCenik();
            /*  string soubor = cenik.SestavObjednavku((objednavka_polozka)this.entityObject, this.DBContext);
              System.Diagnostics.Process.Start(soubor);*/
        }

        private CenikContext CenikParam()
        {
            objednavka_polozka o = (objednavka_polozka)this.entityObject;
            CenikContext paramCenik = new CenikContext();
            paramCenik.kostrukcniTrida = o.produkt.konstrukt_trida ?? 0;
            paramCenik.plosnySpojSpecifikace = o.produkt.plosny_spoj_specifikace;
            paramCenik.Cenik = o.cenik;
            paramCenik.lsVrstva = o.produkt.vrstvas.ToList();
            paramCenik.nazevDPS = o.produkt.nazev + "(" + o.produkt.kod + ")";
            paramCenik.rozmerX = (o.produkt.cisty_rozmer_dps_x ?? 0);
            paramCenik.rozmerY = (o.produkt.cisty_rozmer_dps_y ?? 0);
            paramCenik.rozmerPanelX = (o.produkt.cisty_panel_x ?? 0);
            paramCenik.rozmerPanelY = (o.produkt.cisty_panel_y ?? 0);
            paramCenik.termin = (termin_typ)termintypBindingSource.Current;
            paramCenik.zakaznik = o.zakaznik_objednavatel_zakaznik_id;
            paramCenik.pocetKs = o.pozadovano_pocet ?? 0;
            paramCenik.lsCenikRadka = o.GetCenikPolozky(this.DBContext);

            return paramCenik;
        }



        private void btnCena_ItemClick(object sender, EventArgs e)
        {
            this.Valid();
            if (!this.isValid)
            {
                return;
            }


            objednavka_polozka o = (objednavka_polozka)this.entityObject;
            if (o.produkt != null)
            {

                CenikContext paramCenik = CenikParam();

                Cenik c = new Cenik();

                string hlaska = c.KontrolaMaterialu(o.produkt.vrstvas.ToList(), o.cenik);
                if (hlaska != "")
                {
                    frmNapoveda.Set(hlaska);
                    return;
                }

                List<CenikRadka> ls = c.SestavCena(paramCenik);

                ((objednavka_polozka)this.entityObject).zakladni_cena = c.ZakladniCena;
                ((objednavka_polozka)this.entityObject).cenikova_cena = c.CenikovaCena;
                ((objednavka_polozka)this.entityObject).vychozi_cena = c.VychoziCena;

                string soubor = CenikReport.Print(ls);
                System.Diagnostics.Process.Start(soubor);
            }
        }

        private void btnDopocitat_ItemClick(object sender, EventArgs e)
        {
            objednavka_polozka o = (objednavka_polozka)this.entityObject;
            Cenik c = new Cenik();

            CenikContext paramCenik = CenikParam();


            string hlaska = c.KontrolaMaterialu(o.produkt.vrstvas.ToList(), o.cenik);
            if (hlaska != "")
            {
                frmNapoveda.Set(hlaska);
                return;
            }

            List<CenikRadka> ls = c.SestavCena(paramCenik);

            ((objednavka_polozka)this.entityObject).zakladni_cena = c.ZakladniCena;
            ((objednavka_polozka)this.entityObject).cenikova_cena = c.CenikovaCena;
            ((objednavka_polozka)this.entityObject).vychozi_cena = c.VychoziCena;


        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmObjednavkaPolozkaDetail_Load(object sender, EventArgs e)
        {

            if (((objednavka_polozka)this.entityObject).stav_objednavka_id == (int)stav_objednavka.Value.SpustenaDoVyroby)
            {
                #region ItemsDeactivated

                btnEditZakaznik.Enabled = false;
                btnEditNazevDPS.Enabled = false;
                txtObjednavkaZakaznik.Enabled = false;
                txtNazevDPS.Enabled = false;
                btnObjednavka.Enabled = false;
                txtCisloReklamace.Enabled = false;
                txtPozadovanyPocet.Enabled = false;
                txtTechnologickyPridavek.Enabled = false;
                txtVyrobniPridavek.Enabled = true;
                cmbTypVyroby.Enabled = false;
                cmbZadatel.Enabled = false;
                btnPruvodka.Enabled = false;
                btnKod.Enabled = false;
                txtPlochaDPS.Enabled = false;
                txtZdruzenyMotiv.Enabled = false;
                checkBox1.Enabled = false;
                cmbTermin.Enabled = false;
                btnZvolitDatum.Enabled = false;
                cbDodrzetTermin.Enabled = false;
                txtPripavaFrezovani.Enabled = false;
                txtVicePrace.Enabled = false;
                dateEdit4.Enabled = false;
                memoEdit1.Enabled = false;
                btnObjednavkovyNazev.Enabled = false;
                txtSmluvniCena.Enabled = false;
                btnEditNabidka.Enabled = false;
                txtZakladniCena.Enabled = false;
                txtSlevaZakaznika.Enabled = false;
                cmbCenik.Enabled = false;
                btnCena.Enabled = false;
                btnTechnickaDokumentace.Enabled = false;
                cmbCenik.Enabled = false;
                txtExpedice.Enabled = false;

                #endregion
            }

            if (((objednavka_polozka)this.entityObject).stav_objednavka_id == (int)stav_objednavka.Value.pozastaveno)
            {
                #region ItemsDeactivated

                txtZakaznika.Enabled = false;
                txtPSC.Enabled = false;
                txtMisto.Enabled = false;
                txtUlice.Enabled = false;
                txtInterNazev.Enabled = false;
                lookUpEdit2.Enabled = false;
                btnEditZakaznik.Enabled = false;
                btnEditNazevDPS.Enabled = false;
                txtObjednavkaZakaznik.Enabled = false;
                txtNazevDPS.Enabled = false;
                btnObjednavka.Enabled = false;
                txtCisloReklamace.Enabled = false;
                txtPozadovanyPocet.Enabled = false;
                txtTechnologickyPridavek.Enabled = false;
                txtVyrobniPridavek.Enabled = false;
                cmbTypVyroby.Enabled = false;
                cmbZadatel.Enabled = false;
                btnPruvodka.Enabled = false;
                btnKod.Enabled = false;
                txtPlochaDPS.Enabled = false;
                txtZdruzenyMotiv.Enabled = false;
                checkBox1.Enabled = false;
                cmbTermin.Enabled = false;
                btnZvolitDatum.Enabled = false;
                cbDodrzetTermin.Enabled = false;
                txtPripavaFrezovani.Enabled = false;
                txtVicePrace.Enabled = false;
                dateEdit4.Enabled = false;
                memoEdit1.Enabled = false;
                btnObjednavkovyNazev.Enabled = false;
                txtSmluvniCena.Enabled = false;
                btnEditNabidka.Enabled = false;
                txtZakladniCena.Enabled = false;
                txtSlevaZakaznika.Enabled = false;
                cmbCenik.Enabled = false;
                btnCena.Enabled = false;
                btnTechnickaDokumentace.Enabled = false;
                cmbCenik.Enabled = false;
                txtExpedice.Enabled = false;

                #endregion
            }

            if (((objednavka_polozka)this.entityObject).stav_objednavka_id == (int)stav_objednavka.Value.stornovano)
            {
                #region ItemsDeactivated

                txtZakaznika.Enabled = false;
                txtPSC.Enabled = false;
                txtMisto.Enabled = false;
                txtUlice.Enabled = false;
                txtInterNazev.Enabled = false;
                lookUpEdit2.Enabled = false;
                btnEditZakaznik.Enabled = false;
                btnEditNazevDPS.Enabled = false;
                txtObjednavkaZakaznik.Enabled = false;
                txtNazevDPS.Enabled = false;
                btnObjednavka.Enabled = false;
                txtCisloReklamace.Enabled = false;
                txtPozadovanyPocet.Enabled = false;
                txtTechnologickyPridavek.Enabled = false;
                txtVyrobniPridavek.Enabled = false;
                cmbTypVyroby.Enabled = false;
                cmbZadatel.Enabled = false;
                btnPruvodka.Enabled = false;
                btnKod.Enabled = false;
                txtPlochaDPS.Enabled = false;
                txtZdruzenyMotiv.Enabled = false;
                checkBox1.Enabled = false;
                cmbTermin.Enabled = false;
                btnZvolitDatum.Enabled = false;
                cbDodrzetTermin.Enabled = false;
                txtPripavaFrezovani.Enabled = false;
                txtVicePrace.Enabled = false;
                dateEdit4.Enabled = false;
                memoEdit1.Enabled = false;
                btnObjednavkovyNazev.Enabled = false;
                txtSmluvniCena.Enabled = false;
                btnEditNabidka.Enabled = false;
                txtZakladniCena.Enabled = false;
                txtSlevaZakaznika.Enabled = false;
                cmbCenik.Enabled = false;
                btnCena.Enabled = false;
                btnTechnickaDokumentace.Enabled = false;
                cmbCenik.Enabled = false;
                txtExpedice.Enabled = false;

                #endregion
            }

        }

        private void lblHod_Click(object sender, EventArgs e)
        {

        }

        private void txtVicePrace_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void btnKontrola_ItemClick(object sender, EventArgs e)
        {
            frmKontrola frm = new frmKontrola();
            frm.ShowDetail(this, this.entityObject);
        }

        private void btnProduktDetail_ItemClick(object sender, EventArgs e)
        {
            if (((objednavka_polozka)this.entityObject).produkt != null)
            {

                if (((objednavka_polozka)this.entityObject).produkt.sablona)
                {
                    frmSablonaDetail sablona = new frmSablonaDetail();
                    sablona.ShowDetail(this, ((objednavka_polozka)this.entityObject).produkt);
                }
                else
                {
                    frmProduktDetail produkt = new frmProduktDetail();
                    produkt.ShowDetail(this, ((objednavka_polozka)this.entityObject).produkt);

                }
            }
            else
            {
                frmNapoveda.Set("Není zvolen produkt (Technická dokumentace)");
            }
        }

        private void btnObjednavkovyNazev_Click(object sender, EventArgs e)
        {
            frmPrirazeniDPS frm = new frmPrirazeniDPS();
            frm.entityObject = this.entityObject;
            if (frm.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                produkt p = this.DBContext.produkts.Where(item => item.produkt_id == frm.VybranyProdukt).First();
                btnEditNazevDPS.Text = p.nazev;
                ((objednavka_polozka)this.entityObject).produkt_id = p.produkt_id;
                txtPlochaDPS.Enabled = false;
                ((objednavka_polozka)this.entityObject).majitel_zakaznik_id = p.zakaznik_id;
                ((objednavka_polozka)this.entityObject).nazev = frm.ObjednavkovyNazev;
                ((objednavka_polozka)this.entityObject).plocha_dps = p.plocha;
                ((objednavka_polozka)this.entityObject).plosny_spoj_specifikace_id = p.plosny_spoj_specifikace_id;

            }

        }

        private void btnKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmKod frm = new frmKod();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                plosny_spoj_specifikace item = this.DBContext.plosny_spoj_specifikaces.First(i => i.kod == frm.SelectedItem);
                ((objednavka_polozka)this.entityObject).plosny_spoj_specifikace_id = item.plosny_spoj_specifikace_id;
            }
        }

        private void btnObjednavka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmZakaznikSeznam seznam = new frmZakaznikSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((objednavka_polozka)this.entityObject).objednavatel_zakaznik_id = ((zakaznik)seznam.entityObject).zakaznik_id;
            }

        }


        private void cmbTypVyroby_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (((objednavka_polozka)entityObject).produkt != null)
            {
                if ((plosny_spoj_druh.Value)(int)e.NewValue == plosny_spoj_druh.Value.OpakovanaVyroba || (plosny_spoj_druh.Value)(int)e.NewValue == plosny_spoj_druh.Value.NahradaNeshod)
                {
                    ((objednavka_polozka)entityObject).plocha_dps = ((objednavka_polozka)entityObject).produkt.plocha;
                    ((objednavka_polozka)entityObject).plosny_spoj_specifikace_id = ((objednavka_polozka)entityObject).produkt.plosny_spoj_specifikace_id;
                }
            }
        }



        private void prepocitaKapacitu(int? terminTyp, DateTime? vybranyDatum)
        {
            if (terminTyp.HasValue)
            {
                int pocet = this.DBContext.kapacitas.Where(item => item.objednavka_polozka_id == ((objednavka_polozka)this.entityObject).objednavka_polozka_id).Count();
                if (pocet == 0)
                {
                    if (((objednavka_polozka)entityObject).plosny_spoj_specifikace != null)
                    {
                        ((objednavka_polozka)entityObject).termin_typ_id = terminTyp;
                        DateTime datumDopocitany = ((objednavka_polozka)entityObject).plosny_spoj_specifikace.DatumDodani(terminTyp.Value, dbContext);

                        if (vybranyDatum == null)
                        {
                            DateTime zvolenyDatum = datumDopocitany;

                            this.txtVyroby.EditValue = zvolenyDatum;
                            this.txtExpedice.EditValue = zvolenyDatum;

                            ((objednavka_polozka)entityObject).termin_vyroby = zvolenyDatum;
                            ((objednavka_polozka)entityObject).termin_expedice = zvolenyDatum;

                            txtKapacita.Text = KapacitaRow.GetKapacitaDne(this.DBContext, ((objednavka_polozka)entityObject),
                                 zvolenyDatum).ToString("N2");
                        }
                        else
                        {

                            this.txtVyroby.EditValue = vybranyDatum;
                            this.txtExpedice.EditValue = vybranyDatum;

                            ((objednavka_polozka)entityObject).termin_vyroby = vybranyDatum;
                            ((objednavka_polozka)entityObject).termin_expedice = vybranyDatum;

                            txtKapacita.Text = KapacitaRow.GetKapacitaDne(this.DBContext, ((objednavka_polozka)entityObject), vybranyDatum.Value).ToString("N2");
                        }
                    }
                }
                else
                {
                    if (vybranyDatum.HasValue && ((objednavka_polozka)entityObject).plosny_spoj_specifikace != null)
                    {
                        txtKapacita.Text = KapacitaRow.GetKapacitaDne(this.DBContext, ((objednavka_polozka)entityObject),
                                vybranyDatum.Value).ToString("N2");
                    }
                }
            }
            else
            {
                this.txtVyroby.EditValue = null;
                this.txtExpedice.EditValue = null;

                txtKapacita.Text = "";
            }
        }

        private void cmbTermin_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
            {
                prepocitaKapacitu((int)e.NewValue, null);
            }
            else
            {
                prepocitaKapacitu(null, null);
            }
        }

        private void btnZvolitDatum_Click(object sender, EventArgs e)
        {
            if (((objednavka_polozka)this.entityObject).plosny_spoj_specifikace == null)
            {
                MessageBox.Show("Plošný spoj specifikace není zvolena", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (((objednavka_polozka)this.entityObject).termin_typ_id.HasValue)
            {
                frmKapacitaVyrobyDetail frm = new frmKapacitaVyrobyDetail();
                if (frm.ShowDetail(this, this.entityObject) == System.Windows.Forms.DialogResult.OK)
                {
                    prepocitaKapacitu(((objednavka_polozka)this.entityObject).termin_typ_id.Value, frm.VybranyDatum);
                }
            }
        }

        private void btnPruvodka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPruvodkaSeznam frm = new frmPruvodkaSeznam();
            frm.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;

            if (frm.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                btnPruvodka.Text = ((pruvodka)frm.entityObject).cislo;
                ((objednavka_polozka)this.entityObject).pruvodka_id = ((pruvodka)frm.entityObject).pruvodka_id;
            }
        }

        private void number_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            this.base_number_ParseEditValue(sender, e);
        }

        private void int_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            this.base_int_ParseEditValue(sender, e);
        }

        private void btnKod_EditValueChanged(object sender, EventArgs e)
        {
            if (((objednavka_polozka)this.entityObject).termin_typ_id.HasValue)
            {
                this.prepocitaKapacitu(((objednavka_polozka)this.entityObject).termin_typ_id.Value, null);
            }
            else
            {
                this.prepocitaKapacitu(null, null);
            }
        }
    }
}
