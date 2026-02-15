using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class oddeleni
    {
        public enum Value { vyroba = 1, technologie=2, tpv = 3, obchod =4 }

        private bool vybrano;
        public bool Vybrano
        {
            set { vybrano = value; }
            get { return vybrano; }
        }

    }
}
