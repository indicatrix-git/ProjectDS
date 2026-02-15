using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class zakaznik
    {
        public string Posta { get { return (this.psc + " " + this.misto); } }
        public int Splatnost
        {
            get
            {
                int pocetDni = 14;

                if ((this.splatnost_pocet_dni ?? 0) > 0)
                {

                    pocetDni = int.Parse(this.splatnost_pocet_dni.ToString());
                }
                return pocetDni;
            }

        }
    }
}
