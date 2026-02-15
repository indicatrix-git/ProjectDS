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
    public partial class reportNabidkaHlavicka : DevExpress.XtraReports.UI.XtraReport
    {
        public void SetDataSource(EntityObject eo)
        {
            bindingSource1.DataSource = eo;
        }

        public reportNabidkaHlavicka()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // vyplni tabulku vrstev
            nabidka_polozka nabidka = ((nabidka_polozka)this.bindingSource1.Current);

            
            XRTableRow rowCena = new XRTableRow();

            int i = 0;
            int j = 0;
            foreach (DataColumn column in nabidka.CenovaTabulka.Columns)
            {
                
                i++;
                if (i == 1)
                {
                    InsertCell(rowCena, column.Caption == "0" ? "" : column.Caption, 150, DevExpress.XtraPrinting.TextAlignment.MiddleLeft, false, true);
                }
                else
                {
                    InsertCell(rowCena, column.Caption == "0" ? "" : column.Caption, 40, DevExpress.XtraPrinting.TextAlignment.MiddleRight, false, false);
                }
            }
            xrTableCena.Rows.Add(rowCena);

            
            foreach (DataRow datarow in nabidka.CenovaTabulka.Rows)
            {
                XRTableRow row = new XRTableRow();
                i = 0;
                bool posledni = (j == 2);
                foreach (DataColumn column in nabidka.CenovaTabulka.Columns)
                {
                    i++;
                    if (i == 1)
                    {
                        InsertCell(row, datarow[column].ToString() == "0" ? "" : datarow[column].ToString(), 150, DevExpress.XtraPrinting.TextAlignment.MiddleLeft, posledni, true);
                    }
                    else
                    {
                        InsertCell(row, datarow[column].ToString() == "0" ? "" : datarow[column].ToString(), 40, DevExpress.XtraPrinting.TextAlignment.MiddleRight, posledni, false);
                    }
                }

                j++;
                xrTableCena.Rows.Add(row);
            }

            xrTableCena.DeleteRow(xrTableCena.Rows[0]);

            
        }

        private void InsertCell(XRTableRow row, string text)
        {
            InsertCell(row, text, 0, DevExpress.XtraPrinting.TextAlignment.MiddleLeft, false, false);
        }

        private void InsertCell(XRTableRow row, string text, float sirka, DevExpress.XtraPrinting.TextAlignment align, bool isBottom, bool isFirst)
        {
            XRTableCell cell = new XRTableCell();
            cell.Text = text;
            cell.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            cell.StylePriority.UsePadding = false;
            cell.TextAlignment = align;
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right;
            cell.Font = new Font("Arial", 9); 
            

            if (isBottom)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right |  DevExpress.XtraPrinting.BorderSide.Bottom;
            }

            if (isFirst)
            {
                cell.Borders = DevExpress.XtraPrinting.BorderSide.None | DevExpress.XtraPrinting.BorderSide.Right;
            }

            
            if (sirka > 0)
            {
                cell.WidthF = sirka;
            }
            row.Cells.Add(cell);

        }

    }
}
