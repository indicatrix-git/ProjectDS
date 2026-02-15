using DevExpress.XtraEditors;
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
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
           
            InitializeComponent();

            using (var db = new pcb_develEntities())
            {
                var admin = db.uzivatels.Where(w => w.osobni_cislo == "admin").FirstOrDefault();
                if (admin == null)
                {
                    admin = new uzivatel();
                    admin.jmeno = "";
                    admin.prijmeni = "";
                    admin.osobni_cislo = "admin";
                    admin.Password = "Heslo123";
                    admin.role_id = role.ADMINISTRATOR;
                    admin.emial = "";
                    db.uzivatels.AddObject(admin);
                    db.SaveChanges();
                }
            }

        }
                
        private void btnPrihlasit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            uzivatel u = uzivatel.Prihlasit(txtUzivJm.Text, txtHeslo.Text);
            if (u != null)
            {
                AppHelper.Uzivatel = u;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Uživatelské jméno nebo heslo je chybné", "Chybné přihlášení", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUzivJm.Text = "";
                txtHeslo.Text = "";
                txtUzivJm.Focus();  
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtUzivJm.Focus();
        }
      
    }
}
