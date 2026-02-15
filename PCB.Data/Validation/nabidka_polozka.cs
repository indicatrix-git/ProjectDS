using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCB.Data.Validation;
using System.ComponentModel.DataAnnotations;

namespace pcb_develModel
{
    public partial class nabidka_polozka : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();

            if (String.IsNullOrEmpty(this.nazev_dps))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Název DPS")));
            }

            if (this.vrstvas.Count==0)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Skladba desky")));
            }

            if (this.priorita == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Priorita")));
            }

            if (this.konstrukcni_trida == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Konstrukční třída")));
            }

            if (this.cenik_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Ceník")));
            }

            if (this.priorita_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Priorita")));
            }

            if (this.rozmer_panel_x == null && this.rozmer_panel_y == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Čistý rozměr panelu")));
            }

            if (this.rozmer_dps_x == null && this.rozmer_dps_y == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Čistý rozměr DPS")));
            }

            if (this.plosny_spoj_druh_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Typ výroby")));
            }

            return ls;
        }
    }
}
