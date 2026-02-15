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
    public partial class frmTechnologickaPoznamkaDetail : frmBaseDetail
    {

        public frmTechnologickaPoznamkaDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        
            produkt produkt = (produkt)this.parentEntityObject;
            produkt.LoadSeznamOperaci();

            operaceBindingSource.DataSource = produkt.SeznamOperaci;

            if (this.FormMode == mode.novy)
            {
                produkt_poznamka pozn = new produkt_poznamka();
                this.entityObject = pozn;
            }
            
            bindingSourceTechnologickaPoznamka.DataSource = this.entityObject;
        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                ((produkt_poznamka)this.entityObject).uzivatel_id = this.PrihlasenyUzivatelId;
                ((produkt_poznamka)this.entityObject).d_zapsano = PCB.Data.DBHelper.DateTimeNow();
                ((produkt_poznamka)this.entityObject).aktivni = true;
                ((produkt)this.parentEntityObject).produkt_poznamkas.Add(((produkt_poznamka)this.entityObject));
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            if (memoEdit1.Text == "")
            {
                memoEdit1.Text = "Není vyplněn.";
            }

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
            frm.Produkt = (produkt)this.parentEntityObject;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((produkt_poznamka)this.entityObject).operace_id = ((operace)frm.entityObject).operace_id;
                ((produkt_poznamka)this.entityObject).operace = this.DBContext.operaces.First(item => item.operace_id == ((operace)frm.entityObject).operace_id);
                txtOperace.Text = ((produkt_poznamka)this.entityObject).operace.nazev;
            }
        }
    }
}
