using PCB.Base;
using PCB.Data;
using PCB.Data.CustomObjects;
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
    public partial class frmPrirazeniDPS : frmBaseSeznam
    {
        public int VybranyProdukt { get; set; }
        public string ObjednavkovyNazev { get; set; }

        public frmPrirazeniDPS()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            string strSQL = @"
SELECT DISTINCT 
p.produkt_id AS id, 
obj.nazev AS obj_nazev_dps, 
p.nazev AS nazev_dps, 
zakProdukt.interni_nazev AS majitel
FROM objednavka_polozka obj
JOIN produkt p ON p.produkt_id = obj.produkt_id AND p.produkt_stav_id = 1 /* aktivni */
JOIN zakaznik zakProdukt ON zakProdukt.zakaznik_id = p.zakaznik_id
WHERE 1=1";

            if (!String.IsNullOrEmpty(txtNazev.Text))
            {
                strSQL += string.Format(" AND (upper(obj.nazev) like '%{0}%' OR upper(p.nazev) like '%{0}%')", txtNazev.Text.ToUpper());
            }

            nazevDPSBindingSource.DataSource = DBHelper.SQLSelect(this.DBContext, strSQL);
        }

        private void btnZobrazit_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void gcSeznam_DoubleClick(object sender, EventArgs e)
        {
            if (nazevDPSBindingSource.Current != null)
            {
                this.VybranyProdukt = int.Parse(((DataRowView)nazevDPSBindingSource.Current)["id"].ToString());
                this.ObjednavkovyNazev = ((DataRowView)nazevDPSBindingSource.Current)["obj_nazev_dps"].ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
