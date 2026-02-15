using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.Entity.Core.Objects.DataClasses;
using pcb_develModel;
using DevExpress.Office.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PCB.Report
{
    public partial class reportPruvodkaOperace : DevExpress.XtraReports.UI.XtraReport
    {
        
        public void SetDataSource(EntityObject eo)
        {
            bindingSource1.DataSource = eo;
        }


        public reportPruvodkaOperace()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pruvodka p = (pruvodka)bindingSource1.Current;
            //produkt pp = ((produkt)bindingSource1.Current);


            lblKopie.Visible = ((pruvodka)bindingSource1.Current).Kopie;
            
            string vystup = "";

            if (p.produkt_nestandartni_technologie ?? false)
            {
                vystup = "(Nestandartní technologie)";
            }

            if (p.produkt_specialni_postup ?? false)
            {
                vystup = "(Speciální postup)";
            }

            if ((p.produkt_nestandartni_technologie ?? false) && (p.produkt_specialni_postup ?? false))
            {
                vystup = "(Nestandartní technologie / Speciální postup)";
            }

            txtNadpis.Text += " " +  vystup;
            xrLabelArchivace.Text = ((p.produkt_archivace ?? false) ? "ANO" : "NE");

            xrLabelRevize.Text = p.produkt_revize_count + " - " + (p.produkt_revize_datum.HasValue ? p.produkt_revize_datum.Value.ToString("dd.MM.yyyy") : "") + "                        " + (((pruvodka)bindingSource1.Current).objednavka_polozka.plosny_spoj_druh != null ?((pruvodka)bindingSource1.Current).objednavka_polozka.plosny_spoj_druh.nazev : "");
        }

        private void xrLabel32_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
                if (e.PageIndex >= 2)
                {
                    e.Cancel = false;
                }
        }
    }
}
