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
    public partial class frmPruvodkaOpravna : frmBaseDetail
    {
        public frmPruvodkaOpravna()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            this.entityObject = new pruvodka();
            operaceopravaBindingSource.DataSource = ((pruvodka)this.entityObject).operace_opravas;
        }

        public override void SaveData()
        {
            base.SaveData();
            this.DBContext.SaveChanges();
        }


        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnVytisknout_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            pruvodka p = (pruvodka)this.entityObject;
            p.cislo = txtCisloPruvodky.Text;
            p.pin = rnd.Next(1000, 9999).ToString();
            p.pruvodka_stav_id = 1;
            p.parent_pruvodka_id = ((pruvodka)this.parentEntityObject).pruvodka_id;
            p.objednavka_polozka_id = ((pruvodka)this.parentEntityObject).objednavka_polozka.objednavka_polozka_id;
            p.pocet_kusu = int.Parse(txtPocetKusu.Text);
            //p.u = this.PrihlasenyUzivatelId;
            p.d_tisk_pruvodka = PCB.Data.DBHelper.DateTimeNow();

            DBContext.pruvodkas.AddObject(p);

            this.Ulozit();
        }

        private void btnZmenaNovy_Click(object sender, EventArgs e)
        {
            frmOperaceVyber frm = new frmOperaceVyber();
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (operace o in frm.Vybrano)
                {
                    if (o.Vybrano)
                    {
                        operace_oprava oprava = new operace_oprava();
                        oprava.pruvodka = (pruvodka)this.entityObject;
                        oprava.operace = o;
                        ((pruvodka)this.entityObject).operace_opravas.Add(oprava);
                    }
                }
            }
        }
    }
}
