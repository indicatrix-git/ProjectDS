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
    public partial class frmPruvodkaFrontaSeznam : frmBaseSeznam
    {
        public frmPruvodkaFrontaSeznam()
        {
            InitializeComponent();
        }

        public override void ApplyRight()
        {
            base.ApplyRight();
            if (this.HasPravoZapis(prava.Value.PripravarDavekAFilmuObjednavky))
            {
                btnTisk.Enabled = true;
            }
            
        }

        public override EntityObject GetEntity(int id)
        {
            return this.DBContext.pruvodkas.Where(item => item.pruvodka_id == id).First();
        }


        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);


            this.strSQL = @"
SELECT  
        pruv.pruvodka_id AS id,
        z.interni_nazev AS zakaznik,
		CAST (pruv.pocet_kusu AS varchar) || '+' || pruv.pocet_panelu AS pocet_kusu,
		p.nazev AS nazev_dps,
        obj.cislo_objednavka, 
		pruv.cislo AS cislo_pruvodka,
		obj.termin_vyroby AS termin_vyroby,
		tt.nazev AS termin_typ,
		ps.nazev AS pruvodka_stav,
		pruv.hotovo_procento AS hotovo,
        p.hruby_panel_suma AS nasobnost
FROM pruvodka pruv
JOIN objednavka_polozka AS obj ON obj.objednavka_polozka_id = pruv.objednavka_polozka_id
JOIN produkt AS p ON p.produkt_id = obj.produkt_id
JOIN termin_typ AS tt ON obj.termin_typ_id = tt.termin_typ_id
JOIN zakaznik AS z ON obj.majitel_zakaznik_id = z.zakaznik_id
JOIN pruvodka_stav AS ps ON ps.pruvodka_stav_id = pruv.pruvodka_stav_id
WHERE 1=1 AND pruv.pruvodka_stav_id = 4 ORDER BY pruv.cislo  /* prioravena pro tisk */";
           
            pruvodkaBindingSource.DataSource = this.GetData();
        }

        private void barButtonItemDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                frmPruvodkaFrontaDetail frm = new frmPruvodkaFrontaDetail();
                frm.ShowDetail(this, pruvodka);
                this.LoadData(frm.entityObject);
            }
        }

        private void gridControlFrmPruvodka_DoubleClick(object sender, EventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                frmPruvodkaFrontaDetail frm = new frmPruvodkaFrontaDetail();
                frm.ShowDetail(this, pruvodka);
                this.LoadData(frm.entityObject);
            }
        }


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);

                double soucet = pruvodka.pocet_kusu  + pruvodka.pocet_panelu;
                double deleno = double.Parse((pruvodka.objednavka_polozka.produkt.hruby_panel_suma ?? 0).ToString());

                double zbytek = soucet % deleno;

                if (zbytek > 0)
                {
                        MessageBox.Show("Nevychází násobnost. Zkontrolujte prosím počty kusů.");
                        return;
                }
                
                pruvodka.pruvodka_stav_id = (int)pruvodka_stav.Value.spustena;

                reportPruvodkaHlavicka pruv = new reportPruvodkaHlavicka();
                pruv.SetDataSource(pruvodka);
                pruv.CreateDocument();

                reportPruvodkaOperace report = new reportPruvodkaOperace();
                pruvodka pru = pruvodka;
                //pru.objednavka_polozka.produkt.LoadSeznamOperaci();
                report.SetDataSource(pru);
                report.CreateDocument();

                pruv.Pages.AddRange(report.Pages);
                pruv.Print();

                this.DBContext.SaveChanges();
                this.LoadData(null);
            }
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }

        private void btnSmazatPruvodku_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pruvodkaBindingSource.Current != null)
            {
                int id = int.Parse(((DataRowView)this.pruvodkaBindingSource.Current)["id"].ToString());
                pruvodka pruvodka = (pruvodka)this.GetEntity(id);
                objednavka_polozka obj = pruvodka.objednavka_polozka;
                try
                {
                    this.DBContext.DeleteObject(pruvodka);
                    this.DBContext.SaveChanges();

                    if (obj.pruvodkas.Count() == 0)
                    {
                        obj.stav_objednavka_id = (int)stav_objednavka.Value.ZalozenaPredanoDoTPV;
                        this.DBContext.SaveChanges();
                    }
                    
                }
                catch
                {

                    MessageBox.Show("Nelze smazat!");
                }

                this.LoadData(null);
            }
            
        }

        
    }
}
