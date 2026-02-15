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
    public partial class frmUzivatelSeznam: frmBaseSeznam
    {
        public frmUzivatelSeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            uzivatelBindingSource.DataSource = this.DBContext.uzivatels;
            
            if (entity != null)
            {
                uzivatel z = this.DBContext.uzivatels.Where(item => item.uzivatel_id == ((uzivatel)entity).uzivatel_id).First();
                int pozice = uzivatelBindingSource.IndexOf(z);
                uzivatelBindingSource.Position = pozice;
            }
        }
       

        private void btnNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUzivatelDetail frm = new frmUzivatelDetail();
            frm.FormMode = Base.frmBaseDetail.mode.novy;

            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK) 
            {
                LoadData(frm.entityObject);
            }
            else
            {
                LoadData(null);
            }

        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenDetail();
        }

        private void OpenDetail()
        {
            frmUzivatelDetail frm = new frmUzivatelDetail();
            frm.ShowDetail(this, (pcb_develModel.uzivatel)uzivatelBindingSource.Current);
            LoadData(frm.entityObject);
        }

        private void btnBarNovyNabPol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControlNabPol_DoubleClick(object sender, EventArgs e)
        {
            this.OpenDetail();
        }
    }
}
