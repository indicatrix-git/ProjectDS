using PCB.Base;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace PCB
{
    static class Program
    {

        static frmSplashScreen frmSplash;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.SetCompatibleTextRenderingDefault(false);
            
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("cs-CZ");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("cs-CZ");

            Localizer.Active = Localizer.CreateDefaultLocalizer();

            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;

           /* 
            * Updater.FormSearchForUpdates frmSearching = new Updater.FormSearchForUpdates();
            DialogResult resultSearching = frmSearching.ShowDialog();*/

            frmSplash = new frmSplashScreen();
            frmSplash.Show();
            frmSplash.Refresh();
            Thread.Sleep(3000);
            frmSplash.Close();
         
            frmLogin frmlogin = new frmLogin();
            if (frmlogin.ShowDialog() == DialogResult.OK)
            {
                
                frmMain frm = new frmMain();
                frm.LoadData(null);

                if (!AppHelper.KontrolaVerzeDB())
                {
                    return;
                }
                
                Application.Run(frm);
            }

        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            //AppHelper.Log(e.Exception.ToString());
            MessageBox.Show("Nastala chyba v aplikaci:" + e.Exception.ToString());
            Application.Exit();
        }
    }
}
