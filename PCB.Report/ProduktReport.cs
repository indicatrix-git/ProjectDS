using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace PCB.Report
{
    public class ProduktReport
    {
        public static string Export(DataTable data)
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";
            string fileNameTemplate = @"template\produkt.xls";

            DataView dv = new DataView(data);
            dv.Sort = "d_sestaveno";

            FileStream fileTemplate = new FileStream(fileNameTemplate, FileMode.Open, System.IO.FileAccess.Read);
            NPOI.POIFS.FileSystem.POIFSFileSystem nfs = new NPOI.POIFS.FileSystem.POIFSFileSystem(fileTemplate);

            bool vybranoHasValue = data.Select("vybrano = true").Count() > 0;
            
            using (FileStream file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {

                HSSFWorkbook workbook = new HSSFWorkbook(nfs);
                ISheet sheet = workbook.GetSheetAt(0);
                int i = 0;
                foreach (DataRow drow in dv.ToTable().Rows)
                {
                    if (vybranoHasValue && drow["vybrano"].ToString() != "True")
                    {
                        continue;
                    }
                    i++;
                    IRow row = sheet.CreateRow(i);
                    row.CreateCell(0).SetCellValue(drow["zakaznik"].ToString());
                    row.CreateCell(1).SetCellValue(drow["nazev_dps"].ToString());
                    row.CreateCell(2).SetCellValue(drow["kod"].ToString());
                    row.CreateCell(3).SetCellValue(drow["d_sestaveno"].ToString());
                    row.CreateCell(4).SetCellValue(drow["sestavil"].ToString());
                    row.CreateCell(5).SetCellValue(drow["naposledy_ve_vyrobe"].ToString());
                    row.CreateCell(6).SetCellValue(drow["produkt_stav"].ToString());
                }

                workbook.Write(file);
                file.Close();
            }

            return fileName;

        }
    }
}
