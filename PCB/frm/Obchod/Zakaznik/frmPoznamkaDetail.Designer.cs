namespace PCB
{
    partial class frmPoznamkaDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoznamkaDetail));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.poznamkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oddeleniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.textEditNadpis = new DevExpress.XtraEditors.TextEdit();
            this.lblNadpis = new PCB.Gui.RequiredLabel();
            this.requiredLabel2 = new PCB.Gui.RequiredLabel();
            this.requiredLabel1 = new PCB.Gui.RequiredLabel();
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.cboOddeleni = new PCB.Gui.PCBLookUpEdit();
            this.cboTyp = new PCB.Gui.PCBLookUpEdit();
            this.btnOdkaz = new DevExpress.XtraEditors.SimpleButton();
            this.txtOdkaz = new DevExpress.XtraEditors.TextEdit();
            this.txtZaznamenal = new DevExpress.XtraEditors.TextEdit();
            this.txtDatum = new DevExpress.XtraEditors.TextEdit();
            this.txtPoznamka = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poznamkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddeleniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNadpis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOddeleni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTyp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdkaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZaznamenal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoznamka.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // poznamkaBindingSource
            // 
            this.poznamkaBindingSource.DataSource = typeof(pcb_develModel.poznamka);
            // 
            // oddeleniBindingSource
            // 
            this.oddeleniBindingSource.DataSource = typeof(pcb_develModel.oddeleni);
            // 
            // typBindingSource
            // 
            this.typBindingSource.DataSource = typeof(pcb_develModel.poznamka_typ);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(249, 457);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 28);
            this.btnUlozit.TabIndex = 7;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(355, 457);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 8;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // textEditNadpis
            // 
            this.textEditNadpis.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.poznamkaBindingSource, "nadpis", true));
            this.textEditNadpis.Location = new System.Drawing.Point(115, 116);
            this.textEditNadpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditNadpis.Name = "textEditNadpis";
            this.textEditNadpis.Size = new System.Drawing.Size(308, 22);
            this.textEditNadpis.TabIndex = 4;
            // 
            // lblNadpis
            // 
            this.lblNadpis.Location = new System.Drawing.Point(64, 119);
            this.lblNadpis.Margin = new System.Windows.Forms.Padding(2);
            this.lblNadpis.Name = "lblNadpis";
            this.lblNadpis.Size = new System.Drawing.Size(46, 19);
            this.lblNadpis.TabIndex = 6;
            this.lblNadpis.TabStop = false;
            this.lblNadpis.Text = "Nadpis:";
            // 
            // requiredLabel2
            // 
            this.requiredLabel2.Location = new System.Drawing.Point(20, 90);
            this.requiredLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.requiredLabel2.Name = "requiredLabel2";
            this.requiredLabel2.Size = new System.Drawing.Size(93, 22);
            this.requiredLabel2.TabIndex = 4;
            this.requiredLabel2.Text = "Typ poznámky:";
            // 
            // requiredLabel1
            // 
            this.requiredLabel1.AutoSize = true;
            this.requiredLabel1.Location = new System.Drawing.Point(52, 67);
            this.requiredLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.requiredLabel1.Name = "requiredLabel1";
            this.requiredLabel1.Size = new System.Drawing.Size(58, 19);
            this.requiredLabel1.TabIndex = 2;
            this.requiredLabel1.Text = "Oddělení:";
            this.requiredLabel1.Load += new System.EventHandler(this.requiredLabel1_Load);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(401, 194);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(22, 25);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.ToolTip = "Otevřít";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cboOddeleni
            // 
            this.cboOddeleni.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.poznamkaBindingSource, "oddeleni_id", true));
            this.cboOddeleni.Location = new System.Drawing.Point(115, 64);
            this.cboOddeleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOddeleni.Name = "cboOddeleni";
            this.cboOddeleni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOddeleni.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboOddeleni.Properties.DataSource = this.oddeleniBindingSource;
            this.cboOddeleni.Properties.DisplayMember = "nazev";
            this.cboOddeleni.Properties.NullText = "";
            this.cboOddeleni.Properties.ValueMember = "oddeleni_id";
            this.cboOddeleni.Size = new System.Drawing.Size(308, 22);
            this.cboOddeleni.TabIndex = 2;
            this.cboOddeleni.TabStop = false;
            // 
            // cboTyp
            // 
            this.cboTyp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.poznamkaBindingSource, "poznamka_typ_id", true));
            this.cboTyp.Location = new System.Drawing.Point(115, 90);
            this.cboTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTyp.Name = "cboTyp";
            this.cboTyp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTyp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboTyp.Properties.DataSource = this.typBindingSource;
            this.cboTyp.Properties.DisplayMember = "nazev";
            this.cboTyp.Properties.NullText = "";
            this.cboTyp.Properties.ValueMember = "poznamka_typ_id";
            this.cboTyp.Size = new System.Drawing.Size(308, 22);
            this.cboTyp.TabIndex = 3;
            this.cboTyp.TabStop = false;
            // 
            // btnOdkaz
            // 
            this.btnOdkaz.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOdkaz.Image = ((System.Drawing.Image)(resources.GetObject("btnOdkaz.Image")));
            this.btnOdkaz.Location = new System.Drawing.Point(372, 194);
            this.btnOdkaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdkaz.Name = "btnOdkaz";
            this.btnOdkaz.Size = new System.Drawing.Size(23, 25);
            this.btnOdkaz.TabIndex = 12;
            this.btnOdkaz.TabStop = false;
            this.btnOdkaz.ToolTip = "Otevřít";
            this.btnOdkaz.Click += new System.EventHandler(this.btnOdkaz_Click);
            // 
            // txtOdkaz
            // 
            this.txtOdkaz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poznamkaBindingSource, "odkaz", true));
            this.txtOdkaz.Location = new System.Drawing.Point(115, 168);
            this.txtOdkaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOdkaz.Name = "txtOdkaz";
            this.txtOdkaz.Size = new System.Drawing.Size(308, 22);
            this.txtOdkaz.TabIndex = 5;
            this.txtOdkaz.TextChanged += new System.EventHandler(this.txtOdkaz_TextChanged);
            // 
            // txtZaznamenal
            // 
            this.txtZaznamenal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poznamkaBindingSource, "CeleJmeno", true));
            this.txtZaznamenal.Location = new System.Drawing.Point(115, 142);
            this.txtZaznamenal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZaznamenal.Name = "txtZaznamenal";
            this.txtZaznamenal.Properties.ReadOnly = true;
            this.txtZaznamenal.Size = new System.Drawing.Size(308, 22);
            this.txtZaznamenal.TabIndex = 9;
            this.txtZaznamenal.TabStop = false;
            // 
            // txtDatum
            // 
            this.txtDatum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poznamkaBindingSource, "d_zapsal", true));
            this.txtDatum.Location = new System.Drawing.Point(115, 38);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Properties.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(152, 22);
            this.txtDatum.TabIndex = 1;
            // 
            // txtPoznamka
            // 
            this.txtPoznamka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poznamkaBindingSource, "obsah", true));
            this.txtPoznamka.Location = new System.Drawing.Point(115, 248);
            this.txtPoznamka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoznamka.Name = "txtPoznamka";
            this.txtPoznamka.Size = new System.Drawing.Size(308, 150);
            this.txtPoznamka.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(68, 171);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Odkaz:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 145);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Zaznamenal:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 41);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Datum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOdkaz);
            this.groupBox1.Controls.Add(this.textEditNadpis);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.lblNadpis);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.requiredLabel2);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.requiredLabel1);
            this.groupBox1.Controls.Add(this.txtPoznamka);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Controls.Add(this.cboOddeleni);
            this.groupBox1.Controls.Add(this.txtZaznamenal);
            this.groupBox1.Controls.Add(this.cboTyp);
            this.groupBox1.Controls.Add(this.btnOdkaz);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 419);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 2);
            this.label1.TabIndex = 82;
            // 
            // frmPoznamkaDetail
            // 
            this.AcceptButton = this.btnUlozit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStorno;
            this.ClientSize = new System.Drawing.Size(467, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.btnStorno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPoznamkaDetail";
            this.Text = "Poznámka";
            ((System.ComponentModel.ISupportInitialize)(this.poznamkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddeleniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNadpis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOddeleni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTyp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdkaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZaznamenal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoznamka.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtPoznamka;
        private DevExpress.XtraEditors.TextEdit txtDatum;
        private DevExpress.XtraEditors.TextEdit txtZaznamenal;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.TextEdit txtOdkaz;
        private DevExpress.XtraEditors.SimpleButton btnOdkaz;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private System.Windows.Forms.BindingSource poznamkaBindingSource;
        private System.Windows.Forms.BindingSource oddeleniBindingSource;
        private PCB.Gui.PCBLookUpEdit cboTyp;
        private PCB.Gui.PCBLookUpEdit cboOddeleni;
        private System.Windows.Forms.BindingSource typBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private Gui.RequiredLabel requiredLabel1;
        private Gui.RequiredLabel requiredLabel2;
        private Gui.RequiredLabel lblNadpis;
        private DevExpress.XtraEditors.TextEdit textEditNadpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}