using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class produkt_poznamka
    {

        public string OperaceNazev
        {
            get
            {
                if (this.operace != null)
                {
                    return this.operace.nazev;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
