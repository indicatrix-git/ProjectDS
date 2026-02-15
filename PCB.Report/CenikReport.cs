using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using PCB.Data.CustomObjects;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace PCB.Report
{
    public class CenikReport
    {
        public static string Print(List<CenikRadka> data)
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";
            string fileNameTemplate = @"template\cena.xls";

            FileStream fileTemplate = new FileStream(fileNameTemplate, FileMode.Open, System.IO.FileAccess.Read);
            NPOI.POIFS.FileSystem.POIFSFileSystem nfs = new NPOI.POIFS.FileSystem.POIFSFileSystem(fileTemplate);


            using (FileStream file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {

                HSSFWorkbook workbook = new HSSFWorkbook(nfs);
                ISheet sheet = workbook.GetSheetAt(0);

                // vsechny co maji vyplneou pevnou pozici x i y
                List<CenikRadka> vyslData = data.Where(item => item.SouradniceY > 0 && item.info && item.SouradniceX > 0).ToList();

                foreach (CenikRadka radka in vyslData)
                {
                    IRow row = sheet.GetRow(radka.SouradniceY);
                    if (row == null)
                    {
                        row = sheet.CreateRow(radka.SouradniceY);
                    }
                    string hodnota = "";
                    if (radka.Nazev != null)
                    {
                        hodnota = radka.Nazev;
                    }
                    else
                    {
                        hodnota = radka.Cena.ToString();
                    }


                    row.CreateCell(radka.SouradniceX).SetCellValue(hodnota);
                }

                // vypise typovou cenu
                List<CenikRadka> vyslDataTypova = data.Where(item => item.typovaCena).ToList();
                foreach (CenikRadka radka in vyslDataTypova)
                {
                    IRow row = sheet.GetRow(radka.SouradniceY);
                    row.CreateCell(3).SetCellValue((double)radka.pouzitaPlocha);
                    row.CreateCell(4).SetCellValue(radka.Jednotka);
                    row.CreateCell(5).SetCellValue((double)radka.Sazba);
                    row.CreateCell(6).SetCellValue((double)radka.Cena);
                    row.CreateCell(7).SetCellValue((radka.Polozka.vychozi ?? false) ? "ANO" : "");
                }

                // Material
                    CenikRadka material = data.Where(item => item.MaterialCena).ToList().FirstOrDefault();
                    if (material != null)
                    {
                        IRow rowMaterial = sheet.GetRow(material.SouradniceY);
                        rowMaterial.CreateCell(6).SetCellValue((double)material.Cena);
                        rowMaterial.CreateCell(7).SetCellValue("ANO");
                    }


                    // volitelne priplatky
                    sheet.CreateRow(17).CreateCell(1).SetCellValue("-----------");
                    int pozice = 18;
                    List<CenikRadka> volitelne = data.Where(item => !item.info && !item.typovaCena && !item.pausal && item.Pocet > 0).ToList();
                    foreach (CenikRadka radka in volitelne)
                    {
                        IRow row = sheet.CreateRow(pozice);
                        row.CreateCell(1).SetCellValue(radka.Nazev);
                        row.CreateCell(2).SetCellValue((double)radka.Pocet);

                        if (radka.pouzitaPlocha > 0)
                        {
                            row.CreateCell(3).SetCellValue((double)radka.pouzitaPlocha);
                        }
                        row.CreateCell(4).SetCellValue(radka.Jednotka);
                        row.CreateCell(5).SetCellValue((double)radka.Sazba);
                        row.CreateCell(6).SetCellValue((double)radka.Cena);
                        row.CreateCell(7).SetCellValue((radka.Polozka.vychozi ?? false) ? "ANO" : "");
                        pozice++;
                    }

                // pausaly

                    // volitelne priplatky
                    sheet.CreateRow(pozice).CreateCell(1).SetCellValue("--------------");
                    pozice++;
                    
                    List<CenikRadka> pausal = data.Where(item => item.pausal).ToList();
                    foreach (CenikRadka radka in pausal)
                    {
                        IRow row = sheet.CreateRow(pozice);
                        row.CreateCell(1).SetCellValue(radka.Nazev);
                        row.CreateCell(2).SetCellValue((double)radka.Pocet);
                        row.CreateCell(4).SetCellValue(radka.Jednotka);

                        if (radka.Pocet > 1)
                        {
                            row.CreateCell(5).SetCellValue((double)radka.Sazba);
                        }
                        row.CreateCell(6).SetCellValue((double)radka.Cena);
                        pozice++;
                    }


                workbook.Write(file);
                file.Close();
            }

            return fileName;

        }

    }
}
