using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using PCB.Data.CustomObjects;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PCB.Base;
using System.Data.Entity;
using PCB.Report;

namespace PCB.frm.Reporty
{
    public partial class frmReportTPV : frmBaseSeznam
    {

        public frmReportTPV()
        {
            InitializeComponent();
        }


        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);

            DateTime? dateOd = (deObdobiOd.EditValue != null ? (DateTime)deObdobiOd.EditValue : (DateTime?)null);
            DateTime? dateDo = (deObdobiDo.EditValue != null ? (DateTime)deObdobiDo.EditValue : (DateTime?)null);

            var result = this.DBContext.objednavka_polozkas.
                Where(w =>
                    DbFunctions.TruncateTime(w.d_zadal) >= DbFunctions.TruncateTime(dateOd ?? DateTime.MinValue) &&
                    DbFunctions.TruncateTime(w.d_zadal) <= DbFunctions.TruncateTime(dateDo ?? DateTime.MaxValue) &&
                    w.produkt_id.HasValue &&
                    w.termin_typ_id.HasValue && 
                    w.plosny_spoj_specifikace_id.HasValue && 
                    w.plosny_spoj_druh_id.HasValue)
                    .OrderBy(o => o.d_zadal ?? DateTime.MinValue)
                .Select(s => new TPVGridRow()
                {
                    DruhTerminuId = s.termin_typ_id,
                    DruhTerminuNazev = s.termin_typ.nazev,
                    Kod = s.produkt.kod,
                    ProblemovaData = s.problemova_data ?? false,
                    Sestavil = s.produkt.uzivatel_sestavil.prijmeni + " " + s.produkt.uzivatel_sestavil.jmeno,
                    SestavilId = s.produkt.sestavil,
                    TypDeskyId = s.produkt.plosny_spoj_specifikace_id,
                    TypDeskyNazev = s.produkt.plosny_spoj_specifikace.nazev,
                    TypVyrobyId = s.plosny_spoj_druh_id,
                    TypVyrobyNazev = s.plosny_spoj_druh.nazev,
                    ZakaznikId = s.zakaznik.zakaznik_id,
                    ZakaznikNazev = s.zakaznik.interni_nazev
                }).ToList();

            bsReportTPV.DataSource = result;

            gridView1.BestFitColumns();
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            deObdobiOd.EditValue = null;
            deObdobiDo.EditValue = null;

            this.LoadData(null);
        }

        private void bbiObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime? dateOd = (deObdobiOd.EditValue != null ? (DateTime)deObdobiOd.EditValue : (DateTime?)null);
            DateTime? dateDo = (deObdobiDo.EditValue != null ? (DateTime)deObdobiDo.EditValue : (DateTime?)null);

            string fileName = string.Format("TPV-report_{0:ddMMyyyy}", DateTime.Now);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*";
            dialog.FileName = fileName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
              TPVReport tpv = new TPVReport();
                tpv.Export(dialog.FileName, this.bsReportTPV.DataSource as List<TPVGridRow>, dateOd, dateDo);

                System.Diagnostics.Process.Start(dialog.FileName); 
            }
        }
    }
}
