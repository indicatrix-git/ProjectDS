using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class material
    {
        public bool NestandartniMaterial
        {
            get
            {
                return true;
            }
        }

        public string PoradiProTabulku
        {
            get
            {
                return this.material_typ.poradi.ToString().PadLeft(4, '0')  + this.poradi.ToString().PadLeft(4, '0');
            }
        }

        public string Typ
        {
            get
            {
                return this.material_typ.poradi.ToString().PadLeft(4, '0') + " " + this.material_typ.nazev;
            }
        }
    }
}
