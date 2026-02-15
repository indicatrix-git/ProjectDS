using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using PCB.Data.Validation;
using System.Text.RegularExpressions;

namespace pcb_develModel
{
    public partial class kontakt : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            //kontakt Kontakt = (kontakt)validationContext.ObjectInstance;

            if (this.oddeleni_id == 0)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Oddělení")));
            }

            if (string.IsNullOrEmpty(this.jmeno))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Jméno")));
            }

            if (!string.IsNullOrEmpty(this.email))
            {
                if (!IsEmailValid(this.email))
                {
                    ls.Add(new ValidationResult(string.Format(Hlasky.chybaEmail, "Email")));
                }

            }

            return ls;
        }

        public static bool IsEmailValid(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email ?? "");
            if (match.Success)
                return true;
            else
                return false;


        }
    }
}
