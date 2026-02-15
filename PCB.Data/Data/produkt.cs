using PCB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class produkt
    {
        public String produkt_typ
        {
            get
            {
                if (!this.sablona)
                {
                    return "DPS";
                }
                else
                {
                    return "Šablona";
                }
            }
        }

        public string ProduktStavNazev
        {
            get
            {
                return this.produkt_stav.nazev + ((this.zamek ?? false) ? " (zamčeno)" : "");
            }
        }

        // sestavi tlousku dle navolenych materialu (skladba desky)
        public decimal tlouskaDleMat
        {
            get
            {
                decimal tlouska = 0;
                foreach (vrstva v in this.vrstvas)
                {
                    tlouska = v.tloustka_mm ?? 0;
                }

                return tlouska;
            }
        }
        public int Revize
        {
            get
            {
                produkt_revize r = this.produkt_revizes.OrderByDescending(i => i.revize).FirstOrDefault();
                if (r != null)
                {
                    return r.revize;
                }
                else
                {
                    return 0;
                }
            }
        }

        public DateTime? RevizeDatum
        {
            get
            {

                produkt_revize r = this.produkt_revizes.OrderByDescending(i => i.d_zapsano).FirstOrDefault();
                if (r != null)
                {
                    return r.d_zapsano;
                }
                else
                {
                    return null;
                }
            }
        }

        public int? ProduktRevize
        {
            get
            {
                if (this.produkt_revizes.Count == 0)
                {
                    return null;
                }
                return this.produkt_revizes.OrderByDescending(i => Revize).First().produkt_revize_id;
            }
        }


        public bool Vybrano { get; set; }

        public String kodANazev
        {
            get
            {
                return this.nazev + " / " + this.kod;
            }
        }

        public string OznaceniFilmu
        {
            get
            {
                if (this.uzivatel_sestavil != null)
                {
                    return string.Format("P{0}C{1}B-{2}",
                        this.d_sestaveno.Value.Day.ToString().PadLeft(2, '0') + this.d_sestaveno.Value.Month.ToString().PadLeft(2, '0'),
                        this.d_sestaveno.Value.Year.ToString().Substring(2, 2),
                        this.uzivatel_sestavil.Inicialy);
                }
                else { return ""; }

            }
        }


        public String kodVypocitany
        {
            get
            {
                if (this.plosny_spoj_specifikace == null)
                {
                    return "";
                }

                string vysl = "";

                List<produkt_postup> ls = this.produkt_postups.OrderBy(i => i.poradi).ToList();
                foreach (produkt_postup postup in ls)
                {
                    vysl += postup.postup.kod;
                }

                return this.plosny_spoj_specifikace.kod + vysl;
            }
        }

        public List<string> KodSeznam
        {
            get
            {
                List<string> vysl = new List<string>();
                if (this.plosny_spoj_specifikace == null)
                {
                    return vysl;
                }
                else
                {
                    vysl.Add(this.plosny_spoj_specifikace.kod);
                }

                List<produkt_postup> ls = this.produkt_postups.OrderBy(i => i.poradi).ToList();
                foreach (produkt_postup postup in ls)
                {
                    vysl.Add(postup.postup.kod);
                }

                return vysl;
            }
        }



        public decimal? plocha
        {
            //v dm2
            get
            {
                decimal? x = cisty_rozmer_dps_x / 100;
                decimal? y = cisty_rozmer_dps_y / 100;
                return x * y;
            }
        }


        public int MaterialId
        {
            get
            {
                if (this.vrstvas.FirstOrDefault() == null)
                {
                    this.vrstvas.Add(new vrstva());
                }


                return this.vrstvas.First().material_id;
            }

            set
            {
                if (this.vrstvas.FirstOrDefault() == null)
                {
                    this.vrstvas.Add(new vrstva());
                }
                this.vrstvas.First().material_id = value;
            }
        }

        public DateTime? NaposledyVeVyrobe
        {
            get
            {
                objednavka_polozka objednavka_polozka = this.objednavka_polozkas
                    .Where(i => i.produkt_id == this.produkt_id).OrderByDescending(i => i.termin_vyroby).FirstOrDefault();

                if (objednavka_polozka == null)
                {
                    return null;
                }

                return objednavka_polozka.termin_vyroby;
            }
        }

        public string odberatelNazev
        {
            get
            {
                return zakaznik.nazev;
            }
        }

        public bool ViceVrstvaDeska
        {
            get
            {
                List<string> kody = new List<string>() { "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W4", "W6", "V1A", "V1B", "V1X", "V2A", "V2B", "V2X", "V3A", "V3B", "V3X" };

                return this.produkt_postups.Where(i => kody.Contains(i.postup.kod)).Count() > 0;
            }
        }

        public bool MASLAM_4V
        {
            get
            {
                List<string> kody = new List<string>() { "4A" };
                return this.produkt_postups.Where(i => kody.Contains(i.postup.kod)).Count() > 0;
            }
        }

        public bool ObsahujeKod(string strKod)
        {
            foreach (string s in strKod.Split(';'))
            {
                if (String.IsNullOrWhiteSpace(s))
                {
                    continue;
                }

                if (this.plosny_spoj_specifikace != null && this.plosny_spoj_specifikace.kod.Contains(s))
                {
                    return true;
                }

                if (this.produkt_postups.Where(i => i.postup.kod == s).Any())
                {
                    return true;
                }
            }

            return false;
        }

        public bool ObsahujeMaterial(string strKod)
        {
            int pocet = 0;
            foreach (string s in strKod.Split(';'))
            {
                if (s.Trim() != "")
                {
                    pocet += this.vrstvas.Where(i => i.material.nazev.ToUpper().Contains(s.ToUpper())).Count();
                }
            }
            return pocet > 0;
        }

        public int ObsahujeMaterialPocet(string strKod)
        {
            int pocet = 0;
            foreach (string s in strKod.Split(';'))
            {
                if (s.Trim() != "")
                {
                    pocet += this.vrstvas.Where(i => i.material.nazev.ToUpper().Contains(s.ToUpper())).Count();
                }
            }
            return pocet;
        }


        public bool ObsahujeVrstvuCu(string cu, decimal tl)
        {
            return this.vrstvas.Where(i => i.tloustka_mm == tl && i.vrstva_cu.nazev == cu).Count() > 0;

        }

        public bool MASLAM
        {
            get
            {
                List<string> kody = new List<string>() { "4A", "6A", "8A", "10A", "12A" };
                return this.produkt_postups.Where(i => kody.Contains(i.postup.kod)).Count() > 0;
            }
        }


        private List<operace> seznamOperaci;
        public List<operace> SeznamOperaci
        {
            get
            {
                return seznamOperaci;
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

        public decimal? OstrihPoVrtaniRorzmerX
        {
            get
            {

                if (this.ObsahujeKod("4B;6A;6B;8A;8B;10A;10B;12A;12B"))
                {
                    return Math.Ceiling(this.cisty_panel_x.Value + 50);
                }

                return null;

            }

        }

        public decimal? OstrihPoVrtaniRorzmerY
        {
            get
            {

                if (this.ObsahujeKod("4B;6A;6B;8A;8B;10A;10B;12A;12B"))
                {
                    return Math.Ceiling(this.cisty_panel_y.Value + 50);
                }

                return null;

            }
        }



        public string RevizeProPruvodku
        {
            get
            {
                string s = "";
                foreach (produkt_revize pr in this.produkt_revizes.OrderBy(i => i.d_zapsano))
                {
                    s += pr.revize + " - " + pr.poznamka + " - " + pr.d_zapsano.ToString(DBHelper.FormatDatum) + " - " + pr.uzivatel.celeJmeno + "\n";
                }

                return s;
            }
        }

        public produkt KopieZProduktu
        {
            get;
            set;
        }


    }
}
