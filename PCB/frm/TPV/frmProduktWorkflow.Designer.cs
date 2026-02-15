namespace PCB
{
    partial class frmProduktWorkflow
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
            this.htmlControler1 = new PCB.Gui.HtmlControler();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.chbSpecPrani = new DevExpress.XtraEditors.GroupControl();
            this.cbAOI = new PCB.Gui.CheckBox();
            this.cbET = new PCB.Gui.CheckBox();
            this.chbULOzn = new PCB.Gui.CheckBox();
            this.chbArchivovat = new PCB.Gui.CheckBox();
            this.chbLaser = new PCB.Gui.CheckBox();
            this.chbDvojitaKontrola = new PCB.Gui.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chbSpecPrani)).BeginInit();
            this.chbSpecPrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAOI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbULOzn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbArchivovat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLaser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDvojitaKontrola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlControler1
            // 
            this.htmlControler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlControler1.Location = new System.Drawing.Point(12, 75);
            this.htmlControler1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlControler1.MinimumSize = new System.Drawing.Size(20, 20);
            this.htmlControler1.Name = "htmlControler1";
            this.htmlControler1.Size = new System.Drawing.Size(497, 283);
            this.htmlControler1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(12, 532);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(497, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Storno";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUlozit.Location = new System.Drawing.Point(12, 21);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(497, 48);
            this.btnUlozit.TabIndex = 0;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // chbSpecPrani
            // 
            this.chbSpecPrani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbSpecPrani.Controls.Add(this.cbAOI);
            this.chbSpecPrani.Controls.Add(this.cbET);
            this.chbSpecPrani.Controls.Add(this.chbULOzn);
            this.chbSpecPrani.Controls.Add(this.chbArchivovat);
            this.chbSpecPrani.Controls.Add(this.chbLaser);
            this.chbSpecPrani.Controls.Add(this.chbDvojitaKontrola);
            this.chbSpecPrani.Location = new System.Drawing.Point(12, 364);
            this.chbSpecPrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSpecPrani.Name = "chbSpecPrani";
            this.chbSpecPrani.Size = new System.Drawing.Size(497, 162);
            this.chbSpecPrani.TabIndex = 88;
            this.chbSpecPrani.Text = "Speciální přání";
            // 
            // cbAOI
            // 
            this.cbAOI.Location = new System.Drawing.Point(250, 64);
            this.cbAOI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAOI.Name = "cbAOI";
            this.cbAOI.Properties.Caption = "AOI";
            this.cbAOI.Properties.ReadOnly = true;
            this.cbAOI.Size = new System.Drawing.Size(120, 20);
            this.cbAOI.TabIndex = 5;
            // 
            // cbET
            // 
            this.cbET.Location = new System.Drawing.Point(250, 36);
            this.cbET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbET.Name = "cbET";
            this.cbET.Properties.Caption = "ET";
            this.cbET.Properties.ReadOnly = true;
            this.cbET.Size = new System.Drawing.Size(150, 20);
            this.cbET.TabIndex = 4;
            this.cbET.CheckedChanged += new System.EventHandler(this.cbET_CheckedChanged);
            // 
            // chbULOzn
            // 
            this.chbULOzn.Location = new System.Drawing.Point(15, 64);
            this.chbULOzn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbULOzn.Name = "chbULOzn";
            this.chbULOzn.Properties.Caption = "UL označení";
            this.chbULOzn.Properties.ReadOnly = true;
            this.chbULOzn.Size = new System.Drawing.Size(120, 20);
            this.chbULOzn.TabIndex = 3;
            // 
            // chbArchivovat
            // 
            this.chbArchivovat.Location = new System.Drawing.Point(15, 121);
            this.chbArchivovat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbArchivovat.Name = "chbArchivovat";
            this.chbArchivovat.Properties.Caption = "Archivovat";
            this.chbArchivovat.Properties.ReadOnly = true;
            this.chbArchivovat.Size = new System.Drawing.Size(120, 20);
            this.chbArchivovat.TabIndex = 2;
            // 
            // chbLaser
            // 
            this.chbLaser.Location = new System.Drawing.Point(15, 36);
            this.chbLaser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbLaser.Name = "chbLaser";
            this.chbLaser.Properties.Caption = "Laser";
            this.chbLaser.Properties.ReadOnly = true;
            this.chbLaser.Size = new System.Drawing.Size(150, 20);
            this.chbLaser.TabIndex = 1;
            // 
            // chbDvojitaKontrola
            // 
            this.chbDvojitaKontrola.Location = new System.Drawing.Point(15, 92);
            this.chbDvojitaKontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDvojitaKontrola.Name = "chbDvojitaKontrola";
            this.chbDvojitaKontrola.Properties.Caption = "Dvojitá kontrola";
            this.chbDvojitaKontrola.Properties.ReadOnly = true;
            this.chbDvojitaKontrola.Size = new System.Drawing.Size(150, 20);
            this.chbDvojitaKontrola.TabIndex = 0;
            // 
            // frmProduktWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 592);
            this.Controls.Add(this.chbSpecPrani);
            this.Controls.Add(this.htmlControler1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUlozit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProduktWorkflow";
            this.Text = "Uložit";
            this.Load += new System.EventHandler(this.frmProduktWorkflow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chbSpecPrani)).EndInit();
            this.chbSpecPrani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbAOI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbULOzn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbArchivovat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLaser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDvojitaKontrola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private Gui.HtmlControler htmlControler1;
        private DevExpress.XtraEditors.GroupControl chbSpecPrani;
        private Gui.CheckBox cbAOI;
        private Gui.CheckBox cbET;
        private Gui.CheckBox chbULOzn;
        private Gui.CheckBox chbArchivovat;
        private Gui.CheckBox chbLaser;
        private Gui.CheckBox chbDvojitaKontrola;
    }
}