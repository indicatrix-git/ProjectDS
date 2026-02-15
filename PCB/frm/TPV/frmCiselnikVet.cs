using PCB.Base;
using PCB.Gui;
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
    public partial class frmCiselnikVet : frmBaseSeznam
    {
        public CheckButtonItem[] VybraneVety;

        public frmCiselnikVet()
        {
            InitializeComponent();
        }
                        
        private void frmCiselnikVet_Load(object sender, EventArgs e)
        {
            foreach (veta v in DBContext.vetas.OrderBy(i=>i.veta_id))
            {
                cbVety.Items.Add(new Gui.CheckButtonItem(v.veta_id.ToString(), v.obsah));
            
            }
            cbVety.RefeshData(true);
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            VybraneVety = cbVety.SelectedItems;
            this.Close();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
