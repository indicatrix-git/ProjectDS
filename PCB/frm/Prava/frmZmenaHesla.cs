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
    public partial class frmZmenaHesla : frmBaseDetail
    {
        

        public frmZmenaHesla()
        {
            InitializeComponent();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZmenit_Click(object sender, EventArgs e)
        {
            pcb_develEntities db = new pcb_develEntities();
            uzivatel PrihlasenyUzivatel = db.uzivatels.Where(item => item.uzivatel_id == AppHelper.Uzivatel.uzivatel_id).First();

            if (PrihlasenyUzivatel.heslo != uzivatel.MD5Hash(txtStareHeslo.Text))
            {
                MessageBox.Show("Staré heslo je chybné.");
                return;
            }
            
            if (txtNoveHeslo.Text != txtKontrola.Text)
            {
                MessageBox.Show("Nové heslo a kontrola musí být stejné");
                return;
            }

            PrihlasenyUzivatel.heslo = uzivatel.MD5Hash(txtNoveHeslo.Text);
            db.SaveChanges();

            this.Close();
        }

        private void frmZmenaHesla_Shown(object sender, EventArgs e)
        {
            txtStareHeslo.Focus();
        }

    }
}
