using NDbfReader;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PCB
{
    public partial class frmPuvodniSystem : DevExpress.XtraEditors.XtraForm
    {
        public produkt Produkt {get;set;}

        public frmPuvodniSystem()
        {
            InitializeComponent();
        }

        private void frmPuvodniSystem_Load(object sender, EventArgs e)
        {
            try
            {
                using (var table = Table.Open(PCB.Properties.Settings.Default.oldDBF))
                {
                    // default is UTF-8 encoding
                    DataTable t = table.AsDataTable(); // Dořešit pouze aktivní

                    var row = t.Select("(PRIZ = '' or PRIZ is NULL) and PS_KOD not like ('S.%') and PS_KOD not like ('SN%')");

                    DataTable dt = row.CopyToDataTable();

                    bindingSource1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Nelze otevřít DBF soubor.");
               this.Close();
            }
        }

        private void gridControlTPVPrac_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete opravdu přenést?", "Dotaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                List<int> produkt_stav_active = new List<int>() { (int)produkt_stav.Value.aktivni, (int)produkt_stav.Value.kOdeslani, (int)produkt_stav.Value.odeslane, (int)produkt_stav.Value.prevedeno };

                var dbContext = AppHelper.CreateDBContext();
                var zakaznik = dbContext.zakazniks.ToList().Where(w => w.interni_nazev == ((DataRowView)bindingSource1.Current)["ODBER"].ToString()).FirstOrDefault();
                string nazev = ((DataRowView)bindingSource1.Current)["PS_NAZ"].ToString();

                if (zakaznik == null || !dbContext.produkts.Where(w => !w.sablona && w.zakaznik_id == zakaznik.zakaznik_id && w.nazev == nazev && produkt_stav_active.Contains(w.produkt_stav_id)).Any())
                {
                    this.Produkt = produkt.Prevod((DataRowView)bindingSource1.Current);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show(String.Format("Produkt \"{0}\" pro zákazníka \"{1}\", je již převeden.", nazev, zakaznik.nazev), "Produkt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            frmPuvodniSystemDetail frm = new frmPuvodniSystemDetail();
            frm.row = (DataRowView)bindingSource1.Current;
            frm.ShowDialog();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
