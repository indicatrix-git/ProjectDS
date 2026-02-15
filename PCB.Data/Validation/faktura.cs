using PCB.Data.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace pcb_develModel
{
    public partial class faktura : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                List<ValidationResult> ls = new List<ValidationResult>();

                if (this.doprava_id == 0)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Doprava")));
                }

                if (!this.zakaznik_id.HasValue || this.zakaznik_id == 0)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Zákazník")));
                }

                if (this.uhrada_typ_id == 0)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Úhrada")));
                }

               /* if (this.cislo == null)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Objednávka")));
                }
                 
                */
 
                return ls;
            }
    }
}

