namespace PCB
{
    partial class frmProdejMaterialu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdejMaterialu));
            this.txtNazev = new DevExpress.XtraEditors.TextEdit();
            this.fakturaPolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNazev = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.dphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPocet = new DevExpress.XtraEditors.LabelControl();
            this.txtPocet = new DevExpress.XtraEditors.TextEdit();
            this.txtCenaKs = new DevExpress.XtraEditors.TextEdit();
            this.lblCenaKs = new DevExpress.XtraEditors.LabelControl();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaPolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPocet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCenaKs.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNazev
            // 
            this.txtNazev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturaPolozkaBindingSource, "nazev", true));
            this.txtNazev.Location = new System.Drawing.Point(81, 17);
            this.txtNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(292, 20);
            this.txtNazev.TabIndex = 1;
            // 
            // fakturaPolozkaBindingSource
            // 
            this.fakturaPolozkaBindingSource.DataSource = typeof(pcb_develModel.faktura_polozka);
            // 
            // lblNazev
            // 
            this.lblNazev.Location = new System.Drawing.Point(42, 20);
            this.lblNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(34, 13);
            this.lblNazev.TabIndex = 0;
            this.lblNazev.Text = "Název:";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(219, 96);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // dphBindingSource
            // 
            this.dphBindingSource.DataSource = typeof(pcb_develModel.dph);
            // 
            // lblPocet
            // 
            this.lblPocet.Location = new System.Drawing.Point(257, 42);
            this.lblPocet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPocet.Name = "lblPocet";
            this.lblPocet.Size = new System.Drawing.Size(31, 13);
            this.lblPocet.TabIndex = 4;
            this.lblPocet.Text = "Počet:";
            // 
            // txtPocet
            // 
            this.txtPocet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturaPolozkaBindingSource, "pocet_ks", true));
            this.txtPocet.EditValue = "";
            this.txtPocet.Location = new System.Drawing.Point(293, 40);
            this.txtPocet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPocet.Name = "txtPocet";
            this.txtPocet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPocet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPocet.Size = new System.Drawing.Size(80, 20);
            this.txtPocet.TabIndex = 5;
            this.txtPocet.EditValueChanged += new System.EventHandler(this.txtPocet_EditValueChanged);
            // 
            // txtCenaKs
            // 
            this.txtCenaKs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturaPolozkaBindingSource, "cena_ks", true));
            this.txtCenaKs.EditValue = "";
            this.txtCenaKs.Location = new System.Drawing.Point(81, 40);
            this.txtCenaKs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCenaKs.Name = "txtCenaKs";
            this.txtCenaKs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCenaKs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCenaKs.Size = new System.Drawing.Size(145, 20);
            this.txtCenaKs.TabIndex = 3;
            this.txtCenaKs.EditValueChanged += new System.EventHandler(this.txtCenaKs_EditValueChanged);
            // 
            // lblCenaKs
            // 
            this.lblCenaKs.Location = new System.Drawing.Point(9, 42);
            this.lblCenaKs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCenaKs.Name = "lblCenaKs";
            this.lblCenaKs.Size = new System.Drawing.Size(65, 13);
            this.lblCenaKs.TabIndex = 2;
            this.lblCenaKs.Text = "Cena/ks [Kč]:";
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(309, 96);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(86, 23);
            this.btnStorno.TabIndex = 2;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNazev);
            this.groupBox1.Controls.Add(this.lblNazev);
            this.groupBox1.Controls.Add(this.lblPocet);
            this.groupBox1.Controls.Add(this.lblCenaKs);
            this.groupBox1.Controls.Add(this.txtPocet);
            this.groupBox1.Controls.Add(this.txtCenaKs);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(385, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 2);
            this.label1.TabIndex = 81;
            // 
            // frmProdejMaterialu
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOK);
            this.Name = "frmProdejMaterialu";
            this.Text = "Materiál";
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaPolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPocet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCenaKs.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNazev;
        private DevExpress.XtraEditors.LabelControl lblNazev;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.BindingSource fakturaPolozkaBindingSource;
        private System.Windows.Forms.BindingSource dphBindingSource;
        private DevExpress.XtraEditors.LabelControl lblPocet;
        private DevExpress.XtraEditors.TextEdit txtPocet;
        private DevExpress.XtraEditors.TextEdit txtCenaKs;
        private DevExpress.XtraEditors.LabelControl lblCenaKs;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}