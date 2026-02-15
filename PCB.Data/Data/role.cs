using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class role
    {
        public const int ADMINISTRATOR = 1;
        public const int FOXPRO_SYSTEM = 2;

        public List<prava_role> GetPravaRole(pcb_develEntities dbcontext)
        {
            foreach (prava p in dbcontext.pravas)
            {
                prava_role pravaRole = this.prava_roles.Where(i => i.prava_id == p.prava_id).FirstOrDefault();
                if (pravaRole == null)
                {
                    prava_role pravaRoleNew = new prava_role();
                    pravaRoleNew.prava = p;
                    pravaRoleNew.role = this;
                    pravaRoleNew.prava_hodnota = dbcontext.prava_hodnotas.Where(i => i.prava_hodnota_id == (int)prava_hodnota.Value.zadne).FirstOrDefault();
                    this.prava_roles.Add(pravaRoleNew);
                }
            }
            return this.prava_roles.ToList();
        }        
    }
}
