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
    public partial class frmPravaHodnota : frmBaseDetail
    {

        public frmPravaHodnota()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            pravaBindingSource.DataSource = DBContext.pravas;
            pravahodnotaBindingSource.DataSource = DBContext.prava_hodnotas;
            PravaUzivatelBindingSource.DataSource = (prava_uzivatel)this.entityObject;
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            ((prava_uzivatel)this.entityObject).prava_id = ((prava)pravaBindingSource.Current).prava_id;
            ((prava_uzivatel)this.entityObject).prava_hodnota_id = ((prava_hodnota)pravahodnotaBindingSource.Current).prava_hodnota_id;
           
            this.Close();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
