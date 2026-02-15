using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class ObjednavkaGridRow
    {
        public string Zakaznik { get; set; }
        public string NazevDPS { get; set; }
        public int? PocetKs { get; set; }
        public int? TechnologPlusVyrobniPridavek { get; set; }
        public DateTime? TerminVyroby { get; set; }
        public DateTime? TerminExpedice { get; set; }
        public string DruhTerminu { get; set; }
        public string TypDesky { get; set; }
        public double? CisloPruvodky { get; set; }
        public string Expedice { get; set; }
        public ObjednavkaGridRow()
        {
            this.Expedice = "";
        }
    }
}
