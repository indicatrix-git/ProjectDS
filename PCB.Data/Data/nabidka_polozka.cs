using PCB.Data;
using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class nabidka_polozka
    {
        public DataTable CenovaTabulka { get; set; }
        public string CenaFilmovePredlohy
        {
            get
            {
                return this.cena_filmove_podklady.HasValue ? this.cena_filmove_podklady.Value.ToString("N0") : this.cenik.cenik_hodnotas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).FirstOrDefault() == null ? "" : this.cenik.cenik_hodnotas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).FirstOrDefault().hodnota.ToString("N0")/* + ",-"*/;
            }

            set
            {
                decimal tmpDec;

                if (Decimal.TryParse((value ?? "").ToString(), out tmpDec))
                {
                    this.cena_filmove_podklady = tmpDec;
                }
                else
                {
                    this.cena_filmove_podklady = null;
                }
            }
        }
        public string CenaPripravaFrezovani
        {
            get
            {
                return this.cena_priprava_frezovani.HasValue ? this.cena_priprava_frezovani.Value.ToString("N0") : this.cenik.cenik_hodnotas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaFrezovani).FirstOrDefault() == null ? "" : this.cenik.cenik_hodnotas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaFrezovani).FirstOrDefault().hodnota.ToString("N0")/*  + ",-"*/;
            }

            set
            {
                decimal tmpDec;

                if (Decimal.TryParse((value ?? "").ToString(), out tmpDec))
                {
                    this.cena_priprava_frezovani = tmpDec;
                }
                else
                {
                    this.cena_priprava_frezovani = null;
                }
            }

        }
        public string CenaPripravaSitoTisku
        {
            get
            {
                return this.cena_priprava_sitotisk.HasValue ? this.cena_priprava_sitotisk.Value.ToString("N0") : this.cenik.cenik_hodnotas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSitotisk).FirstOrDefault() == null ? "" : this.cenik.cenik_hodnotas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSitotisk).FirstOrDefault().hodnota.ToString("N0") /*+ ",-"*/;
            }
            set
            {
                decimal tmpDec;

                if (Decimal.TryParse((value ?? "").ToString(), out tmpDec))
                {
                    this.cena_priprava_sitotisk = tmpDec;
                }
                else
                {
                    this.cena_priprava_sitotisk = null;
                }
            }
        }
        public string Sestaveno { get { return this.d_sestaveno.Value.ToString(DBHelper.FormatDatum); } }

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
                    return this.nazev_dps;
                }
            }
        }


    }
}
