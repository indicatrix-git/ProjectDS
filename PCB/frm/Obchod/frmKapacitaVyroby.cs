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
    public partial class frmKapacitaVyroby : frmBaseSeznam
    {
        public frmKapacitaVyroby()
        {
            InitializeComponent();
        }
        
        private int getTerminCustom()
        {
            int terminCustom = 0;

            if (rbStandart.Checked)
            {
                terminCustom = 1;
            }

            if (rbExpress.Checked)
            {
                terminCustom = 2;
            }

            return terminCustom;
        }

        private void LoadDataKapacita()
        {
            kapacitaTabulkaBindingSource.DataSource =  KapacitaRow.LoadDataPrehled(this.DBContext, (DateTime)deOd.EditValue, (DateTime)deDo.EditValue, getTerminCustom());
        }

        private void btnZobrazit_Click(object sender, EventArgs e)
        {
            LoadDataKapacita();
        }
        
        private void gridView4_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

        private void frmKapacitaVyroby_Load(object sender, EventArgs e)
        {
            deOd.EditValue = PCB.Data.DBHelper.DateTimeNow();
            deDo.EditValue = PCB.Data.DBHelper.DateTimeNow().AddDays(20);
            rbStandart.Checked = true;

            LoadDataKapacita();
        }
    }
}
