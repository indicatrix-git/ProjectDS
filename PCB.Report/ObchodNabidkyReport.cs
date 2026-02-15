using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace PCB.Report
{
    public class ObchodNabidkyReport : ReportBuilder
    {
        public ObchodNabidkyReport() : base(@"template\ObchodNabidkyReport.xls") { }
        public void Export(string path, List<NabidkaGridRow> source, DateTime? dateOd, DateTime? dateDo)
        {
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                ISheet sheet = this.workbook.GetSheetAt(0);

                if (dateOd.HasValue)
                {
                    ICell cell = sheet.GetRow(2).CreateCell(1);
                    cell.CellStyle.DataFormat = this.StyleDate;
                    cell.SetCellValue(dateOd.Value);
                }

                if (dateDo.HasValue)
                {
                    ICell cell = sheet.GetRow(3).CreateCell(1);
                    cell.CellStyle.DataFormat = this.StyleDate;
                    cell.SetCellValue(dateDo.Value);
                }

                int startRow = 6;

                source.ForEach(s =>
                {
                    int col = 0;
                    IRow row = sheet.CreateRow(startRow);
                    this.AddCellValue(row, s.Zakaznik, CellFormat.String, ref col);
                    this.AddCellValue(row, s.PocetNabidek, CellFormat.N0, ref col);
                    this.AddCellValue(row, s.PocetUspesnychNabidek, CellFormat.N0, ref col);
                    this.AddCellValue(row, s.PocetNeuspesnychNabidek, CellFormat.N0, ref col);
                    this.AddCellValue(row, (double)s.Uspesnost, CellFormat.P2, ref col);
                    startRow++;
                });
                workbook.Write(file);
                file.Close();
            }
        }
    }
}
