using Devart.Data.PostgreSql;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;

namespace PCB.Data
{
    public class DBHelper
    {
        /// <summary>
        /// Databasovy cas (server)
        /// </summary>
        /// <returns></returns>
        public static DateTime DateTimeNow()
        {
            using (pcb_develEntities db = new pcb_develEntities())
            {
                DbConnection conn = ((EntityConnection)db.Connection).StoreConnection;
                conn.Open();
                IDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select now();";
                DateTime now = DateTime.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                return now;
            }
        }

        public static string FormatDatumACas = "dd.MM.yyyy HH:mm";
        public static string FormatDatum = "dd.MM.yyyy";
        public static string FormatDatumCasNula = "dd.MM.yyyy 00:00";

        /// <summary>
        /// Zavola surovy select
        /// </summary>
        /// <param name="db"></param>
        /// <param name="strSQL"></param>
        /// <returns>DataTable</returns>
        public static DataTable SQLSelect(pcb_develEntities db, string strSQL)
        {
            return SQLSelect(db, strSQL, null);
        }

        public static DataTable SQLSelect(pcb_develEntities db, string strSQL, List<PgSqlParameter> param )
        {
            PgSqlConnection conn = (PgSqlConnection)((EntityConnection)db.Connection).StoreConnection;
            conn.Open();
            PgSqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = strSQL;
            if (param != null)
            {
                cmd.Parameters.AddRange(param.ToArray());
            }

            DataTable table = new DataTable();
            Devart.Data.PostgreSql.PgSqlDataAdapter da = new Devart.Data.PostgreSql.PgSqlDataAdapter(cmd);
            da.Fill(table);
            conn.Close();

            return table;
        }


        /// <summary>
        /// Zavola SQL bez navratu
        /// </summary>
        /// <param name="db"></param>
        /// <param name="strSQL"></param>
        public static void SQLExecute(pcb_develEntities db, string strSQL)
        {
            PgSqlConnection conn = (PgSqlConnection)((EntityConnection)db.Connection).StoreConnection;
            conn.Open();

            PgSqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            conn.Close();
                       
        }

    }
}
