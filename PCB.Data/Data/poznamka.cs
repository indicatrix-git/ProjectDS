using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class poznamka
    {
        public string CeleJmeno
        {
            get
            {
                if (this.uzivatel != null)
                {
                    return this.uzivatel.celeJmeno;
                }
                return "";
            }
        }
    }
}
