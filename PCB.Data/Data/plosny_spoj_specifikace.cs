using PCB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class plosny_spoj_specifikace
    {

        public enum Value
        {
            bez = 1,
            SablonaleptanaS = 2,
            SablonalaserovanaSN = 3,
            FlexiDPSjednostrannabezpodlepuE1 = 4,
            FlexiDPSoboustrannabezpodlepuE2 = 5,
            ZakladjednostranneDPSJ = 6,
            ZakladjednostranneDPSnevrtaneJ0 = 7,
            ThermalcladJ1 = 8,
            ZakladoboustranneDPSO = 9,
            ZakladoboustanneDPSneprokovenneN = 10,
            Zaklad4vrstveDPSMASLAM4A = 11,
            Zaklad6vrstveDPSMASLAM6A = 12,
            Zaklad8vrstveDPSMASLAM8A = 13,
            Zaklad10vrstveDPSMASLAM10A = 14,
            Zaklad12vrstveDPSMASLAM12A = 15,
            Zaklad4vrstveDPSNEMASLAM4B = 16,
            Zaklad6vrstveDPSNEMASLAM6B = 17,
            Zaklad8vrstveDPSNEMASLAM8B = 18,
            Zaklad10vrstveDPSNEMASLAM10B = 19,
            Zaklad12vrstveDPSNEMASLAM12B = 20,
            vrstvaDPSFLEXRIGIDW2 = 21,
            vrstvaDPSFLEXRIGIDW4 = 22,
            vrstvaDPSFLEXRIGIDW6 = 23,
            vrstvaDPSFLEXRIGIDW1 = 24
        }

        public string KodNazev
        {
            get
            {
                return this.kod + " " + this.nazev;
            }
        }

        public int PocetVrstva
        {
            get
            {
                return this.koeficient;
            }
        }

        public int OptimalniPlocha
        {
            get
            {
                if (this.PocetVrstva == 1 || this.PocetVrstva == 2)
                {
                    return 250;
                }

                if (this.PocetVrstva > 2)
                {
                    return 200;
                }

                return 200;
            }
        }


        private DateTime checkDatum(DateTime dt, pcb_develEntities db)
        {

            int pridat = 0;
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                pridat++;
            }

            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                pridat++;
                pridat++;
            }

            if (db.svatkies.ToList().Where(item => item.datum.ToString("yyyy-MM-dd") == dt.ToString("yyyy-MM-dd")).Count() == 1)
            {
                pridat++;
            }

            if (pridat == 0)
            {
                return dt;
            }

            return checkDatum(dt.AddDays(pridat), db
);

        }

        /// <summary>
        /// konstanty dodani podle terminu
        /// </summary>
        /// <param name="termin"></param>
        /// <returns></returns>
        public DateTime DatumDodani(int termin_id, pcb_develEntities db)
        {
            int pocet = 0;
            if ((int)termin_id == (int)termin_typ.Value.normal || (int)termin_id == (int)termin_typ.Value.technologicka)
            {

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.bez)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.SablonalaserovanaSN)
                {
                    pocet = 4;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.SablonaleptanaS)
                {
                    pocet = 4;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN)
                {
                    pocet = 12;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad4vrstveDPSMASLAM4A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad4vrstveDPSNEMASLAM4B)
                {
                    pocet = 15;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad6vrstveDPSMASLAM6A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad6vrstveDPSNEMASLAM6B)
                {
                    pocet = 20;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad8vrstveDPSMASLAM8A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad8vrstveDPSNEMASLAM8B)
                {
                    pocet = 24;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad10vrstveDPSMASLAM10A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad10vrstveDPSNEMASLAM10B)
                {
                    pocet = 24;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad12vrstveDPSMASLAM12A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad12vrstveDPSNEMASLAM12B)
                {
                    pocet = 24;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW1)
                {
                    pocet = 20;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW2)
                {
                    pocet = 20;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW4)
                {
                    pocet = 20;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW6)
                {
                    pocet = 20;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.FlexiDPSjednostrannabezpodlepuE1)
                {
                    pocet = 15;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.FlexiDPSoboustrannabezpodlepuE2)
                {
                    pocet = 15;
                }
            }

            if ((int)termin_id == (int)termin_typ.Value.express || (int)termin_id == (int)termin_typ.Value.ihned)
            {

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.bez)
                {
                    pocet = 3;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.SablonalaserovanaSN)
                {
                    pocet = 1;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.SablonaleptanaS)
                {
                    pocet = 1;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0)
                {
                    pocet = 3;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN)
                {
                    pocet = 4;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad4vrstveDPSMASLAM4A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad4vrstveDPSNEMASLAM4B)
                {
                    pocet = 5;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad6vrstveDPSMASLAM6A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad6vrstveDPSNEMASLAM6B)
                {
                    pocet = 7;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad8vrstveDPSMASLAM8A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad8vrstveDPSNEMASLAM8B)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad10vrstveDPSMASLAM10A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad10vrstveDPSNEMASLAM10B)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad12vrstveDPSMASLAM12A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad12vrstveDPSNEMASLAM12B)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW1)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW2)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW4)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW6)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.FlexiDPSjednostrannabezpodlepuE1)
                {
                    pocet = 5;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.FlexiDPSoboustrannabezpodlepuE2)
                {
                    pocet = 5;
                }
            }

            if ((int)termin_id == (int)termin_typ.Value.poloexpres)
            {
                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.bez)
                {
                    pocet = 7;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.SablonalaserovanaSN)
                {
                    pocet = 2;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.SablonaleptanaS)
                {
                    pocet = 7;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0)
                {
                    pocet = 8;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad4vrstveDPSMASLAM4A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad4vrstveDPSNEMASLAM4B)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad6vrstveDPSMASLAM6A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad6vrstveDPSNEMASLAM6B)
                {
                    pocet = 12;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad8vrstveDPSMASLAM8A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad8vrstveDPSNEMASLAM8B)
                {
                    pocet = 15;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad10vrstveDPSMASLAM10A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad10vrstveDPSNEMASLAM10B)
                {
                    pocet = 15;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad12vrstveDPSMASLAM12A || this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.Zaklad12vrstveDPSNEMASLAM12B)
                {
                    pocet = 15;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW1)
                {
                    pocet = 12;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW2)
                {
                    pocet = 12;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW4)
                {
                    pocet = 12;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.vrstvaDPSFLEXRIGIDW6)
                {
                    pocet = 12;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.FlexiDPSjednostrannabezpodlepuE1)
                {
                    pocet = 10;
                }
                else if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.FlexiDPSoboustrannabezpodlepuE2)
                {
                    pocet = 10;
                }

            }

            // dopocita skutecny mozny pocet, navysi o vikendy a svatky
            DateTime now = DBHelper.DateTimeNow();

            int pocetPracDni = 0;
            int pocetCelkDni = 0;
            while(pocetPracDni != pocet)
            {
                pocetCelkDni++;

                DateTime d = now.AddDays(pocetCelkDni);

                if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday || db.svatkies.ToList().Where(item => item.datum.ToString("yyyy-MM-dd") == d.ToString("yyyy-MM-dd")).Count() == 1)
                {
                    //vysl++;
                } 
                else
                {
                    pocetPracDni++;
                }
            }

            return checkDatum(now.AddDays(pocetCelkDni), db);
        }


        public decimal PridavekPlochy
        {
            get
            {
                if (this.PocetVrstva > 6)
                {
                    return 25 * 25;
                }

                if (this.PocetVrstva > 6)
                {
                    return 50 * 50;
                }

                if (this.PocetVrstva == 4)
                {
                    return 25 * 25;
                }

                return 0;
            }
        }

        public static int getNormaNaDen(bool terminStandart, int pocetVrstev)
        {
            if (terminStandart)
            {
                if (pocetVrstev == 1)
                {
                    return 600;
                }
                else
                    if (pocetVrstev == 2)
                {
                    return 1050;
                }
                else // vice vrstve
                {
                    return 450;
                }
            }
            else
            {
                if (pocetVrstev == 1)
                {
                    return 650;
                }
                else
                    if (pocetVrstev == 2)
                {
                    return 1100;
                }
                else // vice vrstve
                {
                    return 500;
                }
            }
        }



        /// <summary>
        /// denni norma
        /// </summary>
        /// <param name="termin_id">druh terminu st. ex, poloex</param>
        /// <returns>v dm2</returns>
        public int getNorma(int termin_id)
        {
            if ((int)termin_id == (int)termin_typ.Value.normal)
            {
                if (this.koeficient == 1)
                {
                    return 600;
                }
                else
                    if (koeficient == 2)
                {
                    return 1050;
                }
                else // vice vrstve
                {
                    return 450;
                }
            }
            else
            {
                if (this.koeficient == 1)
                {
                    return 650;
                }
                else
                    if (koeficient == 2)
                {
                    return 1100;
                }
                else // vice vrstve
                {
                    return 500;
                }
            }
        }


    }
}

