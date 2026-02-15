using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class stav_objednavka
    {
        public enum Value
        {
            ZalozenaPredanoDoTPV = 1,
            PredanoTechnologie = 2,
            PredanoDoobchodu = 3,
            SpustenaDoVyroby = 4,
            pozastaveno = 5,
            stornovano = 6,
            dokonceno = 7
        }
    }
}
