using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class zakaznik
    {
        public string GetPoznamkyTPV()
        {
            string poznamkaTPV = "";
            List<poznamka> listTpv = this.poznamkas.Where(i => i.poznamka_typ_id == 1 && i.oddeleni_id == (int)oddeleni.Value.tpv).ToList();
            foreach (poznamka p in listTpv)
            {
                poznamkaTPV += p.obsah + "<br /> <hr />";
            }

            return poznamkaTPV;
        }

        public string GetPoznamkyObchod()
        {
            string poznamka = "";
            List<poznamka> listObchod = this.poznamkas.Where(i => i.poznamka_typ_id == 1 && i.oddeleni_id == (int)oddeleni.Value.obchod).ToList();
            foreach (poznamka p in listObchod)
            {
                poznamka += p.obsah + "<br /> <hr />";
            }

            return poznamka;
        }

       

    }

}
