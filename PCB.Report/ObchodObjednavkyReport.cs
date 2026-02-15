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
    public class ObchodObjednavkyReport : ReportBuilder
    {
        public ObchodObjednavkyReport() : base(@"template\ObchodObjednavkyReport.xls") { }
        public void Export(string path, List<ObjednavkaGridRow> source, DateTime? dateOd, DateTime? dateDo)
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

                int test;
                source = source.Where(s => s.Expedice != "").ToList();
                //Řazení podle čísel Expedice
                List<ObjednavkaGridRow> sourceFinal = source.Where(s => int.TryParse(s.Expedice, out test)).OrderBy(s => int.Parse(s.Expedice)).ToList();
                //Neníé číslo, řazení dle abecedy
                sourceFinal.AddRange(source.Except(sourceFinal).OrderBy(s => s.Expedice).ToList());
                sourceFinal.ForEach(s =>
                {
                    int col = 0;
                    IRow row = sheet.CreateRow(startRow);
                    this.AddCellValue(row, s.Zakaznik, CellFormat.String, ref col);
                    this.AddCellValue(row, s.NazevDPS, CellFormat.String, ref col);
                    this.AddCellValue(row, s.PocetKs, CellFormat.N0, ref col);
                    this.AddCellValue(row, s.TechnologPlusVyrobniPridavek, CellFormat.N0, ref col);
                    this.AddCellValue(row, s.TerminVyroby, CellFormat.DateTime, ref col);
                    this.AddCellValue(row, s.TerminExpedice, CellFormat.DateTime, ref col);
                    this.AddCellValue(row, s.DruhTerminu, CellFormat.String, ref col);
                    this.AddCellValue(row, s.TypDesky, CellFormat.String, ref col);
                    this.AddCellValue(row, s.CisloPruvodky, CellFormat.N2, ref col);
                    this.AddCellValue(row, s.Expedice, CellFormat.String, ref col);

                    startRow++;
                });

                workbook.Write(file);
                file.Close();
            }
        }
    }
}
