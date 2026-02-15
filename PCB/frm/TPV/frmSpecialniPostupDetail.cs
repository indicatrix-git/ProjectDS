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
    public partial class frmSpecialniPostupDetail : frmBaseDetail
    {
        public frmSpecialniPostupDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        
            operaceBindingSource.DataSource = DBContext.operaces;

            if (this.FormMode == mode.novy)
            {
                specialni_postup postup = new specialni_postup();
                this.entityObject = postup;
            }

            specialnipostupBindingSource.DataSource = this.entityObject;
        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                int pocet = ((produkt)this.parentEntityObject).specialni_postups.Sum(i => i.poradi);
                ((produkt)this.parentEntityObject).specialni_postups.Add((specialni_postup)this.entityObject);
                ((specialni_postup)this.entityObject).poradi = pocet + 1;
                ((specialni_postup)this.entityObject).aktivni = true;
                ((specialni_postup)this.entityObject).zapsal_uzivatel_id = this.PrihlasenyUzivatelId;
                ((specialni_postup)this.entityObject).d_zapsal = PCB.Data.DBHelper.DateTimeNow();

            }
            else
            {
                specialni_postup sp = new specialni_postup();
                sp.aktivni = true;
                sp.produkt_id = ((produkt)this.parentEntityObject).produkt_id;
                sp.poradi = ((specialni_postup)this.entityObject).poradi;
                sp.aktivni = ((specialni_postup)this.entityObject).aktivni;
                sp.zapsal_uzivatel_id = this.PrihlasenyUzivatelId;
                sp.d_zapsal = PCB.Data.DBHelper.DateTimeNow();
                
                this.DBContext.specialni_postups.AddObject(sp);

                ((specialni_postup)this.entityObject).aktivni = false;
            }

        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnZvolitOperaci_Click(object sender, EventArgs e)
        {
            frmCiselnikOperace frm = new frmCiselnikOperace();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((specialni_postup)this.entityObject).operace_id = ((operace)frm.entityObject).operace_id;
                ((specialni_postup)this.entityObject).operace = this.DBContext.operaces.First(i => i.operace_id == ((operace)frm.entityObject).operace_id);
                txtOperace.Text = ((specialni_postup)this.entityObject).operace.nazev;
                
            }
        }
    }
}
