using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class TPVGridRow
    {
        public int? TypVyrobyId { get; set; }
        public string TypVyrobyNazev { get; set; }
        public int? DruhTerminuId { get; set; }
        public string DruhTerminuNazev { get; set; }
        public string Kod { get; set; }
        public int? SestavilId { get; set; }
        public string Sestavil { get; set; }
        public bool ProblemovaData { get; set; }
        public int? ZakaznikId {get; set; }
        public string ZakaznikNazev { get; set; }
        public int? TypDeskyId { get; set; }
        public string TypDeskyNazev { get; set; }
    }
}
