using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCB.Data.Validation;
using System.ComponentModel.DataAnnotations;
using PCB.Data.CustomObjects;

namespace pcb_develModel
{
    public partial class objednavka_polozka : IValidatableObject
    {
        private List<KontrolaItem> hlaskyZKontroly;
        public List<KontrolaItem> HlaskyZKontroly
        {
            get
            {
                return hlaskyZKontroly;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            if (this.majitel_zakaznik_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Zákazník")));
            }
            
            if (this.cenik_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Ceník")));
            }

            if (this.plosny_spoj_druh_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Typ výroby")));
                return ls;
            }

            if (this.pozadovano_pocet == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Požadovaný počet")));
            }

            //if (this.produkt_id == null && this.plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
            //{
            //    ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Produkt")));
            //}


            if (this.termin_vyroby == null  && this.plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Termín výroby")));
            }

            if (this.termin_typ_id == null && this.plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Druh termínu")));
            }
                        
            if (this.produkt_id == null && this.plosny_spoj_specifikace_id == null && this.plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Plošný spoj")));
            }

            return ls;
        }

        private void hlaska(string s, string level)
        {
            KontrolaItem item = new KontrolaItem();
            item.Text = s;
            item.Level = level;
            
            if (level.Contains("F"))
            {
                item.Fatalni = true;
            }

            if (level.Contains("P"))
            {
                item.Propustna = true;
            }


            this.hlaskyZKontroly.Add(item);
        }

        public void SestavKontroly()
        {
            this.hlaskyZKontroly = new List<KontrolaItem>();
            // nove kontroly pro objednavka

            if (this.produkt.ObsahujeKod("SA;SB;SX;") && this.plosny_spoj_druh_id == (int)plosny_spoj_druh.Value.NovyTypSpoje) // nový produkt 
            {
                hlaska("Nutno zadata jeden přířez navíc.","P");
            }

            if (this.produkt.slepe_vrtani_typ != null) 
            {
                hlaska("Jsou vytvořeny krycí filmy fotorezistu?","P");
            }

            if (this.produkt.plosny_spoj_specifikace.PocetVrstva >= 4) 
            {
                hlaska("Není nutno předělat dokumentaci na INSPECTA?","P");
            }

        }

        
    }
}
