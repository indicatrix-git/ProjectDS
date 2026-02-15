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
    public partial class frmPostupSeznam : frmBaseSeznam
    {
        public frmPostupSeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        
            postupBindingSource.DataSource = DBContext.postups.Where(i=>i.typ_deska.Value);
        }

        private void btnPolozky_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPostupDetail frm = new frmPostupDetail();
            frm.entityObject = (postup)postupBindingSource.Current;
            frm.ShowForm(this);
        }

        private void btnZavrit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUlozit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBContext.SaveChanges();
            this.Close();
        }

      
        
    }
}
