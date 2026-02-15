using PCB.Base;
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
    public partial class frmPruvodkaFrontaDetail : frmBaseDetail
    {
        public frmPruvodkaFrontaDetail()
        {
            InitializeComponent();
            PravaIgnore = true;
        }


        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        
            bindingSource1.DataSource = ((pruvodka)this.entityObject);
            
        }
              

        private void btnObjednavka_Click(object sender, EventArgs e)
        {
            if ((pruvodka)this.entityObject != null)
            {
                frmObjednavkaPolozkaDetail detail = new frmObjednavkaPolozkaDetail();
                objednavka_polozka obj = ((pruvodka)this.entityObject).objednavka_polozka;
                detail.ShowDetail(this, obj);
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.DBContext.SaveChanges();
            this.Close();
        }
                
        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPruvodkaFrontaDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
