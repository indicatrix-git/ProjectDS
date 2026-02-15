using Devart.Data.PostgreSql;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraNavBar;
using PCB.Base;
using PCB.Data;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public partial class frmNabidkaPolozkaSeznam : frmBaseSeznam
    {
        bool filter = false;
        public frmNabidkaPolozkaSeznam()
        {
            InitializeComponent();
        }

        public override EntityObject GetEntity(int id)
        {
            return this.DBContext.nabidka_polozkas.Where(item=>item.nabidka_polozka_id == id).First();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            var vyslData = DBContext.nabidka_polozkas;
            nabidkastavBindingSource.DataSource = DBContext.nabidka_stavs.OrderBy(i => i.nabidka_stav_id).ToList();

            if (!string.IsNullOrEmpty(this.ZakaznikNazev))
            {
                txtZakaznikHledej.Text = this.ZakaznikNazev;
            }

            DateTime? dateOd = (dateEditPrijataOd.EditValue != null ? (DateTime)dateEditPrijataOd.EditValue : (DateTime?)null);
            DateTime? dateDo = (dateEditPrijataDo.EditValue != null ? (DateTime)dateEditPrijataDo.EditValue : (DateTime?)null);

            if (!filter)
            {
                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarTPVNabidkaPolozka")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("nabidka_stav_id", 1);
                }
                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarItemTechnologieNabidky")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("nabidka_stav_id", 2);
                }
            }

            int stavNabidka = Convert.ToInt32(cmbStav.EditValue);

            this.strSQL = @"
SELECT 
    np.nabidka_polozka_id AS id,
    np.d_prijato, 
    z.interni_nazev AS zakaznik,
    np.nazev_dps,
    np.d_sestaveno,
    u.prijmeni || ' ' || u.jmeno AS sestavil,
    ns.nazev AS stav_nazev
FROM nabidka_polozka np
JOIN zakaznik z ON z.zakaznik_id = np.zakaznik_id
JOIN nabidka_stav ns ON ns.nabidka_stav_id = np.nabidka_stav_id
JOIN uzivatel u ON u.uzivatel_id = np.sestavil_id
WHERE 1=1";

            if (!String.IsNullOrEmpty(txtZakaznikHledej.Text))
            {
                strSQL += " AND upper(z.interni_nazev) like @interni_nazev";
                this.ParamSQL.Add(new PgSqlParameter("@interni_nazev", string.Format("%{0}%", txtZakaznikHledej.Text.ToUpper())));
            }

            if (!String.IsNullOrEmpty(txtDPSHledej.Text))
            {
                strSQL += " AND upper(np.nazev_dps) like @nazev_dps";
                this.ParamSQL.Add(new PgSqlParameter("@nazev_dps", string.Format("%{0}%", txtDPSHledej.Text.ToUpper())));
            }

            if (stavNabidka !=0)
            {
                strSQL += string.Format(" AND np.nabidka_stav_id={0}", stavNabidka);
            }

            if (dateOd.HasValue)
            {
                strSQL += string.Format(" AND d_prijato>='{0}'", dateOd.Value.ToString("yyyy-MM-dd 00:00"));
            }

            if (dateDo.HasValue)
            {
                strSQL += string.Format(" AND d_prijato<='{0}'", dateDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            }

            strSQL += " ORDER BY np.d_sestaveno";
            nabidkapolozkaBindingSource.DataSource = this.GetData();
            
            if (entity != null)
            {
                    int pozice = nabidkapolozkaBindingSource.Find("id", ((nabidka_polozka)entity).nabidka_polozka_id);
                    ((ColumnView)gridControlNabPol.MainView).FocusedRowHandle = 0;
                    ((ColumnView)gridControlNabPol.MainView).FocusedRowHandle = ((ColumnView)gridControlNabPol.MainView).GetRowHandle(pozice);
            }
        }

        private void btnBarNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNabidkaPolozkaDetail frm = new frmNabidkaPolozkaDetail();
            frm.parentEntityObject = this.entityObject;
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
            
            
        }

        private void btnBarDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detail();
        }

        private void Pozice(frmBase frm)
        {
            int pozice = nabidkapolozkaBindingSource.IndexOf((nabidka_polozka)frm.entityObject);
            nabidkapolozkaBindingSource.Position = pozice;
        }

        private void btnBarVyhledat_ItemClick(object sender, EventArgs e)
        {
            filter = true;
            this.LoadData(null);
        }

        private void btnBarZrusFiltr_ItemClick(object sender, EventArgs e)
        {
            
            txtZakaznikHledej.Text = "";
            txtDPSHledej.Text = "";
            dateEditPrijataOd.EditValue = null;
            dateEditPrijataDo.EditValue = null;
            cmbStav.EditValue = 0;  // všechny
            

            // filtr na tabulce
            filtrNazevSpoje.ClearFilter();
            filtrSestaveno.ClearFilter();
            filtrSestavil.ClearFilter();
            filtrZakaznik.ClearFilter();
            filter = false;

            this.LoadData(null);
        }
               
        public override void ApplyRight()
        {
            base.ApplyRight();

            if (!this.HasPravoZapis(prava.Value.ObchodNabidky))
            {
                btnBarNovy.Enabled = false;
                btnObnovit.Enabled = false;
                btnStorno.Enabled = false;
            }
        }


        private void gridControlNabPol_DoubleClick(object sender, EventArgs e)
        {
            if (this.SeznamMode == modeCiselnik.vyberCiselnik)
            {
                this.entityObject = this.GetEntity(int.Parse(((DataRowView)nabidkapolozkaBindingSource.Current)["id"].ToString()));
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
            if (nabidkapolozkaBindingSource.Current != null)
            {
                frmNabidkaPolozkaDetail frm = new frmNabidkaPolozkaDetail();
                int id = int.Parse(((DataRowView)nabidkapolozkaBindingSource.Current)["id"].ToString());
                if (frm.ShowDetail(this, GetEntity(id)) == System.Windows.Forms.DialogResult.OK)
                {
                    this.LoadData(frm.entityObject);
                }
                else
                {
                    this.LoadData(null);
                }
            }
        }

        private void btnStorno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nabidkapolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)nabidkapolozkaBindingSource.Current)["id"].ToString());
                nabidka_polozka nb = ((nabidka_polozka)this.GetEntity(id));
                nb.nabidka_stav_id = (int)nabidka_stav.Value.Stornovana;
                this.DBContext.SaveChanges();
                this.LoadData(nb);
                MessageBox.Show("Nabídka stornována", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nabidkapolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)nabidkapolozkaBindingSource.Current)["id"].ToString());
                nabidka_polozka nb = ((nabidka_polozka)this.GetEntity(id));
                nb.nabidka_stav_id = (int)nabidka_stav.Value.Zalozena;
                this.DBContext.SaveChanges();
                this.LoadData(nb);
                MessageBox.Show("Nabídka obnovena", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
