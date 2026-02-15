using Devart.Data.PostgreSql;
using DevExpress.XtraReports.UI;
using PCB.Base;
using PCB.Data;
using PCB.Report;
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
    public partial class frmPruvodkaSeznam : frmBaseSeznam
    {
        public frmPruvodkaSeznam()
        {
            InitializeComponent();
        }

        public override void ApplyRight()
        {
            base.ApplyRight();

            if (!this.HasPravoZapis(prava.Value.VyrobaPruvodky))
            {
                btnNeshody.Enabled = false;
            }
        }

        public override EntityObject GetEntity(int id)
        {
            return this.DBContext.pruvodkas.Where(item => item.pruvodka_id == id).First();
        }

        
        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);

            int filtr = 0;
            Int32.TryParse(txtCisloPruvodky.Text, out filtr);
            DateTime? dateOd = (dtTerminOd.EditValue != null ? (DateTime)dtTerminOd.EditValue : (DateTime?)null);
            DateTime? dateDo = (dtTerminDo.EditValue != null ? (DateTime)dtTerminDo.EditValue : (DateTime?)null);


            this.strSQL = @"
SELECT  
        pruv.pruvodka_id AS id,
        z.interni_nazev AS zakaznik,
		CAST (pruv.pocet_kusu AS varchar) || '+' || pruv.pocet_panelu AS pocet_kusu,
		CASE 
 	when obj.produkt_id IS NOT NULL THEN p.nazev
 	else obj.nazev
 END AS nazev_dps,
        obj.cislo_objednavka, 
		pruv.cislo AS cislo_pruvodka,
		obj.termin_vyroby AS termin_vyroby,
		tt.nazev AS termin_typ,
		ps.nazev AS pruvodka_stav,
		pruv.hotovo_procento AS hotovo
