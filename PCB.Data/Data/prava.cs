using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class prava
    {
        public enum Value
        {
            ObchodZakaznik = 1,
            ObchodNabidky= 2,
            ObchodObjednavky = 3,
            ObchodFakturace = 4,
            ObchodKapacita = 5,
            ObchodCenik = 6,
            TPVObjednavky = 7,
            TPVTechnickaDokumentace = 8,
            TPVNabidky = 9,
            VyrobaPruvodky = 10,
            VyrobaOdepisovani = 11,
            VyrobaObjednavky = 12,
            AdministraceUzivatelskaPrava = 13,
            AdministraceUzivatelskeRole = 14,
            TechnologieTechnickaDokumentace = 15,
            TechnologieNabidky = 16,
            TechnologieObjednavky = 17,
            TechnologieOperace = 18,
            TechnologieNavodky = 19,
            TechnologieTechnologickeRady = 20,
            PripravarDavekAFilmuObjednavky = 21,
            PripravarDatProTestovani = 22
        }
    }
}
