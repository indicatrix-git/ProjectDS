using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class faktura_polozka
    {
        public decimal cenaCelkem
        {
            get
            {
                return (cena_ks ?? 0) * (pocet_ks ?? 0);
            }
        }

        public decimal SestavaCenaCelkem
        {
            get
            {
                if (this.faktura.zahranicni ?? false)
                {
                    return (this.cenaCelkem / (this.faktura.kurz ?? 1));
                }
                else
                {
                    return this.cenaCelkem;
                }
            }
        }

        public decimal SestavaCenaKs
        {
            get
            {
                if (this.faktura.zahranicni ?? false)
                {
                    return (this.cena_ks ?? 0) / (this.faktura.kurz ?? 1);
                }
                else
                {
                    return this.cena_ks ?? 0;
                }
            }
        }
     
    }
}
