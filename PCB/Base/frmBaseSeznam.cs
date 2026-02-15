using Devart.Data.PostgreSql;
using DevExpress.XtraBars;
using PCB.Data;
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

namespace PCB.Base
{
    public partial class frmBaseSeznam : frmBase
    {
        public  bool first = false;
        public string ZakaznikNazev { get; set; }

        public List<PgSqlParameter> ParamSQL;
        public string strSQL { get; set; }

        public enum modeCiselnik { ciselnik, vyberCiselnik }
        private modeCiselnik seznamMode = modeCiselnik.ciselnik;
        public modeCiselnik SeznamMode
        {
            get { return seznamMode; }
            set { seznamMode = value; }
        }

        public override void LoadData(EntityObject entity)
        {
            ParamSQL = new List<PgSqlParameter>();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                base.LoadData(entity);
                this.dbContext = AppHelper.CreateDBContext();
            }
        }

        public DataTable GetData()
        {
            return DBHelper.SQLSelect(this.DBContext, strSQL, this.ParamSQL);
        }

        public virtual EntityObject GetEntity(int id)
        {
            return null;
        }

        public virtual EntityObject Current
        {
            get
            {

                return null;
            }
        }

        /// <summary>
        /// aplikuje prava
        /// </summary>
        public virtual void ApplyRight()
        {

        }

        public frmBaseSeznam()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += frmBaseSeznam_Load;
        }
        
        private void frmBaseSeznam_Load(object sender, EventArgs e)
        {
            ApplyRight();
            this.LoadData(null);
        }

    }
}
