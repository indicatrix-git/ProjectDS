using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PCB.Report
{
    public class VyrobaReport : ReportBuilder
    {
        private bool fullReport;
        public VyrobaReport(bool fullReport) : base(@"template\VyrobaReport.xls")
        {
            this.fullReport = fullReport;
            this.Template = fullReport ? @"template\VyrobaReport.xls" : @"template\VyrobaReportSmall.xls";
        }
        public void Export(string path, List<VyrobaGridRow> source, string info/* DateTime? dateOd, DateTime? dateDo*/)
        {
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                ISheet sheet = workbook.GetSheetAt(0);
                sheet.GetRow(0).GetCell(0).SetCellValue(info);

                int startRow = 3;

                source.ForEach(s =>
                {
                    int col = 0;
                    IRow row = sheet.CreateRow(startRow);
                    if (fullReport) this.AddCellValue(row, s.TerminExpedice, CellFormat.DateTime, ref col);
                    if (fullReport) this.AddCellValue(row, s.TerminVyroby, CellFormat.DateTime, ref col);
                    this.AddCellValue(row, s.TerminZadani, CellFormat.DateTime, ref col);
                    this.AddCellValue(row, s.Odberatel, CellFormat.String, ref col);
                    this.AddCellValue(row, s.NazevPS, CellFormat.String, ref col);
                    //   this.AddCellValue(row, s.Status, CellFormat.String, ref col);
                    this.AddCellValue(row, s.PocetObjednano, CellFormat.N0, ref col);
                    this.AddCellValue(row, s.PocetPridavekPocetPanelu, CellFormat.String, ref col);
                    this.AddCellValue(row, s.PocetZmetkuChybyKs, CellFormat.String, ref col);
                    this.AddCellValue(row, s.CisloPruvodky, CellFormat.N0, ref col);
                    this.AddCellValue(row, s.Kod, CellFormat.String, ref col);
                    //   this.AddCellValue(row, s.CasFrezovaniMinuty, CellFormat.N2, ref col);
                    //   this.AddCellValue(row, s.PocetJizdFrezy, CellFormat.N0, ref col);

                    startRow++;
                });

                workbook.Write(file);
                file.Close();
            }
        }
    }
}
