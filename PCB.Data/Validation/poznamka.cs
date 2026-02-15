using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using PCB.Data.Validation;

namespace pcb_develModel 
{
    public partial class poznamka: IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            //kontakt Kontakt = (kontakt)validationContext.ObjectInstance;

            if (this.oddeleni_id == 0)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Oddělení")));
            }

            if (this.poznamka_typ_id == 0)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Typ poznámky")));
            }

            if (string.IsNullOrEmpty(this.nadpis))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Nadpis")));
            }
            return ls;
        }
    }
}
