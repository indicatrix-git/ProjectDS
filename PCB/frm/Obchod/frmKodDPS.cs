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
    public partial class frmKod : Form
    {
        public string SelectedItem { get; set; }

        public frmKod()
        {
            InitializeComponent();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SelectedItem = rgTypDesky.SelectedItem;
          
            this.DialogResult = this.SelectedItem==null ? DialogResult.None : System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void frmKod_Load(object sender, EventArgs e)
        {
            rgTypDesky.Items.AddRange(new PCB.Gui.CheckButtonItem[]{

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

            rgTypDesky.RefeshData();

        }
    }
}
