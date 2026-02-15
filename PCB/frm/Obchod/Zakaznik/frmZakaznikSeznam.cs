using PCB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Devart.Data.PostgreSql;


namespace PCB
{
    public partial class frmZakaznikSeznam : frmBaseSeznam
    {
        public frmZakaznikSeznam()
        {
            InitializeComponent();
        }

        public override System.Data.Entity.Core.Objects.DataClasses.EntityObject GetEntity(int id)
        {
            return this.DBContext.zakazniks.Where(item => item.zakaznik_id == id).FirstOrDefault();
        }

        public override System.Data.Entity.Core.Objects.DataClasses.EntityObject Current
        {
            get
            {
                if (this.zakaznikBindingSource.Current != null)
                {
                    int id = int.Parse(((DataRowView)this.zakaznikBindingSource.Current)["id"].ToString());
                    return this.GetEntity(id);
                }
                return null;

            }
        }

                
        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);


            this.strSQL = @"
SELECT 
    zakaznik_id AS id,
    interni_nazev, 
    nazev, 
    misto, 
    ico, 
    dic 
FROM zakaznik
WHERE 1=1";

            if (!String.IsNullOrEmpty(txtInterniNazev.Text))
            {
                strSQL += " AND (upper(interni_nazev) like @interni_nazev OR upper(nazev) like @interni_nazev)";
                this.ParamSQL.Add(new PgSqlParameter("@interni_nazev", string.Format("%{0}%", txtInterniNazev.Text.ToUpper())));
                
            }

            zakaznikBindingSource.DataSource = this.GetData();

            if (entity != null)
            {
                int pozice = zakaznikBindingSource.Find("id", ((zakaznik)entity).zakaznik_id);
                ((ColumnView)gcSeznam.MainView).FocusedRowHandle = 0;
                ((ColumnView)gcSeznam.MainView).FocusedRowHandle = ((ColumnView)gcSeznam.MainView).GetRowHandle(pozice);
            }
           
        }

        public override void ApplyRight()
        {
            base.ApplyRight();

            if (!this.HasPravoZapis(prava.Value.ObchodZakaznik))
            {
                btnNovy.Enabled = false;
                btnOdstranit.Enabled = false;
            }
        }


        private void btnNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmZakaznikDetail frm = new frmZakaznikDetail();
            frm.FormMode = Base.frmBaseDetail.mode.novy;
            
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                btnZrusitFiltr_Click(null, null);
                this.LoadData(frm.entityObject);
            }
            
        }
    
        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detail();
            
        }

        private void gcSeznam_DoubleClick(object sender, EventArgs e)
        {
            if (this.SeznamMode == modeCiselnik.vyberCiselnik)
            {
                this.entityObject = this.Current;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                detail();
            }
        }

        private void detail()
        {
            if (this.Current != null)
            {
                frmZakaznikDetail frm = new frmZakaznikDetail();
                frm.ShowDetail(this, this.Current);
                this.LoadData(frm.entityObject);
            }
            
        }

        private void btnVyhledat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }
              
                        
        private void frmZakaznikSeznam_Shown(object sender, EventArgs e)
        {
            txtInterniNazev.Focus();
        }

        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            txtInterniNazev.Text = "";
          
            Interni_nazev.ClearFilter();
            Nazev.ClearFilter();
           
            this.LoadData(null);
        }

        private void txtInterniNazev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnVyhle_Click(null, null);
            }
        }

        private void btnVyhle_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }
    }
}
