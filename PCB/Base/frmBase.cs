 using DevExpress.XtraEditors;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PCB.Base
{
    public class frmBase : XtraForm
    {
        
        #region prava

        public bool PravaIgnore { get; set; }
        public int PrihlasenyUzivatelId
        {
            get
            {
                return AppHelper.Uzivatel.uzivatel_id;
            }
        }

        public uzivatel PrihlasenyUzivatel
        {
            get
            {
                return AppHelper.Uzivatel;

            }
        }
      

        public bool HasPravoZapis(params prava.Value[] prava)
        {
            foreach(var item in prava)
            {
                if (this.PrihlasenyUzivatel.HasPravo(item)== prava_hodnota.Value.zapis)
                {
                    return true;
                }
            }

            return false;            
        }

        public bool HasPravoZapisNeboCteni(params prava.Value[] prava)
        {
            foreach (var item in prava)
            {
                if (this.PrihlasenyUzivatel.HasPravo(item) == prava_hodnota.Value.zapis || this.PrihlasenyUzivatel.HasPravo(item) == prava_hodnota.Value.cteni)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region data

        public EntityObject parentEntityObject;
        public EntityObject entityObject;
        public object Filtr { get; set; }
        public frmBase ParentFormBase { get; set; }

        #endregion
        
        #region dbcontext

        public  pcb_develEntities dbContext;
        public pcb_develEntities DBContext
        {
            get
            {
                if (dbContext != null )
                {
                    return dbContext;
                }
                
                return dbContext = AppHelper.CreateDBContext();
            }
        }
        
        #endregion

        #region virtual

        public virtual void LoadData(EntityObject entity)
        {

        }
        #endregion

        #region showForm metods

        public void showInParent(frmBase parent, frmBase frm, object sender)
        {
            this.ParentFormBase = parent;

            if (this.MdiChildren.Where(i => i.Name == frm.Name).Count() == 0)
            {
                frm.MdiParent = this;
                frm.Filtr = sender;
                frm.WindowState = FormWindowState.Maximized;
                frm.dbContext = AppHelper.CreateDBContext();
                frm.Show();
            }
            else
            {
                Form myFrm = this.MdiChildren.Where(i => i.Name == frm.Name).First();
                myFrm.Activate();
            }
        }

        public DialogResult ShowForm(frmBase parent)
        {
            this.ParentFormBase = parent;
            return this.ShowDialog(parent);
        }

        public void showInParent(frmBase parent, frmBase frm)
        {
            showInParent(parent, frm, null);
        }

        #endregion
        
        #region other

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.SuspendLayout();
            // 
            // frmBase
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase";
            this.ResumeLayout(false);

        }
        #endregion

    }
}
