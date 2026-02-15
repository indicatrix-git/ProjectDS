using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class nabidkaCenikRadka
    {
        termin_typ terminTyp { get; set; }
        int col01 { get; set; }
        int col02 { get; set; }
        int col03 { get; set; }
        int col04 { get; set; }
        int col05 { get; set; }

        public string Nazev {
        
            get
            {
                return terminTyp.nazev;
            }
        }


        public static List<nabidkaCenikRadka> GetData(pcb_develEntities dbContext)
        {
            List<nabidkaCenikRadka> ls = new List<nabidkaCenikRadka>();
            ls.Add(new nabidkaCenikRadka(){terminTyp = dbContext.termin_typs.Where(i=>i.termin_typ_id == 1).First()});
            ls.Add(new nabidkaCenikRadka(){terminTyp = dbContext.termin_typs.Where(i=>i.termin_typ_id == 2).First()});
            ls.Add(new nabidkaCenikRadka(){terminTyp = dbContext.termin_typs.Where(i=>i.termin_typ_id == 3).First()});

            return ls;
        }


    }
}


