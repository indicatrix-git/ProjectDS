using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB.Report
{
    public partial class frmReportView : Form
    {
        public XtraReport Report;

        public frmReportView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = this.Report;
            
        }
    }
}
