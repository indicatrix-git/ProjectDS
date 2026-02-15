using PCB.Data;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public class AppHelper
    {
        /// <summary>
        /// Prihalseny uzivatel
        /// </summary>
        public static uzivatel Uzivatel;

        public static string verze = GetVersion();
        public static string verzeDB = "0.3";
        
        public static void Log(string s)
        {
            StreamWriter sw = new StreamWriter("app.log", true);
            sw.WriteLine(PCB.Data.DBHelper.DateTimeNow().ToString() + " - " +  s);
            sw.Close();
        }

        public static void RunPath(string path)
        {
            Process.Start(path);

        }

        #region Zobrazi napovedu ze souboru (site)
        public static void ZobrazSoubor(string soubor)
        {
            ZobrazSoubor(soubor, false);
        }

        public static void ZobrazSoubor(string soubor, bool primacesta)
        {
            pcb_develEntities DBContext = new pcb_develEntities();
            klice klic = DBContext.klices.Where(i => i.klic == "cesta_napovedne_soubory").First();
            string cesta = klic.hodnota;

            string cestafinal = "";

            if (primacesta)
            {
                cestafinal = soubor;
            }
            else
            {
                cestafinal = cesta + soubor;
            }

            if (File.Exists(cestafinal))
            {
                System.Diagnostics.Process.Start(cestafinal);
            }
            else
            {
                MessageBox.Show("Soubor " + cestafinal + " nenalezen");
            }
        }
        #endregion


        /// <summary>
        /// Kontrola konzistence verzi DB vs APP
        /// </summary>
        /// <param name="DBContext"></param>
        /// <returns></returns>
        public static bool KontrolaVerzeDB()
        {
            pcb_develEntities DBContext = new pcb_develEntities();

            klice klic = DBContext.klices.Where(i => i.klic == "db_verze").First();
            
            if (klic.hodnota != AppHelper.verzeDB)
            {
            string message = @"Nemáte aktuální verzi aplikace! Aplikace nelze spustit! <br> verze aplikace {0} <br> verze DB {1}";
            message = string.Format(message, AppHelper.verzeDB, klic.hodnota);
            AppHelper.Log(message);
            frmNapoveda.Set(message);

            DBContext.Dispose();

            return false;
            }
            else
            {
                return true;
            }
            
        }


        /// <summary>
        /// vytvori kontext DB
        /// </summary>
        /// <returns></returns>
        public static pcb_develEntities CreateDBContext()
        {
                pcb_develEntities db = new pcb_develEntities();
                db.ContextOptions.LazyLoadingEnabled = true;
                return db;
        }

        /// <summary>
        /// Vytahne verzi z EXE
        /// </summary>
        /// <returns></returns>
        public static string GetVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }
    }
}
