using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PCB.Report
{
    public class ReportBuilder
    {
        public string Template
        {
            get { return this.template; }
            set { this.template = value;
                this.CreateWorkBook();
            }
        }

        private string template;

        protected FileStream fileTemplate;
        protected NPOI.POIFS.FileSystem.POIFSFileSystem nfs;
        protected HSSFWorkbook workbook;
        protected IDataFormat DataFormatCustom;

        protected short StyleN0;
        protected short StyleN2;
        protected short StyleDate;
        protected short StyleP2;

        public ReportBuilder(string template)
        {
            this.Template = template;
        }

        private void CreateWorkBook()
        {
            if (fileTemplate != null) fileTemplate.Dispose();
            this.fileTemplate = new FileStream(this.Template, FileMode.Open, System.IO.FileAccess.Read);
            this.nfs = new NPOI.POIFS.FileSystem.POIFSFileSystem(fileTemplate);
            this.workbook = new HSSFWorkbook(this.nfs);
            this.SetStyles();
        }

        public ICell AddCellValue(IRow row, object value, CellFormat format, ref int index, bool autosize = false)
        {
            int i = index++;

            if (value == null)
            {
                return null;
            }

            ICell cell = row.GetCell(i);
            if (cell == null)
            {
                cell = row.CreateCell(i);
            }

            switch (format)
            {
                case CellFormat.N0:
                    cell.SetCellType(CellType.Numeric);
                    cell.CellStyle.DataFormat = this.StyleN0;
                    break;
                case CellFormat.N2:
                    cell.SetCellType(CellType.Numeric);
                    cell.CellStyle.DataFormat = this.StyleN2;
                    break;
                case CellFormat.P2:
                    cell.CellStyle.DataFormat = this.StyleP2;
                    break;
                case CellFormat.DateTime:
                    cell.CellStyle.DataFormat = this.StyleDate;
                    break;
                default:
                    cell.SetCellType(CellType.String);
                    cell.SetCellValue(value.ToString());
                    break;
            }

            if (value is int)
            {
                cell.SetCellValue((int)value);
            }
            else if (value is int?)
            {
                cell.SetCellValue(((int?)value).Value);
            }
            else if (value is double || value is decimal)
            {
                cell.SetCellValue((double)value);
            }
            else if (value is double?)
            {
                cell.SetCellValue(((double?)value).Value);
            }
            else if (value is decimal?)
            {
                cell.SetCellValue((double)((decimal?)value).Value);
            }
            else if (value is DateTime?)
            {
                cell.SetCellValue(((DateTime?)value).Value);
            }
            else if (value is DateTime)
            {
                cell.SetCellValue(((DateTime)value));
            }

            if (autosize)
            {
                row.Sheet.AutoSizeColumn(cell.ColumnIndex);
            }

            row.Sheet.ForceFormulaRecalculation = true;

            return cell;
        }

        private void SetStyles()
        {
            this.DataFormatCustom = workbook.CreateDataFormat();
            
            this.StyleDate = this.DataFormatCustom.GetFormat("dd.MM.yyyy");
            this.StyleN0 = this.DataFormatCustom.GetFormat("0");
            this.StyleN2 = this.DataFormatCustom.GetFormat("0.00");
            this.StyleP2 = this.DataFormatCustom.GetFormat("0.00 %");
        }
    }

    public enum CellFormat
    {
        N0, N2, P2, DateTime, String
    }

}
