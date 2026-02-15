using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;

namespace PCB
{
    public partial class frmOpravaDetail : frmBaseDetail
    {
        public frmOpravaDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                oprava oprava = new oprava();
                this.entityObject = oprava;
            }

            opravaBindingSource.DataSource = this.entityObject;

            neshodaTypBindingSource.DataSource = DBContext.neshoda_typs.ToList();
            pruvodkaOperaceBindingSource.DataSource = DBContext.pruvodka_operaces.Where(w => w.pruvodka_id == ((pruvodka)this.parentEntityObject).pruvodka_id).ToList();
        }

        public override void SaveData()
        {
            base.SaveData();
            ((oprava)this.entityObject).d_zapsani = PCB.Data.DBHelper.DateTimeNow();
            ((oprava)this.entityObject).zapsal_id = this.PrihlasenyUzivatelId;
            ((oprava)this.entityObject).pruvodka_id = ((pruvodka)this.parentEntityObject).pruvodka_id;

            if (this.FormMode == mode.novy)
            {
                DBContext.opravas.AddObject(((oprava)this.entityObject));
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
