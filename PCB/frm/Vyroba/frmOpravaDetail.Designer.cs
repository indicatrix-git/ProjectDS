namespace PCB
{
    partial class frmOpravaDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpravaDetail));
            this.neshodaTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new PCB.Gui.PCBLookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlOperace = new PCB.Gui.PCBLookUpEdit();
            this.pruvodkaOperaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.neshodaTypBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOperace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruvodkaOperaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // neshodaTypBindingSource
            // 
            this.neshodaTypBindingSource.DataSource = typeof(pcb_develModel.neshoda_typ);
            // 
            // opravaBindingSource
            // 
            this.opravaBindingSource.DataSource = typeof(pcb_develModel.oprava);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-2, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 2);
            this.label1.TabIndex = 91;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opravaBindingSource, "pocet_panelu", true));
            this.textEdit2.Location = new System.Drawing.Point(93, 83);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(86, 20);
            this.textEdit2.TabIndex = 90;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opravaBindingSource, "pocet_ks", true));
            this.textEdit1.Location = new System.Drawing.Point(93, 59);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(86, 20);
            this.textEdit1.TabIndex = 89;
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(265, 124);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(86, 23);
            this.btnStorno.TabIndex = 88;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(175, 124);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(86, 23);
            this.btnUlozit.TabIndex = 87;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 86);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 86;
            this.labelControl3.Text = "Počet panelů:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 61);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 85;
            this.labelControl2.Text = "Počet ks:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 38);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "Neshoda:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opravaBindingSource, "neshoda_typ_id", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(93, 35);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("kod", 100, "Kód"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", 400, "Název")});
            this.lookUpEdit1.Properties.DataSource = this.neshodaTypBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "kod";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "neshoda_typ_id";
            this.lookUpEdit1.Size = new System.Drawing.Size(258, 20);
            this.lookUpEdit1.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Operace:";
            // 
            // ddlOperace
            // 
            this.ddlOperace.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opravaBindingSource, "pruvodka_operace_id", true));
            this.ddlOperace.Location = new System.Drawing.Point(93, 11);
            this.ddlOperace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlOperace.Name = "ddlOperace";
            this.ddlOperace.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlOperace.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("kod", 100, "Kód"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", 400, "Název")});
            this.ddlOperace.Properties.DataSource = this.pruvodkaOperaceBindingSource;
            this.ddlOperace.Properties.DisplayMember = "nazev";
            this.ddlOperace.Properties.NullText = "";
            this.ddlOperace.Properties.ValueMember = "pruvodka_operace_id";
            this.ddlOperace.Size = new System.Drawing.Size(258, 20);
            this.ddlOperace.TabIndex = 93;
            // 
            // pruvodkaOperaceBindingSource
            // 
            this.pruvodkaOperaceBindingSource.DataSource = typeof(pcb_develModel.pruvodka_operace);
            // 
            // frmOpravaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 157);
            this.Controls.Add(this.ddlOperace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEdit1);
            this.Name = "frmOpravaDetail";
            this.Text = "Oprava";
            ((System.ComponentModel.ISupportInitialize)(this.neshodaTypBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOperace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruvodkaOperaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource neshodaTypBindingSource;
        private System.Windows.Forms.BindingSource opravaBindingSource;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Gui.PCBLookUpEdit lookUpEdit1;
        private System.Windows.Forms.Label label2;
        private Gui.PCBLookUpEdit ddlOperace;
        private System.Windows.Forms.BindingSource pruvodkaOperaceBindingSource;
    }
}