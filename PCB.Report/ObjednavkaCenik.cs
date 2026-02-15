using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PCB.Report
{
    public class ObjednavkaCenik
    {
        /*
        public string SestavObjednavku(objednavka_polozka objednavkaPolozka, pcb_develEntities dbContext)
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";

            using (FileStream file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite))
             {

                 List<cenik_hodnota> ls = objednavkaPolozka.GetCenikPolozky(dbContext);

                 HSSFWorkbook workbook = new HSSFWorkbook();
                 ISheet sheet = workbook.CreateSheet("Cena");

                 double plocha = Convert.ToDouble(objednavkaPolozka.produkt.cisty_rozmer_dps_x.Value / 100) * Convert.ToDouble(objednavkaPolozka.produkt.cisty_rozmer_dps_y / 100);

                 AddRow(1, "Ceník", objednavkaPolozka.objednavka.cenik.popis, sheet);
                 AddRow(2, "Deska", objednavkaPolozka.produkt.nazev, sheet);
                 AddRow(3, "Počet kusů", objednavkaPolozka.pozadovano_pocet.ToString(), sheet);
                 AddRow(4, "Čistý rozměr na 1 ks", plocha.ToString("N2") + " dm2 - " + objednavkaPolozka.produkt.cisty_rozmer_dps_x + " x " + objednavkaPolozka.produkt.cisty_rozmer_dps_y + " mm", sheet);
                 AddRow(5, "Čistý plocha zakázky", (plocha * objednavkaPolozka.pozadovano_pocet.Value).ToString("N2") + " dm2", sheet);

                 IRow radek = sheet.CreateRow(7);
                 radek.CreateCell(1).SetCellValue("Položka");
                 radek.CreateCell(2).SetCellValue("Počet");
                 radek.CreateCell(3).SetCellValue("Jednotka");
                 radek.CreateCell(4).SetCellValue("Sazba");
                 radek.CreateCell(5).SetCellValue("Cena za ks");

                 double cena_celkem = 0;
                 int i = 8;
                 foreach (cenik_hodnota hodnota in ls)
                 {
                     double cenik_cena = Convert.ToDouble(objednavkaPolozka.objednavka.cenik.cenik_hodnotas.Where(item => item.cenik_polozka_id == hodnota.cenik_polozka_id).First().hodnota);
                     double cena = cenik_cena * Convert.ToDouble(hodnota.Pocet);
                     cena_celkem += cena; 

                     IRow row = sheet.CreateRow(i);
                     row.CreateCell(1).SetCellValue(hodnota.cenik_polozka.nazev);
                     row.CreateCell(2).SetCellValue(Convert.ToDouble(hodnota.Pocet));
                     row.CreateCell(3).SetCellValue(hodnota.cenik_polozka.jednotka);
                     row.CreateCell(4).SetCellValue(cenik_cena);
                     row.CreateCell(5).SetCellValue(cena);
                     row.CreateCell(6).SetCellValue("Kč");

                     i++;
                 }

                 double cena_norma = cena_celkem * 0.80; 
                 AddRow(i + 1, "Celková cena", cena_celkem.ToString("N2"), sheet);
                 AddRow(i + 2, "Celková cena pro zakázku pro 250 dm2", cena_norma.ToString("N2") ,sheet);


                 workbook.Write(file);
                file.Close();
             }
           
             return fileName;

        }*/

        private IRow AddRow(int i, string jmeno, string hodnota, ISheet sheet)
        {
            IRow row = sheet.CreateRow(i);
            row.CreateCell(1).SetCellValue(jmeno);
            row.CreateCell(2).SetCellValue(hodnota);

            return row;
        }


    }
}
