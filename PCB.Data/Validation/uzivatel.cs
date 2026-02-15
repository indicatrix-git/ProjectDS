using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using PCB.Data.Validation;

namespace pcb_develModel
{
    partial class uzivatel : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            uzivatel Uzivatel = (uzivatel)validationContext.ObjectInstance;

            if (string.IsNullOrEmpty(Uzivatel.osobni_cislo))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Osobní číslo")));
            }
            if (string.IsNullOrEmpty(Uzivatel.jmeno))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Jméno")));
            }
            if (string.IsNullOrEmpty(Uzivatel.prijmeni))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Příjmení")));
            }
            if (Uzivatel.role_id == 0)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Role")));
            }
            if (string.IsNullOrEmpty(Uzivatel.emial))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.chybaEmail, "Email")));
            }
                        
            return ls;

        }
    }
}
