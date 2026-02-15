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
    public partial class frmSpecialniPostupPoznamka : frmBase
    {
        public frmSpecialniPostupPoznamka()
        {
            InitializeComponent();
        }

        private void frmSpecialniPostupPoznamka_Load(object sender, EventArgs e)
        {
            memoEdit1.Text = ((specialni_postup)this.entityObject).technologicka_poznamka;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ((specialni_postup)this.entityObject).technologicka_poznamka = memoEdit1.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
