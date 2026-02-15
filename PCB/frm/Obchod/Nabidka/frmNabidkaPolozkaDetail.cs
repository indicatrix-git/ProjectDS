using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using PCB.Base;
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
    public partial class frmNabidkaPolozkaDetail : frmBaseDetail
    {
        public frmNabidkaPolozkaDetail()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.ObchodNabidky))
            {
                base.setReadonly(cs);

                if (this.HasPravoZapis(prava.Value.TechnologieNabidky) && ((nabidka_polozka)this.entityObject).nabidka_stav_id == (int)nabidka_stav.Value.PredanoTechnologie)
                {
                    txtTechnolog.Enabled = true;
                    btnPridat.Enabled = true;
                    btnVrstvaOdstranit.Enabled = true;
                    btnVrstvaOdstranitVse.Enabled = true;
                    btnVrstvaDolu.Enabled = true;
                    btnVrstvaNahoru.Enabled = true;
                    btnUlozit.Enabled = true;
                    btnMaterial.Enabled = true;
                    btnPripravVrstvy.Enabled = true;
                }

                if (this.HasPravoZapis(prava.Value.TPVNabidky) && ((nabidka_polozka)this.entityObject).nabidka_stav_id == (int)nabidka_stav.Value.PredanaDoTPV)
                {
                    btnPridat.Enabled = true;
                    btnVrstvaOdstranit.Enabled = true;
                    btnVrstvaOdstranitVse.Enabled = true;
                    btnVrstvaDolu.Enabled = true;
                    btnVrstvaNahoru.Enabled = true;
                    btnMaterial.Enabled = true;
                    btnPripravVrstvy.Enabled = true;

                    btnUlozit.Enabled = true;

                }
            }

            btnZavrit.Enabled = true;
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (((CheckEdit)sender).Checked)
            {
                ((CheckEdit)sender).ForeColor = Color.Red;
            }
            else
            {
                ((CheckEdit)sender).ForeColor = Color.Black;
            }
        }

        public override void SaveData()
        {
            base.SaveData();

            ((nabidka_polozka)this.entityObject).sestavil_id = this.PrihlasenyUzivatelId;
            ((nabidka_polozka)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();

        }


        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                this.entityObject = new nabidka_polozka();
                ((nabidka_polozka)this.entityObject).nabidka_stav = this.DBContext.nabidka_stavs.Where(i => i.nabidka_stav_id == (int)nabidka_stav.Value.Zalozena).First();
                ((nabidka_polozka)this.entityObject).d_prijato = PCB.Data.DBHelper.DateTimeNow();
                ((nabidka_polozka)this.entityObject).priorita_id = 1; // normal
                ((nabidka_polozka)this.entityObject).cenik = DBContext.ceniks.OrderBy(i => i.datum).FirstOrDefault();
                ((nabidka_polozka)this.entityObject).sestavil_id = this.PrihlasenyUzivatelId;
                ((nabidka_polozka)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();
                ((nabidka_polozka)this.entityObject).konstrukcni_trida = 5;
            }

            this.NabidkaDetailBindingSource.DataSource = this.entityObject;
            this.cmbPriorita.Properties.DataSource = this.DBContext.prioritas.ToList();
            this.cbBarva.Properties.DataSource = this.DBContext.barvas.ToList().OrderBy(o => o.barva_id);
            this.cbBarv.Properties.DataSource = this.DBContext.barvas.Where(i => i.barva_id == 2 || i.barva_id == 3).ToList();
            this.cbVyroba.Properties.DataSource = this.DBContext.plosny_spoj_druhs.ToList();
            plosnyspojspecifikaceBindingSource.DataSource = this.DBContext.plosny_spoj_specifikaces.ToList();
            vrstvaBindingSource.DataSource = ((nabidka_polozka)this.entityObject).vrstvas;
            termintypBindingSource.DataSource = this.DBContext.termin_typs.Where(i => i.termin_typ_id <= 3).ToList();
            cmbTermin.Properties.DataSource = termintypBindingSource.DataSource;
            cenikBindingSource.DataSource = this.DBContext.ceniks.ToList();

            nastavCheckBoxy();

            cmbTermin.EditValue = (int)termin_typ.Value.normal;
            barPocetKs.EditValue = 10;

        }

        private void btnUlozit_ItemClick(object sender, EventArgs e)
        {
            btnEditDPS.Focus();

            frmNabidkaPolozkaWorkflow workflow = new frmNabidkaPolozkaWorkflow();
            if (workflow.ShowForm(this) == DialogResult.OK)
            {
                if (workflow.Stav != 0)
                {
                    ((nabidka_polozka)this.entityObject).nabidka_stav = this.DBContext.nabidka_stavs.Where(i => i.nabidka_stav_id == workflow.Stav).First();
                }

                this.SaveData();
                this.Close();
            }
        }

        private void btnZavrit_ItemClick(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnEditDPS_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmProduktSeznam seznam = new frmProduktSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((nabidka_polozka)this.entityObject).produkt_id = ((produkt)seznam.entityObject).produkt_id;
                ((nabidka_polozka)this.entityObject).zakaznik_id = ((produkt)seznam.entityObject).zakaznik_id.Value;
                ((nabidka_polozka)this.entityObject).konstrukcni_trida = ((produkt)seznam.entityObject).konstrukt_trida;
                ((nabidka_polozka)this.entityObject).rozmer_dps_x = ((produkt)seznam.entityObject).cisty_rozmer_dps_x;
                ((nabidka_polozka)this.entityObject).rozmer_dps_y = ((produkt)seznam.entityObject).cisty_rozmer_dps_y;
                ((nabidka_polozka)this.entityObject).rozmer_panel_x = ((produkt)seznam.entityObject).cisty_panel_x;
                ((nabidka_polozka)this.entityObject).rozmer_panel_y = ((produkt)seznam.entityObject).cisty_panel_y;
                ((nabidka_polozka)this.entityObject).plosny_spoj_specifikace_id = ((produkt)seznam.entityObject).plosny_spoj_specifikace_id;

            }
        }

        private void btnCenik_ItemClick(object sender, EventArgs e)
        {

            if (cmbTermin.EditValue == null)
            {
                cmbTermin.EditValue = 1;
            }

            Valid();
            if (!this.isValid)
            {
                return;
            }

            nabidka_polozka n = (nabidka_polozka)this.entityObject;

            CenikContext paramCenik = new CenikContext();
            paramCenik.plosnySpojSpecifikace = n.plosny_spoj_specifikace;
            paramCenik.kostrukcniTrida = n.konstrukcni_trida ?? 0;
            paramCenik.Cenik = n.cenik;
            paramCenik.lsVrstva = n.vrstvas.ToList();
            paramCenik.nazevDPS = n.nazev_dps;
            paramCenik.rozmerX = (n.rozmer_dps_x ?? 0);
            paramCenik.rozmerY = (n.rozmer_dps_y ?? 0);
            paramCenik.rozmerPanelX = (n.rozmer_panel_x ?? 0);
            paramCenik.rozmerPanelY = (n.rozmer_panel_y ?? 0);
            paramCenik.termin = this.DBContext.termin_typs.Where(i => i.termin_typ_id == (int)cmbTermin.EditValue).First();
            paramCenik.zakaznik = n.zakaznik;
            paramCenik.pocetKs = Convert.ToInt32(barPocetKs.EditValue.ToString());
            paramCenik.lsCenikRadka = n.GetCenikPolozky(this.DBContext);

            Cenik c = new Cenik();

            string hlaska = c.KontrolaMaterialu(n.vrstvas.ToList(), n.cenik);
            if (hlaska != "")
            {
                frmNapoveda.Set(hlaska);
            }

            List<CenikRadka> ls = c.SestavCena(paramCenik);

            string soubor = CenikReport.Print(ls);
            System.Diagnostics.Process.Start(soubor);
        }


        private void btnVrstvaPridat_Click(object sender, EventArgs e)
        {
            ((nabidka_polozka)this.entityObject).vrstvas.Add(new vrstva());
        }

        private void btnVrstvaOdstranit_Click(object sender, EventArgs e)
        {
            if (vrstvaBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((vrstva)vrstvaBindingSource.Current);
            }
        }

        private void btnVrstvaOdstranitVse_Click(object sender, EventArgs e)
        {
            foreach (vrstva item in ((nabidka_polozka)this.entityObject).vrstvas.ToList())
            {
                this.DBContext.DeleteObject(item);
            }

        }

        private void btnVrstvaNahoru_Click(object sender, EventArgs e)
        {
            vrstva vr = (vrstva)vrstvaBindingSource.Current;
            vrstva vr1 = ((IEnumerable<vrstva>)vrstvaBindingSource.DataSource).Where(i => i.poradi == (vr.poradi - 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                vrstvaBindingSource.Position = vrstvaBindingSource.IndexOf(vr);
                gcVrstvy.Refresh();
            }
        }

        private void btnVrstvaDolu_Click(object sender, EventArgs e)
        {
            vrstva vr = (vrstva)vrstvaBindingSource.Current;
            vrstva vr1 = ((IEnumerable<vrstva>)vrstvaBindingSource.DataSource).Where(i => i.poradi == (vr.poradi + 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                vrstvaBindingSource.Position = vrstvaBindingSource.IndexOf(vr);
                gcVrstvy.Refresh();
            }
        }

        private void btnEditMaterial_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((vrstva)vrstvaBindingSource.Current).material_id = ((material)frm.entityObject).material_id;
                gridView1.FocusedRowHandle = -1;
            }
        }

        private void btnEditCuVrstva_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            frmCiselnikCu frm = new frmCiselnikCu();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((vrstva)vrstvaBindingSource.Current).vrstva_cu_id = ((vrstva_cu)frm.entityObject).vrstva_cu_id;
                gridView1.FocusedRowHandle = -1;
            }
        }

        private void btnPripravVrstvy_Click(object sender, EventArgs e)
        {

            if (((nabidka_polozka)this.entityObject).plosny_spoj_specifikace != null)
            {
                ((nabidka_polozka)this.entityObject).plosny_spoj_specifikace.PripravVrstvyDleKodu(this.entityObject);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;

                string strana = (string)View.GetRowCellValue(e.RowHandle, View.Columns["strana"]);
                if (strana != null && strana != "" && strana.Length > 0)
                {
                    e.Appearance.BackColor = Color.LightGray;
                }

            }
        }

        private void btnKod_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            frmKod frm = new frmKod();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (frm.SelectedItem == null) return;

                plosny_spoj_specifikace item = this.DBContext.plosny_spoj_specifikaces.First(i => i.kod == frm.SelectedItem);
                ((nabidka_polozka)this.entityObject).plosny_spoj_specifikace_id = item.plosny_spoj_specifikace_id;
            }
        }

        private void btnEditZakaznik_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            frmZakaznikSeznam seznam = new frmZakaznikSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((nabidka_polozka)this.entityObject).zakaznik_id = ((zakaznik)seznam.entityObject).zakaznik_id;
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            frm.ShowDialog();
        }

        private void btnSkladMaterialuOdkaz_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"x:\SpolecnaData\Info\Skladové_zásoby_PCB10.pdf", true);
        }

        private void cb_barva(object sender, EventArgs e)
        {
            if (((CheckEdit)sender).Checked)
            {
                ((CheckEdit)sender).ForeColor = Color.Red;
            }
            else
            {
                ((CheckEdit)sender).ForeColor = Color.Black;
            }
        }

        private void chbNutnoKonz_CheckedChanged(object sender, EventArgs e)
        {
            nastavCheckBoxy();
        }

        private void cbPoznamkaObchod_CheckedChanged(object sender, EventArgs e)
        {
            nastavCheckBoxy();
        }

        private void nastavCheckBoxy()
        {
            txtPoznamka.ReadOnly = !cbPoznamkaObchod.Checked;
            txtTechnolog.ReadOnly = !chbNutnoKonz.Checked;
            cb_barva(chbNutnoKonz, null);
        }

        private void btnTisk_Click(object sender, EventArgs e)
        {
            Valid();
            if (this.isValid)
            {
                frmNabidkaPolozkaCena frm = new frmNabidkaPolozkaCena();
                frm.ShowDetail(this, this.entityObject);
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

        private void gbPovrchUprav_Enter(object sender, EventArgs e)
        {

        }
    }
}
