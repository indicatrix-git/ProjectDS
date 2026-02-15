using DevExpress.XtraNavBar;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PCB.Gui
{
    public class btnNavBar : NavBarItem
    {

        public string puvodniJmeno { get; set; }

        private List<prava.Value> _prava;
        public List<prava.Value> Prava
        {
            get
            {
                return _prava;
            }

            set
            {
                _prava = value;
            }
        }

        private List<int> _nabidkaStav;
        public List<int> NabidkaStav
        {
            get
            {
                return _nabidkaStav;
            }

            set
            {
                _nabidkaStav = value;
            }
        }

        private List<int> _objednavkaStav;
        public List<int> ObjednavkaStav
        {
            get
            {
                return _objednavkaStav;
            }

            set
            {
                _objednavkaStav = value;
            }
        }


        public void Check(int uzivatelId)
        {
            pcb_develEntities db = new pcb_develEntities();
            uzivatel uziv = db.uzivatels.Where(item => item.uzivatel_id == uzivatelId).First();
            

            if (this.Prava != null)
            {
                int pocet = 0;
                foreach (prava.Value pravo in this.Prava)
                {

                    if ((int)uziv.HasPravo(pravo) > (int)prava_hodnota.Value.zadne)
                    {
                        pocet += 1;
                    }
                }
                this.Visible = (pocet > 0);
            }
            else
            {
                 this.Visible = false;
            }
        }

     public void Pocitej(pcb_develEntities dbContext)
     {
         int pocet = 0;
         if (this.NabidkaStav != null)
         {
             foreach (int item in this.NabidkaStav)
             {
                 pocet += dbContext.nabidka_polozkas.Where(i => i.nabidka_stav_id.Value == item).Count();
             }
             this.Caption = string.Format(this.Caption, pocet.ToString());
         }

         if (this.ObjednavkaStav != null)
         {
             foreach (int item in this.ObjednavkaStav)
             {
                 pocet += dbContext.objednavka_polozkas.Where(i => i.stav_objednavka_id.Value == item).Count();
             }

             this.Caption = string.Format(this.Caption, pocet.ToString());
         }

         
     }

    }
}
