using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmProduktSeznam : frmBaseSeznam
    {
        bool filter = false;

        public frmProduktSeznam()
        {
            InitializeComponent();
        }

        public override EntityObject GetEntity(int id)
        {
            return this.DBContext.produkts.Where(item => item.produkt_id == id).First();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            // pro 
            this.strSQL = @"
SELECT 
    false AS vybrano,
	pr.produkt_id AS id,
	z.interni_nazev AS zakaznik,
	pr.nazev AS nazev_dps,
	pr.d_sestaveno,
	u.prijmeni || ' ' || u.jmeno AS sestavil,

	CASE pr.zamek 
    	WHEN true  THEN ps.nazev || ' (zámek)' 
    	ELSE ps.nazev 
	END as produkt_stav
	,
    pr.kod AS kod,
(   SELECT max(d_tisk_pruvodka) FROM pruvodka pruv 
    JOIN objednavka_polozka obj ON obj.objednavka_polozka_id = pruv.objednavka_polozka_id
    WHERE obj.produkt_id = pr.produkt_id) AS naposledy_ve_vyrobe,
pr.produkt_stav_id,
pr.sablona
FROM produkt AS pr
JOIN zakaznik AS z ON z.zakaznik_id = pr.zakaznik_id
JOIN uzivatel AS u ON u.uzivatel_id = pr.sestavil
JOIN produkt_stav AS ps ON ps.produkt_stav_id = pr.produkt_stav_id
WHERE 1=1";

            if (filter == false)
            {
                produktstavBindingSource.DataSource = this.DBContext.produkt_stavs.ToList();
                cmbStavProdukt.EditValue = cmbStavProdukt.EditValue = cmbStavProdukt.Properties.GetDataSourceValue("produkt_stav_id", 0);
            }


            int stav = cmbStavProdukt.EditValue == null ? 0 : int.Parse(cmbStavProdukt.EditValue.ToString());

            DateTime? dOd = (DateTime?)dateEditNaposledyOd.EditValue;
            DateTime? dDo = (DateTime?)dateEditNaposledyDo.EditValue;


            /* var lsProdukt = this.DBContext.produkts
                  .Where(i => (!String.IsNullOrEmpty(txtZakaznikHledej.Text) ? i.zakaznik != null && i.zakaznik.interni_nazev.Contains(txtZakaznikHledej.Text.ToUpper()) : true))
                  .Where(i => (!String.IsNullOrEmpty(txtDPSHledej.Text) ? i.nazev.Contains(txtDPSHledej.Text) : true))
                  .Where(i => (cbSablona.Checked ? i.sablona == true : true))
                  .Where(i => (stav != 0 ? i.produkt_stav_id == stav : true)).ToList()
                 //custom
                  .Where(i => (txtKod.Text != null ? i.kod.ToUpper().Contains(txtKod.Text.ToUpper()) : true))
               *   .Where(i => (dOd.HasValue && i.NaposledyVeVyrobe.HasValue ? i.NaposledyVeVyrobe >= dOd : true))
               *   .Where(i => (dDo.HasValue && i.NaposledyVeVyrobe.HasValue ? i.NaposledyVeVyrobe <= dDo : true));*/

            if (!String.IsNullOrEmpty(txtZakaznikHledej.Text))
            {
                strSQL += " AND upper(z.interni_nazev) like @interni_nazev";
                this.ParamSQL.Add(new PgSqlParameter("@interni_nazev", string.Format("%{0}%", txtZakaznikHledej.Text.ToUpper())));
            }

            if (!String.IsNullOrEmpty(txtKod.Text))
            {
                strSQL += string.Format(" AND upper(pr.kod) like @kod", txtKod.Text.ToUpper());
                this.ParamSQL.Add(new PgSqlParameter("@kod", string.Format("%{0}%", txtKod.Text.ToUpper())));
            }

            if (stav != 0)
            {
                strSQL += string.Format(" AND pr.produkt_stav_id={0}", stav);
            }

            if (dOd.HasValue)
            {
                strSQL += string.Format(" AND pr.d_sestaveno>='{0}'", dOd.Value.ToString("yyyy-MM-dd 00:00"));
            }

            if (dDo.HasValue)
            {
                strSQL += string.Format(" AND pr.d_sestaveno<='{0}'", dDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            }

            if (cbSablona.Checked)
            {
                strSQL += string.Format(" AND (pr.sablona = true)");
            }

            strSQL += string.Format(" ORDER BY z.interni_nazev, pr.nazev ");

            produktBindingSource.DataSource = this.GetData();

            if (entity != null)
            {
                int pozice = produktBindingSource.Find("id", ((produkt)entity).produkt_id);
                ((ColumnView)gridControlTechDok.MainView).FocusedRowHandle = 0;
                ((ColumnView)gridControlTechDok.MainView).FocusedRowHandle = ((ColumnView)gridControlTechDok.MainView).GetRowHandle(pozice);
            }

            ((ColumnView)gridControlTechDok.MainView).BeginSort();
            ((ColumnView)gridControlTechDok.MainView).ClearSorting();
            ((ColumnView)gridControlTechDok.MainView).Columns["zakaznik"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            ((ColumnView)gridControlTechDok.MainView).Columns["nazev_dps"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            ((ColumnView)gridControlTechDok.MainView).EndSort();
        }

        public override void ApplyRight()
        {
            base.ApplyRight();

            if (cmbStavProdukt.EditValue != null && int.Parse(cmbStavProdukt.EditValue.ToString()) != (int)produkt_stav.Value.aktivni)
            {
                btnBarNovaSablona.Enabled =
                btnBarNovyDPS.Enabled =
                btnKopieDPS.Enabled =

                btnZmenaDPS.Enabled =
                btnZmenaIV.Enabled =

                btnZamek1.Enabled = false;

            }
            else
            {
                btnBarNovaSablona.Enabled =
               btnBarNovyDPS.Enabled =
               btnKopieDPS.Enabled =

               btnZmenaDPS.Enabled =
               btnZmenaIV.Enabled =

               btnZamek1.Enabled = true;
            }


            if (!this.HasPravoZapis(prava.Value.TPVTechnickaDokumentace))
            {
                btnBarNovaSablona.Enabled = false;
                btnBarNovyDPS.Enabled = false;
                btnZmenaDPS.Enabled = false;
                btnZmenaIV.Enabled = false;
                btnKopieDPS.Enabled = false;
                btnDoStarych.Enabled = false;
                btnPrevestDoAkitivnich.Enabled = false;
                btnDoOdeslanych.Enabled = false;
                btnKodeslani.Enabled = false;
                btnZamek1.Enabled = false;
            }

            if (this.HasPravoZapis(prava.Value.PripravarDavekAFilmuObjednavky))
            {
                btnDoOdeslanych.Enabled = true;
                btnKodeslani.Enabled = true;
            }
        }


        private void btnBarNovyDBS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProduktDetail frm = new frmProduktDetail();
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
        }

        private void gridControlTechDok_DoubleClick(object sender, EventArgs e)
        {

            if (this.SeznamMode == modeCiselnik.vyberCiselnik)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());
                produkt p = ((produkt)this.GetEntity(id));

                this.entityObject = p;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                detail();
            }

        }

        private void btnBarDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detail();
        }

        private void detail()
        {
            if (produktBindingSource.Current != null)
            {

                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());

                pcb_develEntities db = new pcb_develEntities();
                produkt p = db.produkts.Where(item => item.produkt_id == id).FirstOrDefault();

                if (p.sablona)
                {
                    frmSablonaDetail sablona = new frmSablonaDetail();
                    sablona.ShowDetail(this, p, db);
                    LoadData(sablona.entityObject);
                }
                else
                {
                    frmProduktDetail produkt = new frmProduktDetail();
                    produkt.ShowDetail(this, p, db);
                    LoadData(produkt.entityObject);
                }


            }
        }

        private void detail(produkt p, PCB.frmProduktDetail.ProduktAkce akce, pcb_develEntities db)
        {
            if (p.sablona)
            {
                frmSablonaDetail sablona = new frmSablonaDetail();
                sablona.FormMode = frmBaseDetail.mode.novy;
                sablona.TypAkce = akce;
                sablona.ShowDetail(this, p, db);

            }
            else
            {
                frmProduktDetail produkt = new frmProduktDetail();
                produkt.FormMode = frmBaseDetail.mode.novy;
                produkt.TypAkce = akce;
                produkt.ShowDetail(this, p, db);

            }


        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            filter = true;
            this.LoadData(null);

        }

        private void txtZakaznikHledej_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnVyhledat_Click(null, null);
            }
        }

        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            txtZakaznikHledej.Text = "";
            txtDPSHledej.Text = "";
            txtKod.Text = "";
            cbSablona.Checked = false;
            cmbStavProdukt.EditValue = null;
            dateEditNaposledyOd.EditValue = null;
            dateEditNaposledyDo.EditValue = null;

            filter = false;
            this.LoadData(null);
        }

        private void btnBarNovaSablona_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSablonaDetail frm = new frmSablonaDetail();
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
        }

        private void btnExportXLSx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnVyhledat.Focus();
            string soubor = Report.ProduktReport.Export((DataTable)produktBindingSource.DataSource);
            System.Diagnostics.Process.Start(soubor);
        }


        private void chkViditelne_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in ((DataTable)produktBindingSource.DataSource).Rows)
            {
                row["vybrano"] = ((CheckEdit)sender).Checked;
            }

            gridControlTechDok.RefreshDataSource();
        }

        private void btnPrevestDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            short stav = 0;

            List<int> produkt_stav_active = new List<int>() { (int)produkt_stav.Value.aktivni, (int)produkt_stav.Value.kOdeslani, (int)produkt_stav.Value.odeslane };

            switch (e.Item.Name)
            {
                case "btnKodeslani":
                    stav = (int)produkt_stav.Value.kOdeslani;
                    break;
                case "btnDoOdeslanych":
                    stav = (int)produkt_stav.Value.odeslane;
                    break;
                case "btnPrevestDoAkitivnich":
                    stav = (int)produkt_stav.Value.aktivni;
                    break;
                case "btnDoStarych":
                    stav = (int)produkt_stav.Value.neaktivni;
                    break;
            }


            List<produkt> produkts = new List<produkt>();
            foreach (DataRow row in ((DataTable)produktBindingSource.DataSource).Rows)
            {
                if (bool.Parse(row["vybrano"].ToString()))
                {
                    produkts.Add((produkt)this.GetEntity(Convert.ToInt32(row["id"])));
                }
            }

            if (produkts.Count == 0)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());
                produkts.Add(((produkt)this.GetEntity(id)));
            }

            if (produkt_stav_active.Contains(stav))
            {
                foreach (var p in produkts)
                {

                    if (this.DBContext.produkts.Where(w => w.sablona == p.sablona && w.zakaznik_id == p.zakaznik_id && w.nazev == p.nazev && w.produkt_id != p.produkt_id && produkt_stav_active.Contains(w.produkt_stav_id)).Any())
                    {
                        XtraMessageBox.Show(String.Format("Produkt \"{0}\" pro zákazníka \"{1}\", je již aktivní.", p.nazev, p.ZakaznikNazev), "Produkt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        p.produkt_stav_id = stav;
                    }
                }
            }
            else
            {
                if (produkts.Count > 0)
                {
                    string strSQL = "UPDATE produkt SET produkt_stav_id = {0} WHERE produkt_id IN ({1})";
                    DBHelper.SQLExecute(this.DBContext, string.Format(strSQL, stav, string.Join(",", produkts.Select(s => s.produkt_id))));
                }
            }

            this.DBContext.SaveChanges();
            this.LoadData(null);

        }

        private void btnPoznamkaZakaznika_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());
            produkt p = ((produkt)this.GetEntity(id));

            frmNapoveda.Set(p.zakaznik.GetPoznamkyTPV());
        }

        private void btnKopieDPS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (produktBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());

                pcb_develEntities db = new pcb_develEntities();
                produkt p = db.produkts.Where(item => item.produkt_id == id).FirstOrDefault();

                produkt produkt = p.CopyProdukt(false, false, false);


                detail(produkt, frmProduktDetail.ProduktAkce.kopie, db);

                this.LoadData(produkt);
            }
        }

        private void btnZmenaDPS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (produktBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());

                pcb_develEntities db = new pcb_develEntities();
                produkt p = db.produkts.Where(item => item.produkt_id == id).FirstOrDefault();

                p.produkt_stav_id = (int)produkt_stav.Value.neaktivni;
                //db.SaveChanges();

                produkt nova = p.CopyProdukt(true, true, true);
                nova.produkt_stav_id = (int)produkt_stav.Value.aktivni;
                // puvodni se prevede do historie

                detail(nova, frmProduktDetail.ProduktAkce.zmenaDPS, db);
                this.LoadData(nova);
            }
        }

        private void btnKontrola_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (produktBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());
                produkt p = ((produkt)this.GetEntity(id));

                frmKontrola frm = new frmKontrola();
                frm.ShowDetail(this, p);
            }
        }

        private void btnZamek1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (produktBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());
                produkt p = ((produkt)this.GetEntity(id));
                p.zamek = !(p.zamek ?? false);
                this.DBContext.SaveChanges();

                this.LoadData(p);
            }
        }

        private void btnZmenaIV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (produktBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)produktBindingSource.Current)["id"].ToString());
                pcb_develEntities db = new pcb_develEntities();
                produkt p = db.produkts.Where(item => item.produkt_id == id).FirstOrDefault();

                if (p.sablona)
                {
                    frmSablonaDetail sablona = new frmSablonaDetail();
                    sablona.TypAkce = PCB.frmProduktDetail.ProduktAkce.zmenaIV;
                    sablona.ShowDetail(this, p, db);
                    LoadData(sablona.entityObject);
                }
                else
                {
                    frmProduktDetail produkt = new frmProduktDetail();
                    produkt.TypAkce = PCB.frmProduktDetail.ProduktAkce.zmenaIV;
                    produkt.ShowDetail(this, p, db);
                    LoadData(produkt.entityObject);
                }
            }
        }

        private void btnPrenest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPuvodniSystem frm = new frmPuvodniSystem();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.LoadData(frm.Produkt);
            }
        }

        private void cmbStavProdukt_EditValueChanged(object sender, EventArgs e)
        {
            ApplyRight();
        }

 
        private void gridView5_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == gridColumn9)
            {
                this.gridView5.SetRowCellValue(e.RowHandle, e.Column, e.Value);
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }
    }

}

