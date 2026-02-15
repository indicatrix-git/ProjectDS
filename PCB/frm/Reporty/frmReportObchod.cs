using PCB.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Data;
using PCB.Data.CustomObjects;
using pcb_develModel;
using PCB.Report;
using DevExpress.XtraEditors;

namespace PCB.frm.Reporty
{
    public partial class frmReportObchod : frmBaseSeznam
    {
        DateTime? nabidkaOd;
        DateTime? nabidkaDo;
        DateTime? objednavkaOd;
        DateTime? objednavkaDo;
        public frmReportObchod()
        {
            InitializeComponent();
            DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.dtNabidkyOd.EditValue = this.dtObjednavkyOd.EditValue = start;
            this.dtNabidkyDo.EditValue = this.dtObjednavkyDo.EditValue = start.AddDays(DateTime.DaysInMonth(start.Year, start.Month) - 1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadNabidkyDatasource();
            LoadObjednavkyDatasource();
        }
        private void LoadNabidkyDatasource()
        {
            this.nabidkaOd = dtNabidkyOd.EditValue != null ? (DateTime)dtNabidkyOd.EditValue : (DateTime?)null;
            this.nabidkaDo = dtNabidkyDo.EditValue != null ? (DateTime)dtNabidkyDo.EditValue : (DateTime?)null;
            this.grdNabidky.DataSource = LoadNabidky();
        }
        private void LoadObjednavkyDatasource()
        {
            this.objednavkaOd = dtObjednavkyOd.EditValue != null ? (DateTime)dtObjednavkyOd.EditValue : (DateTime?)null;
            this.objednavkaDo = dtObjednavkyDo.EditValue != null ? (DateTime)dtObjednavkyDo.EditValue : (DateTime?)null;
            this.grdObjednavky.DataSource = LoadObjednavky();
        }
        private List<NabidkaGridRow> LoadNabidky()
        {
            NabidkaGridRow predchoziZakaznik = null;
            List<NabidkaGridRow> result = new List<NabidkaGridRow>();

            this.dbContext.nabidka_polozkas.Where(np =>
            np.d_prijato >= (nabidkaOd ?? DateTime.MinValue) && np.d_prijato <= (nabidkaDo ?? DateTime.MaxValue) && np.zakaznik != null).ToList().ForEach(np =>
            {
                if (predchoziZakaznik == null || predchoziZakaznik.ZakaznikId != np.zakaznik_id)
                {
                    predchoziZakaznik = new NabidkaGridRow();
                    result.Add(predchoziZakaznik);
                }
                predchoziZakaznik.ZakaznikId = np.zakaznik.zakaznik_id;
                predchoziZakaznik.Zakaznik = np.ZakaznikNazev;
                predchoziZakaznik.PocetNabidek++;
                if (np.objednavka_polozkas.Count > 0) predchoziZakaznik.PocetUspesnychNabidek++;
            });

            return result;
        }
        private List<ObjednavkaGridRow> LoadObjednavky()
        {
            List<ObjednavkaGridRow> result = new List<ObjednavkaGridRow>();
            dbContext.objednavka_polozkas.Where(op => op.d_zadal >= (objednavkaOd ?? DateTime.MinValue) && op.d_zadal <= (objednavkaDo ?? DateTime.MaxValue))
            .ToList().ForEach(op =>
             {
                 List<ObjednavkaGridRow> objednavkyTmp = new List<ObjednavkaGridRow>();

                 if (op.pruvodkas.Count == 0)
                 {
                     objednavkyTmp.Add(new ObjednavkaGridRow()
                     {
                         PocetKs = op.pozadovano_pocet
                     });
                 }
                 else
                 {
                     //Objednavka ma vice jak 0 pruvodek, pro kazdou pruvodku se vytvori objednavka do objednavkyTMP a vyplni atributy z pruvodky
                     for (int i = 1; i <= op.pruvodkas.Count; i++)
                     {
                         pruvodka pruvodka = op.pruvodkas.ToArray()[i - 1];
                         objednavkyTmp.Add(new ObjednavkaGridRow()
                         {
                             PocetKs = pruvodka.pocet_kusu,
                             CisloPruvodky = pruvodka.cisloPruvodky
                         });
                     }
                 }

                 //Atributy spolecné (nejsou z objeku pruvodka) se hromadně nastaví pro celý list objednavkyTMP
                 objednavkyTmp.ForEach(ot =>
                 {
                     ot.Zakaznik = op.ZakaznikNazev;
                     ot.NazevDPS = op.NazevDPS;
                     ot.TechnologPlusVyrobniPridavek = (op.tech_pridavek ?? 0) + (op.vyrobni_pridavek ?? 0);
                     ot.TerminVyroby = op.termin_vyroby;
                     ot.TerminExpedice = op.termin_expedice;
                     ot.DruhTerminu = op.termin_typ == null ? "" : op.termin_typ.nazev;
                     ot.TypDesky = op.PlosnySpojSpecifikaceNazev;
                 });

                 result.AddRange(objednavkyTmp);
             });

            return result.OrderByDescending(o => o.Expedice).ToList();
        }
        private void btnHledat_Click(object sender, EventArgs e)
        {
            if ((SimpleButton)sender == btnNabidkyHledat)
                this.LoadNabidkyDatasource();
            else if ((SimpleButton)sender == btnObjednavkyHledat)
                this.LoadObjednavkyDatasource();
        }
        private void btnExportXLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*";

            if (this.tabControl.SelectedTabPage == this.tabNabidky)
                dialog.FileName = "ReportNabidky_" + DateTime.Now.ToString("yyyyMMdd");
            else if (this.tabControl.SelectedTabPage == this.tabObjednavky)
            {
                if (((List<ObjednavkaGridRow>)this.grdObjednavky.DataSource).Where(o => o.Expedice.Trim() != "").Count() == 0)
                {
                    MessageBox.Show("Nejsou zvolena žádná data ve sloupci Expedice", "Expedice" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dialog.FileName = "ReportObjednavky_" + DateTime.Now.ToString("yyyyMMdd");
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (this.tabControl.SelectedTabPage == this.tabNabidky)
                    new ObchodNabidkyReport().Export(dialog.FileName, (List<NabidkaGridRow>)this.grdNabidky.DataSource, nabidkaOd, nabidkaDo);
                else if (this.tabControl.SelectedTabPage == this.tabObjednavky)
                    new ObchodObjednavkyReport().Export(dialog.FileName, (List<ObjednavkaGridRow>)this.grdObjednavky.DataSource, objednavkaOd, objednavkaDo);
                System.Diagnostics.Process.Start(dialog.FileName);
            }
        }

        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTabPage == this.tabNabidky)
            {
                this.dtNabidkyDo.EditValue = this.dtNabidkyOd.EditValue = null;
                this.LoadNabidkyDatasource();
            }
            else if (this.tabControl.SelectedTabPage == this.tabObjednavky)
            {
                this.dtObjednavkyDo.EditValue = this.dtObjednavkyOd.EditValue = null;
                this.LoadObjednavkyDatasource();
            }
        }

        private void btnObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.tabControl.SelectedTabPage == this.tabNabidky) this.LoadNabidkyDatasource();
            else if (this.tabControl.SelectedTabPage == this.tabObjednavky) this.LoadObjednavkyDatasource();
        }
    }
}