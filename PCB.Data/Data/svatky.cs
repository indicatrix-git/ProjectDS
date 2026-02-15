using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCB;
using PCB.Data;

namespace pcb_develModel
{
    public partial class svatky
    {
        public pcb_develEntities DBContext { get; set; }
        public List<svatky> Svatky { get; set; }
        public svatky() { }
        public svatky(pcb_develEntities dbContext)
        {
            DBContext = dbContext;
            nactiSvatky();
        }

        private void nactiSvatky()
        {
            List<svatky> svatky = DBContext.svatkies.ToList();
            foreach(svatky s in svatky)
            {
                s.datum.AddYears(PCB.Data.DBHelper.DateTimeNow().Year - s.datum.Year);
            }
            svatky sv = new svatky();
            sv.datum = vypocitejVelikonoce();
            svatky.Add(sv);

            Svatky = svatky;
        }

        private DateTime vypocitejVelikonoce()
        {
            int rok = PCB.Data.DBHelper.DateTimeNow().Year;
            int a = rok % 19; //po 19 letech se měsíční cyklus opakuje ve stejné dny
            int b = rok % 4; //cyklus opakování přestupných roků
            int c = rok % 7; //dorovnání dne v týdnu

            //Pro 20. a 21. století platí konstanty:
            int m = 24;
            int n = 5;

            var d = (19 * a + m) % 30;
            var e = (n + 2 * b + 4 * c + 6 * d) % 7;

            var u = d + e - 9;
            int v = 0;
            if (u == 25 && d == 28 && e == 6 && a > 10)
            {
                u = 18;
                v = 4;
            }
            else if ( u >= 1 && u <= 25)
            {
                v = 4;
            }
            else if(u > 25)
            {
                u = u - 7;
                v = 4;
            }
            else
            {
                u = 22 + d + e;
                v = 3;
            }
            DateTime velikonoce = new DateTime(rok, v, u).AddDays(1);
            return velikonoce;
        }
    }
}
