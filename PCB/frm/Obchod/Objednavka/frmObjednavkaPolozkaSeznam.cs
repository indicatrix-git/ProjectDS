using Devart.Data.PostgreSql;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmObjednavkaPolozkaSeznam : frmBaseSeznam
    {
        bool filter = false;
        public frmObjednavkaPolozkaSeznam()
        {
            InitializeComponent();
        }

        public override EntityObject GetEntity(int id)
        {
            return this.DBContext.objednavka_polozkas.Where(item => item.objednavka_polozka_id == id).First();
        }



        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            var vyslData = DBContext.objednavka_polozkas;
            stavobjednavkaBindingSource.DataSource = this.DBContext.stav_objednavkas.OrderBy(i => i.stav_objednavka_id).ToList();

            if (!string.IsNullOrEmpty(this.ZakaznikNazev))
            {
                txtZakaznikHledej.Text = this.ZakaznikNazev;
            }

            if (!filter)
            {
                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarDataET")
                {
                    cbET.Checked = true;
                }

                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarItemDataObjVyroba")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("stav_objednavka_id", 0);
                }

                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarTPVObjednavkaPolozka")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("stav_objednavka_id", 0);
                }

                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarItemPripravarObjednavky")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("stav_objednavka_id", 0);
                }

                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarObjednavkaPolozky")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("stav_objednavka_id", 0);
                }
                if (this.Filtr != null && ((NavBarItem)this.Filtr).Name == "navBarItemTechnologieObjednavky")
                {
                    cmbStav.EditValue = cmbStav.Properties.GetDataSourceValue("stav_objednavka_id", 1);
                }
            }


            plosnyspojdruhBindingSource.DataSource = this.DBContext.plosny_spoj_druhs.ToList();
            uzivatelBindingSource.DataSource = this.DBContext.uzivatel_oddelenis.Where(i => i.oddeleni_id == (int)oddeleni.Value.tpv).Select(i => i.uzivatel);
            uzivatelBindingSource1.DataSource = this.DBContext.uzivatel_oddelenis.Where(i => i.oddeleni_id == (int)oddeleni.Value.tpv).Select(i => i.uzivatel);

            DateTime? dateOd = (dtTerminOd.EditValue != null ? (DateTime)dtTerminOd.EditValue : (DateTime?)null);
            DateTime? dateDo = (dtTerminOd.EditValue != null ? (DateTime)dtTerminOd.EditValue : (DateTime?)null);


            int typVyroby = cmbTypVyroby.EditValue == null ? 0 : (int)cmbTypVyroby.EditValue;
            int stav = cmbStav.EditValue == null ? 0 : (int)cmbStav.EditValue;
            int uzivatel = cbPrirazenFiltr.EditValue == null ? 0 : (int)cbPrirazenFiltr.EditValue;
            this.strSQL = @"
SELECT
 obj.objednavka_polozka_id AS id,
 obj.d_zadal,
 z.interni_nazev AS zakaznik,
 obj.termin_vyroby AS termin_vyroby,
 tt.nazev AS termin_typ,
 psd.nazev AS typ_vyroby,
 CASE 
 	when obj.produkt_id IS NOT NULL THEN p.nazev
 	else obj.nazev
 END AS nazev_dps,
 
 CASE 
 	WHEN obj.produkt_id IS NOT NULL THEN true
 	ELSE false
 END AS je_td,
 
 CAST (obj.pozadovano_pocet AS varchar) || '+' || CAST (coalesce(obj.tech_pridavek, 0) AS varchar) AS pocet,
 (
    SELECT max(d_tisk_pruvodka) FROM pruvodka pruv 
    JOIN objednavka_polozka obj ON obj.objednavka_polozka_id = pruv.objednavka_polozka_id
    WHERE obj.produkt_id = p.produkt_id) AS naposledy_ve_vyrobe,
 pozn_z_tpv AS pozn_tpv,

CASE 
 	WHEN obj.produkt_id IS NOT NULL THEN p.kod
 	ELSE pss.kod
 END AS typ_desky,
 obj.prirazeno_id,
CASE 
 	when obj.produkt_id IS NOT NULL AND p.zamek IS NOT NULL AND p.zamek = true THEN true
 	else false
 END AS zamek,
