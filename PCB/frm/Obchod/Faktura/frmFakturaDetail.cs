using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PCB.Base;
using pcb_develModel;
using DevExpress.XtraReports.UI;
using PCB.Report;

namespace PCB
{
    public partial class frmFakturaDetail : frmBaseDetail
    {
        int zakaznikId = 0;

        public frmFakturaDetail()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.ObchodFakturace))
            {
                base.setReadonly(cs);
            }

            btnZavrit.Enabled = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            if (this.FormMode == mode.novy)
            {
                this.entityObject = new faktura();
                ((faktura)this.entityObject).vystavil_id = this.PrihlasenyUzivatelId;
                ((faktura)this.entityObject).uzivatel = this.DBContext.uzivatels.Where(item => item.uzivatel_id == this.PrihlasenyUzivatelId).First();
                ((faktura)this.entityObject).faktura_stav_id = (int)faktura_stav.Value.Zalozena;
                
                dtSplatnost.ReadOnly = true;
                dtPlneni.ReadOnly = true;

            }
            else
            {
                uzivatelBindingSource.DataSource = ((faktura)this.entityObject).uzivatel;
                //btnEditZakaznik.Text = ((faktura)this.entityObject).objednavka.zakaznik.nazev;

                if  (((faktura)this.entityObject).faktura_stav_id == (int)faktura_stav.Value.Vystavna)
                {
                    btnVystavit.Enabled = false;
                    dtVystaveno.ReadOnly = false;
                    txtEditSplatnost.ReadOnly = false;
                }

                if (((faktura)this.entityObject).zakaznik.Splatnost > 0)
                {
                    txtEditSplatnost.EditValue = ((faktura)this.entityObject).zakaznik.Splatnost;
                }
                else
                {
                    txtEditSplatnost.EditValue = 14;
                }

                

            }

            if (((faktura)this.entityObject).zakaznik != null)
            {
                btnEditZakaznik.Text = ((faktura)this.entityObject).zakaznik.interni_nazev;
            }

            fakturaBindingSource.DataSource = (faktura)this.entityObject;
            cboDoprava.Properties.DataSource = DBContext.dopravas.ToList().OrderBy(i=>i.doprava_id);
            lueUhrada.Properties.DataSource = DBContext.uhrada_typs.ToList();
            //cboStav.Properties.DataSource = DBContext.faktura_stavs.ToList();
            polozkyBindingSource.DataSource = ((faktura)this.entityObject).faktura_polozkas;

            refresh();
            
        }

        
        public override void SaveData()
        {
            //if (this.FormMode == mode.novy)
            //{
            //    this.DBContext.fakturas.AddObject((faktura)this.entityObject);
            //}

            base.SaveData();
            
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            Ulozit();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Storno();
        }

        private void refresh()
        {
           txtCena.Text = ((faktura)this.entityObject).ZakladDPH21.ToString();
        }

        private void btnTPVEXP_Click(object sender, EventArgs e)
        {
            this.Valid();
            if (this.isValid)
            {
                frmFakturaPausaly frm = new frmFakturaPausaly();
                frm.parentEntityObject = this.entityObject;

                if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
                {
                    refresh();
                }
            }
            refresh();
        }

        private void btnKoop_Click(object sender, EventArgs e)
        {
            this.Valid();
            if (this.isValid)
            {
                frmKooperace frm = new frmKooperace();
                frm.parentEntityObject = ((faktura)this.entityObject);
                if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
                {
                    refresh();
                }
            }
            refresh();
        }

        private void btnProdMat_Click(object sender, EventArgs e)
        {
            this.Valid();
            if (this.isValid)
            {
                frmProdejMaterialu frm = new frmProdejMaterialu();
                frm.parentEntityObject = ((faktura)this.entityObject);
                if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
                {
                    refresh();
                }
            }
            refresh();
        }

        private void btnExpedice_Click(object sender, EventArgs e)
        {
            this.Valid();
            if (this.isValid)
            {
                frmFakturacePruvodkaVyrobniDavky frm = new frmFakturacePruvodkaVyrobniDavky();
                frm.parentEntityObject = ((faktura)this.entityObject);

                if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
                {
                    refresh();
                }
            }
            refresh();
        }

        private void gcSeznam_DoubleClick(object sender, EventArgs e)
        {
            frmBaseDetail frm = new frmBaseDetail();
            frm.FormMode = mode.editace;
            faktura_polozka p = (faktura_polozka)polozkyBindingSource.Current;
            switch(p.faktura_polozka_typ_id)
            {
                case (int)faktura_polozka_typ.Value.Pausaly:
                    frm = new frmFakturaPausaly();
                    break;
                case (int)faktura_polozka_typ.Value.Pruvodky:
                   // frm = new frmFakturacePruvodkaVyrobniDavky();
                    break;
                case (int)faktura_polozka_typ.Value.Kooperace:
                    frm = new frmKooperace();
                    break;
                case (int)faktura_polozka_typ.Value.Prodej:
                    frm = new frmProdejMaterialu();
                    break;
            }
            frm.parentEntityObject = (faktura)this.entityObject;

            frm.ShowDetail(this, p);
            refresh();
        }

        private void btnOdstan_Click(object sender, EventArgs e)
        {
            deleteRow();
            
        }

       

        private void deleteRow()
        {
            if (XtraMessageBox.Show("Chcete smazat záznam?", "Upozornění", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                return;

            faktura_polozka f = (faktura_polozka)polozkyBindingSource.Current;
            if(f.faktura_polozka_typ_id == (int)faktura_polozka_typ.Value.Pruvodky)
            {

                pruvodka p = f.pruvodka;
                if (p != null)
                {
                    p.expedice_ks -= f.pocet_ks == null ? 0 : (int)f.pocet_ks;
                }
            
            }

            ((faktura)this.entityObject).faktura_polozkas.Remove(f);
                
            try
            {
               DBContext.faktura_polozkas.DeleteObject(f);
            }
            catch
            {

            }
            
            

            refresh();
        }

        private void btnZavrit_ItemClick(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnUlozit_ItemClick(object sender, EventArgs e)
        {
            txtNazev.Focus();
            this.Close();
        }

        

        private void btnTisk_ItemClick(object sender, EventArgs e)
        {
            this.Valid();
            if (this.isValid)
            {
                reportFaktura report = new reportFaktura();
                report.SetDataSourceEntity((faktura)this.entityObject);
                report.CreateDocument();

                // vytiskne
                ReportPrintTool pt = new ReportPrintTool(report);
                pt.ShowPreviewDialog();
            }
        }

        

        private void btnFakturyCislo_Click(object sender, EventArgs e)
        {
            ((faktura)this.entityObject).cislo_faktury = ((faktura)this.entityObject).DalsiCisloFaktury(this.DBContext).ToString();
        }
        
        private void btnVystavit_ItemClick(object sender, EventArgs e)
        {
                ((faktura)this.entityObject).faktura_stav_id = (int)faktura_stav.Value.Vystavna;
                ((faktura)this.entityObject).d_plneni = PCB.Data.DBHelper.DateTimeNow();
                ((faktura)this.entityObject).d_vystaveno = PCB.Data.DBHelper.DateTimeNow();
                ((faktura)this.entityObject).d_splatnost = ((faktura)this.entityObject).d_plneni.Value.AddDays(((int)txtEditSplatnost.Value));
                ((faktura)this.entityObject).cislo_faktury = ((faktura)this.entityObject).DalsiCisloFaktury(this.DBContext);

                this.Ulozit();
                this.Close();
        }

       

        private void btnEditZakaznik_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmZakaznikSeznam seznam = new frmZakaznikSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                zakaznikId = ((zakaznik)seznam.entityObject).zakaznik_id;
                btnEditZakaznik.Text = ((zakaznik)seznam.entityObject).interni_nazev;
                
                zakaznik zak = this.DBContext.zakazniks.Where(i=>i.zakaznik_id == zakaznikId).First();
                ((faktura)this.entityObject).zakaznik = zak;
                
                ((faktura)this.entityObject).zakaznik_nazev = zak.nazev;
                ((faktura)this.entityObject).ulice = zak.ulice;
                ((faktura)this.entityObject).misto = zak.misto;
                ((faktura)this.entityObject).psc = zak.psc;
                ((faktura)this.entityObject).ico = zak.ico;
                ((faktura)this.entityObject).dic = zak.dic;

                if (zak.Splatnost > 0)
                {
                    txtEditSplatnost.EditValue = zak.Splatnost;
                }
                else
                {
                    txtEditSplatnost.EditValue = 14;
                }

            }

        }

 
    }
}
