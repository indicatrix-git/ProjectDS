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

namespace PCB
{
    public partial class frmRoleSeznam : frmBaseSeznam
    {
        public frmRoleSeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            roleBindingSource.DataSource = DBContext.roles;

            if (entity != null)
            {
                role z = this.DBContext.roles.Where(item => item.role_id == ((role)entity).role_id).First();
                int pozice = roleBindingSource.IndexOf(z);
                roleBindingSource.Position = pozice;
            }
        }


        private void btnNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRoleDetail frm = new frmRoleDetail();
            frm.FormMode = Base.frmBaseDetail.mode.novy;

            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                LoadData(frm.entityObject);
            }
        }

        private void btnOdstranit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            role role = roleBindingSource.Current as role;
            if (role.uzivatels.Count > 0)
            {
                MessageBox.Show(string.Format("Roli není možné smazat, je přiřazena uživatelům {0} ",
                   string.Join(",\n", role.uzivatels.Select(u => u.prijmeni).ToArray())), "Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (role.role_id == role.ADMINISTRATOR)
            {
                MessageBox.Show("Nelze smazat administrátorskou roli.", "Role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Chcete opravdu smazat tuto roli?", "", MessageBoxButtons.OKCancel) != DialogResult.OK) return;

            this.dbContext.prava_roles.Where(p => p.role_id == role.role_id).ToList().ForEach(r =>
                 {
                     this.dbContext.DeleteObject(r);
                 });

            this.dbContext.DeleteObject(role);
            this.dbContext.SaveChanges();
        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRoleDetail frm = new frmRoleDetail();
            frm.ShowDetail(this, (pcb_develModel.role)roleBindingSource.Current);
            LoadData(frm.entityObject);
        }

        private void gcSeznam_DoubleClick(object sender, EventArgs e)
        {
            OpenDetail();
        }

        private void OpenDetail()
        {
            frmRoleDetail frm = new frmRoleDetail();
            frm.ShowDetail(this, (pcb_develModel.role)roleBindingSource.Current);
            LoadData(frm.entityObject);
        }
    }
}
