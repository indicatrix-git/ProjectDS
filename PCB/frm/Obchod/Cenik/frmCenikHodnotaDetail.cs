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
    public partial class frmCenikHodnotaDetail : frmBaseDetail
    {
        public frmCenikHodnotaDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
            cenikhodnotaBindingSource.DataSource = ((cenik)this.entityObject).GetCenikHodnota(this.DBContext).OrderBy(i=>i.cenik_polozka_id);
            cenikvrstacuBindingSource.DataSource = ((cenik)this.entityObject).cenik_vrsta_cus;

            materialBindingSource.DataSource = this.DBContext.materials.ToList().OrderBy(i=>i.material_typ.poradi).ThenBy(i=>i.poradi);
            vrstvacuBindingSource.DataSource = this.DBContext.vrstva_cus.ToList();
            
        }

        public override void setReadonly(Control.ControlCollection cs)
        {

            if (!this.HasPravoZapis(prava.Value.ObchodCenik))
            {
                base.setReadonly(cs);
            }
                
        }

        public override void SaveData()
        {
            base.SaveData();
        }

        private void btnCenikNovy_Click(object sender, EventArgs e)
        {
            frmCenikDetail frm = new frmCenikDetail();
            frm.ShowDetailNovy(this);
        }

        private void btnCenik_Click(object sender, EventArgs e)
        {
            frmCenikDetail frm = new frmCenikDetail();
            frm.ShowDetail(this, (cenik)cenikBindingSource.Current);
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            cenik_vrsta_cu cenik_vrstva = new cenik_vrsta_cu();
            cenik_vrstva.vrstva_cu_id = 1;
            ((cenik)this.entityObject).cenik_vrsta_cus.Add(cenik_vrstva);
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Ulozit();
        }

        
    }
}
