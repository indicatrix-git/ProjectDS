using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class KontrolaItem
    {

       /// <summary>
       /// Neslo by vyrobit
       /// </summary>
        public bool Fatalni { get; set;}

        public bool Tiskova { get; set;}


        /// <summary>
        /// chyba, muze byt povolena technologem/TPV (SP atd)
        /// </summary>
        public bool Propustna { get; set;}
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }


        /// <summary>
        /// Text zprávy na obrazovku
        /// </summary>
        public string Text { get; set;}

        /// <summary>
        /// Level chyby vsechny v textu
        /// </summary>
        public string Level { get; set; }

    }
}
