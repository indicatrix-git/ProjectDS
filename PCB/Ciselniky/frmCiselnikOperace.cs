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
    public partial class frmCiselnikOperace : frmBaseSeznam
    {
        public produkt Produkt
        {
            get;
            set;
        }

        public frmCiselnikOperace()
        {
            InitializeComponent();
            this.PravaIgnore = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            //base.LoadData(entity);

            this.Produkt.LoadSeznamOperaci();

            dataBindingSource.DataSource = this.Produkt.SeznamOperaci.OrderBy(i => i.poradi);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.entityObject = (operace)dataBindingSource.Current;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

                
    }
}
