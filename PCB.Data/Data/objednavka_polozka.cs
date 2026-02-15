using PCB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class objednavka_polozka
    {
        public string Ks
        {
            get
            {
                return this.pozadovano_pocet.ToString() + "+" + this.tech_pridavek.ToString();
            }
        }

        public int Naplanovano { get; set; }
        public int Zbyva { get; set; }

        

        public string produktNazev
        {
            get
            {
                if (produkt != null)
                {
                    return this.produkt.nazev;
                }
                return "";
            }
        }

        public bool zamek
        {
          get{

              if (this.produkt == null)
              {
                  return false;
              }

              return (produkt.zamek ?? false); 
          }
        }

        public string NazevDPS
        {
            get
            {
                if (produkt_id != null)
                {
                    return this.produkt.nazev;
                }
                else
                {
                    return nazev;
                }
            }
        }

        public bool PrirazenaDokumentace
        {

            get
            {
                return this.produkt != null;
            }
        }

        
        public int PocetksCelkem
        {
            get
            {
                return (this.pozadovano_pocet ?? 0) + (this.tech_pridavek ?? 0);
            }
        }


        public string PlosnySpojSpecifikace
        {
            get
            {
                if (this.produkt == null)
                {
                    if (this.plosny_spoj_specifikace != null)
                    {
                        return this.plosny_spoj_specifikace.kod;
                    }
                    else
                    {
                        return "";
                    }


                }
                else
                {
                    return this.produkt.kod;
                }

            }
        }

        public string TerminTyp
        {
            get
            {
                return this.termin_typ.nazev;
            }
        }


        public int PocetPruvodek
        {
            get
            {
                return this.pruvodkas.Count();
            }

        }
        public string Popis
        {
            get
            {
                return this.produkt.nazev + " / " + this.cislo_objednavka;
            }
        }
        public string PlosnySpoj
        {
            get
            {
                return this.plosny_spoj_specifikace == null ? null : this.plosny_spoj_specifikace.nazev;
            }
        }
        public List<cenik_hodnota> GetCenikObjednavka()
        {
            List<cenik_hodnota> vysledek = new List<cenik_hodnota>();
            return vysledek;
        }

        public int Hotovo
        {
            get
            {
                return 0;
            }
        }
        
        public decimal plochaZakazky
        {
            get
            {
                int pocet = ((this.pozadovano_pocet ?? 0) + (this.tech_pridavek ?? 0));
                decimal plocha = 0;
                if (this.produkt != null)
                {
                    plocha = ((this.produkt.cisty_rozmer_dps_x ?? 0) * (this.produkt.cisty_rozmer_dps_y ?? 0)) / 10000;
                }
                else
                {
                    plocha = this.plocha_dps ?? 0;
                }

                return plocha * pocet;
            }
        }

        public decimal PlochaDPS
        {
            get
            {

                decimal plocha = 0;
                if (this.produkt != null)
                {
                    plocha = ((this.produkt.cisty_rozmer_dps_x ?? 0) * (this.produkt.cisty_rozmer_dps_y ?? 0)) / 10000;
                }
                else
                {
                    plocha = this.plocha_dps ?? 0;
                }

                return plocha;
            }
        }

        public string Vytiskl
        {
            get
            {
                return (from item in this.pruvodkas
                        where item.uzivatel != null
                        select item.uzivatel.celeJmeno).FirstOrDefault();
            }
        }

        public string Zadal
        {
            get
            {
                if (this.zadal_id != null)
                {
                    return this.uzivatel.celeJmeno;
                }
                else
                {
                    return "";
                }
            }
        }


        public DateTime? VytisklDatum
        {
            get
            {
                return (from item in this.pruvodkas
                        where item.d_tisk_pruvodka.HasValue
                        select item.d_tisk_pruvodka).OrderByDescending(i => i.Value).FirstOrDefault();
            }
        }

        public string ProduktNazev
        {
            get
            {
                if (this.produkt != null)
                {
                    return this.produkt.nazev;
                }
                else
                {
                    return "";
                }
            }
        }

        public string Objendavetel
        {
            get
            {
                if (this.zakaznik_objednavatel_zakaznik_id != null)
                {
                    return this.zakaznik_objednavatel_zakaznik_id.interni_nazev;
                }
                else
                {
                    return "";
                }
            }
        }

        public string ZakaznikNazev
        {
            get
            {
                if (this.zakaznik != null)
                {
                    return this.zakaznik.interni_nazev;
                }
                else
                {
                    return "";
                }
            }
        }

        public string Nabidka
        {
            get
            {
                if (this.nabidka_polozka != null)
                {
                    return this.nabidka_polozka.d_prijato.Value.ToString(DBHelper.FormatDatum);
                }
                else
                {
                    return "";
                }
            }
        }

        public string PlosnySpojSpecifikaceNazev
        {
            get
            {
                if (this.plosny_spoj_specifikace != null)
                {
                    return this.plosny_spoj_specifikace.nazev;
                }
                else
                {
                    return "";
                }
            }
        }

        public string PosledniPruvodka
        {
            get
            {
                if (this.pruvodka_pruvodka_id != null)
                {
                    return this.pruvodka_pruvodka_id.cislo;
                }
                else
                {
                    return "";
                }
            }
        }

    }
}

