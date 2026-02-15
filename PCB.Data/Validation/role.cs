using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using PCB.Data.Validation;

namespace pcb_develModel 
{
    public partial class role : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            //kontakt Kontakt = (kontakt)validationContext.ObjectInstance;

            if (string.IsNullOrEmpty(this.jmeno))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Název")));
            }
            return ls;
        }
    }
}
