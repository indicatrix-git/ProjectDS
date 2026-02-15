using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using PCB.Base;
using pcb_develModel;
using PCB.Data.CustomObjects;

namespace PCB
{
    public partial class frmFakturaPausaly : frmBaseDetail
    {
        public frmFakturaPausaly()
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
                ((faktura_polozka)this.entityObject).faktura_polozka_typ = this.DBContext.faktura_polozka_typs.Where(i => i.faktura_polozka_typ_id == (int)faktura_polozka_typ.Value.Pausaly).First();
                ((faktura_polozka)this.entityObject).faktura = ((faktura)this.parentEntityObject);
            }

            fakturaPolozkaBindingSource.DataSource = (faktura_polozka)this.entityObject;

            typTpvBindingSource.DataSource = this.DBContext.faktura_tpv_typs.ToList();
            dphBindingSource.DataSource = DBContext.dphs.ToList();

        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
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
            //cenaCelkem();
        }

        private void txtPocet_EditValueChanged(object sender, EventArgs e)
        {
            //cenaCelkem();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }
    }
}