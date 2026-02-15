using DevExpress.XtraGrid.Views.Grid;
using PCB.Base;
using PCB.Data.CustomObjects;
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
    public partial class frmKontrola : frmBaseDetail
    {
        private List<KontrolaItem> Vysledek;

        public int Fatalni
        {
            get
            {
                if (this.Vysledek != null)
                {
                    return Vysledek.Where(i => i.Fatalni).Count();
                }
                return -1;
            }
        }

        public frmKontrola()
        {
            InitializeComponent();
            this.PravaIgnore = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.entityObject is produkt)
            {
                
                if (!((produkt)this.entityObject).ObsahujeKod("S.;SN"))
                {
                    ((produkt)this.entityObject).SestavKontroly();
                }
                else
                {
                    ((produkt)this.entityObject).SestavKontrolySablona();
                }

                Vysledek = ((produkt)this.entityObject).HlaskyZKontroly;
            }

            if (this.entityObject is objednavka_polozka)
            {
                objednavka_polozka obj = (objednavka_polozka)this.entityObject;
                obj.SestavKontroly();


                if (!(obj.produkt).ObsahujeKod("S.;SN"))
                {
                    (obj.produkt).SestavKontroly();
                }
                else
                {
                    (obj.produkt).SestavKontrolySablona();
                }

                // secte hlasky jak pro obj i produkt
                Vysledek = obj.HlaskyZKontroly;
                Vysledek.AddRange(obj.produkt.HlaskyZKontroly);
            }

            if (rbFatalni.Checked)
            {
                Vysledek = Vysledek.Where(i => i.Fatalni).ToList();
            }
            else
            if (rbPropustne.Checked)
            {
                Vysledek = Vysledek.Where(i => i.Propustna).ToList();
            }
            else
            if (rbTiskova.Checked)
            {
                Vysledek = Vysledek.Where(i => i.Tiskova).ToList();
            }
            
            kontrolaItemBindingSource.DataSource = Vysledek.OrderBy(i => (i.Level + i.Kod));

            txtFatalni.Text = Vysledek.Where(i => i.Fatalni).Count().ToString();
            txtPropustna.Text = Vysledek.Where(i => i.Propustna).Count().ToString();
            txtTiskova.Text = Vysledek.Where(i => i.Tiskova).Count().ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;

                string level = (string)View.GetRowCellValue(e.RowHandle, View.Columns["Level"]);
                if (level == null)
                {
                    return;
                }
                if (level.Contains("F"))
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }

                if (level.Contains("T"))
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }

            }
        }

        private void rbVsechny_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void btnCiselnikKontrol_Click(object sender, EventArgs e)
        {
            frmCiselnikChyb frm = new frmCiselnikChyb();
            frm.ShowDialog();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
