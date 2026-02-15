using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using pcb_develModel;
using PCB.Base;




namespace PCB
{
    public partial class frmKooperace : frmBaseDetail
    {
       
        public frmKooperace()
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
                ((faktura_polozka)this.entityObject).faktura_polozka_typ_id = (int)faktura_polozka_typ.Value.Kooperace;
                ((faktura_polozka)this.entityObject).dph_id = (int)dph.Value.dph21;
                ((faktura_polozka)this.entityObject).nazev = "Kooperace";

            }
            else
            {
                txtPruvodka.ReadOnly = true;
                txtPruvodka.Text = ((faktura_polozka)this.entityObject).pruvodka != null ? ((faktura_polozka)this.entityObject).pruvodka.cislo : "";
            }
                        
            dphBindingSource.DataSource = DBContext.dphs.ToList();
            fakturaPolozkaBindingSource.DataSource = (faktura_polozka)this.entityObject;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ((faktura)this.parentEntityObject).faktura_polozkas.Add(((faktura_polozka)this.entityObject));

            this.Close();
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

        private void txtCenaKs_EditValueChanged(object sender, EventArgs e)
        {
           // cenaCelkem();
        }

        private void txtPocet_EditValueChanged(object sender, EventArgs e)
        {
           // cenaCelkem();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void cboTyp_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            ((faktura_polozka)this.entityObject).faktura_kooperace_typ_id = (short)e.NewValue;
            ((faktura_polozka)this.entityObject).nazev = ((faktura_polozka)this.entityObject).faktura_kooperace_typ.nazev;
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            frmPruvodkaSeznam seznam = new frmPruvodkaSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((faktura_polozka)this.entityObject).pruvodka_id = ((pruvodka)seznam.entityObject).pruvodka_id;
                txtPruvodka.Text = ((pruvodka)seznam.entityObject).cislo;
                
            }

           
        }

        private void frmKooperace_Load(object sender, EventArgs e)
        {

        }
    }
}