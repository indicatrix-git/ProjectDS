using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using pcb_develModel;
using System.Reflection;

namespace PCB.Report
{
    public partial class reportFaktura : DevExpress.XtraReports.UI.XtraReport
    {
        public reportFaktura()
        {
            InitializeComponent();
        }

        public void SetDataSourceEntity(faktura data)
        {
            data.faktura_polozkas.ToList().OrderBy(item => item.faktura_polozka_id);
            bsFaktura.DataSource = data;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            // informace o platbach
            faktura f = (faktura)bsFaktura.Current;
            if (!f.zahranicni ?? false)
            {
                lblSwift.Visible = false;
                lblIBAN.Visible = false;
            }
            else
            {
                lblPolozkaCelkemBezDPH.Text = "Celkem";

                xrLabelKB.Visible = false;
                xrLabelKBCislo.Visible = false;
                xrLabelCSOB.Visible = false;
                xrLabelCSOBCislo.Visible = false;

                lblDPH.Visible = false;
                lblZaokrouhleni.Visible = false;
                lblBezDPH.Visible = false;
                txtDPH.Visible = false;
                txtZaokrouhleni.Visible = false;
                txtCelkemBezDPH.Visible = false;
            }       
        }

        private void xrRazitko_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //ToDo - z uživatele vzít název razítka

            string s = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\img\\" + ((faktura)bsFaktura.Current).uzivatel.podpis + ".png";
            xrRazitko.ImageUrl = s;
        }

       
    }
}
