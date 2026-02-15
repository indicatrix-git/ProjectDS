using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class Cenik
    {
        public decimal CenikovaCena = 0;
        public decimal ZakladniCena = 0;
        public decimal VychoziCena = 0;
        
        public string KontrolaMaterialu(List<vrstva> lsVrstva, cenik cenikHodnoty)
        {
            List<string> result = new List<string>();

            foreach (vrstva v in lsVrstva)
            {
                cenik_vrsta_cu cenaMat = cenikHodnoty.cenik_vrsta_cus.Where(i => i.material_id == v.material_id && i.vrstva_cu_id == (v.vrstva_cu_id != null ? v.vrstva_cu_id : 1) && i.tloustka == v.tloustka_mm.Value).FirstOrDefault();
                if (cenaMat == null)
                {
                    result.Add("<tr><td>" + v.material.nazev + " </td><td>" + v.tloustka_mm + "</td><td>" + (v.vrstva_cu == null ? "000/000" : v.vrstva_cu.nazev) + "</td></tr>");
                    
                }
            }

            string sHlaska = "<b>Materiál nemá přiřazené ceny:</b>  <br />";

            sHlaska += "<table><tr><td>Materiál</td><td>Tlouška</td><td>Vrstva Cu</td></tr>";

            foreach (string s in result)
            {
                sHlaska += s;
            }

            sHlaska += "</table>";

            if (result.Count == 0)
            {
                return "";
            }

            return sHlaska;
        }

        public List<CenikRadka> SestavCena(CenikContext cenikContext)
        {
            List<CenikRadka> vysledek = new List<CenikRadka>();
            List<CenikRadka> parametryZakazky = cenikContext.lsCenikRadka;

            decimal plocha = Convert.ToDecimal(cenikContext.Plocha / 10000);
            decimal plochaZakazky = (cenikContext.pocetKs * plocha);

            decimal obvod = (cenikContext.rozmerPanelX + cenikContext.rozmerPanelY) * 2;
            decimal cenaZkladni = 0;
                      
            // Objednavatel
            CenikRadka radkaZakaznik = new CenikRadka();
            radkaZakaznik.Nazev = cenikContext.zakaznik.interni_nazev;
            radkaZakaznik.info = true;
            radkaZakaznik.SouradniceX = 2;
            radkaZakaznik.SouradniceY = 1;

            vysledek.Add(radkaZakaznik);

            // nazev DPS
            CenikRadka radkaInfo = new CenikRadka();
            radkaInfo.Nazev = cenikContext.nazevDPS;
            radkaInfo.info = true;
            radkaInfo.SouradniceX = 2;
            radkaInfo.SouradniceY = 2;
            vysledek.Add(radkaInfo);

            //  Počet desek / Termín
            CenikRadka radkaPocet = new CenikRadka();
            radkaPocet.info = true;
            radkaPocet.Nazev = string.Format("{0} / {1}", cenikContext.pocetKs, cenikContext.termin.nazev);
            radkaPocet.SouradniceX = 2;
            radkaPocet.SouradniceY = 3;
            vysledek.Add(radkaPocet);

            // Zakladni Plocha desky
            CenikRadka radkaPlocha = new CenikRadka();
            radkaPlocha.Nazev = string.Format("{0}[mm]x{1}[mm] = {2} dm2.", cenikContext.rozmerX, cenikContext.rozmerY, plocha); ;
            radkaPlocha.info = true;
            radkaPlocha.SouradniceX = 2;
            radkaPlocha.SouradniceY = 4;
            vysledek.Add(radkaPlocha);

            // Plocha zakazky
            CenikRadka radkaPlochaZakazky = new CenikRadka();
            radkaPlochaZakazky.Cena = (plocha * cenikContext.pocetKs);
            radkaPlochaZakazky.info = true;
            radkaPlochaZakazky.SouradniceX = 2;
            radkaPlochaZakazky.SouradniceY = 5;
            vysledek.Add(radkaPlochaZakazky);

            // Typ desky
            CenikRadka radkaTyp = new CenikRadka();
            radkaTyp.info = true;
            radkaTyp.Nazev = string.Format("{0} - {1} vrstev ", cenikContext.plosnySpojSpecifikace.nazev, cenikContext.plosnySpojSpecifikace.PocetVrstva); ;
            radkaTyp.SouradniceX = 2;
            radkaTyp.SouradniceY = 6;
            vysledek.Add(radkaTyp);

            // Konstrukcni trida
            CenikRadka radkaKonstrukcniTrida = new CenikRadka();
            radkaKonstrukcniTrida.info = true;
            radkaKonstrukcniTrida.Nazev = cenikContext.kostrukcniTrida.ToString();
            radkaKonstrukcniTrida.SouradniceX = 2;
            radkaKonstrukcniTrida.SouradniceY = 7;
            vysledek.Add(radkaKonstrukcniTrida);


            // sleva
            CenikRadka radkaObjem = new CenikRadka();
            radkaObjem.info = true;
            radkaObjem.Cena = Sleva(cenikContext);
            radkaObjem.Jednotka = "%";
            radkaObjem.SouradniceX = 2;
            radkaObjem.SouradniceY = 8;
            vysledek.Add(radkaObjem);

       
            foreach (CenikRadka radka in parametryZakazky.Where(i => i.typovaCena))
            {
                radka.Nazev = radka.Polozka.nazev;
                radka.Poradi = 88;
                radka.pouzitaPlocha = plocha;
                radka.Jednotka = radka.Polozka.jednotka;
                radka.Cena = radka.Pocet * radka.Sazba * radka.pouzitaPlocha;
                radka.SouradniceY = 15;
                cenaZkladni += radka.Cena;

                vysledek.Add(radka);
            }

            foreach (CenikRadka radka in parametryZakazky.Where(i => i.pocitaSplochou && !i.typovaCena))
            {
                radka.Nazev = radka.Polozka.nazev;
                radka.Poradi = 88;
                radka.Jednotka = radka.Polozka.jednotka;
                radka.pouzitaPlocha = plocha;
                radka.Cena = radka.Pocet * radka.Sazba * radka.pouzitaPlocha;
                vysledek.Add(radka);
            }

            // na kus
            foreach (CenikRadka radka in parametryZakazky.Where(i => (i.naKus)))
            {
                radka.Pocet = 1;
                radka.Nazev = radka.Polozka.nazev;
                radka.Cena = radka.Sazba * radka.Pocet;
                radka.Jednotka = radka.Polozka.jednotka;

                radka.Poradi = 99;
                vysledek.Add(radka);
            }

            // na obvod
            foreach (CenikRadka radka in parametryZakazky.Where(i => (i.pocitaSobvodem)))
            {
                radka.Nazev = radka.Polozka.nazev;
                radka.Poradi = 100;
                radka.Jednotka = radka.Polozka.jednotka;
                radka.Cena = radka.Pocet * radka.Sazba * obvod;
                radka.pouzityObvod = obvod;
                vysledek.Add(radka);
            }

            // ostatní polozky
            foreach (CenikRadka radka in parametryZakazky.Where(i => (!i.pocitaSplochou && !i.pausal && !i.naKus && !i.pocitaSobvodem)))
            {

                radka.Nazev = radka.Polozka.nazev;
                radka.Cena = radka.Pocet * radka.Sazba;
                radka.Jednotka = radka.Polozka.jednotka;
                radka.Poradi = 101;
                vysledek.Add(radka);
            }

            CenikRadka radkaMaterial = new CenikRadka();
            // cena za material
            if (cenikContext.lsVrstva.Count > 0)
            {
                decimal cena = 0;
                
                foreach (vrstva v in cenikContext.lsVrstva)
                {
                    cenik_vrsta_cu cenaMat = cenikContext.Cenik.cenik_vrsta_cus.Where(i => i.material_id == v.material_id && i.vrstva_cu_id == (v.vrstva_cu_id != null ? v.vrstva_cu_id : 1) && i.tloustka == v.tloustka_mm.Value).FirstOrDefault();
                    if (cenaMat != null)
                    {
                        cena += cenaMat.hodnota * v.pocet * ((cenikContext.plosnySpojSpecifikace.PridavekPlochy + (cenikContext.rozmerPanelX * cenikContext.rozmerPanelY)) / 10000);
                    }

                }

                // material
                radkaMaterial.Jednotka = "Kč";
                radkaMaterial.Pocet = 1;
                radkaMaterial.Sazba = cena;
                radkaMaterial.Cena = cena;
                radkaMaterial.info = true;
                radkaMaterial.MaterialCena = true;
                radkaMaterial.SouradniceY = 16;
                radkaMaterial.SouradniceX = 0;
                vysledek.Add(radkaMaterial);
            }

            VychoziCena = vysledek.Where(i => i.Polozka != null && (i.Polozka.vychozi ?? false)).Sum(i => i.Cena) + radkaMaterial.Sazba;
            ZakladniCena = VychoziCena + vysledek.Where(i => i.Polozka != null && i.pausal == false && i.info == false && (i.Polozka.vychozi ?? false) == false).Sum(i => i.Cena);
            CenikovaCena = (VychoziCena * (100 + Sleva(cenikContext)) / 100) + vysledek.Where(i => i.Polozka != null && i.pausal == false && i.info == false && (i.Polozka.vychozi ?? false) == false).Sum(i => i.Cena); ;

            if (ZakladniCena > CenikovaCena)
            {
                ZakladniCena = CenikovaCena;
            }

            // vychozi cena
            CenikRadka vysledekRadkaVychozi = new CenikRadka();
            vysledekRadkaVychozi.Cena = VychoziCena; 
            vysledekRadkaVychozi.info = true;
            vysledekRadkaVychozi.SouradniceX = 2;
            vysledekRadkaVychozi.SouradniceY = 10;
            vysledek.Add(vysledekRadkaVychozi);
            

            // zakladni cena
            CenikRadka vysledekRadkaZakladni = new CenikRadka();
            vysledekRadkaZakladni.Cena = ZakladniCena;
            vysledekRadkaZakladni.info = true;
            vysledekRadkaZakladni.SouradniceX = 2;
            vysledekRadkaZakladni.SouradniceY = 11;
            vysledek.Add(vysledekRadkaZakladni);

            // cenikova cena
            CenikRadka vysledekRadkaCenikova = new CenikRadka();
            vysledekRadkaCenikova.Cena = CenikovaCena;
            vysledekRadkaCenikova.info = true;
            vysledekRadkaCenikova.SouradniceX = 2;
            vysledekRadkaCenikova.SouradniceY = 12;
            vysledek.Add(vysledekRadkaCenikova);

            this.ZakladniCena = vysledekRadkaZakladni.Cena;
            this.CenikovaCena = vysledekRadkaCenikova.Cena;
            this.VychoziCena = vysledekRadkaVychozi.Cena;

            CenikRadka optimalniPlocha = new CenikRadka();
            optimalniPlocha.Cena = cenikContext.plosnySpojSpecifikace.OptimalniPlocha;
            optimalniPlocha.info = true;
            optimalniPlocha.SouradniceX = 6;
            optimalniPlocha.SouradniceY = 11;
            vysledek.Add(optimalniPlocha);


            // vypis pausalu            
            foreach (CenikRadka radka in parametryZakazky.Where(i => (i.pausal)))
            {
                radka.Nazev = radka.Polozka.nazev;
                radka.Cena = radka.Pocet * radka.Sazba;
                radka.Pocet = radka.Pocet;
                radka.Jednotka = radka.Polozka.jednotka;

                radka.Poradi = 9999;
                vysledek.Add(radka);
            }

            return vysledek;
        }
        
        public static decimal Sleva(CenikContext context)
        {
            if (context.plosnySpojSpecifikace.PocetVrstva == 1 || context.plosnySpojSpecifikace.PocetVrstva == 2)
            {

                if (context.termin.termin_typ_id == (int)termin_typ.Value.express)
                {
                    return 175;
                }
                else
                    if (context.termin.termin_typ_id == (int)termin_typ.Value.poloexpres)
                    {
                        if (context.PlochaZakazky < 3)
                        {
                            return 140;
                        }
                        else
                        {
                            return Convert.ToDecimal( (7813 / (context.PlochaZakazky + 53.11m)) + 4.22m);
                        }
                    }
                    else
                    {
                        if (context.PlochaZakazky < 3)
                        {
                            return 110;
                        }
                        else
                        {
                            return Convert.ToDecimal((7813 / (context.PlochaZakazky + 53.11m)) - 25.78m);
                        }
                    }
            }

            if (context.plosnySpojSpecifikace.PocetVrstva > 2)
            {
                if (context.termin.termin_typ_id == (int)termin_typ.Value.express)
                {
                    return 125;
                }
                else
                    if (context.termin.termin_typ_id == (int)termin_typ.Value.poloexpres)
                    {
                        if (context.PlochaZakazky < 5)
                        {
                            return 100;
                        }
                        else
                        {
                            return Convert.ToDecimal((7270.41m / (context.PlochaZakazky + 71.43m)) - 1.79m);
                        }
                    }
                    else
                    {
                        if (context.PlochaZakazky < 5)
                        {
                            return 75;
                        }
                        else
                        {
                            return Convert.ToDecimal((7270.41m / (context.PlochaZakazky + 71.43m)) - 26.57m);
                        }
                    }
            }

            return 0;
        }
    }
}
