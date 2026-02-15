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
    public partial class frmOperaceVyber : frmBaseDetail
    {
        public List<operace> Vybrano { get; set; }
        

        public frmOperaceVyber()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            try
            {
                this.Vybrano = ((IEnumerable<operace>)operaceBindingSource.DataSource).Where(i => i.Vybrano == true).ToList();
            }
            catch (Exception exp) { }
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            operaceBindingSource.DataSource = this.DBContext.operaces.ToList().OrderBy(item=>item.operace_id);
        }
    }
}
    
