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
    public partial class frmCenikDetail : frmBaseDetail
    {
        public frmCenikDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            
            if (this.FormMode == mode.novy)
            {
                this.entityObject = new cenik();
            }

            cenikBindingSource.DataSource = this.entityObject;
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.ObchodCenik))
            {
                base.setReadonly(cs);
            }
        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                DBContext.ceniks.AddObject((cenik)this.entityObject);
            }
            base.SaveData();
        }

       
        private void btnUlozit_Click_1(object sender, EventArgs e)
        {
            this.Ulozit();
        }

        private void btnStorno_Click_1(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void frmCenikDetail_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
        }
    }
}
