using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.Entity.Core.Objects.DataClasses;
using pcb_develModel;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraRichEdit.API.Native;
using System.Collections.Generic;
using PCB.Data;

namespace PCB.Report
{
    public partial class reportPruvodkaHlavicka : DevExpress.XtraReports.UI.XtraReport
    {
        public reportPruvodkaHlavicka()
        {
            InitializeComponent();
        }

        public void SetDataSource(EntityObject eo)
        {
            bsPruvodka.DataSource = eo;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void InsertCell(XRTableRow row, string text)
        {
            InsertCell(row, text, 0);
        }

        private void InsertCell(XRTableRow row, string text, float sirka)
        {
            XRTableCell cell = new XRTableCell();
            cell.Text = text;
            cell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            cell.StylePriority.UsePadding = false;

            if (sirka > 0)
            {
                cell.WidthF = sirka;
            }
            row.Cells.Add(cell);

        }

        private void Pruvodka_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pruvodka p = (pruvodka)bsPruvodka.Current;


            if (p.Kopie)
            {
                lblKopie.Visible = true;
            }
            else
            {
                lblKopie.Visible = false;
            }


            lblSkladbaDesky.Text = "Skladba desky";

            if (p.produkt_dodrzet_typ_materialu ?? false)
            {
                lblSkladbaDesky.Text += " (dodržet typ materiálu)";
            }


            if (p.produkt_nestandartni_technologie ?? false)
            {
                lblNT.Text = "NT";
            }
            else
            {
                lblNT.Text = "";
            }

            if (p.produkt_specialni_postup ?? false)
            {
                lblSP.Text = "SP";
            }
            else
            {
                lblSP.Text = "";
            }
            if ((p.produkt_ul ?? 0) > 0)
            {
                lblUL.Text = "UL";
            }
            else
            {
                lblUL.Text = "";
            }

            int i = 0;

            List<string> lsTermin = new List<string>();
            lsTermin.Add("Standart");
            lsTermin.Add("Poloexpres");
            lsTermin.Add("Expres");
            lsTermin.Add("Náhrada");
            lsTermin.Add("Tech.zkouška");
            int termin = ((pruvodka)bsPruvodka.Current).objednavka_polozka.termin_typ.termin_typ_id;

            xrTerminText.Text = lsTermin.ToArray()[termin] + " " + ((((pruvodka)bsPruvodka.Current).objednavka_polozka.dodrzet_termin ?? false && termin > 4) ? "Dodržet" : "");


            foreach (pruvodka_vrstva v in (p.pruvodka_vrstvas.ToList().OrderBy(item => item.poradi)))
            {
                bool obarvit = (v.strana != null && v.strana != "");

                XRTableRow row = new XRTableRow();
                InsertCell(row, v.pocet.ToString(), 53.67F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);
                InsertCell(row, v.material.nazev, 319.7F, DevExpress.XtraPrinting.TextAlignment.MiddleLeft, obarvit);
                InsertCell(row, v.vrstva_cu != null ? v.vrstva_cu.nazev : "", 74.08F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);
                InsertCell(row, v.tloustka_mm.ToString(), 99.16F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);
                InsertCell(row, ((pruvodka)bsPruvodka.Current).objednavka_polozka.produkt.sablona ? "" : v.strana, 84.15F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);

                xrTableVrstvy.Rows.Add(row);
                i++;
            }

            for (int j = i; j < 16; j++)
            {
                XRTableRow row = new XRTableRow();
                InsertCell(row, " ", 53.67F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 319.7F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 74.08F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 99.16F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 84.15F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);

                xrTableVrstvy.Rows.Add(row);
            }

            int k = 0;

            List<pruvodka_zmena> lsZmena = p.pruvodka_zmenas.ToList().OrderBy(item => item.rok).ThenBy(c => c.cislo).ToList();
            for (int j = 0; j < lsZmena.Count; j++)
            {
                if (j < 2)
                {
                    xrZmenyDPS1.Rows[j + 1].Cells[0].Text = lsZmena[j].rok.ToString();
                    xrZmenyDPS1.Rows[j + 1].Cells[1].Text = lsZmena[j].cislo.ToString();
                    xrZmenyDPS1.Rows[j + 1].Cells[2].Text = lsZmena[j].d_zmena.ToString(DBHelper.FormatDatum);
                    xrZmenyDPS1.Rows[j + 1].Cells[3].Text = lsZmena[j].uzivatel.celeJmeno.ToString();
                }

                if (j > 1)
                {
                    k++;
                    if (j < 5)
                    {
                        xrZmenyDPS2.Rows[k].Cells[0].Text = lsZmena[j].rok.ToString();
                        xrZmenyDPS2.Rows[k].Cells[1].Text = lsZmena[j].cislo.ToString();
                        xrZmenyDPS2.Rows[k].Cells[2].Text = lsZmena[j].d_zmena.ToString(DBHelper.FormatDatum);
                        xrZmenyDPS2.Rows[k].Cells[3].Text = lsZmena[j].uzivatel.celeJmeno.ToString();
                    }
                }
            }

            List<pruvodka_film> lsFilmy = p.pruvodka_films.ToList();

            pruvodka_film vsechny = lsFilmy.Where(item => item.film_typ_id == 1).FirstOrDefault();
            if (vsechny != null)
            {
                xrFilmyVsechny.Text = vsechny.oznaceni; // vsechny
            }
            else
            {
                xrFilmyVsechny.Text = "";
            }

            k = 0;
            lsFilmy = lsFilmy.Where(item => item.film_typ_id != 1).ToList();
            for (int j = 0; j < lsFilmy.Count; j++)
            {
                if (j < 2)
                {
                    xrDefinitceFilmu1.Rows[j + 1].Cells[0].Text = lsFilmy[j].film_typ.nazev.ToString();
                    xrDefinitceFilmu1.Rows[j + 1].Cells[1].Text = lsFilmy[j].vrstva.ToString();
                    xrDefinitceFilmu1.Rows[j + 1].Cells[2].Text = lsFilmy[j].oznaceni.ToString();
                }

                if (j > 1)
                {
                    k++;
                    if (j < 5)
                    {
                        xrDefinitceFilmu2.Rows[k].Cells[0].Text = lsFilmy[j].film_typ.nazev.ToString();
                        xrDefinitceFilmu2.Rows[k].Cells[1].Text = lsFilmy[j].vrstva.ToString();
                        xrDefinitceFilmu2.Rows[k].Cells[2].Text = lsFilmy[j].oznaceni.ToString();
                    }
                }
            }
            
            xrLabelArchivace.Text = ((p.produkt_archivace ?? false) ? "ANO" : "NE");
            xrLabelRevize.Text = p.produkt_revize_count + " - " + (p.produkt_revize_datum.HasValue ? p.produkt_revize_datum.Value.ToString("dd.MM.yyyy") : "") + "                        " + (((pruvodka)bsPruvodka.Current).objednavka_polozka.plosny_spoj_druh != null ? ((pruvodka)bsPruvodka.Current).objednavka_polozka.plosny_spoj_druh.nazev : "");
        }

        private void InsertCell(XRTableRow row, string text, float sirka, DevExpress.XtraPrinting.TextAlignment align, bool obarvit)
        {
            XRTableCell cell = new XRTableCell();
            cell.Text = text;
            cell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 100F);
            cell.StylePriority.UsePadding = false;
            cell.Font = new Font("Arial", 9);
            cell.TextAlignment = align;
            if (obarvit)
            {
                cell.BackColor = Color.WhiteSmoke;
            }

            if (sirka > 0)
            {
                cell.WidthF = sirka;
            }
            row.Cells.Add(cell);

        }


    }
}
