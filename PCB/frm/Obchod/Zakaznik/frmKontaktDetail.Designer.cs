namespace PCB
{
    partial class frmKontaktDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKontaktDetail));
            this.kontaktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oddeleniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requiredLabel1 = new PCB.Gui.RequiredLabel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.requiredLabel2 = new PCB.Gui.RequiredLabel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtJmeno = new DevExpress.XtraEditors.TextEdit();
            this.btnEmail = new DevExpress.XtraEditors.SimpleButton();
            this.cboOddeleni = new PCB.Gui.PCBLookUpEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtMobil = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddeleniBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmeno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOddeleni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kontaktBindingSource
            // 
            this.kontaktBindingSource.DataSource = typeof(pcb_develModel.kontakt);
            // 
            // oddeleniBindingSource
            // 
            this.oddeleniBindingSource.DataSource = typeof(pcb_develModel.oddeleni);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(123, 199);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(86, 23);
            this.btnUlozit.TabIndex = 13;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(215, 199);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(86, 23);
            this.btnStorno.TabIndex = 14;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.requiredLabel1);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.requiredLabel2);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtJmeno);
            this.groupBox1.Controls.Add(this.btnEmail);
            this.groupBox1.Controls.Add(this.cboOddeleni);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMobil);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(289, 176);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // requiredLabel1
            // 
            this.requiredLabel1.Location = new System.Drawing.Point(16, 26);
            this.requiredLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requiredLabel1.Name = "requiredLabel1";
            this.requiredLabel1.Size = new System.Drawing.Size(46, 17);
            this.requiredLabel1.TabIndex = 15;
            this.requiredLabel1.Text = "Oddělení:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 74);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mobil:";
            // 
            // requiredLabel2
            // 
            this.requiredLabel2.Location = new System.Drawing.Point(26, 50);
            this.requiredLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requiredLabel2.Name = "requiredLabel2";
            this.requiredLabel2.Size = new System.Drawing.Size(40, 17);
            this.requiredLabel2.TabIndex = 16;
            this.requiredLabel2.Text = "Jméno:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 98);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Telefon:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(39, 122);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Fax:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(29, 146);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "E-mail:";
            // 
            // txtJmeno
            // 
            this.txtJmeno.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kontaktBindingSource, "jmeno", true));
            this.txtJmeno.Location = new System.Drawing.Point(67, 47);
            this.txtJmeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(210, 20);
            this.txtJmeno.TabIndex = 2;
            // 
            // btnEmail
            // 
            this.btnEmail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnEmail.Enabled = false;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.Location = new System.Drawing.Point(243, 140);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(40, 24);
            this.btnEmail.TabIndex = 7;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // cboOddeleni
            // 
            this.cboOddeleni.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kontaktBindingSource, "oddeleni", true));
            this.cboOddeleni.Location = new System.Drawing.Point(67, 23);
            this.cboOddeleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOddeleni.Name = "cboOddeleni";
            this.cboOddeleni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOddeleni.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboOddeleni.Properties.DataSource = this.oddeleniBindingSource;
            this.cboOddeleni.Properties.DisplayMember = "nazev";
            this.cboOddeleni.Properties.NullText = "";
            this.cboOddeleni.Size = new System.Drawing.Size(210, 20);
            this.cboOddeleni.TabIndex = 1;
            this.cboOddeleni.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kontaktBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(67, 143);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtMobil
            // 
            this.txtMobil.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kontaktBindingSource, "mobil", true));
            this.txtMobil.Location = new System.Drawing.Point(67, 71);
            this.txtMobil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMobil.Name = "txtMobil";
            this.txtMobil.Size = new System.Drawing.Size(210, 20);
            this.txtMobil.TabIndex = 3;
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kontaktBindingSource, "fax", true));
            this.txtFax.Location = new System.Drawing.Point(67, 119);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(210, 20);
            this.txtFax.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kontaktBindingSource, "telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(67, 95);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(210, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-21, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 2);
            this.label1.TabIndex = 82;
            // 
            // frmKontaktDetail
            // 
            this.AcceptButton = this.btnUlozit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStorno;
            this.ClientSize = new System.Drawing.Size(312, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKontaktDetail";
            this.Text = "Kontakt";
            ((System.ComponentModel.ISupportInitialize)(this.kontaktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddeleniBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmeno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOddeleni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtJmeno;
        private PCB.Gui.PCBLookUpEdit cboOddeleni;
        private DevExpress.XtraEditors.TextEdit txtMobil;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.SimpleButton btnEmail;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.BindingSource kontaktBindingSource;
        private System.Windows.Forms.BindingSource oddeleniBindingSource;
        private Gui.RequiredLabel requiredLabel1;
        private Gui.RequiredLabel requiredLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}