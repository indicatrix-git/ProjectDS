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
    public partial class frmCenikSeznam : frmBaseSeznam
    {
        public frmCenikSeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            cenikBindingSource.DataSource = DBContext.ceniks.ToList();
        }

        private void OpenDetail()
        {
            frmCenikDetail frm = new frmCenikDetail();
            frm.ShowDetail(this, (cenik)cenikBindingSource.Current);
        }

        private void btnCenik_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenDetail();
        }

        private void btnBarNova_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCenikDetail frm = new frmCenikDetail();
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCenikHodnotaDetail frm = new frmCenikHodnotaDetail();
            if (frm.ShowDetail(this,(cenik)cenikBindingSource.Current) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
        }

        private void gridControlCenik_DoubleClick(object sender, EventArgs e)
        {
            this.OpenDetail();
        }
    }
}