FROM pruvodka pruv
JOIN objednavka_polozka AS obj ON obj.objednavka_polozka_id = pruv.objednavka_polozka_id
LEFT JOIN produkt AS p ON p.produkt_id = obj.produkt_id
JOIN termin_typ AS tt ON obj.termin_typ_id = tt.termin_typ_id
JOIN zakaznik AS z ON obj.majitel_zakaznik_id = z.zakaznik_id
JOIN pruvodka_stav AS ps ON ps.pruvodka_stav_id = pruv.pruvodka_stav_id
WHERE 1=1";

            if (!String.IsNullOrEmpty(txtZakaznikHledej.Text))
            {
                strSQL += " AND upper(z.interni_nazev) like @interni_nazev";
                this.ParamSQL.Add(new PgSqlParameter("@interni_nazev", string.Format("%{0}%", txtZakaznikHledej.Text.ToUpper())));
            }
            if (dateOd.HasValue)
            {
                strSQL += string.Format(" AND obj.termin_vyroby>='{0}'", dateOd.Value.ToString("yyyy-MM-dd 00:00"));
            }
            if (dateDo.HasValue)
            {
                strSQL += string.Format(" AND obj.termin_vyroby<='{0}'", dateDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            }
            if (!String.IsNullOrEmpty(txtCisloPruvodky.Text))
            {
                strSQL += " AND upper(pruv.cislo) = @pruvodka_cislo";
                this.ParamSQL.Add(new PgSqlParameter("@pruvodka_cislo", txtCisloPruvodky.Text));
            }
            if (!String.IsNullOrEmpty(txtCisloObjednavky.Text))
            {
                strSQL += " AND upper(obj.cislo_objednavka) like @cislo_objednavka";
                this.ParamSQL.Add(new PgSqlParameter("@cislo_objednavka", string.Format("%{0}%", txtCisloObjednavky.Text.ToUpper())));
            }

            if (cbExpres.Checked)
            {
                strSQL += string.Format(" AND (obj.termin_typ_id = {0} OR obj.termin_typ_id={1})", (int)termin_typ.Value.express, (int)termin_typ.Value.poloexpres);
            }

            if (rgTypVyroby.EditValue != null && rgTypVyroby.EditValue.ToString() == "1")
            {
                strSQL += string.Format(" AND (obj.plosny_spoj_druh_id = {0})", (int)plosny_spoj_druh.Value.Kooperace);
            }

            if (rgTypVyroby.EditValue != null && rgTypVyroby.EditValue.ToString() == "2")
            {
                strSQL += string.Format(" AND (obj.plosny_spoj_druh_id = {0})", (int)plosny_spoj_druh.Value.NahradaNeshod);
            }

            if (cbNestandartniTechnologie.Checked)
            {
                strSQL += string.Format(" AND p.nestandartni_technologie = true");
            }

            if (cbSpecialniPostup.Checked)
            {
                strSQL += string.Format(" AND p.specialni_postup = true");
            }
            
            if (cbSablona.Checked)
            {
                strSQL += string.Format(" AND p.sablona = true");
            }

            if (rgStavVyroby.EditValue != null && rgStavVyroby.EditValue.ToString() == "1")
            {
                strSQL += string.Format(" AND pruv.pruvodka_stav_id = {0}", (int)pruvodka_stav.Value.spustena);
            }

            if (rgStavVyroby.EditValue != null && rgStavVyroby.EditValue.ToString() == "2")
            {
                strSQL += string.Format(" AND pruv.pruvodka_stav_id = {0}", (int)pruvodka_stav.Value.pozastavena);
            }

            if (rgStavVyroby.EditValue != null && rgStavVyroby.EditValue.ToString() == "3")
            {
                strSQL += string.Format(" AND pruv.pruvodka_stav_id = {0}", (int)pruvodka_stav.Value.dokoncena);
            }

            pruvodkaBindingSource.DataSource = GetData();

        }

        private void barButtonItemDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                frmPruvodkaDetail frm = new frmPruvodkaDetail();
                frm.ShowDetail(this, pruvodka);
            }
        }

        private void gridControlFrmPruvodka_DoubleClick(object sender, EventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                if (this.SeznamMode != modeCiselnik.vyberCiselnik)
                {
                    int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                    pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                    frmPruvodkaDetail frm = new frmPruvodkaDetail();
                    frm.ShowDetail(this, pruvodka);
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                    pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                    this.entityObject = pruvodka;

                }
            }
        }

        private void neshody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                frmNeshodySeznam frm = new frmNeshodySeznam();
                frm.entityObject = pruvodka;
                frm.ShowForm(this);
            }
        }

        
        private void btnNeshody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                frmNeshodySeznam frm = new frmNeshodySeznam();
                frm.entityObject = pruvodka;
                frm.ShowForm(this);
            }
        }
                
        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            txtDPSHledej.Text = "";
            txtZakaznikHledej.Text = "";
            txtCisloPruvodky.Text = "";
            txtCisloObjednavky.Text = "";
            dtTerminOd.EditValue = null;
            dtTerminDo.EditValue = null;
            rgStavVyroby.EditValue = 0;
            rgTypVyroby.EditValue = 0;
            cbExpres.Checked = false;
            cbSablona.Checked = false;
            cbNestandartniTechnologie.Checked = false;
            cbSpecialniPostup.Checked = false;
            columnZakaznik.ClearFilter();
            columnDPS.ClearFilter();
            columnObjednavka.ClearFilter();
            columnPruvodka.ClearFilter();
            columnKusu.ClearFilter();
            columnTermin.ClearFilter();
            columnExpedice.ClearFilter();
            columnStav.ClearFilter();
            columnHotovo.ClearFilter();


            this.LoadData(null);
        }

        private void btnPrintCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pruvodkaBindingSource.Current != null)
            {

                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                if (pruvodka.objednavka_polozka.plosny_spoj_druh_id == (int)plosny_spoj_druh.Value.Kooperace)
                {
                    MessageBox.Show("Průvodka s kooperací nelze vytisknout.");
                    return;
                }

                reportPruvodkaHlavicka pruv = new reportPruvodkaHlavicka();
                pruv.SetDataSource(pruvodka);
                pruv.CreateDocument();

                reportPruvodkaOperace report = new reportPruvodkaOperace();
                pruvodka pru = pruvodka;
                //pru.objednavka_polozka.produkt.LoadSeznamOperaci();
                pru.Kopie = true;
                report.SetDataSource(pru);
                report.CreateDocument();

                pruv.Pages.AddRange(report.Pages);
                pruv.ShowPreview();

            }
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pruvodkaBindingSource.Current != null)
            {

                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);
                pruvodka.pruvodka_stav_id = 1;

                reportPruvodkaHlavicka pruv = new reportPruvodkaHlavicka();
                pruv.SetDataSource(pruvodka);
                pruv.CreateDocument();

                reportPruvodkaOperace report = new reportPruvodkaOperace();
                pruvodka pru = pruvodka;
                //pru.objednavka_polozka.produkt.LoadSeznamOperaci();
                pru.Kopie = true;
                report.SetDataSource(pru);
                report.CreateDocument();

                pruv.Pages.AddRange(report.Pages);
                pruv.ShowPreview();
                this.DBContext.SaveChanges();

            }
        }


        private void btnObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }

        private void btnOpravy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                frmOpravySeznam frm = new frmOpravySeznam();
                frm.entityObject = pruvodka;
                frm.ShowForm(this);
            }

            
        }
    }
}
