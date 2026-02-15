using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class CTermin
    {
        public DateTime Datum { get; set; }
        public int Hodiny { get; set; }
        public int MaxHodiny { get; set; }
        public bool IsVikend { get; set; }

        public CTermin(DateTime datum, int hodiny, int maxHodin)
        {
            Datum = datum;
            Hodiny = hodiny;
            MaxHodiny = maxHodin;
        }

        public CTermin(DateTime datum, bool isVikend = false)
        {
            Datum = datum;
            IsVikend = isVikend;
        }
    }
}
