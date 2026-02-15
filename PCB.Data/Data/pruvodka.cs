using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class pruvodka
    {
        public string Ks
        {
            get
            {
                return this.pocet_kusu + " / " + this.pocet_panelu;
            }
        }


        public int volnyPocetKusu
        {
            get
            {
                return pocet_kusu - expedice_ks;
            }
        }

        public string CisloObjednavka
        {
            get
            {
                return this.objednavka_polozka.cislo_objednavka;
            }
        }

        public double cisloPruvodky
        {
            get
            {
                return int.Parse(this._cislo);
            }
        }

        public bool Kopie
        {
            set;
            get;
        }
        
        public string poznamkaObchod
        {
            get
            {
                return this.objednavka_polozka.informace_zakaznik;
            }
        }

        public string JednotnyPanel
        {
            get
            {
                List<int> lsRadky = new List<int>() { 2, 3, 4, 5, 6 };


                if (this.objednavka_polozka.produkt.ObsahujeKod("4A") && this.objednavka_polozka.produkt.hruby_panel_x.Value <= 408 && this.objednavka_polozka.produkt.hruby_panel_y.Value <= 308)
                {
                    decimal y = ((408 - this.objednavka_polozka.produkt.hruby_panel_x.Value) / 2);

                    int pocet = this.objednavka_polozka.produkt.vrstvas.Where(i => i.material != null && lsRadky.Contains(i.poradi) && (this.objednavka_polozka.produkt.ObsahujeMaterial("DE104") || this.objednavka_polozka.produkt.ObsahujeMaterial("IS400"))).Count();

                    int pocetDE = this.objednavka_polozka.produkt.ObsahujeMaterialPocet("DE104");
                    int pocetISO = this.objednavka_polozka.produkt.ObsahujeMaterialPocet("IS400");

                    int pocetProVypocet = pocetDE == 0 ? pocetISO : pocetDE;

                    decimal celkem = 0;
                    foreach (vrstva v in this.objednavka_polozka.produkt.vrstvas.Where(i => lsRadky.Contains(i.poradi)))
                    {
                        celkem += v.poradi * (v.tloustka_mm ?? 0) * v.pocet;
                    }

                    if (!(celkem == 5.84m
                        && pocet == lsRadky.Count
                        && pocet == pocetProVypocet
                        && this.objednavka_polozka.produkt.vrstvas.Where(i => i.strana == "BC").First().tloustka_mm.Value == 0.9m))
                    {
                        return "";
                    }
                    if (this.HrubyPocet < 4)
                    {
                        return string.Format("408,00 x 308,00 Y={0}", y);
                    }
                }

                return "";
            }
        }

        public decimal? FakturaCenikovaCena
        {
            get
            {
                return this.objednavka_polozka.vychozi_cena;
            }
        }

        public decimal? FakturaSmluvniCena
        {
            get
            {
                return this.objednavka_polozka.smluv_cena;
            }
        }

        public decimal? FakturaZakladniCena
        {
            get
            {
                return this.objednavka_polozka.zakladni_cena;
            }
        }

        public int HrubyPocet
        {
            get
            {
                int pocet = this.pocet_kusu + this.pocet_panelu;
                decimal vysl = (Convert.ToDecimal(pocet) / (this.objednavka_polozka.produkt.hruby_panel_suma ?? 0));

                return  int.Parse(Math.Round(vysl,0).ToString());


            }
        }

    }

}

