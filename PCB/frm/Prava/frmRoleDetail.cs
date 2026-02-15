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
    public partial class frmRoleDetail : frmBaseDetail
    {
        public frmRoleDetail()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.AdministraceUzivatelskeRole))
            {
                base.setReadonly(cs);
            }

            btnStorno.Enabled = true;
        }


        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        

            if (this.FormMode == mode.novy)
            {
                this.entityObject = new role();
            }

            roleBindingSource.DataSource = (role)this.entityObject;
            pravaBindingSource.DataSource = ((role)this.entityObject).GetPravaRole(this.DBContext);
            hodnotaBindingSource.DataSource = this.DBContext.prava_hodnotas;
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.Ulozit();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

    }
}
