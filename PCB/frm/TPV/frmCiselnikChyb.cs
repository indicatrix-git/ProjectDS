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
    public partial class frmCiselnikChyb : frmBaseSeznam
    {
        public frmCiselnikChyb()
        {
            InitializeComponent();
        }

        private void frmCiselnikChyb_Load(object sender, EventArgs e)
        {
            kontrolaBindingSource.DataSource = DBContext.kontrolas.OrderBy(item=>item.kontrola_id);
        }
    }
}
