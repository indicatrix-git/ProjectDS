using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class CenikContext
    {
        public decimal rozmerX;
        public decimal rozmerY;
        public decimal rozmerPanelX;
        public decimal rozmerPanelY;
        public plosny_spoj_specifikace plosnySpojSpecifikace;
        public int kostrukcniTrida;
        public zakaznik zakaznik;
        public string nazevDPS;
        public decimal sleva;


        public pcb_develModel.cenik Cenik;
        
        public decimal Plocha
        {
            get
            {

                return (this.rozmerX * this.rozmerY);
            }
        }

        public decimal PlochaZakazky
        {
            get
            {
                return (this.rozmerX * this.rozmerY)*pocetKs;
            }
        }


        public int pocetKs;
        public termin_typ termin;
        public List<vrstva> lsVrstva;
        public List<CenikRadka> lsCenikRadka;

              
        public pcb_develEntities dbContext;

    }
}
