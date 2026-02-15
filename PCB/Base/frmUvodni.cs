using PCB.Base;
using PCB.Data;
using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public partial class frmUvodni : frmBaseSeznam
    {
        public frmUvodni()
        {
            InitializeComponent();
        }

        private void frmUvodni_Load(object sender, EventArgs e)
        {
            btnPrihlasenyUzivatel.Text = AppHelper.Uzivatel.celeJmeno;
            txtVerzeAplikace.Text = AppHelper.verze;
            txtDB.Text = getKey("Host") + "\n" + getKey("Database");

            string s = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\avatar\\" + this.PrihlasenyUzivatel.osobni_cislo + ".jpg";
            if (File.Exists(s))
            {
                pictureBox1.ImageLocation = s;
            }
            else
            {
                s = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\avatar\\anonym.jpg";
                if (File.Exists(s))
                {
                    pictureBox1.ImageLocation = s;
                }
            }

            
        }

        private string getKey( string key)
        {
            string connectionString = ((IDbConnection)((EntityConnection)this.DBContext.Connection).StoreConnection).ConnectionString;
            string[] s = connectionString.Split(';');
            return s.ToList().First(i => i.Contains(key));
        }

        private void btnPrihlasenyUzivatel_Click(object sender, EventArgs e)
        {
            frmZmenaHesla frm = new frmZmenaHesla();
            frm.ShowForm(this);
        }

        private void frmUvodni_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void btnVypnout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAktualizovat_Click(object sender, EventArgs e)
        {
            ((frmMain)this.ParentFormBase).SetPrava();
        }
    }
}
