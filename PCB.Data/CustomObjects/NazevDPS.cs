using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class NazevDPS
    {
        public string Nazev
        {
            get;
            set;
        }

        public zakaznik Zakaznik
        {
            get;
            set;
        }

        public produkt ProduktDPS
        {
            get;
            set;
        }

        //public static List<NazevDPS> LoadData(pcb_develEntities dbContext)
        //{
        //    var result = from item in dbContext.objednavka_polozkas.Where(i => i.produkt != null)
        //                 select new { item.nazev, item.za, item.produkt };

        //    List<NazevDPS> ls = new List<NazevDPS>();

        //    foreach (var item in result.Distinct())
        //    {
        //        ls.Add(new NazevDPS() { Nazev = item.nazev, Zakaznik=item.zakaznik, ProduktDPS = item.produkt });
        //    }

        //    return ls;
        //}

    }
}
