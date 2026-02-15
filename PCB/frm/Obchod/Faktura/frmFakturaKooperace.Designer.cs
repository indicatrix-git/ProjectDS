namespace PCB
{
    partial class frmKooperace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKooperace));
            this.fakturaPolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNazev = new DevExpress.XtraEditors.LabelControl();
            this.txtPocet = new DevExpress.XtraEditors.TextEdit();
            this.lblPocetKusu = new DevExpress.XtraEditors.LabelControl();
            this.txtCenaKs = new DevExpress.XtraEditors.TextEdit();
            this.lblCenaKs = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.dphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPruvodka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnVyhledat = new DevExpress.XtraEditors.SimpleButton();
            this.txtNazevDPS = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaPolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPocet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCenaKs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPruvodka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazevDPS.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fakturaPolozkaBindingSource
            // 
            this.fakturaPolozkaBindingSource.DataSource = typeof(pcb_develModel.faktura_polozka);
            // 
            // lblNazev
            // 
            this.lblNazev.Location = new System.Drawing.Point(46, 85);
            this.lblNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(34, 13);
            this.lblNazev.TabIndex = 3;
            this.lblNazev.Text = "Název:";
            // 
            // txtPocet
            // 
            this.txtPocet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturaPolozkaBindingSource, "pocet_ks", true));
            this.txtPocet.EditValue = "";
            this.txtPocet.Location = new System.Drawing.Point(85, 128);
            this.txtPocet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPocet.Name = "txtPocet";
            this.txtPocet.Size = new System.Drawing.Size(104, 20);
            this.txtPocet.TabIndex = 8;
            this.txtPocet.EditValueChanged += new System.EventHandler(this.txtPocet_EditValueChanged);
            // 
            // lblPocetKusu
            // 
            this.lblPocetKusu.Location = new System.Drawing.Point(23, 130);
            this.lblPocetKusu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPocetKusu.Name = "lblPocetKusu";
            this.lblPocetKusu.Size = new System.Drawing.Size(56, 13);
            this.lblPocetKusu.TabIndex = 7;
            this.lblPocetKusu.Text = "Počet kusů:";
            // 
            // txtCenaKs
            // 
            this.txtCenaKs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturaPolozkaBindingSource, "cena_ks", true));
            this.txtCenaKs.EditValue = "";
            this.txtCenaKs.Location = new System.Drawing.Point(85, 106);
            this.txtCenaKs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCenaKs.Name = "txtCenaKs";
            this.txtCenaKs.Size = new System.Drawing.Size(104, 20);
            this.txtCenaKs.TabIndex = 6;
            this.txtCenaKs.EditValueChanged += new System.EventHandler(this.txtCenaKs_EditValueChanged);
            // 
            // lblCenaKs
            // 
            this.lblCenaKs.Location = new System.Drawing.Point(13, 108);
            this.lblCenaKs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCenaKs.Name = "lblCenaKs";
            this.lblCenaKs.Size = new System.Drawing.Size(65, 13);
            this.lblCenaKs.TabIndex = 5;
            this.lblCenaKs.Text = "Cena/ks [Kč]:";
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(205, 187);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dphBindingSource
            // 
            this.dphBindingSource.DataSource = typeof(pcb_develModel.dph);
            // 
            // txtPruvodka
            // 
            this.txtPruvodka.Location = new System.Drawing.Point(85, 23);
            this.txtPruvodka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPruvodka.Name = "txtPruvodka";
            this.txtPruvodka.Properties.ReadOnly = true;
            this.txtPruvodka.Size = new System.Drawing.Size(249, 20);
            this.txtPruvodka.TabIndex = 2;
            this.txtPruvodka.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 25);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Průvodka:";
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(285, 187);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 23);
            this.btnStorno.TabIndex = 2;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.Image = ((System.Drawing.Image)(resources.GetObject("btnVyhledat.Image")));
            this.btnVyhledat.Location = new System.Drawing.Point(237, 46);
            this.btnVyhledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.Size = new System.Drawing.Size(98, 23);
            this.btnVyhledat.TabIndex = 0;
            this.btnVyhledat.TabStop = false;
            this.btnVyhledat.Text = "Vyhledat...";
            this.btnVyhledat.Click += new System.EventHandler(this.btnVyhledat_Click);
            // 
            // txtNazevDPS
            // 
            this.txtNazevDPS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturaPolozkaBindingSource, "nazev", true));
            this.txtNazevDPS.Location = new System.Drawing.Point(85, 80);
            this.txtNazevDPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazevDPS.Name = "txtNazevDPS";
            this.txtNazevDPS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtNazevDPS.Properties.Appearance.Options.UseFont = true;
            this.txtNazevDPS.Properties.Mask.EditMask = "[A-Z1 -9_.-]+";
            this.txtNazevDPS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtNazevDPS.Size = new System.Drawing.Size(249, 22);
            this.txtNazevDPS.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVyhledat);
            this.groupBox1.Controls.Add(this.txtNazevDPS);
            this.groupBox1.Controls.Add(this.lblNazev);
            this.groupBox1.Controls.Add(this.lblPocetKusu);
            this.groupBox1.Controls.Add(this.txtPocet);
            this.groupBox1.Controls.Add(this.txtPruvodka);
            this.groupBox1.Controls.Add(this.lblCenaKs);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtCenaKs);
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(351, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 2);
            this.label1.TabIndex = 81;
            // 
            // frmKooperace
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKooperace";
            this.Text = "Kooperace";
            this.Load += new System.EventHandler(this.frmKooperace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakturaPolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPocet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCenaKs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPruvodka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazevDPS.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNazev;
        private DevExpress.XtraEditors.TextEdit txtPocet;
        private DevExpress.XtraEditors.LabelControl lblPocetKusu;
        private DevExpress.XtraEditors.TextEdit txtCenaKs;
        private DevExpress.XtraEditors.LabelControl lblCenaKs;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Windows.Forms.BindingSource fakturaPolozkaBindingSource;
        private System.Windows.Forms.BindingSource dphBindingSource;
        private DevExpress.XtraEditors.TextEdit txtPruvodka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.SimpleButton btnVyhledat;
        private DevExpress.XtraEditors.TextEdit txtNazevDPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}