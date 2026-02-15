using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class KapacitaRow
    {
        public DateTime Datum { get; set; }

        public string Den { 
            get
            {
                return DateTimeFormatInfo.CurrentInfo.GetDayName(this.Datum.DayOfWeek).Substring(0,2).ToUpper();
            }
        }

        public decimal Jednostranky { get; set; }
        public decimal JednostrankyProcento { get; set; }
        
        public decimal Oboustranky { get; set; }
        public decimal OboustrankyProcento { get; set; }

        public decimal Vicevrstve { get; set; }
        public decimal VicevrstveProcento { get; set; }

        /// <summary>
        /// Procento
        /// </summary>
        public decimal Zabrano { get; set; }

        /// <summary>
        /// Procento
        /// </summary>
        public decimal Zbyva { get; set; }
                
        public decimal Plocha { get; set; }

        


        public static List<KapacitaRow> LoadDataPlanovani(pcb_develEntities dbContext, DateTime odObdobi, plosny_spoj_specifikace typSpoje,  termin_typ terminTyp)
        {
            DateTime dt = typSpoje.DatumDodani(terminTyp.termin_typ_id, dbContext);

            TimeSpan pocetDnu = (DBHelper.DateTimeNow() - dt);

            
            List<KapacitaRow> ls = new List<KapacitaRow>();

            for (int i = 0; i < Math.Abs(pocetDnu.Days) + 10; i++)
            {
                decimal denniPlocha = 0;

                string strSQLJeden = @"SELECT ((o.plocha_dps) * (COALESCE(o.pozadovano_pocet,0) + COALESCE(o.tech_pridavek,0))) AS plochaZakazky
                                       FROM kapacita k
                                       JOIN objednavka_polozka o ON o.objednavka_polozka_id = k.objednavka_polozka_id
                                       WHERE 1=1";



                if (terminTyp.termin_typ_id == (int)termin_typ.Value.normal)
                {
                    strSQLJeden += " AND o.termin_typ_id = " + (int)termin_typ.Value.normal;

                }
                else if (terminTyp.termin_typ_id == (int)termin_typ.Value.express || terminTyp.termin_typ_id == (int)termin_typ.Value.poloexpres)
                {
                    // poloexpress a express dohromady
                    strSQLJeden += " AND (o.termin_typ_id = " + (int)termin_typ.Value.poloexpres;
                    strSQLJeden += " OR o.termin_typ_id = " + (int)termin_typ.Value.express + ")";
                }

                strSQLJeden += string.Format(" AND k.datum = '{0}'", odObdobi.AddDays(i).ToString(DBHelper.FormatDatumCasNula));
                strSQLJeden += " AND o.plosny_spoj_specifikace_id = " + typSpoje.plosny_spoj_specifikace_id;

                DataTable kapacita = DBHelper.SQLSelect(dbContext, strSQLJeden);

                foreach (DataRow kap in kapacita.Rows)
                {
                    if (kap["plochaZakazky"] != DBNull.Value)
                    {
                        denniPlocha += decimal.Parse(kap["plochaZakazky"].ToString());
                    }
                }
                                
                KapacitaRow tabulkaRow = new KapacitaRow();
                tabulkaRow.Datum = odObdobi.AddDays(i);
                tabulkaRow.Plocha = denniPlocha;
                tabulkaRow.Zabrano = (denniPlocha / decimal.Parse(plosny_spoj_specifikace.getNormaNaDen(terminTyp.termin_typ_id ==(int)termin_typ.Value.normal,  typSpoje.koeficient).ToString()) * 100);
                tabulkaRow.Zbyva = 100 - tabulkaRow.Zabrano;
                
                ls.Add(tabulkaRow);
            }

            return ls;

        }

        public static decimal GetKapacitaDne(pcb_develEntities dbContext, objednavka_polozka obj, DateTime odObdobi)
        {
            string strSQL = @"
                SELECT ((o.plocha_dps) * (COALESCE(o.pozadovano_pocet,0) + COALESCE (o.tech_pridavek,0)) )  AS plochaZakazky
                                       FROM kapacita k
                                       JOIN objednavka_polozka o ON o.objednavka_polozka_id = k.objednavka_polozka_id
                WHERE 1=1 
                ";

            strSQL += string.Format(" AND k.datum='{0}'", odObdobi.ToString(DBHelper.FormatDatumCasNula));
            

            strSQL += " AND o.termin_typ_id = " + obj.termin_typ_id;

            DataTable kapacita = DBHelper.SQLSelect(dbContext, strSQL);

            decimal denniPlocha = 0;
            foreach (DataRow kap in kapacita.Rows)
            {
                if (kap["plochaZakazky"] != DBNull.Value)
                {
                    denniPlocha += decimal.Parse(kap["plochaZakazky"].ToString());
                }
            }
                        
            denniPlocha += obj.plochaZakazky;
                       
            return (denniPlocha / (decimal)plosny_spoj_specifikace.getNormaNaDen(obj.termin_typ_id == (int)termin_typ.Value.normal,obj.plosny_spoj_specifikace.koeficient))  * 100;
        }


        public static List<KapacitaRow> LoadDataPrehled(pcb_develEntities dbContext, DateTime odObdobi, DateTime doObdobi, int terminTypCustom)
        {
            TimeSpan rozdil = doObdobi - odObdobi;
            int pocetDni = rozdil.Days+1;

            pocetDni = pocetDni == 0 ? 1 : pocetDni;


            string strSQL = @"
SELECT 
    k.datum, 
    psp.koeficient AS pocetVr, 
    o.termin_typ_id, 
    sum(((p.cisty_rozmer_dps_x * p.cisty_rozmer_dps_y) * (COALESCE (o.pozadovano_pocet, 0) + COALESCE (o.tech_pridavek,0)) ) / 10000) AS plochaZakazky
FROM kapacita k
JOIN objednavka_polozka o ON o.objednavka_polozka_id = k.objednavka_polozka_id
JOIN produkt p ON o.produkt_id = p.produkt_id
JOIN plosny_spoj_specifikace psp ON p.plosny_spoj_specifikace_id = psp.plosny_spoj_specifikace_id
WHERE 1=1";

            strSQL += string.Format(" AND k.datum>='{0}'", odObdobi.ToString(DBHelper.FormatDatumCasNula));
            strSQL += string.Format(" AND k.datum<='{0}'", doObdobi.ToString(DBHelper.FormatDatumCasNula));

            // vystup
            List<KapacitaRow> ls = new List<KapacitaRow>();
            
            // standart
            if (terminTypCustom == (int)termin_typ.ValueCustom.normal)
            {
                strSQL += " AND o.termin_typ_id = " + (int)termin_typ.Value.normal;
            }
            else
                if (terminTypCustom == (int)termin_typ.ValueCustom.poloexpresExpress)
                {
                    // poloexpress a express dohromady
                    strSQL += " AND (o.termin_typ_id = " + (int)termin_typ.Value.poloexpres;
                    strSQL += " OR o.termin_typ_id = " + (int)termin_typ.Value.express + ")";
                }

            strSQL += " GROUP BY k.datum, psp.koeficient, o.termin_typ_id";

            DataTable table = DBHelper.SQLSelect(dbContext, strSQL);



            for (int i = 0; i < pocetDni; i++)
            {

                KapacitaRow tabulkaRow = new KapacitaRow();
                tabulkaRow.Datum = odObdobi.AddDays(i);

                decimal plochaJednostranky = 0;
                decimal plochaOboustranky = 0;
                decimal plochaVicestranky = 0;    

                    DataRow[] jedenDen;


                    if (terminTypCustom == (int)termin_typ.ValueCustom.normal) // standart
                    {

                        jedenDen = table.Select(string.Format("datum = '{0}' AND termin_typ_id = {1}", odObdobi.AddDays(i).ToString(DBHelper.FormatDatumCasNula), (int)termin_typ.Value.normal));
                    }
                    else // poloexpres, express
                    {
                        jedenDen = table.Select(string.Format("datum = '{0}' AND (termin_typ_id = {1} OR termin_typ_id = {2})", odObdobi.AddDays(i).ToString(DBHelper.FormatDatumCasNula), (int)termin_typ.Value.express, (int)termin_typ.Value.poloexpres));
                    }
                    

                    foreach (DataRow kap in jedenDen)
                    {
                        if (int.Parse(kap["pocetVr"].ToString()) == 1)
                        {
                            plochaJednostranky += decimal.Parse(kap["plochaZakazky"].ToString());
                        }
                        if (int.Parse(kap["pocetVr"].ToString()) == 2)
                        {
                            plochaOboustranky += decimal.Parse(kap["plochaZakazky"].ToString());
                        }

                        if (int.Parse(kap["pocetVr"].ToString()) > 2)
                        {
                            plochaVicestranky += decimal.Parse(kap["plochaZakazky"].ToString());
                        }
                    }


                    int jednostranky = plosny_spoj_specifikace.getNormaNaDen(terminTypCustom == (int)termin_typ.ValueCustom.normal, 1);
                    int oboustranky = plosny_spoj_specifikace.getNormaNaDen(terminTypCustom == (int)termin_typ.ValueCustom.normal, 2);
                    int vicestranky = plosny_spoj_specifikace.getNormaNaDen(terminTypCustom == (int)termin_typ.ValueCustom.normal, 3);

                    tabulkaRow.Jednostranky = plochaJednostranky;
                    tabulkaRow.JednostrankyProcento = Math.Round((plochaJednostranky/ decimal.Parse(jednostranky.ToString())*100), 2);
                    tabulkaRow.Vicevrstve = plochaVicestranky;
                    tabulkaRow.VicevrstveProcento = Math.Round((plochaVicestranky / decimal.Parse(vicestranky.ToString())*100), 2);
                    tabulkaRow.Oboustranky = plochaOboustranky;
                    tabulkaRow.OboustrankyProcento = Math.Round((plochaOboustranky / decimal.Parse(oboustranky.ToString())*100), 2);

                    ls.Add(tabulkaRow);

                }

                
            

            return ls;

        }

    }
}
