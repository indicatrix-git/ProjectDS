using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class faktura_tpv_typ
    {
        public enum Value
        {
            PripravaDat = 1,
            FilmovePredlohy = 2,
            TPSita = 3,
            TPfrezovani = 4,
            TPVyroba = 5,
            PostovneABalne = 6
        }

        /// <summary>
        /// naparovani TPV (pausalu) s cenikem
        /// </summary>
        /// <param name="faktura_tpv_typ_id"></param>
        /// <returns></returns>
        public static cenik_polozka.Value CenikPolozka(int faktura_tpv_typ_id)
        {
            switch (((faktura_tpv_typ.Value)faktura_tpv_typ_id))
            {
                case Value.PripravaDat:
                    return cenik_polozka.Value.pripravaData;
                case Value.FilmovePredlohy:
                    return cenik_polozka.Value.filmovePredlohyNaVrstvu;
                case Value.TPSita:
                    return cenik_polozka.Value.PripravaSitotisk;
                case Value.TPfrezovani:
                    return cenik_polozka.Value.PripravaFrezovani;
                case Value.TPVyroba:
                    return cenik_polozka.Value.pripravaTPV;
                case Value.PostovneABalne:
                    return cenik_polozka.Value.postovneAbalne;
            }

            return cenik_polozka.Value.pripravaTPV;

        }
    }
}
