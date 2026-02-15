using PCB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class faktura
    {
        public string Posta { get { return (this.psc + " " + this.misto); } }
        
        public decimal ZakladDPH21
        {
            get
            {
                return faktura_polozkas.Sum(i => i.cenaCelkem);
            }
        }

        
        public decimal dan21
        {
            get
            {
                return (ZakladDPH21 * 0.21m);
            }
        }

        public decimal Soucet
        {
            get
            {
                return dan21;
            }
        }

        public decimal SoucetDPH
        {
            get
            {
                return dan21;
            }
        }

        public decimal Zaokrouhleni
        {
            get
            {
                return Math.Round(this.CelkemKUhradeZaokrouhleno - this.CelkemKUhrade, 2);
            }
        }

        public decimal CelkemKUhrade
        {
            get
            {
                return this.ZakladDPH21 + this.SoucetDPH;
            }
        }

        public decimal CelkemKUhradeZaokrouhleno
        {
            get
            {
                return Math.Round(CelkemKUhrade, 0);
            }
        }


        public string DalsiCisloFaktury(pcb_develEntities dbContext)
        {
            int cislo = int.Parse(dbContext.klices.Where(i => i.klic == "faktura_cislo").First().hodnota) + 1;
            string strCislo = string.Format("{0}{1}{2}",
                PCB.Data.DBHelper.DateTimeNow().Year.ToString().Substring(2), // rok
                ((this.zahranicni ?? false) ? "03": "01"), // zahranicni / domaci
                cislo.ToString().PadLeft(4,'0'));

            dbContext.klices.Where(i => i.klic == "faktura_cislo").First().hodnota = cislo.ToString();


            return strCislo;
        }

        public decimal SestavaCelkemKUhrade
        {
            get
            {
                if (this.zahranicni ?? false)
                {
                    return (this.ZakladDPH21 / (this.kurz ?? 1));
                }
                else
                {
                    return this.CelkemKUhrade;
                }
            }
        }

        public decimal SestavaZakladDPH21
        {
            get
            {
                return faktura_polozkas.Sum(i => i.SestavaCenaCelkem);
            }
        }

        public String SestavaKUhradeJednotka
        {
            get
            {
                if (this.zahranicni ?? false)
                {
                    return "K ÚHRADĚ (EUR)";
                }
                else
                {
                    return "K ÚHRADĚ (Kč)";
                }
            }
        }

        public bool JeJinyOdberatelPrijemce
        {
            get
            {
                //line.Add(faktura.zakaznik.nazev); // PR_INSTITUCE
                //line.Add(faktura.zakaznik_nazev); // PR_PRACOVNIK
                //line.Add(""); // PR_ODDELENI
                //line.Add(faktura.ulice); // PR_ULICE
                //line.Add(faktura.misto); // PR_MESTO
                //line.Add(""); // PR_STAT
                //line.Add(faktura.psc); // PR_PSC
                //line.Add(faktura.dic); // PR_DIC
                //line.Add(faktura.ico); // PR_IC
                //line.Add(""); // PR_KDZE

                if (this.zakaznik_id.HasValue)
                {
                    return !(this.zakaznik.nazev == this.zakaznik_nazev &&
                           this.zakaznik.ulice == this.ulice &&
                           this.zakaznik.misto == this.misto &&
                           this.zakaznik.psc == this.psc &&
                           this.zakaznik.dic == this.dic &&
                           this.zakaznik.ico == this.ico);
                }

                return true;
            }
        }
        
                

    }
}
