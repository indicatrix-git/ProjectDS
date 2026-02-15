using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class CenikRadka
    {

        public cenik_polozka Polozka { get; set; }

        public decimal Pocet { get; set; }
        public decimal Sazba { get; set; }
        public decimal Cena { get; set; }
        public string Jednotka { get; set; }
        public string Nazev { get; set; }


        public int SouradniceX { get; set; }
        public int SouradniceY { get; set; }

        public decimal pouzitaPlocha { get; set; }
        public decimal pouzityObvod { get; set; }

        public bool pausal { get; set; }
        public bool naKus { get; set; }

        public bool pocitaSplochou { get; set; }
        public bool pocitaSobvodem { get; set; }

        public bool typovaCena { get; set; }
        public bool MaterialCena { get; set; }

        public bool info { get; set; }
        public int Poradi { get; set; }


        public decimal GetSazba(EntityObject o)
        {
            if (o is nabidka_polozka)
            {
                // pretizeni u zakaznika
                zakaznik_cenik_polozka polozka = ((nabidka_polozka)o).zakaznik.zakaznik_cenik_polozkas.Where(item => item.cenik_polozka_id == this.Polozka.cenik_polozka_id).FirstOrDefault();
                if (polozka != null)
                {
                    return polozka.hodnota ?? 0;
                }

                // defualt standartni cenik pro ostatni
                cenik_hodnota hodnota = ((nabidka_polozka)o).cenik.cenik_hodnotas.Where(item => item.cenik_polozka_id == this.Polozka.cenik_polozka_id).FirstOrDefault();
                if (hodnota == null)
                {
                    return 0;
                }
                else
                {
                    return hodnota.hodnota;
                }
            }
            else
            {
                // pretizeni u zakaznika
                zakaznik_cenik_polozka polozka = ((objednavka_polozka)o).zakaznik.zakaznik_cenik_polozkas.Where(item => item.cenik_polozka_id == this.Polozka.cenik_polozka_id).FirstOrDefault();
                if (polozka != null)
                {
                    return polozka.hodnota ?? 0;
                }

                // defualt standartni cenik pro ostatni
                cenik_hodnota hodnota = ((objednavka_polozka)o).cenik.cenik_hodnotas.Where(item => item.cenik_polozka_id == this.Polozka.cenik_polozka_id).FirstOrDefault();
                if (hodnota == null)
                {
                    return 0;
                }
                else
                {
                    return hodnota.hodnota;
                }
            }
        }

    }
}
