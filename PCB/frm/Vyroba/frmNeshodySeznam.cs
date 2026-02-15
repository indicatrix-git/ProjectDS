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
    public partial class frmNeshodySeznam : frmBaseSeznam
    {
        public frmNeshodySeznam()
        {
            InitializeComponent();
        }


        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
           base.LoadData(entity);
           neshodaBindingSource.DataSource = DBContext.neshodas.Where(i => i.pruvodka_id == ((pruvodka)this.entityObject).pruvodka_id);
        }

        private void btnBarNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNeshodaDetail frm = new frmNeshodaDetail();
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPruvodkaDetail frm = new frmPruvodkaDetail();
            frm.ShowDetail(this, ((pruvodka)this.entityObject));
        }

        private void btnBarOdstranit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((neshoda)neshodaBindingSource.Current) != null)
            {
                DBContext.DeleteObject(((neshoda)neshodaBindingSource.Current));
                DBContext.SaveChanges();
            }
        }
    }
}
