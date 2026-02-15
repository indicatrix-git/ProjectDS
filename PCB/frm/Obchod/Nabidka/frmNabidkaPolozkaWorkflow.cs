using DevExpress.XtraEditors;
using PCB.Base;
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
    public partial class frmNabidkaPolozkaWorkflow : frmBaseDetail
    {
        public int Stav { get; set; }

        public frmNabidkaPolozkaWorkflow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStavZmena_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Stav = int.Parse(((SimpleButton)sender).Tag.ToString());
            this.Close();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
