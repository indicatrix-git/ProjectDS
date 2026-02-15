using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PCB.Base;
using PCB.Gui;
using pcb_develModel;
using PCB.Data.CustomObjects;
using DevExpress.XtraGrid.Views.Grid;

namespace PCB
{
    public partial class frmKapacitaVyrobyDetail : frmBaseDetail
    {
        objednavka_polozka objednavka_polozka;
        

        // zobrazeni v tabulce
        List<KapacitaRow> lsVyroba;
        
        public frmKapacitaVyrobyDetail()
        {
            InitializeComponent();
            this.PravaIgnore = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            objednavka_polozka = (objednavka_polozka)this.entityObject;
            objednavkapolozkaBindingSource.DataSource = objednavka_polozka;
            objednavka_polozka.Zbyva = objednavka_polozka.PocetksCelkem;
            

            lsVyroba = KapacitaRow.LoadDataPlanovani(this.DBContext,
                PCB.Data.DBHelper.DateTimeNow(), 
                objednavka_polozka.plosny_spoj_specifikace,
                objednavka_polozka.termin_typ).ToList();
            
            kapacitaTabulkaBindingSource.DataSource = lsVyroba;

        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public DateTime VybranyDatum
        {
            get
            {
                return ((KapacitaRow)kapacitaTabulkaBindingSource.Current).Datum;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;

                if (e.Column.Name == "gcDen")
                {
                    string den = (string)View.GetRowCellValue(e.RowHandle, View.Columns["Den"]);
                    if (den == "SO" || den == "NE")
                    {
                        e.Appearance.BackColor = Color.LightGray;
                    }
                }
            }
        }
      
    }
}
