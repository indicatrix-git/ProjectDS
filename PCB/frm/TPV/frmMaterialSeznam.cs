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
    public partial class frmMaterialSeznam : frmBaseSeznam
    {
        public frmMaterialSeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        
            if (this.entityObject != null && this.entityObject is produkt)
            {
                // filtr jen na plechy
                materialBindingSource.DataSource = this.DBContext.materials.Where(i => i.material_typ_id == 3 || i.material_id == 16).OrderBy(i => i.PoradiProTabulku).ToList();
            }
            else
            {
                materialBindingSource.DataSource = this.DBContext.materials.ToList().OrderBy(i=>i.PoradiProTabulku).ToList();
            }

            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView1.IsGroupRow(this.gridView1.FocusedRowHandle)) return;


            this.entityObject = (material)materialBindingSource.Current;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Typ" && e.IsForGroupRow)
            {
                e.DisplayText = e.DisplayText.Substring(4);
            }
        }

    }
}
