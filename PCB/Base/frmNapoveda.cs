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
    public partial class frmNapoveda : frmBase
    {
        public string Text
        {
            set
            {

                webBrowser1.Navigate("about:blank");
                if (webBrowser1.Document != null)
                {
                    webBrowser1.Document.Write(string.Empty);
                }

                string sablona = @"
<html>
    <body>
        {0}
    </body>
</html>
";
                this.webBrowser1.DocumentText = string.Format(sablona, value);
            }
        }

        public frmNapoveda()
        {
            InitializeComponent();
        }
        
        public static void Set(string text)
        {
            frmNapoveda frm = new frmNapoveda();
            frm.Text = text;
            frm.WindowState = FormWindowState.Normal;
            frm.MinimizeBox = false;
            frm.MaximizeBox = true;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

        }

        private void frmNapoveda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 27)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
