using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class motivy
    {
        public int tl_Cu { get; set; }
        public decimal min_spoj { get; set; }
        public decimal min_izolacni_mezera { get; set; }
        public decimal min_mezikruzi { get; set; }
        
        public static int mez(string vrstva_cu)
        {
            if (!vrstva_cu.Contains('/'))
            {
                return int.Parse(vrstva_cu);
            }

            int cislo1 = int.Parse(vrstva_cu.Split('/')[0]);
            int cislo2 = int.Parse(vrstva_cu.Split('/')[1]);

            if (cislo1 < cislo2)
            {
                return cislo2;
            }
            else
            {
                return cislo1;
            }

        }


    }
}
