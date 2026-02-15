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
    public partial class frmPostupDetail : frmBaseSeznam
    {
        public frmPostupDetail()
        {
            InitializeComponent();
        }
        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            postupoperaceBindingSource.DataSource = ((postup)this.entityObject).postup_operaces;
        }

        
        private void btnBarNova_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOperaceVyber vyber = new frmOperaceVyber();
            if (vyber.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                int i = 0;
                foreach (operace o in vyber.Vybrano)
                {
                    if (o.Vybrano == false)
                    {
                        continue;
                    }

                    i++;
                    postup_operace po = new postup_operace();
                    po.operace = o;
                    po.postup = (postup)this.entityObject;
                    po.poradi = i;
                    ((postup)this.entityObject).postup_operaces.Add(po);
                }
            }

        }

        private void btnZavrit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void btnOdstranit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (postupoperaceBindingSource.Current != null)
            {
                ((postup)entityObject).postup_operaces.Remove(((postup_operace)postupoperaceBindingSource.Current));
            }
        }

        private void btnOK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        
        
    }
}
