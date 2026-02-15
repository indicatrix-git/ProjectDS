namespace PCB
{
    partial class frmPruvodkaFrontaDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruvodkaFrontaDetail));
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPozadPocet = new DevExpress.XtraEditors.LabelControl();
            this.lblKs = new DevExpress.XtraEditors.LabelControl();
            this.txtTechnologickyPridavek = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTechPrid = new DevExpress.XtraEditors.LabelControl();
            this.txtPozadovanyPocet = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnologickyPridavek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPozadovanyPocet.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Objednávka";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Filtr";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(191, 122);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 258;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(85, 122);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 28);
            this.btnUlozit.TabIndex = 257;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(250, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 256;
            this.labelControl1.Text = "ks";
            // 
            // lblPozadPocet
            // 
            this.lblPozadPocet.Location = new System.Drawing.Point(44, 21);
            this.lblPozadPocet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPozadPocet.Name = "lblPozadPocet";
            this.lblPozadPocet.Size = new System.Drawing.Size(107, 16);
            this.lblPozadPocet.TabIndex = 249;
            this.lblPozadPocet.Text = "Požadovaný počet:";
            // 
            // lblKs
            // 
            this.lblKs.Location = new System.Drawing.Point(250, 21);
            this.lblKs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblKs.Name = "lblKs";
            this.lblKs.Size = new System.Drawing.Size(12, 16);
            this.lblKs.TabIndex = 252;
            this.lblKs.Text = "ks";
            // 
            // txtTechnologickyPridavek
            // 
            this.txtTechnologickyPridavek.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "pocet_panelu", true));
            this.txtTechnologickyPridavek.Location = new System.Drawing.Point(157, 46);
            this.txtTechnologickyPridavek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTechnologickyPridavek.Name = "txtTechnologickyPridavek";
            this.txtTechnologickyPridavek.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTechnologickyPridavek.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTechnologickyPridavek.Properties.Mask.EditMask = "d";
            this.txtTechnologickyPridavek.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTechnologickyPridavek.Properties.MaxLength = 6;
            this.txtTechnologickyPridavek.Size = new System.Drawing.Size(87, 22);
            this.txtTechnologickyPridavek.TabIndex = 2;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(pcb_develModel.pruvodka);
            // 
            // lblTechPrid
            // 
            this.lblTechPrid.Location = new System.Drawing.Point(14, 49);
            this.lblTechPrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTechPrid.Name = "lblTechPrid";
            this.lblTechPrid.Size = new System.Drawing.Size(137, 16);
            this.lblTechPrid.TabIndex = 253;
            this.lblTechPrid.Text = "Technologický přídavek:";
            // 
            // txtPozadovanyPocet
            // 
            this.txtPozadovanyPocet.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "pocet_kusu", true));
            this.txtPozadovanyPocet.Location = new System.Drawing.Point(157, 18);
            this.txtPozadovanyPocet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPozadovanyPocet.Name = "txtPozadovanyPocet";
            this.txtPozadovanyPocet.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPozadovanyPocet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPozadovanyPocet.Properties.Mask.EditMask = "d";
            this.txtPozadovanyPocet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPozadovanyPocet.Properties.MaxLength = 6;
            this.txtPozadovanyPocet.Size = new System.Drawing.Size(87, 22);
            this.txtPozadovanyPocet.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPozadPocet);
            this.groupBox1.Controls.Add(this.txtPozadovanyPocet);
            this.groupBox1.Controls.Add(this.lblTechPrid);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtTechnologickyPridavek);
            this.groupBox1.Controls.Add(this.lblKs);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 260;
            // 
            // frmPruvodkaFrontaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPruvodkaFrontaDetail";
            this.Text = "Počty";
            this.Load += new System.EventHandler(this.frmPruvodkaFrontaDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnologickyPridavek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPozadovanyPocet.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit txtTechnologickyPridavek;
        private DevExpress.XtraEditors.TextEdit txtPozadovanyPocet;
        private DevExpress.XtraEditors.LabelControl lblTechPrid;
        private DevExpress.XtraEditors.LabelControl lblKs;
        private DevExpress.XtraEditors.LabelControl lblPozadPocet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}