using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;

namespace PCB
{
    public partial class frmOpravySeznam : frmBaseSeznam
    {
        public frmOpravySeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);

            opravyBindingSource.DataSource = DBContext.opravas.Where(w => w.pruvodka_id == ((pruvodka)this.entityObject).pruvodka_id);
        }

        private void btnBarNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOpravaDetail frm = new frmOpravaDetail();
            frm.parentEntityObject = this.entityObject;
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
        }

        private void btnBarOdstranit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((oprava)opravyBindingSource.Current) != null)
            {
                DBContext.DeleteObject(((oprava)opravyBindingSource.Current));
                DBContext.SaveChanges();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPruvodkaDetail frm = new frmPruvodkaDetail();
            frm.ShowDetail(this, ((pruvodka)this.entityObject));
        }
    }
}
