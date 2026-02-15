using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PCB.Base;
using pcb_develModel;

namespace PCB
{
    public partial class frmProdejMaterialu : frmBaseDetail
    {
        
        public frmProdejMaterialu()
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
                ((faktura_polozka)this.entityObject).faktura_polozka_typ_id = (int)faktura_polozka_typ.Value.Prodej;
                ((faktura_polozka)this.entityObject).dph_id = (int)dph.Value.dph21;
            }
            dphBindingSource.DataSource = DBContext.dphs;
            fakturaPolozkaBindingSource.DataSource = (faktura_polozka)this.entityObject;
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cenaCelkem()
        {
            decimal celkem = getDecimal(txtCenaKs.Text) * getDecimal(txtPocet.Text);
            //txtCenaBezDPh.Text = Math.Round(celkem, 4).ToString();
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
            cenaCelkem();
        }

        private void txtPocet_EditValueChanged(object sender, EventArgs e)
        {
            cenaCelkem();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Valid();
            if (isValid)
            {
                ((faktura)this.parentEntityObject).faktura_polozkas.Add(((faktura_polozka)this.entityObject));
                this.Close();
            }
                 
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }
    }
}