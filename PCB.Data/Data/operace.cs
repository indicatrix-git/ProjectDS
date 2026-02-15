using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class operace
    {
        public bool Vybrano { get; set; }

        public string KodNazev
        {
            get { return this.kod + " " + this.nazev; }
        }

        public string Popisek { get; set; }

        public string Poznamka { get; set; }
    }
}
