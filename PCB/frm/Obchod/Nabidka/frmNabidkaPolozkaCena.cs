using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using PCB.Base;
using PCB.Data.CustomObjects;
using PCB.Report;
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
    public partial class frmNabidkaPolozkaCena : frmBaseDetail
    {

        Dictionary<string, decimal> value = new Dictionary<string, decimal>();
        List<string> ls = new List<string>() { "01", "02", "04", "03", "05", "06" };
        DataTable data = new DataTable();

        int terminTypId = 0;
        int davka = 0;

        public frmNabidkaPolozkaCena()
        {
            InitializeComponent();
            this.PravaIgnore = true;
        }

        private void btnCena_Click(object sender, EventArgs e)
        {

            // spocita cenu
            foreach (Control c in groupBox1.Controls)
            {
                foreach (string pocet in ls)
                {
                    int davka = GetPocet(pocet);
                    if (c is TextEdit)
                    {
                        string tag = ((TextEdit)c).Tag.ToString();

                        //decimal hodnota = 0;
                        //if (value.TryGetValue(tag, out hodnota))
                        if (tag.Contains("_") && tag.Split('_')[1] == pocet )
                        {
                            {
                                c.Text = ZakladniCena(int.Parse(tag.Split('_')[0]), davka, (nabidka_polozka)this.entityObject ).ToString();
                            }
                        }
                    }
                }
            }

            // přečte hodnoty
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextEdit)
                {
                    string tag = ((TextEdit)c).Tag.ToString();
                    if (tag.Contains('_'))
                    {
                        if (c.Text != null && c.Text != "")
                        {
                            value[tag] = decimal.Parse(c.Text);
                        }
                    }
                }
            }

            
            


        }

        private void GetData()
        {
            // sestavy datatable pro report
            data = new DataTable();
            data.Columns.Add("Dávka (ks):");
            for (int i = 0; i < 6; i++)
            {
                int k = GetPocet((i + 1).ToString().PadLeft(2, '0'));
                DataColumn column = new DataColumn(i.ToString());
                column.Caption = k.ToString();

                data.Columns.Add(column);

            }


            for (int i = 0; i < 3; i++)
            {
                DataRow row = data.NewRow();
                data.Rows.Add(row);
            }
            data.Rows[0][0] = "Standartní termín - cena (Kč/ks):";
            data.Rows[1][0] = "Poloexpres - cena (Kč/ks):";
            data.Rows[2][0] = "Expres - cena (Kč/ks):";

            foreach (string key in value.Keys)
            {
                if (key.Length != 2)
                {
                    int x = int.Parse(key.Substring(0, 2));
                    int y = int.Parse(key.Substring(3, 2));
                    data.Rows[x - 1][y] = value[key];
                }
            }


        }



        private int GetPocet(string pocet)
        {

            foreach (Control c in groupBox1.Controls)
            {

                if (c is TextEdit)
                {
                    string tag = ((TextEdit)c).Tag.ToString();

                    if (tag == pocet)
                    {
                        int vysl = 0;

                        int.TryParse(((TextEdit)c).Text, out vysl);

                        return vysl;
                        
                    }
                }
            }

            return 0;

        }


        private decimal? ZakladniCena(int terminTyp, int pocetKs, nabidka_polozka n)
        {
            if (pocetKs == 0)
            {
                return null;
            }

            CenikContext paramCenik = new CenikContext();
            paramCenik.plosnySpojSpecifikace = n.plosny_spoj_specifikace;
            paramCenik.kostrukcniTrida = n.konstrukcni_trida ?? 0;
            paramCenik.Cenik = n.cenik;
            paramCenik.lsVrstva = n.vrstvas.ToList();
            paramCenik.nazevDPS = n.nazev_dps;
            paramCenik.rozmerX = (n.rozmer_dps_x ?? 0);
            paramCenik.rozmerY = (n.rozmer_dps_y ?? 0);
            paramCenik.rozmerPanelX = (n.rozmer_panel_x ?? 0);
            paramCenik.rozmerPanelY = (n.rozmer_panel_y ?? 0);
            paramCenik.termin = this.DBContext.termin_typs.Where(i => i.termin_typ_id == terminTyp).First();
            paramCenik.zakaznik = n.zakaznik;
            paramCenik.pocetKs = pocetKs;
            paramCenik.lsCenikRadka = n.GetCenikPolozky(this.DBContext);

            Cenik c = new Cenik();
            List<CenikRadka> ls = c.SestavCena(paramCenik);
            return Math.Round(c.ZakladniCena,2);

        }

        private void btnTisk_Click(object sender, EventArgs e)
        {

            GetData();

            ((nabidka_polozka)this.entityObject).CenovaTabulka = data;
            reportNabidkaHlavicka nabidka = new reportNabidkaHlavicka();
            nabidka.SetDataSource(this.entityObject);
            nabidka.CreateDocument();
            
            reportNabidkaPodrobnosti nabidkaPodrobnosti = new reportNabidkaPodrobnosti();
            nabidkaPodrobnosti.SetDataSource(this.entityObject);
            nabidkaPodrobnosti.CreateDocument();

            nabidka.Pages.AddRange(nabidkaPodrobnosti.Pages);
                        
            // vytiskne
            ReportPrintTool pt = new ReportPrintTool(nabidka);
            pt.ShowPreview();

        }

        private void btnDetailCena_Click(object sender, EventArgs e)
        {
            if (davka == 0)
            {
                MessageBox.Show("Nelze sestavit cenu na nulovou dávku");
                return;
            }

            

            nabidka_polozka n = (nabidka_polozka)this.entityObject;

            CenikContext paramCenik = new CenikContext();
            paramCenik.plosnySpojSpecifikace = n.plosny_spoj_specifikace;
            paramCenik.kostrukcniTrida = n.konstrukcni_trida ?? 0;
            paramCenik.Cenik = n.cenik;
            paramCenik.lsVrstva = n.vrstvas.ToList();
            paramCenik.nazevDPS = n.nazev_dps;
            paramCenik.rozmerX = (n.rozmer_dps_x ?? 0);
            paramCenik.rozmerY = (n.rozmer_dps_y ?? 0);
            paramCenik.rozmerPanelX = (n.rozmer_panel_x ?? 0);
            paramCenik.rozmerPanelY = (n.rozmer_panel_y ?? 0);
            paramCenik.termin = this.DBContext.termin_typs.Where(i => i.termin_typ_id == terminTypId).First();
            paramCenik.zakaznik = n.zakaznik;
            paramCenik.pocetKs = davka;
            paramCenik.lsCenikRadka = n.GetCenikPolozky(this.DBContext);

            Cenik c = new Cenik();

            string hlaska = c.KontrolaMaterialu(n.vrstvas.ToList(), n.cenik);
            if (hlaska != "")
            {
                frmNapoveda.Set(hlaska);
            }

            List<CenikRadka> ls = c.SestavCena(paramCenik);

            string soubor = CenikReport.Print(ls);
            System.Diagnostics.Process.Start(soubor);
        }

        private void txt01_Enter(object sender, EventArgs e)
        {
            terminTypId = int.Parse(((TextEdit)sender).Tag.ToString().Split('_')[0]);
            davka = GetPocet(((TextEdit)sender).Tag.ToString().Split('_')[1]);
            
        }

        private void txt01_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            decimal hodnota = 0;
            decimal.TryParse(e.NewValue.ToString().Replace(".",","), out hodnota);

            value[((TextEdit)sender).Tag.ToString()] = hodnota;
        }

        private void teFilmovePodklady_EditValueChanged(object sender, EventArgs e)
        {
            if (((nabidka_polozka)this.entityObject).CenaFilmovePredlohy != this.teFilmovePodklady.Text)
            {
                ((nabidka_polozka)this.entityObject).CenaFilmovePredlohy = this.teFilmovePodklady.Text;
                this.teFilmovePodklady.EditValue = ((nabidka_polozka)this.entityObject).CenaFilmovePredlohy;
            }
        }

        private void tePripravaFrezovani_EditValueChanged(object sender, EventArgs e)
        {
            if (((nabidka_polozka)this.entityObject).CenaPripravaFrezovani != this.tePripravaFrezovani.Text)
            {
                ((nabidka_polozka)this.entityObject).CenaPripravaFrezovani = this.tePripravaFrezovani.Text;
                this.tePripravaFrezovani.EditValue = ((nabidka_polozka)this.entityObject).CenaPripravaFrezovani;
            }
        }

        private void tePripravaSitaProTisk_EditValueChanged(object sender, EventArgs e)
        {
            if (((nabidka_polozka)this.entityObject).CenaPripravaSitoTisku != this.tePripravaSitaProTisk.Text)
            {
                ((nabidka_polozka)this.entityObject).CenaPripravaSitoTisku = this.tePripravaSitaProTisk.Text;
                this.tePripravaSitaProTisk.EditValue = ((nabidka_polozka)this.entityObject).CenaPripravaSitoTisku;
            }
        }
    }
}
