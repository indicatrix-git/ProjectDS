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
using DevExpress.XtraEditors;

namespace PCB
{
    public partial class frmPruvodkaOdepisovani : frmBaseDetail
    {
        private pruvodka NalezenaPruvodka { get; set; }
        private uzivatel NalezenaUzivatel { get; set; }

        public frmPruvodkaOdepisovani()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (this.PrihlasenyUzivatel.HasPravo(prava.Value.VyrobaOdepisovani) == prava_hodnota.Value.zapis)
            {
                base.setReadonly(cs);
            }

        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPruvodkaDetail frm = new frmPruvodkaDetail();
            frm.ShowForm(this);
        }

        private void btnZobrazitPruv_Click(object sender, EventArgs e)
        {
            frmObjednavkaPolozkaDetail frm = new frmObjednavkaPolozkaDetail();
            frm.ShowDetail(this, this.NalezenaPruvodka.objednavka_polozka);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.dbContext = AppHelper.CreateDBContext();
            bool chyba = false;

            var vysluziv = this.DBContext.uzivatels.Where(i => i.uzivatel_id == this.PrihlasenyUzivatelId).First();

            var vysl = this.DBContext.pruvodkas.Where(i => i.cislo == textCisloPruvOdepis.Text && i.objednavka_polozka.stav_objednavka_id == (int)stav_objednavka.Value.SpustenaDoVyroby).FirstOrDefault();

            if (vysl.pruvodka_stav_id == (int)pruvodka_stav.Value.dokoncena)
            {
                MessageBox.Show("Tato průvodka již byla dokončena.", "Odepisování", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCisloPruvOdepis.Text = "";
                txtPinPruvodky.Text = "";
                textCisloPruvOdepis.Focus();

                return;
            }

            if (vysl != null && vysl.pin != txtPinPruvodky.Text)
            {
                if (vysl.objednavka_polozka.plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
                {
                    vysl = null;
                }
            }

            if (vysl == null)
            {
                chyba = true;
            }

            if (chyba)
            {
                MessageBox.Show("Chyba přihlášení!", "Odepisování", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCisloPruvOdepis.Text = "";
                txtPinPruvodky.Text = "";
                textCisloPruvOdepis.Focus();
            }
            else
            {
                pOdepisovani.Visible = true;
                textCisloPruvOdepis.Enabled = false;
                txtPoznamkaObchod.Text = ((pruvodka)vysl).poznamkaObchod;
                txtPinPruvodky.Enabled = false;
                btnOK.Enabled = false;

                this.NalezenaPruvodka = (pruvodka)vysl;
                this.NalezenaUzivatel = (uzivatel)vysluziv;



                if (this.NalezenaPruvodka.objednavka_polozka.plosny_spoj_druh_id != (int)plosny_spoj_druh.Value.Kooperace)
                {
                    btnUzavritKooperaci.Visible = false;
                    pOdepisovani.Visible = true;
                    //this.NalezenaPruvodka.objednavka_polozka.produkt.LoadSeznamOperaci();




                    List<pruvodka_operace> lsVsechny = this.NalezenaPruvodka.pruvodka_operaces.OrderBy(ob => ob.poradi).ToList();
                    List<int> lsHotove = (from item in this.NalezenaPruvodka.pruvodka_odepisovanis
                                          select item.pruvodka_operace_id.Value).ToList();

                    this.NalezenaPruvodka.hotovo_procento = Convert.ToInt32(Math.Round(Convert.ToDouble(lsHotove.Count * 100) / Convert.ToDouble(lsVsechny.Count), 0));
                    progressBarControl1.EditValue = this.NalezenaPruvodka.hotovo_procento;
                    pruvodka_operace o = lsVsechny.Where(i => !lsHotove.Contains(i.pruvodka_operace_id)).OrderBy(i => i.poradi).FirstOrDefault();

                    if (o == null) // neni co odepisovat
                    {
                        XtraMessageBox.Show("Výroba dokončena.", "Odepisování", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        return;
                    }
                    txtOperace.Text = o.nazev;
                    txtTechnickaPoznamka.EditValue = o.poznamka;

                    this.entityObject = new pruvodka_odepisovani();
                    ((pruvodka_odepisovani)this.entityObject).pruvodka = this.DBContext.pruvodkas.Where(item => item.pruvodka_id == this.NalezenaPruvodka.pruvodka_id).First();
                    ((pruvodka_odepisovani)this.entityObject).odepsal_id = this.NalezenaUzivatel.uzivatel_id;
                    ((pruvodka_odepisovani)this.entityObject).pruvodka_operace_id = o.pruvodka_operace_id;


                    pruvodkaodepisovaniBindingSource.DataSource = this.entityObject;
                }
                else
                {
                    pOdepisovani.Visible = false;
                    btnUzavritKooperaci.Visible = true;
                }
            }

        }

        private void btnOdepsat_Click(object sender, EventArgs e)
        {
            if (((pruvodka_odepisovani)this.entityObject).pruvodka != null)
            {
                ((pruvodka_odepisovani)this.entityObject).d_odepsani = PCB.Data.DBHelper.DateTimeNow();



                if (((pruvodka_odepisovani)this.entityObject).pruvodka.pruvodka_operaces.Where(w => w.pruvodka_operace_id == ((pruvodka_odepisovani)this.entityObject).pruvodka_operace_id).Select(s => s.cislo).First() == 147) // expedice
                {
                    ((pruvodka_odepisovani)this.entityObject).pruvodka.pruvodka_stav_id = (int)pruvodka_stav.Value.dokoncena; // dokonecna
                }

                // vynulovani v kapacite
                objednavka_polozka obj = ((pruvodka_odepisovani)this.entityObject).pruvodka.objednavka_polozka;
                int pocet = obj.pruvodkas.Count();
                int pocetDokonecnych = obj.pruvodkas.Where(item => item.pruvodka_stav_id == (int)pruvodka_stav.Value.dokoncena).Count();

                if (pocet == pocetDokonecnych)
                {
                    obj.stav_objednavka_id = (int)stav_objednavka.Value.dokonceno;

                    kapacita k = dbContext.kapacitas.Where(item => item.objednavka_polozka_id == obj.objednavka_polozka_id).First();
                    DBContext.DeleteObject(k);
                }

                // ulozeni
                DBContext.pruvodka_odepisovanis.AddObject(((pruvodka_odepisovani)this.entityObject));
                DBContext.SaveChanges();

                textCisloPruvOdepis.Focus();
                pOdepisovani.Visible = false;

                textCisloPruvOdepis.Enabled = true;
                txtPinPruvodky.Enabled = true;
                btnOK.Enabled = true;

                btnOK_Click(null, null);
            }


        }

        private void btnZrusit_Click(object sender, EventArgs e)
        {
            textCisloPruvOdepis.Text = "";
            txtPinPruvodky.Text = "";

            textCisloPruvOdepis.Focus();
            pOdepisovani.Visible = false;

            textCisloPruvOdepis.Enabled = true;
            txtPinPruvodky.Enabled = true;
            btnOK.Enabled = true;
        }

        private void btnOdespatAZavrit_Click(object sender, EventArgs e)
        {
            if (((pruvodka_odepisovani)this.entityObject).pruvodka != null)
            {
                ((pruvodka_odepisovani)this.entityObject).d_odepsani = PCB.Data.DBHelper.DateTimeNow();

                if (((pruvodka_odepisovani)this.entityObject).pruvodka.pruvodka_operaces.Where(w => w.pruvodka_operace_id == ((pruvodka_odepisovani)this.entityObject).pruvodka_operace_id).Select(s => s.cislo).First() == 147) // expedice
                {
                    ((pruvodka_odepisovani)this.entityObject).pruvodka.pruvodka_stav_id = 3; // dokonecna
                }

                DBContext.SaveChanges();

                textCisloPruvOdepis.Text = "";
                txtPinPruvodky.Text = "";

                textCisloPruvOdepis.Focus();
                pOdepisovani.Visible = false;

                textCisloPruvOdepis.Enabled = true;
                txtPinPruvodky.Enabled = true;
                btnOK.Enabled = true;
            }
        }

        private void btnUzavritKooperaci_Click(object sender, EventArgs e)
        {
            this.NalezenaPruvodka.pruvodka_stav_id = (int)pruvodka_stav.Value.dokoncena;
            this.DBContext.SaveChanges();
            this.Close();
        }
    }
}
