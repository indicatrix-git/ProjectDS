using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using PCB.Data.Validation;

namespace pcb_develModel
{
    public partial class zakaznik : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            //zakaznik Zakaznik = (zakaznik)validationContext.ObjectInstance;

            if (string.IsNullOrEmpty(nazev))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Název")));
            }

            if (string.IsNullOrEmpty(interni_nazev))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Interní název")));
            }

            foreach(var sazba in this.zakaznik_cenik_polozkas)
            {
                if (sazba.cenik_polozka_id == 0)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Sazby zákazníka - Název")));
                    break;
                }
            }

            foreach(var sleva in this.zakaznik_termin_slevas)
            {
                if (!sleva.termin_typ_id.HasValue || sleva.termin_typ_id == 0)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Přirážka / Sleva - Termín")));
                }

                if (!sleva.plosny_spoj_specifikace_typ_id.HasValue || sleva.plosny_spoj_specifikace_typ_id == 0)
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Přirážka / Sleva - Typ desky")));
                    break;
                }
            }

            return ls;
        }
    }
}
