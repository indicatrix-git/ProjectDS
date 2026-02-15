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
    public partial class frmKodPoradi : frmBaseDetail
    {
        public frmKodPoradi()
        {
            InitializeComponent();
            this.PravaIgnore = true;
        }

        private void frmKodPoradi_Load(object sender, EventArgs e)
        {
            produktpostupBindingSource.DataSource = ((produkt)this.entityObject).produkt_postups;
        }

        private void btnNahoru_Click(object sender, EventArgs e)
        {
            produkt_postup vr = (produkt_postup)produktpostupBindingSource.Current;
            produkt_postup vr1 = ((IEnumerable<produkt_postup>)produktpostupBindingSource.DataSource).Where(i => i.poradi == (vr.poradi - 1)).FirstOrDefault();

            if (vr != null && vr1 != null)
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                produktpostupBindingSource.Position = produktpostupBindingSource.IndexOf(vr);
                gridControl1.Refresh();
            }
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            produkt_postup vr = (produkt_postup)produktpostupBindingSource.Current;
            produkt_postup vr1 = ((IEnumerable<produkt_postup>)produktpostupBindingSource.DataSource).Where(i => i.poradi == (vr.poradi + 1)).FirstOrDefault();
            if (vr != null && vr1 != null)
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                produktpostupBindingSource.Position = produktpostupBindingSource.IndexOf(vr);

                gridControl1.Refresh();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
