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
    public partial class frmPuvodniSystemDetail : Form
    {
        public DataRowView row;
        public frmPuvodniSystemDetail()
        {
            InitializeComponent();
        }

        private void frmPuvodniSystemDetail_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = row;
        }
    }
}
