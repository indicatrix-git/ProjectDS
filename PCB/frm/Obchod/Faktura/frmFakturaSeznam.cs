using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;
using PCB.Data;
using DevExpress.XtraGrid.Views.Base;
using Devart.Data.PostgreSql;
using System.Data.Entity.Core.Objects.DataClasses;

namespace PCB
{
    public partial class frmFakturaSeznam : frmBaseSeznam
    {
        public frmFakturaSeznam()
        {
            InitializeComponent();
        }

        public override void ApplyRight()
        {
            base.ApplyRight();
            if (!this.HasPravoZapis(prava.Value.ObchodFakturace))
            {
                btnBarNova.Enabled = false;
            }
            
        }

        public override EntityObject GetEntity(int id)
        {
            return this.DBContext.fakturas.Where(item => item.faktura_id == id).FirstOrDefault();
        }

        public override System.Data.Entity.Core.Objects.DataClasses.EntityObject Current
        {
            get
            {
                if (this.fakturaBindingSource.Current != null)
                {
                    int id = int.Parse(((DataRowView)this.fakturaBindingSource.Current)["id"].ToString());
                    return this.GetEntity(id);
                }
                return null;

            }
        }
        
        public override void LoadData(EntityObject entity)
        {
            base.LoadData(entity);
            fakturastavBindingSource.DataSource = DBContext.faktura_stavs.ToList();

            DateTime? dateOd = (dateEditPrijataOd.EditValue != null ? (DateTime)dateEditPrijataOd.EditValue : (DateTime?)null);
            DateTime? dateDo = (dateEditPrijataDo.EditValue != null ? (DateTime)dateEditPrijataDo.EditValue : (DateTime?)null);

            if (!string.IsNullOrEmpty(this.ZakaznikNazev))
            {
                txtZakaznikHledej.Text = this.ZakaznikNazev;
            }

            int typFaktury = 0;

            // uz jsem nevedel jak
            if (cbTypFaktury.EditValue != null)
            {
                if (cbTypFaktury.EditValue.ToString() == "Tuzemské")
                {
                    typFaktury = 1;
                }
                else if (cbTypFaktury.EditValue.ToString() == "Zahraniční")
                {
                    typFaktury = 2;
                }
                else
                {
                    typFaktury = 0; // všechny
                }
            }

            int stav = cmbStav.EditValue == null ? 0 : (int)cmbStav.EditValue;

            this.strSQL = @"
SELECT 
    f.faktura_id AS id,
    f.cislo_faktury,
    z.interni_nazev AS zakaznik,
    fs.nazev AS stav,
    u.prijmeni || ' ' || u.jmeno AS sestavil,
    (SELECT sum(cena_ks * pocet_ks) FROM faktura_polozka WHERE faktura_id = f.faktura_id ) AS cena,
    f.d_vystaveno AS sestaveno
FROM faktura f
JOIN faktura_stav fs ON fs.faktura_stav_id = f.faktura_stav_id
JOIN uzivatel u ON u.uzivatel_id = f.vystavil_id
JOIN zakaznik z ON z.zakaznik_id = f.zakaznik_id
WHERE 1=1";

            if (!String.IsNullOrEmpty(txtZakaznikHledej.Text))
            {
                strSQL += " AND upper(z.interni_nazev) like @interni_nazev";
                this.ParamSQL.Add(new PgSqlParameter("@interni_nazev", string.Format("%{0}%",txtZakaznikHledej.Text.ToUpper())));
            }

            if (!String.IsNullOrEmpty(txtCisloFaktury.Text))
            {
                strSQL += " AND upper(f.cislo_faktury) like @cislo_faktury";
                this.ParamSQL.Add(new PgSqlParameter("@cislo_faktury", string.Format("%{0}%",txtCisloFaktury.Text.ToUpper())));
            }

            if (stav != 0)
            {
                strSQL += " AND f.faktura_stav_id=@stav";
                this.ParamSQL.Add(new PgSqlParameter("@stav", stav));
            }

            if (typFaktury > 0)
            {
                strSQL += string.Format(" AND coalesce(f.zahranicni, false)={0}", typFaktury == 2 ? "true" : "false");
            }

            if (dateOd.HasValue)
            {
                strSQL += string.Format(" AND f.d_vystaveno>='{0}'", dateOd.Value.ToString("yyyy-MM-dd 00:00"));
            }

            if (dateDo.HasValue)
            {
                strSQL += string.Format(" AND f.d_vystaveno<='{0}'", dateDo.Value.ToString("yyyy-MM-dd 23:59:59"));
            }

            fakturaBindingSource.DataSource = this.GetData();
         
            if (entity != null)
            {
                int pozice = fakturaBindingSource.Find("id", ((faktura)entity).faktura_id);
                ((ColumnView)gcSeznam.MainView).FocusedRowHandle = 0;
                ((ColumnView)gcSeznam.MainView).FocusedRowHandle = ((ColumnView)gcSeznam.MainView).GetRowHandle(pozice);
            }
        }


        private void btnBarDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detail();
        }

        private void btnBarNova_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFakturaDetail frm = new frmFakturaDetail();
            frm.FormMode = Base.frmBaseDetail.mode.novy;

            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadData(frm.entityObject);
            }
            else
            {
                this.LoadData(null);
            }
        }

        private void gcSeznam_DoubleClick(object sender, EventArgs e)
        {
            detail();
        }

        private void detail()
        {
            if (this.Current != null)
            {
                frmFakturaDetail frm = new frmFakturaDetail();
                frm.ShowDetail(this, this.Current);
                this.LoadData(frm.entityObject);
            }
        }

        private void btnZrusitFiltr_Click(object sender, EventArgs e)
        {
            txtZakaznikHledej.Text = "";
            dateEditPrijataDo.EditValue = null;
            dateEditPrijataDo.EditValue = null;
            cmbStav.EditValue = null;
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            this.LoadData(null);
        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detail();
        }

        private void btnObnovit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }

        private void btnObnovitSeznam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LoadData(null);
        }
    }
}
