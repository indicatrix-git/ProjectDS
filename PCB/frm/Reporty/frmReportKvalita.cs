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

namespace PCB.frm.Reporty
{
    public partial class frmReportKvalita : frmBaseSeznam
    {
        public frmReportKvalita()
        {
            InitializeComponent();
        }


        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);

            //DateTime? dateOd = (deObdobiOd.EditValue != null ? (DateTime)deObdobiOd.EditValue : (DateTime?)null);
            //DateTime? dateDo = (deObdobiDo.EditValue != null ? (DateTime)deObdobiDo.EditValue : (DateTime?)null);


            this.strSQL = @"
            SELECT
            nt.kod AS ""Kod"",
            nt.nazev AS ""Nazev chyby""

            FROM neshoda_typ nt
            WHERE 1 = 1";



            //if (dateOd.HasValue)
            //{
            //    strSQL += string.Format(" AND obj.d_zadal >= '{0}'", dateOd.Value.ToString("yyyy-MM-dd 00:00"));
            //}

            //if (dateDo.HasValue)
            //{
            //    strSQL += string.Format(" AND obj.d_zadal <= '{0}'", dateDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            //}

            bsNeshody.DataSource = this.GetData();

            //DateTime? dateOd = (deObdobiOd.EditValue != null ? (DateTime)deObdobiOd.EditValue : (DateTime?)null);
            //DateTime? dateDo = (deObdobiDo.EditValue != null ? (DateTime)deObdobiDo.EditValue : (DateTime?)null);


            this.strSQL = @"
            SELECT
            nt.kod AS ""Kod"",
            nt.nazev AS ""Nazev chyby""

            FROM neshoda_typ nt
            WHERE 1 = 1";



            //if (dateOd.HasValue)
            //{
            //    strSQL += string.Format(" AND obj.d_zadal >= '{0}'", dateOd.Value.ToString("yyyy-MM-dd 00:00"));
            //}

            //if (dateDo.HasValue)
            //{
            //    strSQL += string.Format(" AND obj.d_zadal <= '{0}'", dateDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            //}

            bsOpravy.DataSource = this.GetData();
        }





        public void btnVyhledatOpravy_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void btnVyhledatNeshody_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void btnZrusitFiltrNeshody_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void btnZrusitFiltrOpravy_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void bbiObnovitSeznamNeshody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }

        private void bbiObnovitSeznamOpravy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }

        private void bbiExportXLSOpravy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bsOpravy.Current != null)
            {
                System.Diagnostics.Process.Start(PrintOpravy());
            }
        }

        private void bbiExportXLSNeshody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bsOpravy.Current != null)
            {
                System.Diagnostics.Process.Start(PrintNeshody());
            }
        }



        public string PrintOpravy()
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";
            string fileNameTemplate = @"template\ReportASVOpravy.xls";

            FileStream fileTemplate = new FileStream(fileNameTemplate, FileMode.Open, System.IO.FileAccess.Read);
            NPOI.POIFS.FileSystem.POIFSFileSystem nfs = new NPOI.POIFS.FileSystem.POIFSFileSystem(fileTemplate);


            using (FileStream file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                HSSFWorkbook workbook = new HSSFWorkbook(nfs);
                ISheet sheet = workbook.GetSheetAt(0);



                IEnumerable<KvalitaOpravy> result =
                    from nt in this.DBContext.neshoda_typs
                    where true
                    select new KvalitaOpravy()
                    {
                        Kod = nt.kod,
                        NazevChyby = nt.nazev
                    };


                int i = 0;
                foreach (KvalitaOpravy ko in result)
                {
                    IRow row = sheet.CreateRow(i);
                    row.CreateCell(i - i).SetCellValue(ko.Kod);
                    row.CreateCell(i - (i - 1)).SetCellValue(ko.NazevChyby);
                    i++;
                }

                workbook.Write(file);
                file.Close();
            }
            return fileName;
        }

        public string PrintNeshody()
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";
            string fileNameTemplate = @"template\ReportASVOpravy.xls";

            FileStream fileTemplate = new FileStream(fileNameTemplate, FileMode.Open, System.IO.FileAccess.Read);
            NPOI.POIFS.FileSystem.POIFSFileSystem nfs = new NPOI.POIFS.FileSystem.POIFSFileSystem(fileTemplate);


            using (FileStream file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                HSSFWorkbook workbook = new HSSFWorkbook(nfs);
                ISheet sheet = workbook.GetSheetAt(0);



                IEnumerable<KvalitaOpravy> result =
                    from nt in this.DBContext.neshoda_typs
                    where true
                    select new KvalitaOpravy()
                    {
                        Kod = nt.kod,
                        NazevChyby = nt.nazev
                    };


                int i = 0;
                foreach (KvalitaOpravy ko in result)
                {
                    IRow row = sheet.CreateRow(i);
                    row.CreateCell(i - i).SetCellValue(ko.Kod);
                    row.CreateCell(i - (i - 1)).SetCellValue(ko.NazevChyby);
                    i++;
                }


                workbook.Write(file);
                file.Close();
            }
            return fileName;
        }

        
    }
}
