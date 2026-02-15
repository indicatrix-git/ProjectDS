using DevExpress.XtraReports.UI;
using PCB.Base;
using PCB.Data;
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
    public partial class frmPruvodkaDavka : frmBaseDetail
    {
        public frmPruvodkaDavka()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.PripravarDavekAFilmuObjednavky))
            {
                base.setReadonly(cs);
                btnStorno.Enabled = true;
                btnKontrola.Enabled = true;
            }
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            objednavkapolozkaBindingSource.DataSource = (objednavka_polozka)this.entityObject;

            if (((objednavka_polozka)this.entityObject).plosny_spoj_druh_id == (int)plosny_spoj_druh.Value.Kooperace)
            {
                btnKontrola.Visible = false;
                btnOk.Text = "Přiřadit";
            }
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            objednavka_polozka objednavka = (objednavka_polozka)this.entityObject;

            if (((objednavka_polozka)this.entityObject).plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
            {
                if (objednavka.stav_objednavka_id != (int)stav_objednavka.Value.ZalozenaPredanoDoTPV || (objednavka.produkt.zamek ?? false) == false)
                {
                    MessageBox.Show("Nelze vytisknout -  technická dokumentace musí být uzamčena.");
                    return;
                }
            }

            decimal pocetPozadovny = objednavka.pozadovano_pocet ?? 0;
            decimal pridavek = objednavka.tech_pridavek ?? 0;

            decimal PocetPruvodek = int.Parse(txtPocet.Text);
            int cisloPruvodky = int.Parse(txtCisloPruvodky.Text);


            decimal pocetNaPruvodku = Math.Round(pocetPozadovny / PocetPruvodek);
            decimal zbytek = pocetPozadovny - (pocetNaPruvodku * PocetPruvodek);


            // pro generovani pin
            Random rnd = new Random();

            for (int i = 1; i <= PocetPruvodek; i++)
            {
                pruvodka p = new pruvodka();

                p.objednavka_polozka = this.DBContext.objednavka_polozkas.Where(item => item.objednavka_polozka_id == ((objednavka_polozka)this.entityObject).objednavka_polozka_id).First();

                if (i == PocetPruvodek)
                {
                    p.pocet_kusu = Convert.ToInt16(pocetNaPruvodku);
                    p.pocet_panelu = Convert.ToInt16(pridavek);
                }
                else
                {
                    p.pocet_kusu = Convert.ToInt16(pocetNaPruvodku);
                }

                p.pin = rnd.Next(1000, 9999).ToString();
                p.cislo = (cisloPruvodky + (i - 1)).ToString().PadLeft(5, '0');
                p.pruvodka_stav_id = (int)pruvodka_stav.Value.priprava;
                p.d_tisk_pruvodka = PCB.Data.DBHelper.DateTimeNow();
                p.vytiskl_id = this.PrihlasenyUzivatelId;

                if (((objednavka_polozka)this.entityObject).plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
                {
                    p.produkt_revize_id = p.objednavka_polozka.produkt.ProduktRevize;
                    p.objednavka_polozka.produkt.zamek = true;
                }
                else
                {
                    // kooperace rovnou dokonecna
                    p.pruvodka_stav_id = (int)pruvodka_stav.Value.spustena;
                }

                p.objednavka_polozka.stav_objednavka_id = (int)stav_objednavka.Value.SpustenaDoVyroby;

                p.objednavka_polozka.produkt.LoadSeznamOperaci(new pcb_develEntities());

                // Kopirovani z produktu
                p.produkt_archivace = p.objednavka_polozka.produkt.archivace;
                p.produkt_dodrzet_typ_materialu = p.objednavka_polozka.produkt.dodrzet_typ_materialu;
                p.produkt_d_naposledy_ve_vyrobe = p.objednavka_polozka.produkt.NaposledyVeVyrobe;
                p.produkt_kod = p.objednavka_polozka.produkt.kod;
                p.produkt_konstrukt_trida = p.objednavka_polozka.produkt.konstrukt_trida;
                p.produkt_motiv = p.objednavka_polozka.produkt.motiv;
                p.produkt_nazev = p.objednavka_polozka.produkt.nazev;
                p.produkt_nestandartni_technologie = p.objednavka_polozka.produkt.nestandartni_technologie;
                p.produkt_plosny_spoj_specifikace_id = p.objednavka_polozka.produkt.plosny_spoj_specifikace_id;
                p.produkt_poznamka = p.objednavka_polozka.produkt.poznamka;
                p.produkt_revize_count = p.objednavka_polozka.produkt.Revize;
                p.produkt_revize_datum = p.objednavka_polozka.produkt.RevizeDatum;
                p.produkt_revize_pro_pruvodky = p.objednavka_polozka.produkt.RevizeProPruvodku;
                p.produkt_specialni_postup = p.objednavka_polozka.produkt.specialni_postup;
                p.produkt_ul = p.objednavka_polozka.produkt.ul;
                p.produkt_uloziste = p.objednavka_polozka.produkt.uloziste;
                p.produkt_celkova_tloustka = p.objednavka_polozka.produkt.celkova_tloustka;
                p.produkt_cisty_rozmer_x = p.objednavka_polozka.produkt.cisty_rozmer_dps_x;
                p.produkt_cisty_rozmer_y = p.objednavka_polozka.produkt.cisty_rozmer_dps_y;
                p.produkt_datovy_soubor = p.objednavka_polozka.produkt.datovy_soubor;
                p.produkt_hruby_panel_suma = p.objednavka_polozka.produkt.hruby_panel_suma;
                p.produkt_hruby_panel_x = p.objednavka_polozka.produkt.hruby_panel_x;
                p.produkt_hruby_panel_y = p.objednavka_polozka.produkt.hruby_panel_y;
                p.produkt_ostrih_po_vrtani_rozmer_x = p.objednavka_polozka.produkt.OstrihPoVrtaniRorzmerX;
                p.produkt_ostrih_po_vrtani_rozmer_y = p.objednavka_polozka.produkt.OstrihPoVrtaniRorzmerY;
                p.produkt_tolerance_cististeho_rozmeru_dolni = p.objednavka_polozka.produkt.tolerance_cististeho_rozmeru_dolni;
                p.produkt_tolerance_cististeho_rozmeru_horni = p.objednavka_polozka.produkt.tolerance_cististeho_rozmeru_horni;
                p.produkt_tolerance_dolni = p.objednavka_polozka.produkt.tolerance_dolni;
                p.produkt_tolerance_horni = p.objednavka_polozka.produkt.tolerance_horni;
                p.produkt_zakladni_panel_suma = p.objednavka_polozka.produkt.zakladni_panel_suma;
                p.produkt_zakladni_panel_x = p.objednavka_polozka.produkt.zakladni_panel_x;
                p.produkt_zakladni_panel_y = p.objednavka_polozka.produkt.zakladni_panel_y;

                foreach (var operace in p.objednavka_polozka.produkt.SeznamOperaci)
                {
                    pruvodka_operace po = new pruvodka_operace();
                    po.nazev = operace.nazev;
                    po.poradi = operace.poradi;
                    po.poznamka = operace.Poznamka;
                    po.cislo = operace.operace_id;

                    p.pruvodka_operaces.Add(po);
                }

                foreach(var film in p.objednavka_polozka.produkt.films)
                {
                    pruvodka_film pf = new pruvodka_film();
                    pf.film_typ_id = film.film_typ_id;
                    pf.oznaceni = film.oznaceni;
                    pf.vrstva = film.vrstva;

                    p.pruvodka_films.Add(pf);
                }

                foreach(var vrstva in p.objednavka_polozka.produkt.vrstvas)
                {
                    pruvodka_vrstva pv = new pruvodka_vrstva();
                    pv.material_id = vrstva.material_id;
                    pv.pocet = vrstva.pocet;
                    pv.poradi = vrstva.poradi;
                    pv.strana = vrstva.strana;
                    pv.tloustka_mm = vrstva.tloustka_mm;
                    pv.vrstva_cu_id = vrstva.vrstva_cu_id;

                    p.pruvodka_vrstvas.Add(pv);
                }

                foreach (var zmena in p.objednavka_polozka.produkt.zmenas)
                {
                    pruvodka_zmena pz = new pruvodka_zmena();
                    pz.cislo = zmena.cislo;
                    pz.d_zmena = zmena.d_zmena;
                    pz.rok = zmena.rok;
                    pz.uzivatel_id = zmena.uzivatel_id;

                    p.pruvodka_zmenas.Add(pz);
                }

                p.objednavka_polozka.pruvodkas.Add(p);


                // pokud je jen jedna, rovnou se vytiskne, bez ptani
                if (PocetPruvodek == 1 && ((objednavka_polozka)this.entityObject).plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
                {
                    p.pruvodka_stav_id = (int)pruvodka_stav.Value.spustena;

                    double soucet = p.pocet_kusu + p.pocet_panelu;
                    double deleno = double.Parse((p.objednavka_polozka.produkt.hruby_panel_suma ?? 0).ToString());

                    double zbytek1 = soucet % deleno;

                    if (zbytek1 > 0)
                    {
                        MessageBox.Show("Nevychází násobnost. Zkontrolujte prosím počty kusů.");
                        return;
                    }

                    reportPruvodkaHlavicka pruv = new reportPruvodkaHlavicka();
                    pruv.SetDataSource(p);
                    pruv.CreateDocument();
                    reportPruvodkaOperace report = new reportPruvodkaOperace();
                    //p.objednavka_polozka.produkt.LoadSeznamOperaci();

                    report.SetDataSource(p);
                    report.CreateDocument();

                    pruv.Pages.AddRange(report.Pages);
                    pruv.Print();
                }
            }

            this.DBContext.SaveChanges();
            this.Close();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void frmPruvodkaDavka_Load(object sender, EventArgs e)
        {
            double cislo = 0;
            foreach (pruvodka p in this.DBContext.pruvodkas)
            {
                if (p.cisloPruvodky > cislo)
                {
                    cislo = p.cisloPruvodky;
                }
            }

            cislo += 1;
            txtCisloPruvodky.Text = cislo.ToString();
        }

        private void bntNahledPruvodky_Click(object sender, EventArgs e)
        {
            List<pruvodka> davkaProTisk = new List<pruvodka>();


            objednavka_polozka objednavka = (objednavka_polozka)this.entityObject;

            decimal pocetPozadovny = objednavka.pozadovano_pocet.Value;
            decimal pridavek = objednavka.tech_pridavek.Value;

            decimal PocetPruvodek = int.Parse(txtPocet.Text);
            int cisloPruvodky = int.Parse(txtCisloPruvodky.Text);


            decimal pocetNaPruvodku = Math.Round(pocetPozadovny / PocetPruvodek);
            decimal zbytek = pocetPozadovny - (pocetNaPruvodku * PocetPruvodek);

            Random rnd = new Random();

            for (int i = 1; i <= PocetPruvodek; i++)
            {
                pruvodka p = new pruvodka();
                p.objednavka_polozka = (objednavka_polozka)this.entityObject;

                if (i == PocetPruvodek)
                {
                    p.pocet_kusu = Convert.ToInt16(pocetNaPruvodku + zbytek + pridavek);
                }
                else
                {
                    p.pocet_kusu = Convert.ToInt16(pocetNaPruvodku);
                }

                p.pin = rnd.Next(1000, 9999).ToString();
                p.cislo = (cisloPruvodky + (i - 1)).ToString();

                ((objednavka_polozka)this.entityObject).pruvodkas.Add(p);
                davkaProTisk.Add(p);

                reportPruvodkaHlavicka reportVysl = new reportPruvodkaHlavicka();
                reportVysl.CreateDocument();

                List<reportPruvodkaHlavicka> ls = new List<reportPruvodkaHlavicka>();

                foreach (pruvodka pru in davkaProTisk)
                {
                    reportPruvodkaHlavicka report = new reportPruvodkaHlavicka();
                    pru.objednavka_polozka.produkt.LoadSeznamOperaci();
                    report.SetDataSource(pru);
                    report.CreateDocument();
                    ls.Add(report);

                }

                for (int j = 1; j < ls.Count; j++)
                {
                    ls[0].Pages.AddRange(ls[j].Pages);
                }

                ReportPrintTool pt = new ReportPrintTool(ls[0]);
                pt.ShowPreview();

            }

            this.Close();

        }

        private void txtPocet_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmPruvodkaSeznam seznam = new frmPruvodkaSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((objednavka_polozka)this.entityObject).pruvodka_id = ((pruvodka)seznam.entityObject).pruvodka_id;
            }
        }

        private void btnKontrola_Click(object sender, EventArgs e)
        {
            frmKontrola frm = new frmKontrola();
            frm.ShowDetail(this, this.entityObject);
        }
    }
}
