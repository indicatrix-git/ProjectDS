using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PCB.Base;
using PCB.Gui;
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
    public partial class frmSablonaDetail : frmBaseDetail
    {
        private vrstva vrstvaMaterial = null;
        public PCB.frmProduktDetail.ProduktAkce TypAkce { get; set; }

        public frmSablonaDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                if (this.entityObject == null)
                {
                    this.entityObject = new produkt();
                    ((produkt)this.entityObject).sestavil = this.PrihlasenyUzivatelId;
                }
                ((produkt)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();
                ((produkt)this.entityObject).produkt_stav_id = (int)produkt_stav.Value.aktivni;

            }
            else
            {
                if (TypAkce == PCB.frmProduktDetail.ProduktAkce.zmenaIV)
                {
                    produkt_revize pr = new produkt_revize();
                    if (((produkt)this.entityObject).produkt_revizes.Count == 0)
                    {
                        pr.revize = 1;
                    }
                    else
                    {
                        pr.revize = ((produkt)this.entityObject).produkt_revizes.Max(item => item.revize) + 1;
                    }

                    pr.d_zapsano = PCB.Data.DBHelper.DateTimeNow();
                    pr.uzivatel_id = this.PrihlasenyUzivatelId;

                    ((produkt)this.entityObject).zamek = false;
                    ((produkt)this.entityObject).produkt_revizes.Add(pr);
                }
            }

            ((produkt)this.entityObject).produkt_stav = this.DBContext.produkt_stavs.Where(item => item.produkt_stav_id == ((produkt)this.entityObject).produkt_stav_id).First();

            // pro sicher
            ((produkt)this.entityObject).sablona = true;

            produktBindingSource.DataSource = this.entityObject;
            uzivatelBindingSource.DataSource = this.DBContext.uzivatels.ToList();
            vrstvaBindingSource.DataSource = ((produkt)this.entityObject).vrstvas;
            produktrevizeBindingSource.DataSource = ((produkt)this.entityObject).produkt_revizes;
            lblZamek.Visible = (((produkt)this.entityObject).zamek ?? false);
        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                ((produkt)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();
                ((produkt)this.entityObject).produkt_stav = this.DBContext.produkt_stavs.Where(item => item.produkt_stav_id == 1).First();

                this.DBContext.AddToprodukts((produkt)this.entityObject);

            }

            base.SaveData();

        }

        private void btnEditZakaznik_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmZakaznikSeznam seznam = new frmZakaznikSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;

            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((produkt)this.entityObject).zakaznik_id = ((zakaznik)seznam.entityObject).zakaznik_id;
                ((produkt)this.entityObject).zakaznik = this.DBContext.zakazniks.Where(item => item.zakaznik_id == ((zakaznik)seznam.entityObject).zakaznik_id).First();
                btnEditZakaznik.Text = ((produkt)this.entityObject).zakaznik.interni_nazev;

                if (this.FormMode == mode.novy)
                {
                    ((produkt)this.entityObject).uloziste = ((produkt)this.entityObject).zakaznik.interni_nazev;
                }
            }

        }

        private void btnEditDPS_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmCiselnikKodDPS frm = new frmCiselnikKodDPS(frmCiselnikKodDPS.Value.sablona);
            frm.entityObject = this.entityObject;

            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                string kod = ((produkt)frm.entityObject).kodVypocitany;
                btnEditDPS.Text = kod;
                ((produkt)this.entityObject).kod = kod;
                ((produkt)this.entityObject).plosny_spoj_specifikace_id = ((produkt)frm.entityObject).plosny_spoj_specifikace_id;

            }

        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (((produkt)this.entityObject).zamek ?? false)
            {

                base.setReadonly(cs);

            }
            else
            {
                if (!this.HasPravoZapis(prava.Value.TPVTechnickaDokumentace))
                {
                    base.setReadonly(cs);
                }
            }


            btnStorno.Enabled = true;
            btnHelp.Enabled = true;
            btnKontrola.Enabled = true;
            btnMaterial.Enabled = true;

        }

        private void btnUlozit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Ulozit();
        }

        private void btnZavrit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Storno();
        }

        private void btnMaterial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            frm.entityObject = this.entityObject;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vrstvaMaterial.material = this.DBContext.materials.Where(i => i.material_id == ((material)frm.entityObject).material_id).First();
                btnMaterial.Text = vrstvaMaterial.material.nazev;
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                frmKontrola frm = new frmKontrola();
                if (frm.ShowDetail(this, this.entityObject) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
            }
            catch (Exception ex) { }

            frmProduktWorkflow workflow = new frmProduktWorkflow();
            workflow.entityObject = this.entityObject;
            if (workflow.ShowForm(this) == DialogResult.OK)
            {
                if (workflow.Stav != 0)
                {
                    ((produkt)this.entityObject).produkt_stav_id = (short)workflow.Stav;
                }

                ((produkt)this.entityObject).sablona = true;


                if (this.TypAkce == frmProduktDetail.ProduktAkce.kopie)
                {
                    this.Ulozit();
                }
                else if (this.TypAkce == frmProduktDetail.ProduktAkce.zmenaDPS)
                {
                    this.Ulozit(frmProduktDetail.ProduktAkce.zmenaDPS);
                    this.Close();
                }
                else if (this.TypAkce == frmProduktDetail.ProduktAkce.zmenaIV)
                {
                    this.Ulozit(frmProduktDetail.ProduktAkce.zmenaIV);
                }
                else
                {
                    this.Ulozit();
                }

            }
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnPoznamka_Click(object sender, EventArgs e)
        {
            frmCiselnikVet frm = new frmCiselnikVet();
            if (frm.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (CheckButtonItem v in frm.VybraneVety)
                {
                    if (txtPoznamka.EditValue == null)
                    {
                        txtPoznamka.EditValue = v.Name + "\r\n";
                    }
                    else
                    {
                        txtPoznamka.EditValue += v.Name + "\r\n";
                    }

                    //txtPoznamka.Text += v.Name + "\r\n";
                }
            }
        }

        private void btnPripravVrstvy_Click(object sender, EventArgs e)
        {
            produkt p = (produkt)this.entityObject;

            if (string.IsNullOrEmpty(p.kod))
            {
                frmNapoveda.Set("Kód DPS musí být vyplněn!");
                return;
            }

            p.plosny_spoj_specifikace.PripravVrstvyDleKodu(p);

        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            ((produkt)this.entityObject).vrstvas.Add(new vrstva());
        }

        private void btnVrstvaOdstranit_Click(object sender, EventArgs e)
        {
            if (vrstvaBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((vrstva)vrstvaBindingSource.Current);
            }
        }

        private void btnVrstvaOdstranitVse_Click(object sender, EventArgs e)
        {
            if (((produkt)this.entityObject).vrstvas.Count > 0)
            {
                foreach (vrstva item in ((produkt)this.entityObject).vrstvas.ToList())
                {
                    this.DBContext.DeleteObject(item);
                }
            }
        }

        private void btnVrstvaDolu_Click(object sender, EventArgs e)
        {
            vrstva vr = (vrstva)vrstvaBindingSource.Current;
            vrstva vr1 = ((IEnumerable<vrstva>)vrstvaBindingSource.DataSource).Where(i => i.poradi == (vr.poradi + 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                vrstvaBindingSource.Position = vrstvaBindingSource.IndexOf(vr);
                gcVrstvy.Refresh();
            }
        }

        private void btnVrstvaNahoru_Click(object sender, EventArgs e)
        {
            vrstva vr = (vrstva)vrstvaBindingSource.Current;
            vrstva vr1 = ((IEnumerable<vrstva>)vrstvaBindingSource.DataSource).Where(i => i.poradi == (vr.poradi - 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {

                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                vrstvaBindingSource.Position = vrstvaBindingSource.IndexOf(vr);
                gcVrstvy.Refresh();
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            frm.ShowDialog();
        }

        private void btnSkladMaterialuOdkaz_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"x:\SpolecnaData\Info\Skladové_zásoby_PCB10.pdf", true);
        }

        private void btnEditMaterial_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((vrstva)vrstvaBindingSource.Current).material_id = ((material)frm.entityObject).material_id;
                gridView1.FocusedRowHandle = -1;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (((produkt)this.entityObject).zakaznik != null)
            {
                frmNapoveda.Set(((produkt)this.entityObject).zakaznik.GetPoznamkyTPV());
            }
        }

        private void btnKontrola_Click(object sender, EventArgs e)
        {
            if (((produkt)this.entityObject).kod == "")
            {
                MessageBox.Show("Nemáte vyplněný kód.");

            }
            else
            {
                frmKontrola frm = new frmKontrola();
                frm.ShowDetail(this, this.entityObject);
            }
        }

        private void btnRevizeNovy_Click(object sender, EventArgs e)
        {


            produkt_revize pr = new produkt_revize();
            pr.revize = ((produkt)this.entityObject).produkt_revizes.Sum(i => i.revize) > 0 ?
                        ((produkt)this.entityObject).produkt_revizes.Max(i => i.revize) + 1 :
                        1;
            pr.d_zapsano = PCB.Data.DBHelper.DateTimeNow();
            pr.poznamka = "";
            pr.uzivatel_id = this.PrihlasenyUzivatelId;

            ((produkt)this.entityObject).produkt_revizes.Add(pr);

        }

        private void btnRevizeOdstranit_Click(object sender, EventArgs e)
        {
            if ((produkt_revize)produktrevizeBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((produkt_revize)produktrevizeBindingSource.Current);
            }
        }

        private void number_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            this.base_number_ParseEditValue(sender, e);
        }

        private void int_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            this.base_int_ParseEditValue(sender, e);
        }

        private void frmSablonaDetail_Load(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',', '.' };
            string text = txtTotalHrPan.Text;
            string[] str = text.Split(delimiterChars);

            txtTotalHrPan.Text = str[0];
        }

        private void txtPoznamka_EditValueChanged(object sender, EventArgs e)
        {
            ((produkt)this.entityObject).poznamka = txtPoznamka.Text;
        }
    }
}