os.nazev AS objednavka_stav,
(select count(*) from pruvodka where objednavka_polozka_id = obj.objednavka_polozka_id) as pocet_pruvodek
 
FROM objednavka_polozka obj
LEFT JOIN zakaznik z ON z.zakaznik_id = obj.majitel_zakaznik_id
LEFT JOIN termin_typ tt ON tt.termin_typ_id = obj.termin_typ_id
LEFT JOIN plosny_spoj_druh psd ON psd.plosny_spoj_druh_id = obj.plosny_spoj_druh_id
LEFT JOIN plosny_spoj_specifikace pss ON pss.plosny_spoj_specifikace_id = obj.plosny_spoj_specifikace_id
LEFT JOIN stav_objednavka os ON os.stav_objednavka_id = obj.stav_objednavka_id
LEFT JOIN produkt p ON p.produkt_id = obj.produkt_id
WHERE 1=1";

            if (!String.IsNullOrEmpty(txtZakaznikHledej.Text))
            {
                strSQL += " AND upper(z.interni_nazev) like @interni_nazev";
                this.ParamSQL.Add(new PgSqlParameter("@interni_nazev", string.Format("%{0}%", txtZakaznikHledej.Text.ToUpper())));
            }

            if (!String.IsNullOrEmpty(txtDPSHledej.Text))
            {
                strSQL += " AND upper(CASE when obj.produkt_id IS NOT NULL THEN p.nazev ELSE obj.nazev END) LIKE @nazev_dps";
                this.ParamSQL.Add(new PgSqlParameter("@nazev_dps", string.Format("%{0}%", txtDPSHledej.Text.ToUpper())));
            }

            if (stav != 0)
            {
                strSQL += string.Format(" AND obj.stav_objednavka_id={0}", stav);
            }

            if (typVyroby != 0)
            {
                strSQL += string.Format(" AND obj.plosny_spoj_druh_id={0}", typVyroby);
            }

            if (uzivatel != 0)
            {
                strSQL += string.Format(" AND obj.prirazeno_id={0}", uzivatel);
            }

            if (dateOd.HasValue)
            {
                strSQL += string.Format(" AND obj.d_zadal>='{0}'", dateOd.Value.ToString("yyyy-MM-dd 00:00"));
            }

            if (dateDo.HasValue)
            {
                strSQL += string.Format(" AND obj.d_zadal<='{0}'", dateDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            }

            if (!String.IsNullOrEmpty(txtCisloObjednavky.Text))
            {
                strSQL += " AND upper(obj.cislo_objednavka) like @cislo_objednavka";
                this.ParamSQL.Add(new PgSqlParameter("@cislo_objednavka", string.Format("%{0}%", txtCisloObjednavky.Text)));
            }

            if (!String.IsNullOrEmpty(txtCisloPruvHledej.Text))
            {
                string strSQLPruv = @"
SELECT o.objednavka_polozka_id AS id
FROM pruvodka p
JOIN objednavka_polozka o ON o.objednavka_polozka_id = p.objednavka_polozka_id
WHERE p.cislo = @cislo";

                DataTable tableObjSeznam = DBHelper.SQLSelect(this.DBContext, strSQLPruv, new List<PgSqlParameter>() { new PgSqlParameter("@cislo", txtCisloPruvHledej.Text) });

                List<string> ls = new List<string>();
                foreach (DataRow row in tableObjSeznam.Rows)
                {
                    ls.Add(row["id"].ToString());
                }
                string param = string.Join(",", ls.ToArray());

                if (!String.IsNullOrEmpty(param))
                {
                    strSQL += string.Format(" AND objednavka_polozka_id IN ({0})", param);
                }
                else
                {
                    strSQL += string.Format(" AND objednavka_polozka_id = -1", param);
                }
            }

            if (cbJenSablony.Checked)
            {
                strSQL += string.Format(" AND (p IS NOT NULL AND p.sablona = TRUE)");
            }



            //pojdeme do Produkt, zistime ci je checked Pozadavek pro...a zaroven odskrtnute AOI, tak ak bude cbAOE.checked, tak ich vypise

            if (cbAOE.Checked)
            {
                strSQL += string.Format(" AND (p.pozadovan_opticky_test_sn = TRUE AND p.aoi_datum IS NULL)");
            }

            if (cbET.Checked)
            {
                strSQL += string.Format(" AND (p.et_datum IS NULL AND p.kod LIKE '%T%')");
            }

            strSQL += " ORDER BY d_zadal, zakaznik, termin_vyroby";

            ObjednavkaPolozkaBindingSource.DataSource = this.GetData();

            if (entity != null)
            {
                int pozice = ObjednavkaPolozkaBindingSource.Find("id", ((objednavka_polozka)entity).objednavka_polozka_id);
                ((ColumnView)gridControlObjPoloz.MainView).FocusedRowHandle = 0;
                ((ColumnView)gridControlObjPoloz.MainView).FocusedRowHandle = ((ColumnView)gridControlObjPoloz.MainView).GetRowHandle(pozice);
            }

            gridView5.BestFitColumns();
        }

        public override void ApplyRight()
        {
            base.ApplyRight();

            if (!this.HasPravoZapis(prava.Value.ObchodObjednavky))
            {
                btnBarNovy.Enabled = false;
                btnBarOdstranit.Enabled = false;
                btnKopieDPS.Enabled = false;
                btnKopirovat.Enabled = false;
                btnObnovit.Enabled = false;
                btnPozastavit.Enabled = false;
                btnStorno.Enabled = false;
                btnTisk.Enabled = false;
            }

            if (this.HasPravoZapis(prava.Value.PripravarDavekAFilmuObjednavky))
            {
                btnTisk.Enabled = true;
            }
        }

        private void btnBarNovy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmObjednavkaPolozkaDetail polozka = new frmObjednavkaPolozkaDetail();
            if (polozka.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(polozka.entityObject);
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

        private void gridControlObjPoloz_DoubleClick(object sender, EventArgs e)
        {
            if (this.SeznamMode == modeCiselnik.vyberCiselnik)
            {
                this.entityObject = (objednavka_polozka)ObjednavkaPolozkaBindingSource.Current;
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
            if (this.ObjednavkaPolozkaBindingSource.Current != null)
            {
                frmObjednavkaPolozkaDetail polozka = new frmObjednavkaPolozkaDetail();

                int id = int.Parse(((DataRowView)this.ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                if (polozka.ShowDetail(this, this.GetEntity(id)) == System.Windows.Forms.DialogResult.OK)
                {
                    this.LoadData(polozka.entityObject);
                }
                else
                {
                    this.LoadData(null);
                }
            }
        }

        private void btnBarVyhledat_ItemClick(object sender, EventArgs e)
        {
            filter = true;
            this.LoadData(null);

        }

        private void btnBarZrusFiltr_ItemClick(object sender, EventArgs e)
        {
            txtDPSHledej.Text = "";
            txtZakaznikHledej.Text = "";
            dtTerminOd.EditValue = null;
            txtCisloPruvHledej.Text = "";
            txtCisloObjednavky.Text = "";
            cmbStav.EditValue = null;
            cmbTypVyroby.EditValue = null;

            filtrPrijato.ClearFilter();
            filtrZakaznik.ClearFilter();
            filtrTermin.ClearFilter();
            filtrPlosnySpoj.ClearFilter();
            filtrKs.ClearFilter();
            filtrExpedice.ClearFilter();
            filtrTPV.ClearFilter();
            //filtrObjednavka.ClearFilter();
            cbPrirazenFiltr.EditValue = null;
            cbAOE.Checked = false;
            cbET.Checked = false;
            cbJenSablony.Checked = false;

            filter = false;

            this.LoadData(null);

        }

        private void btnBarOdstranit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Position != -1)
            {
                if (MessageBox.Show(string.Format("Chcete opravdu smazat položku \"{0}\" ?", ((objednavka_polozka)ObjednavkaPolozkaBindingSource.Current).nazev), "Smazat?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DBContext.DeleteObject((objednavka_polozka)ObjednavkaPolozkaBindingSource.Current);
                    DBContext.SaveChanges();

                    this.LoadData(null);

                }
            }
        }

        private void cbPrirazeno_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void cbPrirazeno_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
            objednavka_polozka obj = (objednavka_polozka)this.GetEntity(id);
            obj.prirazeno_id = (int)e.NewValue;
            obj.d_prirazeno = PCB.Data.DBHelper.DateTimeNow();
            this.DBContext.SaveChanges();
        }

        private void btnKopirovat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                objednavka_polozka objNew = ((objednavka_polozka)this.GetEntity(id)).Copy();
                frmObjednavkaPolozkaDetail polozka = new frmObjednavkaPolozkaDetail();
                polozka.FormMode = frmBaseDetail.mode.novy;
                if (polozka.ShowDetail(this, objNew) == System.Windows.Forms.DialogResult.OK)
                {
                    this.LoadData(polozka.entityObject);
                }
                else
                {
                    this.LoadData(null);
                }


            }
        }

        private void btnStorno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                objednavka_polozka obj = ((objednavka_polozka)this.GetEntity(id));
                obj.stav_objednavka_id = (int)stav_objednavka.Value.stornovano;
                this.DBContext.SaveChanges();
                this.LoadData(obj);
                MessageBox.Show("Objednávka stornována", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPozastavit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                objednavka_polozka obj = ((objednavka_polozka)this.GetEntity(id));
                obj.stav_objednavka_id = (int)stav_objednavka.Value.pozastaveno;
                this.DBContext.SaveChanges();
                this.LoadData(obj);
                MessageBox.Show("Objednávka pozastavena", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                objednavka_polozka obj = ((objednavka_polozka)this.GetEntity(id));
                obj.stav_objednavka_id = (int)stav_objednavka.Value.SpustenaDoVyroby;
                this.DBContext.SaveChanges();
                this.LoadData(obj);
                MessageBox.Show("Objednávka obnovena", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                frmNapoveda.Set(((objednavka_polozka)this.GetEntity(id)).zakaznik.GetPoznamkyTPV());
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current == null)
            {
                return;
            }

            int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
            objednavka_polozka obj = ((objednavka_polozka)this.GetEntity(id));

            if (obj != null && obj.produkt != null)
            {

                if (obj.produkt.sablona)
                {
                    frmSablonaDetail sablona = new frmSablonaDetail();
                    sablona.ShowDetail(this, obj.produkt);
                }
                else
                {
                    frmProduktDetail produkt = new frmProduktDetail();
                    produkt.ShowDetail(this, obj.produkt);
                }
            }
            else
            {
                frmNapoveda.Set("Není zvolen produkt (Technická dokumentace)");
            }
        }

        private void btnTisk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                objednavka_polozka obj = ((objednavka_polozka)this.GetEntity(id));

                if (obj.produkt != null || (obj.plosny_spoj_druh_id == (int)plosny_spoj_druh.Value.Kooperace))
                {
                    frmPruvodkaDavka frmDavka = new frmPruvodkaDavka();
                    frmDavka.ShowDetail(this, obj);
                }
                else
                {
                    MessageBox.Show("Tisk průvodky je umožněn pouze u té, která má zvolen produkt.");
                }

                this.LoadData(null);
            }
        }

        private void gridView5_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {

                GridView View = sender as GridView;

                bool zamek = (bool)View.GetRowCellValue(e.RowHandle, "zamek");
                if (zamek == false)
                {
                    // e.Appearance.ForeColor = Color.Red;
                }

            }
        }

        private void btnPruvodky_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPruvodkaSeznam frm = new frmPruvodkaSeznam();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDokoncit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ObjednavkaPolozkaBindingSource.Current != null)
            {
                if (MessageBox.Show("Opravdu chcete objednávku dokončit?", "Objednávka", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int id = int.Parse(((DataRowView)ObjednavkaPolozkaBindingSource.Current)["id"].ToString());
                    objednavka_polozka obj = ((objednavka_polozka)this.GetEntity(id));
                    obj.stav_objednavka_id = (int)stav_objednavka.Value.dokonceno;
                    this.DBContext.SaveChanges();
                    this.LoadData(obj);
                    MessageBox.Show("Objednávka dokončena", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnObnovitSeznam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }
    }
}
