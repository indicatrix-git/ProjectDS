using DevExpress.XtraEditors.Controls;
using PCB.Base;
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
    public partial class frmCiselnikKodDPS : frmBaseDetail
    {
        List<string> povoleneProSablonu = new List<string>() { "SN", "S.", "V1A", "V1B", "V1X", "H" };

        private Value odkudVolano;
        public enum Value { sablona, produkt };


        public frmCiselnikKodDPS(Value typDat)
        {
            InitializeComponent();
            odkudVolano = typDat;
            this.PravaIgnore = true;
        }

        public void Init()
        {

            this.cbTypDesky.Items.AddRange(new PCB.Gui.CheckButtonItem[]{
            new PCB.Gui.CheckButtonItem("..", "DPS bez kódu (nutno vytvořit postup)"),
            new PCB.Gui.CheckButtonItem("S.", "Šablona - leptaná"),
            new PCB.Gui.CheckButtonItem("SN", "Šablona - laserovaná"),
            new PCB.Gui.CheckButtonItem("E1", "Flexi DPS jednostranná"),
            new PCB.Gui.CheckButtonItem("E2", "Flexi DPS oboustranná"),
            new PCB.Gui.CheckButtonItem("J.", "Základ jednostranné DPS"),
            new PCB.Gui.CheckButtonItem("J0", "Základ jednostranné DPS nevrtané"),
            new PCB.Gui.CheckButtonItem("O.", "Základ oboustranné DPS"),
            new PCB.Gui.CheckButtonItem("N.", "Základ oboustranné DPS neprokovenné"),
            new PCB.Gui.CheckButtonItem("4A", "Základ 4-vrstvé DPS - MASLAM"),
            new PCB.Gui.CheckButtonItem("6A", "Základ 6-vrstvé DPS - MASLAM"),
            new PCB.Gui.CheckButtonItem("8A", "Základ 8-vrstvé DPS - MASLAM"),
            new PCB.Gui.CheckButtonItem("10A", "Základ 10-vrstvé DPS - MASLAM"),
            new PCB.Gui.CheckButtonItem("12A", "Základ 12-vrstvé DPS - MASLAM"),
            new PCB.Gui.CheckButtonItem("4B", "Základ 4-vrstvé DPS - NEMASLAM"),
            new PCB.Gui.CheckButtonItem("6B", "Základ 6-vrstvé DPS - NEMASLAM"),
            new PCB.Gui.CheckButtonItem("8B", "Základ 8-vrstvé DPS - NEMASLAM"),
            new PCB.Gui.CheckButtonItem("10B", "Základ 10-vrstvé DPS - NEMASLAM"),
            new PCB.Gui.CheckButtonItem("12B", "Základ 12-vrstvé DPS - NEMASLAM"),
            new PCB.Gui.CheckButtonItem("W1", "1-vrstvá DPS - FLEX-RIGID"),
            new PCB.Gui.CheckButtonItem("W2", "2-vrstvá DPS - FLEX-RIGID"),
            new PCB.Gui.CheckButtonItem("W4", "4-vrstvá DPS - FLEX-RIGID"),
            new PCB.Gui.CheckButtonItem("W6", "6-vrstvá DPS - FLEX-RIGID"),
            new PCB.Gui.CheckButtonItem("J1", "Thermalclad (Al)"),
            new PCB.Gui.CheckButtonItem("J2", "Thermalclad (Cu)")});

            this.cblPovrchoveUpravy.Items.AddRange(new PCB.Gui.CheckButtonItem[] {
             new PCB.Gui.CheckButtonItem("MA", "Maska na straně A"),
             new PCB.Gui.CheckButtonItem("MB", "Maska na straně B"),
             new PCB.Gui.CheckButtonItem("MX", "Maska na straně A i B"),
             new PCB.Gui.CheckButtonItem("L", "Podlepy"),
             new PCB.Gui.CheckButtonItem("C", "Imersní cínování"),
             new PCB.Gui.CheckButtonItem("I", "Imersní zlacení"),
             new PCB.Gui.CheckButtonItem("Q", "Celoplošné galvanické zlacení"),
             new PCB.Gui.CheckButtonItem("Z", "Galvanické zlacení (přímých konektorů, ...)"),
             new PCB.Gui.CheckButtonItem("V1A", "Karbonová pasta na straně A"),
             new PCB.Gui.CheckButtonItem("V1B", "Karbonová pasta na straně B"),
             new PCB.Gui.CheckButtonItem("V1X", "Karbonová pasta na straně A i B"),
            /* new PCB.Gui.CheckButtonItem("V2A", "Měděná pasta na straně A"),
             new PCB.Gui.CheckButtonItem("V2B", "Měděná pasta na straně B"),
             new PCB.Gui.CheckButtonItem("V2X", "Měděná pasta na straně A i B"),
             new PCB.Gui.CheckButtonItem("V3A", "Stříbrná pasta na straně A"),
             new PCB.Gui.CheckButtonItem("V3B", "Stříbrná pasta na straně B"),
             new PCB.Gui.CheckButtonItem("V3X", "Stříbrná pasta na straně A i B"), */
             new PCB.Gui.CheckButtonItem("H", "Aktivace Cu + HALL"),
             new PCB.Gui.CheckButtonItem("T", "Elektrické testování"),
             new PCB.Gui.CheckButtonItem("PA", "Potisk na straně A"),
             new PCB.Gui.CheckButtonItem("PB", "Potisk na straně B"),
             new PCB.Gui.CheckButtonItem("PX", "Potisk na straně A i B"),
             new PCB.Gui.CheckButtonItem("G", "Organický povlak"),
             new PCB.Gui.CheckButtonItem("SA", "Snímatelná maska na straně A"),
             new PCB.Gui.CheckButtonItem("SB", "Snímatelná maska na straně B"),
             new PCB.Gui.CheckButtonItem("SX", "Snímatelná maska na straně A i B")});
            
            this.cbDokonceni.Items.AddRange(new PCB.Gui.CheckButtonItem[] {
             new PCB.Gui.CheckButtonItem("F1", "Frézování výřezů"),
             new PCB.Gui.CheckButtonItem("F2", "Frézování tvaru"),
             new PCB.Gui.CheckButtonItem("D1", "Drážkování + úprava panelu"),
             new PCB.Gui.CheckButtonItem("D2", "Drážkování bez úpravy panelu"),
             new PCB.Gui.CheckButtonItem("D3", "Drážkování + rozlámání panelu"),
             new PCB.Gui.CheckButtonItem("R", "Rozstřih, dokončení tvaru")});

            

            
            foreach (CheckButtonItem item in cblPovrchoveUpravy.Items)
            {
                produkt_postup p = ((produkt)this.entityObject).produkt_postups.Where(i => i.postup.kod == (string)item.Code).FirstOrDefault();
                if (p != null)
                {
                    item.Selected = true;
                }
            }



            foreach (CheckButtonItem item in cbDokonceni.Items)
            {
                produkt_postup p = ((produkt)this.entityObject).produkt_postups.Where(i => i.postup.kod == (string)item.Code).FirstOrDefault();
                if (p != null)
                {
                    item.Selected = true;
                }
            }


            if (this.odkudVolano == Value.sablona)
            {
                foreach (CheckButtonItem item in cbTypDesky.Items)
                {
                    item.Enabled = povoleneProSablonu.Contains(item.Code);
                }

                List<CheckButtonItem> lsSeznamPovrchoveUpravy = new List<CheckButtonItem>();
                foreach (CheckButtonItem item in cblPovrchoveUpravy.Items)
                {
                    lsSeznamPovrchoveUpravy.Add(item);
                }

                foreach (CheckButtonItem item in lsSeznamPovrchoveUpravy)
                {
                    if (!povoleneProSablonu.Contains(item.Code))
                    {
                        cblPovrchoveUpravy.Remove(item);
                    }
                }

            }
            else
            {
                foreach (CheckButtonItem item in cbTypDesky.Items)
                {
                    if (item.Code.ToString() == "S." || item.Code.ToString() == "SN")
                    {
                        item.Enabled = false;
                    }
                }

            }

            if (((produkt)this.entityObject).plosny_spoj_specifikace != null)
            {
                cbTypDesky.SelectedItem = ((produkt)this.entityObject).plosny_spoj_specifikace.kod;
            }

            this.cbTypDesky.RefeshData();
            this.cblPovrchoveUpravy.RefeshData();
            this.cbDokonceni.RefeshData();
        }



        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVybrat_Click(object sender, EventArgs e)
        {

            int poradi = 0;

            try
            {
                foreach (produkt_postup item in ((produkt)this.entityObject).produkt_postups.ToList())
                {
                    this.DBContext.DeleteObject(item);
                }

            ((produkt)this.entityObject).plosny_spoj_specifikace_id = this.DBContext.plosny_spoj_specifikaces.Where(i => i.kod == (string)cbTypDesky.SelectedItem).First().plosny_spoj_specifikace_id;
                ((produkt)this.entityObject).plosny_spoj_specifikace = this.DBContext.plosny_spoj_specifikaces.Where(i => i.plosny_spoj_specifikace_id == ((produkt)this.entityObject).plosny_spoj_specifikace_id).First();
                foreach (CheckButtonItem item in cblPovrchoveUpravy.SelectedItems)
                {
                    poradi++;
                    produkt_postup postup = new produkt_postup();
                    postup.produkt_id = ((produkt)this.entityObject).produkt_id;
                    postup.postup_id = DBContext.postups.Where(i => i.kod == (string)item.Code).First().postup_id;
                    postup.poradi = poradi;
                    ((produkt)this.entityObject).produkt_postups.Add(postup);
                }

                foreach (CheckButtonItem item in cbDokonceni.SelectedItems)
                {
                    poradi++;
                    produkt_postup postup = new produkt_postup();
                    postup.produkt_id = ((produkt)this.entityObject).produkt_id;
                    postup.postup_id = DBContext.postups.Where(i => i.kod == (string)item.Code).First().postup_id;
                    postup.poradi = poradi;
                    ((produkt)this.entityObject).produkt_postups.Add(postup);
                }
            }
            catch (Exception exp) { }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void frmCiselnikKodDPS_Load(object sender, EventArgs e)
        {
            Init();

        }

    }
}
