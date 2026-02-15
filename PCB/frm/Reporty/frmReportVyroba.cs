using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PCB.Base;
using PCB.Data.CustomObjects;
using PCB.Report;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PCB.frm.Reporty
{
    public partial class frmReportVyroba : frmBaseSeznam
    {
        DateTime? dateOd;
        DateTime? dateDo;
        public frmReportVyroba()
        {
            InitializeComponent();
            DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.dtOd.EditValue = start;
            this.dtDo.EditValue = start.AddDays(DateTime.DaysInMonth(start.Year, start.Month) - 1);
            this.grvVyroba.Bands.ToList().ForEach(b =>
            {
                if (b.Columns[0].Name.Contains("Filter"))
                {
                    b.Caption = b.Columns[0].Caption;
                    b.Columns[0].AppearanceHeader.Options.UseImage = true;
                    b.Columns[0].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    b.Columns[0].Image = ((System.Drawing.Image)colFilterFoto.Image);
                    b.Columns[0].ImageAlignment = System.Drawing.StringAlignment.Center;
                    b.Columns[0].ImageIndex = 0;
                    b.Columns[0].Width = 35;
                }
            });

            this.grdVyroba.LevelTree.Nodes.Add("ListDetail", this.grvDetail);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.LoadDatasource();
        }
        private void LoadDatasource()
        {
            this.dateOd = dtOd.EditValue != null ? (DateTime)dtOd.EditValue : (DateTime?)null;
            this.dateDo = dtDo.EditValue != null ? (DateTime)dtDo.EditValue : (DateTime?)null;
            this.grdVyroba.DataSource = LoadData();
        }
        private List<VyrobaGridRow> LoadData()
        {
            List<VyrobaGridRow> result = new List<VyrobaGridRow>();
            //MITA?? filtr datumu ok na obj. OK????
            this.dbContext.pruvodkas.Where(pr => pr.objednavka_polozka.d_zadal >= (dateOd ?? DateTime.MinValue) && pr.objednavka_polozka.d_zadal <= (dateDo ?? DateTime.MaxValue)).ToList().ForEach(pr =>
            {
                VyrobaGridRow r = new VyrobaGridRow();
                r.TerminExpedice = pr.objednavka_polozka.termin_expedice;
                r.TerminVyroby = pr.objednavka_polozka.termin_vyroby;
                r.TerminZadani = pr.objednavka_polozka.d_zadal;
                r.Odberatel = pr.objednavka_polozka.ZakaznikNazev;
                r.NazevPS = pr.objednavka_polozka.NazevDPS; //MITA??    PS==DPS ??
                r.Status = pr.objednavka_polozka.stav_objednavka.nazev; //MITA??
                r.PocetObjednano = pr.objednavka_polozka.pozadovano_pocet;
                r.PocetPridavekPocetPanelu = string.Format("{0}/{1}", 999999, pr.pocet_panelu); //MITA?? KDE POCET PRIDAVEK
                r.PocetZmetkuChybyKs = string.Format("{0}/{1}", 999999, 999999); //MITA?? KDE BOZE KDE ?????
                r.CisloPruvodky = pr.cisloPruvodky;
                r.Kod = pr.produkt_kod;
                r.SeznamOperaci.Add(new operace() { nazev = "OPERACE FERDA" }); //MITA?? TO SI DODELA RAHE
                r.CasFrezovaniMinuty = 666; //MITA?? TO SI DODELA RAHE
                r.PocetJizdFrezy = 666; //MITA?? TO SI DODELA RAHE
                result.Add(r);
            });
            return result;
        }
        private void btnHledat_Click(object sender, EventArgs e)
        {
            this.LoadDatasource();
        }
        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            this.dtDo.EditValue = this.dtOd.EditValue = null;
            this.LoadDatasource();
        }
        private void grvVyroba_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = this.grvVyroba.CalcHitInfo(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                if (info.Column != null && info.Column.Name.Contains("Filter"))
                {
                    this.contextMenuFilter.Tag = info.Column;
                    this.contextMenuFilter.Show(this.grdVyroba.PointToScreen(e.Location));
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (info.InColumnPanel && info.Column != null && info.Column.Name.Contains("Filter"))
                {
                    this.grvVyroba.FocusedRowHandle = -1;
                    this.GenerateReportForColumn(info.Column);
                }
            }
        }
        private void btnObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadDatasource();
        }
        private void btnExportXLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.GenerateReport((List<VyrobaGridRow>)this.grdVyroba.DataSource, "Vše", true);
        }
        private void GenerateReportForColumn(GridColumn col)
        {
            List<VyrobaGridRow> source = ((List<VyrobaGridRow>)this.grdVyroba.DataSource)
                .Where(s => (bool)s.GetType().GetProperty(col.FieldName).GetValue(s, null) == true).ToList();

            if (source.Count == 0)
            {
                MessageBox.Show("Nejsou zvolena žádná data ve sloupci " + col.Caption, col.Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.GenerateReport(source, col.Caption, false);
            return;
        }
        private void btnContextMenu_Click(object sender, EventArgs e)
        {
            GridColumn col = (GridColumn)this.contextMenuFilter.Tag;

            ((List<VyrobaGridRow>)this.grdVyroba.DataSource).ForEach(r =>
            {
                r.GetType().GetProperty(col.FieldName).SetValue(r, ((ToolStripMenuItem)sender) == this.btnCheckAll, null);
            });
            this.grdVyroba.RefreshDataSource();
        }
        private void GenerateReport(List<VyrobaGridRow> source, string info, bool fullReport)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*";
            dialog.FileName = info + "_" + DateTime.Now.ToString("yyyyMMdd");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                new VyrobaReport(fullReport).Export(dialog.FileName, source, info);
                System.Diagnostics.Process.Start(dialog.FileName);
            }
        }

        //Rotace textu
        private void grvVyroba_CustomDrawBandHeader(object sender, DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs e)
        {
            if (e.Band == null) return;
            GridColumn col = e.Band.Columns[0];

            if (col == null || !col.Name.Contains("Filter")) return;

            e.Info.Caption = "";
            e.Painter.DrawObject(e.Info);
            System.Drawing.Drawing2D.GraphicsState state = e.Graphics.Save();
            Rectangle r = e.Info.CaptionRect;
            StringFormat sf = new StringFormat();
            sf.Trimming = StringTrimming.EllipsisCharacter;
            sf.FormatFlags = sf.FormatFlags | StringFormatFlags.NoWrap;
            if (col.Caption == "Horizontal")
            {
                sf.LineAlignment = StringAlignment.Far;
            }
            else
            {
                e.Graphics.TranslateTransform(r.Width / 2, r.Height / 2);
                e.Graphics.RotateTransform(270);
                r.X = e.Info.CaptionRect.Y - e.Info.CaptionRect.Height / 2;
                r.Y = e.Info.CaptionRect.X - e.Appearance.FontHeight / 2;
                r.Height = e.Info.CaptionRect.Width;
                r.Width = e.Info.CaptionRect.Height;
            }
            e.Handled = true;
            e.Graphics.DrawString(e.Band.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf);
            e.Graphics.Restore(state);

        }
    }
}
