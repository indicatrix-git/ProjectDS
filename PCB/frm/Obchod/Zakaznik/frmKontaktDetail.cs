using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;

namespace PCB
{
    public partial class frmKontaktDetail : frmBaseDetail
    {
        public frmKontaktDetail()
        {
            InitializeComponent();

            this.PravaIgnore = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                this.entityObject = new kontakt();
            }

            kontaktBindingSource.DataSource = (kontakt)this.entityObject;
            oddeleniBindingSource.DataSource = this.DBContext.oddelenis;
        }

        public override void SaveData()
        {
            //base.SaveData();
            if (this.FormMode == mode.novy)
            {
                ((zakaznik)this.parentEntityObject).kontakts.Add((kontakt)this.entityObject);
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = string.Format("mailto:{0}", txtEmail.Text);
            proc.Start();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.Ulozit();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {

            this.Storno();
        }

        private void detail()
        {
            frmKontaktDetail frm = new frmKontaktDetail();
            frm.ShowDetail(this, (pcb_develModel.kontakt)kontaktBindingSource.Current);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnEmail.Enabled = kontakt.IsEmailValid(txtEmail.Text);
        }

    }
}
