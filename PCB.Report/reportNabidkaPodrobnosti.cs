using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.Entity.Core.Objects.DataClasses;
using pcb_develModel;
using System.Data;

namespace PCB.Report
{
    public partial class reportNabidkaPodrobnosti : DevExpress.XtraReports.UI.XtraReport
    {
        public void SetDataSource(EntityObject eo)
        {
            bindingSource1.DataSource = eo;
        }

        public reportNabidkaPodrobnosti()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            

            // vyplni tabulku vrstev
            nabidka_polozka nabidka = ((nabidka_polozka)this.bindingSource1.Current);
            int i = 0;
            foreach (vrstva v in nabidka.vrstvas)
            {
               
                XRTableRow row = new XRTableRow();
                bool obarvit = (v.strana != null && v.strana != "");
               
                InsertCell(row, v.pocet.ToString(), 53.67F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);
                InsertCell(row, v.material.nazev, 260.5F, DevExpress.XtraPrinting.TextAlignment.MiddleLeft, obarvit);
                InsertCell(row, v.vrstva_cu != null ? v.vrstva_cu.nazev : "", 74.83F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);
                InsertCell(row, v.tloustka_mm.ToString(), 100.11F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);
                InsertCell(row, v.strana, 85F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, obarvit);

                xrTableVrstvy.Rows.Add(row);
                i++;
            }

            for (int j=i;j<14;j++)
            {
                XRTableRow row = new XRTableRow();
                InsertCell(row, " ", 53.67F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 260.5F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 74.83F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 100.11F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);
                InsertCell(row, " ", 85F, DevExpress.XtraPrinting.TextAlignment.MiddleCenter, false);

                xrTableVrstvy.Rows.Add(row);
            }

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
