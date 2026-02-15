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
    public partial class frmOperaceSeznam : frmBaseSeznam
    {
        public frmOperaceSeznam()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            operaceBindingSource.DataSource = DBContext.operaces;

            gridView1.BestFitColumns();
        }

        private void btnBarNova_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBContext.operaces.AddObject(new operace());
        }

        private void btnUlozit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DBContext.SaveChanges();
            this.Close();
        }

        private void btnZavrit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private string GetKody(string kody)
        {
            return kody.Replace("V;", "4A;6A;8A;10A;12A;4B;6B;8B;10B;12B;").Replace("O;", "O.;").Replace("S:;", "SN.;").Replace("W;", "W2;W4;W6;").Replace("N;","N.;").Replace("J","J.;J0;J1"); 
        }

        private void btnPropsat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<postup> postups = this.DBContext.postups.Where(i => i.typ_deska ?? false).ToList();

            foreach (operace o in this.DBContext.operaces)
            {
                string[] znak = GetKody(o.popis).Split(';');
                    foreach (string z in znak)
                    {
                       postup p = postups.Where(i => i.kod.Trim() == z.Trim()).FirstOrDefault();
                       if (p != null)
                       {
                           postup_operace pp = new postup_operace();
                           pp.operace = o;
                           pp.postup = p;
                           p.postup_operaces.Add(pp);
                       }
                    }
                
            }

            this.DBContext.SaveChanges();

        }

        private void btnObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }
    }
}
