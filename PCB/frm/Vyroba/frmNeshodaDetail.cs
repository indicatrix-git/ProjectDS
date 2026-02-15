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
    public partial class frmNeshodaDetail : frmBaseDetail
    {
        public frmNeshodaDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                neshoda n = new neshoda();
                this.entityObject = n;
                neshodaBindingSource.DataSource = n;
            }
            else
            {
                neshodaBindingSource.DataSource = this.entityObject;
            }
            neshodatypBindingSource.DataSource = DBContext.neshoda_typs.ToList();
            pruvodkaOperaceBindingSource.DataSource = DBContext.pruvodka_operaces.Where(w => w.pruvodka_id == ((pruvodka)this.parentEntityObject).pruvodka_id).ToList();
        }

        public override void SaveData()
        {

            base.SaveData();
            ((neshoda)this.entityObject).d_zapsani = PCB.Data.DBHelper.DateTimeNow();
            ((neshoda)this.entityObject).zapsal_id = this.PrihlasenyUzivatelId;
            ((neshoda)this.entityObject).pruvodka_id = ((pruvodka)this.parentEntityObject).pruvodka_id;

            if (this.FormMode == mode.novy)
            {
                DBContext.neshodas.AddObject(((neshoda)this.entityObject));
            }

            DBContext.SaveChanges();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.Ulozit();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }
    }
}
