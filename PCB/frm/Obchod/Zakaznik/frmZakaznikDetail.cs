using PCB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;
using PCB.Gui;

namespace PCB
{
    public partial class frmZakaznikDetail : frmBaseDetail
    {
        public frmZakaznikDetail()
        {
            InitializeComponent();
            setIkonyPoznamka();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        
            if (this.FormMode == mode.novy)
            {
                this.entityObject = new zakaznik();
            }
            zakaznikBindingSource.DataSource = (zakaznik)this.entityObject;
            poznamkaBindingSource.DataSource = ((zakaznik)this.entityObject).poznamkas;
            kontaktyBindingSource.DataSource = ((zakaznik)this.entityObject).kontakts;

           List<int> lsCenikAllow = new List<int>() { 
66,
72,
75,
76,
77,
79,
78
        };

            cenikpolozkaBindingSource.DataSource = this.DBContext.cenik_polozkas.ToList().Where(i => lsCenikAllow.Contains(i.cenik_polozka_id)).OrderBy(i => i.cenik_polozka_id);

            List<int> lsTermin = new List<int>() { 1, 2, 3 };

            termintypBindingSource.DataSource = this.DBContext.termin_typs.ToList().Where(i => lsTermin.Contains(i.termin_typ_id)).OrderBy(i => i.termin_typ_id);
            plosnyspojspecifikacetypBindingSource.DataSource = this.DBContext.plosny_spoj_specifikace_typs.ToList().OrderBy(i => i.plosny_spoj_specifikace_typ_id);
            
            zakaznikcenikpolozkaBindingSource.DataSource = ((zakaznik)this.entityObject).zakaznik_cenik_polozkas;
            zakaznikterminslevaBindingSource.DataSource = ((zakaznik)this.entityObject).zakaznik_termin_slevas;

            setPoznamkySouhrn();
            zvyrazneni();

            gridView1.ExpandAllGroups();
            gridView5.ExpandAllGroups();

        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.ObchodZakaznik))
            {
                base.setReadonly(cs);
            }

            if (this.HasPravoZapisNeboCteni(prava.Value.ObchodNabidky))
            {
                btnNabidky.Enabled = true;
            }

            if (this.HasPravoZapisNeboCteni(prava.Value.ObchodObjednavky))
            {
                btnObjednavky.Enabled = true;
            }

            if (this.HasPravoZapisNeboCteni(prava.Value.ObchodFakturace))
            {
                btnFaktury.Enabled = true;
            }

