using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using PCB.Data.CustomObjects;
using pcb_develModel;

namespace PCB.Report
{
    public class TPVReport : ReportBuilder
    {
        public TPVReport() : base(@"template\TPVReport.xls") { }

        public void Export(string path, List<TPVGridRow> source, DateTime? dateOd, DateTime? dateDo)
        {
            Dictionary<int, int> deskaRow = new Dictionary<int, int>()
            {
                { 1, 15 },
                { 2, 31 },
                { 3, 31 },
                { 4, 16 },
                { 5, 17 },
                { 6, 18},
                { 7, 18 },
                { 8, 29 },
                { 9, 19 },
                { 10, 19 },
                { 11, 20 },
                { 12, 21 },
                { 13, 22 },
                { 14, 23 },
                { 15, 24 },
                { 16, 20 },
                { 17, 21 },
                { 18, 22 },
                { 19, 23 },
                { 20, 24 },
                { 21, 25 },
                { 22, 26 },
                { 23, 27 },
                { 24, 29 }
            };

            Dictionary<int, Dictionary<int, int>> druhTyp = new Dictionary<int, Dictionary<int, int>>();
            Dictionary<int, Dictionary<int, int>> druhDeska = new Dictionary<int, Dictionary<int, int>>();
            source.GroupBy(g => g.DruhTerminuId).ToList().ForEach(item =>
            {
                int key = item.Key.Value;

                if (!druhTyp.ContainsKey(key))
                {
                    druhTyp[key] = new Dictionary<int, int>();
                }

                item.GroupBy(g => g.TypVyrobyId).ToList().ForEach(group =>
                {
                    druhTyp[key][group.Key.Value] = group.Count();
                });
                

                if (!druhDeska.ContainsKey(key))
                {
                    druhDeska[key] = new Dictionary<int, int>();
                }

                item.GroupBy(g => g.TypDeskyId).ToList().ForEach(group =>
                {
                    druhDeska[key][group.Key.Value] = group.Count();
                });
            });

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

                int startRow = 5;

                foreach(var dic in druhTyp.Keys)
                {
                    foreach(var typ in druhTyp[dic].Keys)
                    {
                        int col = dic;

                        IRow row = sheet.GetRow(startRow + typ);
                        this.AddCellValue(row, druhTyp[dic][typ], CellFormat.N0, ref col);
                    }
                }

                foreach(var dic in druhDeska.Keys)
                {
                    foreach(var deska in druhDeska[dic].Keys)
                    {
                        int col = dic;

                        IRow row = sheet.GetRow(deskaRow[deska]);
                        this.AddCellValue(row, druhDeska[dic][deska], CellFormat.N0, ref col);
                    }
                }

                ISheet sheet2 = workbook.GetSheetAt(1);
                int startRowIndex2 = 1;

                foreach(var group in source.Where(w => w.ProblemovaData).GroupBy(g => g.ZakaznikId))
                {
                    int colIndex = 0;

                    IRow row2 = sheet2.CreateRow(startRowIndex2);
                    this.AddCellValue(row2, group.First().ZakaznikNazev, CellFormat.String, ref colIndex, true);
                    this.AddCellValue(row2, group.Count(), CellFormat.N0, ref colIndex, true);

                    startRowIndex2++;
                }


                workbook.Write(file);
                file.Close();
            }
        }
    }
}
