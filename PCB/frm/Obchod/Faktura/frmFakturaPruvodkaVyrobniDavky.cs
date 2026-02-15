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
using PCB.Data.CustomObjects;

namespace PCB
{
    public partial class frmFakturacePruvodkaVyrobniDavky : frmBaseDetail
    {

        public frmFakturacePruvodkaVyrobniDavky()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.ObchodFakturace))
            {
                base.setReadonly(cs);
            }
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                this.entityObject = new faktura_polozka();
                ((faktura_polozka)this.entityObject).faktura_polozka_typ_id = (int)faktura_polozka_typ.Value.Pruvodky;
            }

            fakturaPolozkaBindingSource.DataSource = (faktura_polozka)this.entityObject;

            if (this.FormMode == mode.editace)
            {
                txtKFakturaci.Text = ((faktura_polozka)this.entityObject).pruvodka.volnyPocetKusu.ToString();
                txtPruvodka.ReadOnly = true;
                txtPruvodka.Text = ((faktura_polozka)this.entityObject).pruvodka.cislo;
                txtFakturovat.ReadOnly = false;
                Info(((faktura_polozka)this.entityObject).pruvodka);
            }

        }


        public override void SaveData()
        {
            //if (this.FormMode == mode.novy)
            //{
            //    this.DBContext.faktura_polozkas.AddObject((faktura_polozka)this.entityObject);
            //}

            //base.SaveData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFakturovat.Text))
            {
                MessageBox.Show("Není vyplněn počet fakturovaných kusů.");
                return;
            }

            if (string.IsNullOrEmpty(txtSmluvniCena.Text))
            {
                MessageBox.Show("Není vyplněna cena.");
                return;
            }

            if (((faktura_polozka)this.entityObject).pruvodka == null)
            {
                MessageBox.Show("Není vyplněna průvodka");
                return;
            }

            ((faktura_polozka)this.entityObject).cena_ks = decimal.Parse(txtSmluvniCena.Text);
            ((faktura_polozka)this.entityObject).pocet_ks = int.Parse(txtFakturovat.Text);
            ((faktura_polozka)this.entityObject).dph_id = (int)dph.Value.dph21;
            ((faktura_polozka)this.entityObject).pruvodka.expedice_ks += Convert.ToInt32(getDecimal(txtFakturovat.Text));

            if (!string.IsNullOrEmpty(txtPocetFP.Text))
            {
                polozka("Filmové předlohy", int.Parse(txtPocetFP.Text), txtFilmovePredlohy.EditValue, cbFilmovePredlohy.Checked);
            }

            polozka("Technická příprava výroby", 1, txtTechnickaPriprava.EditValue, cbTechnickaPriprava.Checked);
            polozka("Příprava síta", int.Parse(txtSitoPocet.Text), txtSito.EditValue, cbPripravaSita.Checked);
            polozka("Příprava frézování", 1, txtPripravaFrezovani.EditValue, cbPripravaFrezovani.Checked);
            polozka("Poštovné a balné", 1, txtPostovneBalne.EditValue, cbPostovneABalne.Checked);
            
            // mita
            //Ulozit();

            this.Close();

        }

        private void polozka(string nazev, int pocetks, object cena, bool add)
        {
            if (add)
            {
                faktura_polozka polozka = new faktura_polozka();
                polozka.cena_ks = Convert.ToDecimal(((cena ?? "") == "") ? 0 : cena);
                polozka.nazev = nazev;
                polozka.pocet_ks = pocetks;
                polozka.faktura_polozka_typ_id = (int)faktura_polozka_typ.Value.Pausaly;
                polozka.dph_id = (int)dph.Value.dph21;

                ((faktura)this.parentEntityObject).faktura_polozkas.Add(polozka);
            }
        }


        private decimal getDecimal(string strCislo)
        {
            decimal result = 0;
            strCislo = strCislo.Replace(".", ",");
            try
            {
                result = Convert.ToDecimal(strCislo);
            }
            catch { }

            return result;
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Storno();
        }


        private void Info(pruvodka nalezenaPruvodka)
        {
            if (nalezenaPruvodka != null)
            {

                btnOk.Enabled = true;
                txtFakturovat.ReadOnly = false;
                txtPruvodka.Text = nalezenaPruvodka.cislo;

                pruvodkaBindingSource.DataSource = nalezenaPruvodka;
                ((faktura_polozka)this.entityObject).pruvodka = nalezenaPruvodka;
                txtKFakturaci.Text = ((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.pruvodkas.Sum(i => i.pocet_kusu).ToString();
                txtNazevDps.Text = ((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.produkt != null ? ((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.produkt.nazev : ((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.nazev;
                txtKod.Text = ((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.produkt != null ? ((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.produkt.kod : "";
                ((faktura_polozka)this.entityObject).nazev = txtNazevDps.Text;

                txtPocetFP.EditValue = nalezenaPruvodka.objednavka_polozka.produkt.pocet_fp.ToString();
                txtSmluvniCena.Text = nalezenaPruvodka.objednavka_polozka.smluv_cena.ToString();
                List<CenikRadka> ls = nalezenaPruvodka.objednavka_polozka.GetCenikPolozky(this.DBContext);

                txtFilmovePredlohy.EditValue = ls.Where(i => i.Polozka.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First().Sazba.ToString();
                txtFilmovePredlohyCelkem.EditValue = (((faktura_polozka)this.entityObject).pruvodka.objednavka_polozka.produkt.pocet_fp * ls.Where(i => i.Polozka.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First().Sazba).ToString();

                txtTechnickaPriprava.EditValue = ls.Where(i => i.Polozka.cenik_polozka_id == (int)cenik_polozka.Value.pripravaTPV).First().Sazba.ToString();
                txtSito.EditValue = ls.Where(i => i.Polozka.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSitotisk).First().Sazba.ToString();
                txtSitoPocet.EditValue = nalezenaPruvodka.objednavka_polozka.produkt.ObsahujeKod("PX") ? "2" : nalezenaPruvodka.objednavka_polozka.produkt.ObsahujeKod("PA;PB") ? "1" : "0";
                txtSitaCelkem.EditValue = (Convert.ToInt32(txtSito.EditValue ?? 0) * Convert.ToInt32(txtSitoPocet.EditValue ?? 0)).ToString();


                txtPripravaFrezovani.EditValue = ls.Where(i => i.Polozka.cenik_polozka_id == (int)cenik_polozka.Value.PripravaFrezovani).First().Sazba.ToString();
                txtPostovneBalne.EditValue = ls.Where(i => i.Polozka.cenik_polozka_id == (int)cenik_polozka.Value.postovneAbalne).First().Sazba.ToString();



            }

        }

        private void btnPruvodka_Click(object sender, EventArgs e)
        {
            frmPruvodkaSeznam seznam = new frmPruvodkaSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((faktura_polozka)this.entityObject).pruvodka = ((pruvodka)seznam.entityObject);
                Info(((faktura_polozka)this.entityObject).pruvodka);

            }
        }

    }
}
