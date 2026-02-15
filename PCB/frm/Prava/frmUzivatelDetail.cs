using PCB.Base;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public partial class frmUzivatelDetail : frmBaseDetail
    {

        public frmUzivatelDetail()
        {
            InitializeComponent();
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (!this.HasPravoZapis(prava.Value.AdministraceUzivatelskaPrava))
            {
                base.setReadonly(cs);
            }
            btnStorno.Enabled = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);


            if (this.FormMode == mode.novy)
            {
                this.entityObject = new uzivatel();
            }

            uzivatelsBindingSource.DataSource = (uzivatel)this.entityObject;

            roleBindingSource.DataSource = this.DBContext.roles;
            pravahodnotaBindingSource.DataSource = this.DBContext.prava_hodnotas;
            oddeleniBindigSource.DataSource = this.DBContext.oddelenis;
            ((uzivatel)this.entityObject).LoadOddeleni(this.DBContext);


        }

        public override void Valid()
        {
            base.Valid();
        }

        public override void SaveData()
        {
            base.SaveData();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {


            uzivatel uzivatel = (uzivatel)this.uzivatelsBindingSource.Current;

            if (!String.IsNullOrWhiteSpace(txtHeslo.Text))
            {
                if (txtHeslo.Text != txtHesloKontrola.Text)
                {
                    MessageBox.Show("Kontrola hesla musí být stejná jako Heslo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                uzivatel.Password = txtHeslo.Text;
            }

            foreach (object o in clbOddeleni.SelectedItems)
            {
                uzivatel_oddeleni uo = new uzivatel_oddeleni();
                uo.uzivatel_id = uzivatel.uzivatel_id;
                uo.oddeleni_id = ((oddeleni)o).oddeleni_id;
                uzivatel.uzivatel_oddelenis.Add(uo);
            }

            if (this.FormMode == mode.novy)
            {
                this.DBContext.uzivatels.AddObject(uzivatel);
            }

            this.Ulozit();

        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void cmbRole_EditValueChanged(object sender, EventArgs e)
        {
            pravaBindingSource.DataSource = ((uzivatel)this.entityObject).GetPravaUzivatel(this.DBContext);
        }


    }
}