            btnStorno.Enabled = true;            
        }
                
        private void setPoznamkySouhrn()
        {
            htmlTPV.Text = ((zakaznik)this.entityObject).GetPoznamkyTPV();
            htmlObchod.Text = ((zakaznik)this.entityObject).GetPoznamkyObchod();

        }

        private void zvyrazneni()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZakaznikDetail));

            if (!string.IsNullOrEmpty(htmlTPV.Text))
            {
                xtraTabPageTPV.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageTPV.Image")));
            }
            else
            {
                xtraTabPageTPV.Image = null;
            }

            if (!string.IsNullOrEmpty(htmlObchod.Text))
            {
                xtraTabPageObchoda.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageTPV.Image")));
            }
            else
            {
                xtraTabPageObchoda.Image = null;
            }


            zakaznik z = ((zakaznik)this.entityObject);
            if ((z.archivovat ?? false) || (z.dvojita_kontrola ?? false) || (z.laser ?? false) || (z.ul_znaceni ?? false))
            {
                xtraTabPageSpecialniPrani.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageTPV.Image")));
            }
            else
            {
                xtraTabPageSpecialniPrani.Image = null;
            }
        }

        private void setIkonyPoznamka()
        {
            icKontakt.VisibleDetail = true;
            icKontakt.VisibleOdstranit = true;
            icKontakt.VisiblePridat = true;

            icPoznamka.VisibleDetail = true;
            icPoznamka.VisibleOdstranit = true;
            icPoznamka.VisiblePridat = true;
        }

        private void icKontakt_DetailOnClick()
        {
            if (kontaktyBindingSource.Current == null)
                return;

            frmKontaktDetail frm = new frmKontaktDetail();
            frm.PravaIgnore = true;
            frm.parentEntityObject = ((zakaznik)this.entityObject);
            frm.ShowDetail(this, (pcb_develModel.kontakt)kontaktyBindingSource.Current);
        }

        private void icKontakt_PridatOnClick()
        {
            frmKontaktDetail frm = new frmKontaktDetail();
            frm.parentEntityObject = ((zakaznik)this.entityObject);
            frm.FormMode = Base.frmBaseDetail.mode.novy;

            
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                //this.UlozitKontakt();
                gcKontakt.Refresh();
            }
            
        }

        private void icPoznamka_DetailOnClick()
        {
            
            frmPoznamkaDetail frm = new frmPoznamkaDetail();
            frm.parentEntityObject = this.entityObject;
            frm.PravaIgnore = true;
            if ((pcb_develModel.poznamka)poznamkaBindingSource.Current == null) return;

            frm.ShowDetail(this, (pcb_develModel.poznamka)poznamkaBindingSource.Current);
            setPoznamkySouhrn();
            
        }

        private void IconHolder_PridatClick()
        {
            
            frmPoznamkaDetail frm = new frmPoznamkaDetail();
            frm.parentEntityObject = (zakaznik)this.entityObject;

            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                gcPoznamka.Refresh();
            }
            setPoznamkySouhrn();
            
        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                this.DBContext.AddTozakazniks((zakaznik)this.entityObject);
            }
            
            base.SaveData();
        }

        private void gcKontakt_DoubleClick(object sender, EventArgs e)
        {
            icKontakt_DetailOnClick();

        }

        private void gridControlNabidky_DoubleClick(object sender, EventArgs e)
        {
            if (nabidkaBindingSource.Current != null)
            {
                frmNabidkaPolozkaSeznam frm = new frmNabidkaPolozkaSeznam();
                frm.entityObject = (nabidka_polozka)nabidkaBindingSource.Current;
                frm.ShowForm(this);
            }

        }

        private void gcObjednavka_DoubleClick(object sender, EventArgs e)
        {
            if (objednavkaBindingSource.Current != null)
            {
                frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
                frm.ShowForm(this);
            }
        }

        private void gcSeznam_DoubleClick(object sender, EventArgs e)
        {
            if (fakturaBindingSource.Current != null)
            {
                frmFakturaDetail frm = new frmFakturaDetail();
                frm.ShowDetail(this, (faktura)fakturaBindingSource.Current);
            }
        }

        private void btnZavrit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tabControlDetZak.Focus();
            this.Storno();
        }

        private void icKontakt_SmazatOnClick()
        {
            if (kontaktyBindingSource.Current != null)
            {
                if (MessageBox.Show("Chcete opravdu odstranit kontakt?", "Smazat?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DBContext.DeleteObject((kontakt)kontaktyBindingSource.Current);
                }
            }
        }

        private void icPoznamka_SmazatOnClick()
        {
            if (poznamkaBindingSource.Current != null)
            {
                if (MessageBox.Show("Chcete opravdu odstranit kontakt?", "Smazat?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DBContext.DeleteObject((poznamka)poznamkaBindingSource.Current);
                }
            }
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Ulozit();            
        }

        private void gcPoznamka_DoubleClick(object sender, EventArgs e)
        {
            icPoznamka_DetailOnClick();
        }

        private void btnPridatCenaPolozka_Click(object sender, EventArgs e)
        {
            try
            { 
                zakaznik_cenik_polozka polozka =  new zakaznik_cenik_polozka();
                ((zakaznik)this.entityObject).zakaznik_cenik_polozkas.Add(polozka);

                //this.SaveData();
            }
            catch(Exception exp) { }
        }

        private void btnNovyTermin_Click(object sender, EventArgs e)
        {
            try
            { 
                zakaznik_termin_sleva polozka = new zakaznik_termin_sleva();
                polozka.hodnota = 100;
                ((zakaznik)this.entityObject).zakaznik_termin_slevas.Add(polozka);

                //this.SaveData();
            }
            catch (Exception exp) { }
        }

        private void gridControlTermin_Click(object sender, EventArgs e)
        {

        }

        private void btnOdstranitCenaPolozka_Click(object sender, EventArgs e)
        {
            if (zakaznikcenikpolozkaBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((zakaznik_cenik_polozka)zakaznikcenikpolozkaBindingSource.Current);
            }
        }

        private void btnOdstranitTermin_Click(object sender, EventArgs e)
        {
            if (zakaznikterminslevaBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((zakaznik_termin_sleva)zakaznikterminslevaBindingSource.Current);
            }
        }

        private void frmZakaznikDetail_Shown(object sender, EventArgs e)
        {
            txtInterNazev.Focus();
        }

        private void btnNabidky_Click(object sender, EventArgs e)
        {
            frmNabidkaPolozkaSeznam frm = new frmNabidkaPolozkaSeznam();
            frm.ZakaznikNazev = txtInterNazev.Text;
            frm.ShowForm(this);
        }

        private void btnObjednavky_Click(object sender, EventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            frm.ZakaznikNazev = txtInterNazev.Text;
            frm.ShowForm(this);
        }

        private void btnFaktury_Click(object sender, EventArgs e)
        {
            frmFakturaSeznam frm = new frmFakturaSeznam();
            frm.ZakaznikNazev = txtInterNazev.Text;
            frm.ShowForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }

        private void icKontakt_Load(object sender, EventArgs e)
        {

        }

        private void gridControlCenik_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void gridControlCenik_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridControlCenik_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void gridView6_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "hodnota")
            {
                if (Convert.ToDecimal(e.Value) == 0)
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}
