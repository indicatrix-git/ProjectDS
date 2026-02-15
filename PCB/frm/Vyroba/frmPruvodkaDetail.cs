using PCB.Base;
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
    public partial class frmPruvodkaDetail : frmBaseDetail
    {
        public frmPruvodkaDetail()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            //base.setReadonly(cs);
            btnObjednavka.Enabled = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            pruvodkaodepisovaniBindingSource.DataSource = ((pruvodka)this.entityObject).pruvodka_odepisovanis;
            lblCisloPruvodky.Text = ((pruvodka)this.entityObject).cislo;
            progressBarControl1.EditValue = ((pruvodka)this.entityObject).hotovo_procento;
            
        }

        private void btnObjednavka_Click(object sender, EventArgs e)
        {
            if ((pruvodka)this.entityObject != null)
            {
                frmObjednavkaPolozkaDetail detail = new frmObjednavkaPolozkaDetail();
                objednavka_polozka obj = ((pruvodka)this.entityObject).objednavka_polozka;
                detail.ShowDetail(this, obj);
            }
        }

        private void btnZavrit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActionNeshoda_Click(object sender, EventArgs e)
        {
            pruvodka_odepisovani po = this.gridView5.GetFocusedRow() as pruvodka_odepisovani;

            if (po != null)
            {
                frmNeshodaDetail frm = new frmNeshodaDetail();
                frm.parentEntityObject = this.entityObject;
                frm.PravaIgnore = true;
                frm.ShowDetail(this, new neshoda() { pocet_ks = po.vadny_ks, pocet_panelu = po.vadny_panelu_ks, pruvodka = po.pruvodka, pruvodka_operace_id = po.pruvodka_operace_id });
            }
        }

        private void btnActionOprava_Click(object sender, EventArgs e)
        {
            pruvodka_odepisovani po = this.gridView5.GetFocusedRow() as pruvodka_odepisovani;

            if (po != null)
            {
                frmOpravaDetail frm = new frmOpravaDetail();
                frm.parentEntityObject = this.entityObject;
                frm.PravaIgnore = true;
                frm.ShowDetail(this, new oprava() { pocet_ks = po.vadny_ks, pocet_panelu = po.vadny_panelu_ks, pruvodka = po.pruvodka, pruvodka_operace_id = po.pruvodka_operace_id });
            }
        }

        private void gridView5_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            
        }
    }
}
