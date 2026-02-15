using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class cenik
    {

        public List<cenik_hodnota> GetCenikHodnota(pcb_develEntities dbcontext)
        {
            foreach (cenik_polozka cp in dbcontext.cenik_polozkas)
            {
                cenik_hodnota cenikhondnota = this.cenik_hodnotas.Where(i => i.cenik_polozka_id == cp.cenik_polozka_id).FirstOrDefault();
                if (cenikhondnota == null)
                {
                    cenik_hodnota ch = new cenik_hodnota();
                    ch.cenik_polozka = cp;
                    ch.cenik = this;
                    this.cenik_hodnotas.Add(ch);
                }
            }
            return this.cenik_hodnotas.ToList();
        }


        public List<cenik_vrsta_cu> GetCenikCu(pcb_develEntities dbcontext)
        {
            foreach (vrstva_cu vc in dbcontext.vrstva_cus)
            {
                cenik_vrsta_cu cenikVrstva = this.cenik_vrsta_cus.Where(i => i.vrstva_cu_id == vc.vrstva_cu_id).FirstOrDefault();
                if (cenikVrstva == null)
                {
                    cenik_vrsta_cu ch = new cenik_vrsta_cu();
                    ch.vrstva_cu_id = vc.vrstva_cu_id;
                    ch.cenik = this;
                    this.cenik_vrsta_cus.Add(ch);
                }
            }
            return this.cenik_vrsta_cus.ToList();
        }
    }
}
