using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using pcb_develModel;

namespace PCB.Report
{
    public class FakturaReport
    {
        private string _fileName;
        private List<faktura> Faktury = null;
        public FakturaReport(string fileName)
        {
            this._fileName = fileName;

            this.LoadData();
            this.Fill();
        }

        public void LoadData()
        {

                
        }

        public void Fill()
        {
            var formater = new NumberFormatInfo() { NumberDecimalDigits = 2, NumberDecimalSeparator = ".", NumberGroupSeparator = "" };
            
            StringBuilder sb = new StringBuilder();
            using (var db = new pcb_develEntities())
            {
                foreach (var faktura in db.fakturas.Where(w => w.d_vystaveno.HasValue).OrderBy(o => o.d_vystaveno))
                {
                    List<object> line = new List<object>();
                    line.Add("H"); // TYP_R
                    line.Add(faktura.d_vystaveno.Value.Year); // H_RRRR
                    line.Add(faktura.d_vystaveno.Value.ToString("yy") + "01"); // H_RD
                    line.Add(faktura.cislo_faktury); // H_CSDK
                    line.Add("TPDDK"); // H_TPDK
                    line.Add(""); // H_ST
                    line.Add(""); // H_ZA
                    line.Add(""); // H_AK
                    line.Add((faktura.zahranicni ?? false) ? "EUR" : "CZK"); // H_KDME
                    line.Add((faktura.zahranicni ?? false) ? faktura.kurz : (decimal?)null); // H_KU
                    line.Add(faktura.cislo_faktury); // H_PO
                    line.Add(faktura.d_vystaveno.HasValue ? faktura.d_vystaveno.Value.ToString("dd.MM.yyyy") : ""); // H_DMDK
                    line.Add(faktura.d_plneni.HasValue ? faktura.d_plneni.Value.ToString("dd.MM.yyyy") : ""); // H_DMSP
                    line.Add(faktura.d_splatnost.HasValue ? faktura.d_splatnost.Value.ToString("dd.MM.yyyy") : ""); // H_DMSL
                    line.Add(""); // H_KS
                    line.Add(faktura.uhrada_typ.nazev); // H_TPPL
                    line.Add(""); // H_TXDK


                    line.Add(faktura.SestavaZakladDPH21.ToString("N2", formater)); // H_CEUHTU - ToDo
                    line.Add((faktura.zahranicni ?? false) ? faktura.SestavaZakladDPH21.ToString("N2", formater) : ""); // H_CEUHVA - ToDo


                    line.Add(""); // H_DPTU1
                    line.Add(faktura.dan21.ToString("N2", formater)); // H_DPTU2
                    line.Add(""); // H_DPTU3


                    line.Add(""); // H_RA - ToDo

                    line.Add(""); // ADDO - ToDo

                    // PŘÍJEMCE
                    if (true) // jestli je rozdilna adresa od zakaznika
                    {
                        
                        line.Add(""); // ADPR
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.zakaznik.nazev : ""); // PR_INSTITUCE
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.zakaznik_nazev : ""); // PR_PRACOVNIK
                        line.Add(""); // PR_ODDELENI
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.ulice : ""); // PR_ULICE
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.misto : ""); // PR_MESTO
                        line.Add(""); // PR_STAT
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.psc : ""); // PR_PSC
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.dic : ""); // PR_DIC
                        line.Add(faktura.JeJinyOdberatelPrijemce ? faktura.ico : ""); // PR_IC
                        line.Add(""); // PR_KDZE
                    }

                    // ODBĚRATEL
                    line.Add(faktura.zakaznik.kod_adresa); // ADOD - ToDo
                    line.Add(faktura.zakaznik.nazev); // OD_INSTITUCE
                    line.Add(""); // OD_PRACOVNIK
                    line.Add(""); // OD_ODDELENI
                    line.Add(faktura.zakaznik.ulice); // OD_ULICE
                    line.Add(faktura.zakaznik.misto); // OD_MESTO
                    line.Add(""); // OD_STAT
                    line.Add(faktura.zakaznik.psc); // OD_PSC
                    line.Add(faktura.zakaznik.dic); // OD_DIC
                    line.Add(faktura.zakaznik.ico); // OD_IC

                    // NEVYPLNUJE SE
                    line.Add(""); // OD_PRBAUC
                    line.Add(""); // OD_BAUC
                    line.Add(""); // OD_BA
                    line.Add(""); // OD_NSK
                    line.Add(""); // OD_SWIFT
                    line.Add(""); // OD_IBAN
                    line.Add(""); // OD_KDZE

                    line.Add(faktura.cislo_faktury.Substring(0, 2) + "/" + faktura.cislo_faktury.Substring(2, 2) + "/" + faktura.cislo_faktury.Substring(4));

                    sb.Append(String.Join(";", line) + Environment.NewLine);
                }
            }
        }
    }
}
