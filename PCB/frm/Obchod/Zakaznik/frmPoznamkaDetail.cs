using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCB.Base;
using pcb_develModel;

namespace PCB
{
    public partial class frmPoznamkaDetail : frmBaseDetail
    {
        public frmPoznamkaDetail()
        {
            InitializeComponent();
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            oddeleniBindingSource.DataSource = this.DBContext.oddelenis.ToList();
            typBindingSource.DataSource = this.DBContext.poznamka_typs.ToList();


            if (this.FormMode == mode.novy)
            {
                this.entityObject = new poznamka();
                ((poznamka)this.entityObject).d_zapsal = PCB.Data.DBHelper.DateTimeNow();
                ((poznamka)this.entityObject).zapsal_id = this.PrihlasenyUzivatelId;
                //((poznamka)this.entityObject).zakaznik_id = ((zakaznik)this.parentEntityObject).zakaznik_id;
                ((poznamka)this.entityObject).poznamka_typ_id = 1;

            }
            
            poznamkaBindingSource.DataSource = (poznamka)this.entityObject;
        }

        public override void SaveData()
        {
            //base.SaveData();

            if (this.FormMode == mode.novy)
            {
                ((zakaznik)this.parentEntityObject).poznamkas.Add((poznamka)this.entityObject);
            }
            
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {

            this.Storno();
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            this.Ulozit();
        }

        private void btnOdkaz_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            openFileDialog.CustomPlaces.Clear();
            foreach (DriveInfo Drive in DriveInfo.GetDrives())
            {
                if (Drive.DriveType == DriveType.Network)
                {
                    openFileDialog.CustomPlaces.Add(Drive.Name);
                }
            }

            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((poznamka)poznamkaBindingSource.DataSource).odkaz = openFileDialog.FileName;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string fileName = txtOdkaz.Text;
            if (File.Exists(fileName))
            {
                try
                {
                    System.Diagnostics.Process.Start(txtOdkaz.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nejedná se o spustitelný soubor \n\n" + ex.Message );
                }
            }
        }

        private void txtOdkaz_TextChanged(object sender, EventArgs e)
        {
            string fileName = txtOdkaz.Text;
            if (File.Exists(fileName))
            {
                btnOpenFile.Enabled = true;
            }
            else
            {
                btnOpenFile.Enabled = false;
            }
        }

        private void requiredLabel1_Load(object sender, EventArgs e)
        {

        }
    }
}
