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
    public partial class frmCiselnikCu : frmBaseSeznam
    {
        public string Kody;

        public frmCiselnikCu()
        {
            InitializeComponent();
            this.PravaIgnore = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
       
            vrstvacuBindingSource.DataSource = this.DBContext.vrstva_cus.ToList().OrderBy(i => i.vrstva_cu_id);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.entityObject = (vrstva_cu)vrstvacuBindingSource.Current;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

                
    }
}
