namespace PCB
{
    partial class frmCiselnikKodDPS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiselnikKodDPS));
            this.postupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cbTypDesky = new PCB.Gui.CheckBoxButtonList();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.cblPovrchoveUpravy = new PCB.Gui.CheckBoxButtonList();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.cbDokonceni = new PCB.Gui.CheckBoxButtonList();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // postupBindingSource
            // 
            this.postupBindingSource.DataSource = typeof(pcb_develModel.postup);
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(594, 741);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(84, 28);
            this.btnStorno.TabIndex = 1;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(506, 741);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnVybrat_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(671, 701);
            this.xtraTabControl1.TabIndex = 13;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cbTypDesky);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(665, 670);
            this.xtraTabPage1.Text = "Typ desky";
            // 
            // cbTypDesky
            // 
            this.cbTypDesky.Location = new System.Drawing.Point(0, 0);
            this.cbTypDesky.Name = "cbTypDesky";
            this.cbTypDesky.RadioButtonMode = true;
            this.cbTypDesky.ShowColumnsCode = true;
            this.cbTypDesky.Size = new System.Drawing.Size(662, 667);
            this.cbTypDesky.TabIndex = 19;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.cblPovrchoveUpravy);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(665, 670);
            this.xtraTabPage2.Text = "Povrchové úpravy";
            // 
            // cblPovrchoveUpravy
            // 
            this.cblPovrchoveUpravy.Location = new System.Drawing.Point(0, 0);
            this.cblPovrchoveUpravy.Name = "cblPovrchoveUpravy";
            this.cblPovrchoveUpravy.RadioButtonMode = false;
            this.cblPovrchoveUpravy.ShowColumnsCode = true;
            this.cblPovrchoveUpravy.Size = new System.Drawing.Size(661, 667);
            this.cblPovrchoveUpravy.TabIndex = 18;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.cbDokonceni);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(665, 670);
            this.xtraTabPage3.Text = "Dokončení";
            // 
            // cbDokonceni
            // 
            this.cbDokonceni.Location = new System.Drawing.Point(0, 0);
            this.cbDokonceni.Name = "cbDokonceni";
            this.cbDokonceni.RadioButtonMode = false;
            this.cbDokonceni.ShowColumnsCode = true;
            this.cbDokonceni.Size = new System.Drawing.Size(661, 667);
            this.cbDokonceni.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 725);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 2);
            this.label1.TabIndex = 82;
            // 
            // frmCiselnikKodDPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 783);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOk);
            this.Name = "frmCiselnikKodDPS";
            this.Text = "Kódy DPS";
            this.Load += new System.EventHandler(this.frmCiselnikKodDPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.BindingSource postupBindingSource;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Gui.CheckBoxButtonList cblPovrchoveUpravy;
        private Gui.CheckBoxButtonList cbDokonceni;
        private Gui.CheckBoxButtonList cbTypDesky;
        private System.Windows.Forms.Label label1;
    }
}