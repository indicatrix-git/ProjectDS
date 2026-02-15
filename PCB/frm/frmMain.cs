using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using PCB.Base;
using PCB.frm.Reporty;
using PCB.Gui;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public partial class frmMain : frmBase
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmUvodni frm = new frmUvodni();
            showInParent(this, frm);
        }
               

        public void SetPrava()
        {
#if DEBUG
            this.btnDevelop.Visible = true;
#endif

            // Obchod

            navBarBarAdresar.Prava = new List<prava.Value>() { prava.Value.ObchodZakaznik };
            navBarNabidkaPolozky.Prava = new List<prava.Value>() { prava.Value.ObchodNabidky };
            navBarObjednavkaPolozky.Prava = new List<prava.Value>() { prava.Value.ObchodObjednavky };
            navBarObjednavkaPolozky.ObjednavkaStav = new List<int>() { (int)stav_objednavka.Value.PredanoDoobchodu };
            navBarFaktur.Prava = new List<prava.Value>() { prava.Value.ObchodFakturace };
            navBarKapacita.Prava = new List<prava.Value>() { prava.Value.ObchodKapacita };
            navBarCenik.Prava = new List<prava.Value>() { prava.Value.ObchodCenik };
            
            
            // TPV
            navBarDokum.Prava = new List<prava.Value>() { prava.Value.TPVTechnickaDokumentace };
            navBarTPVObjednavkaPolozka.Prava = new List<prava.Value>() { prava.Value.TPVObjednavky };
            navBarTPVNabidkaPolozka.Prava = new List<prava.Value>() { prava.Value.TPVNabidky };
         
            // výroba

            navBarVyrobaPruvod.Prava = new List<prava.Value>() { prava.Value.VyrobaPruvodky };
            navBarOdepisovani.Prava = new List<prava.Value>() { prava.Value.VyrobaOdepisovani };
            navBarItemDataObjVyroba.Prava = new List<prava.Value>() { prava.Value.VyrobaObjednavky };

            // technologie
            navBarItemTechlologieProdukt.Prava = new List<prava.Value>() { prava.Value.TechnologieTechnickaDokumentace };
            navBarItemTechnologieNabidky.Prava = new List<prava.Value>() { prava.Value.TechnologieNabidky };
            navBarItemTechnologieObjednavky.Prava = new List<prava.Value>() { prava.Value.TechnologieObjednavky };
            //navBarItemTechnologickeRady.Prava = new List<prava.Value>() { prava.Value.TechnologieTechnologickeRady };
            //navBarNavodky.Prava = new List<prava.Value>() { prava.Value.TechnologieNavodky };
            navBarItemOperace.Prava = new List<prava.Value>() { prava.Value.TechnologieOperace };
                        
            // pripravar
            navBarItemPripravarObjednavky.Prava = new List<prava.Value>() { prava.Value.PripravarDavekAFilmuObjednavky };
            btnTiskovaFronta.Prava = new List<prava.Value>() { prava.Value.PripravarDavekAFilmuObjednavky };

            // data test
            navBarDataET.Prava = new List<prava.Value>() { prava.Value.PripravarDatProTestovani };

            // Uzivatelska prava
            navBarUzivRole.Prava = new List<prava.Value>() { prava.Value.AdministraceUzivatelskeRole };
            navBarUzivPrava.Prava = new List<prava.Value>() { prava.Value.AdministraceUzivatelskaPrava };


            foreach (NavBarItem item in navBarControl1.Items)
            {
                if (item is btnNavBar)
                {
                    ((btnNavBar)item).Check(this.PrihlasenyUzivatelId);
                }
               // item.Pocitej(this.DBContext);
            }

            foreach (NavBarGroup item in navBarControl1.Groups)
            {
                int pocet=0;
                foreach (NavBarItemLink btn in item.ItemLinks)
                {
                    if (!btn.Visible)
                    {
                        pocet += 1;
                    }
                }
                if (pocet == item.ItemLinks.Count)
                {
                    item.Visible = false;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete opravdu ukončit aplikaci ?", "Ukončit?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
       
        private void navBarUzivPrava_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmUzivatelSeznam seznam = new frmUzivatelSeznam();
            showInParent(this, seznam);
        }

        private void navBarUzivRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmRoleSeznam seznam = new frmRoleSeznam();
            showInParent(this, seznam);
        }

        private void navBarPruvod_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPruvodkaSeznam frm = new frmPruvodkaSeznam();
            showInParent(this, frm);
        }

        private void navBarOdepisovani_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPruvodkaOdepisovani frm = new frmPruvodkaOdepisovani();
            frm.ShowDetailNovy(this);
        }

        private void navBarItemKapacita_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKapacitaVyroby frm = new frmKapacitaVyroby();
            showInParent(this, frm);
        }

        private void navBarItemNeshody_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNeshodySeznam frm = new frmNeshodySeznam();
            showInParent(this, frm);
        }
                
        private void navBarItemPripravarDPS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarItemTechnologieObjednavky_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarItemTechnologieNabidky_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNabidkaPolozkaSeznam frm = new frmNabidkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarItemTechlologieProdukt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmProduktSeznam frm = new frmProduktSeznam();
            showInParent(this, frm);
        }

        private void navBarTPVObjednavkaPolozka_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarTPVNabidkaPolozka_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNabidkaPolozkaSeznam frm = new frmNabidkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void btnCenik_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCenikSeznam frm = new frmCenikSeznam();
            showInParent(this, frm);
        }
        
        private void btnObjednavkaPolozky_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void btnNabidkaPolozky_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNabidkaPolozkaSeznam frm = new frmNabidkaPolozkaSeznam();
            showInParent(this, frm);
        }
             
        private void navBarItemOperace_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmOperaceSeznam frm = new frmOperaceSeznam();
            showInParent(this, frm);
        }

        private void navBarAdresar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmZakaznikSeznam frm = new frmZakaznikSeznam();
            showInParent(this, frm);
        }

        private void navBarDokum_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmProduktSeznam frm = new frmProduktSeznam();
            showInParent(this, frm);
        }
               
        private void timer1_Tick(object sender, EventArgs e)
        {
            SetPrava();
        }

        private void navBarFaktur_ItemChanged(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFakturaSeznam frm = new frmFakturaSeznam();
            showInParent(this, frm);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //this.SetPrava();
        }

        private void btnPostupy_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPostupSeznam frm = new frmPostupSeznam();
            showInParent(this, frm);
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void navBarItemDataET_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarItemDataAOE_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmObjednavkaPolozkaSeznam frm = new frmObjednavkaPolozkaSeznam();
            showInParent(this, frm, sender);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetPrava();
        }

        private void btnTiskovaFronta_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmPruvodkaFrontaSeznam frm = new frmPruvodkaFrontaSeznam();
            showInParent(this, frm, sender);
        }

        private void btnQMS_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            AppHelper.RunPath(@"\\Pcbserver10\QMSDokumentace\ŘízenéDokumenty-zdroje\Platné\");
        }

        private void btnTechnickePodminky_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            AppHelper.RunPath(@"\\Pcbserver10\QMSDokumentace\ŘízenéDokumenty\1-TechnickaDokumentace\1-Technickepodminky");
        }

        private void btnNavodky_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            AppHelper.RunPath(@"\\Pcbserver10\QMSDokumentace\ŘízenéDokumenty\1-TechnickaDokumentace\2-Navodky");
        }

        private void btnTechnikceRady_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            AppHelper.RunPath(@"\\Pcbserver10\QMSDokumentace\ŘízenéDokumenty\1-TechnickaDokumentace\3-Technologicke Rady");
        }
 

        private void btnUkazatSkrytMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dockPanel1.Visibility = this.dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible ? DevExpress.XtraBars.Docking.DockVisibility.Hidden : DevExpress.XtraBars.Docking.DockVisibility.Visible;
            this.btnUkazatSkrytMenu.Caption = this.dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible ? "Skrýt menu" : "Zobrazit menu";

        }

        private void navBarItemExcelASV_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmExcelAsvSeznam frm = new frmExcelAsvSeznam();
            showInParent(this, frm, sender);
        }

        private void navBarItemObchod_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.showInParent(this, new frmReportObchod(), sender);
        }

        private void navBarItemVyroba_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.showInParent(this, new frmReportVyroba(), sender);
        }

        private void navBarItemTPV_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.showInParent(this, new frmReportTPV(), sender);
        }

        private void navBarItemKvalita_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.showInParent(this, new frmReportKvalita(), sender);
        }





        /*
private void btnDevelop_LinkClicked(object sender, NavBarLinkEventArgs e)
{
Report.FakturaReport report = new Report.FakturaReport("test");

}*/
    }
}
