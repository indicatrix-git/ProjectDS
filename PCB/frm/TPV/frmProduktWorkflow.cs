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
    public partial class frmProduktWorkflow : frmBaseDetail
    {
        public int Stav { get; set; }

        public frmProduktWorkflow()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStavZmena_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Stav = int.Parse(((SimpleButton)sender).Tag.ToString());
            this.Close();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void frmProduktWorkflow_Load(object sender, EventArgs e)
        {
            if (((produkt)this.entityObject).zakaznik != null)
            {
                htmlControler1.Text = ((produkt)this.entityObject).zakaznik.GetPoznamkyTPV();
                
                cbAOI.EditValue = ((produkt)this.entityObject).zakaznik.aoi;
                cbET.EditValue = ((produkt)this.entityObject).zakaznik.et;
                chbArchivovat.EditValue = ((produkt)this.entityObject).zakaznik.archivovat;
                chbDvojitaKontrola.EditValue = ((produkt)this.entityObject).zakaznik.dvojita_kontrola;
                chbLaser.EditValue = ((produkt)this.entityObject).zakaznik.laser;
                chbULOzn.EditValue = ((produkt)this.entityObject).zakaznik.ul_znaceni;
            }
        }

        private void cbET_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
