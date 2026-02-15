namespace PCB
{
    partial class frmObjednavkaPolozkaWorkflow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjednavkaPolozkaWorkflow));
            this.btnTPV = new DevExpress.XtraEditors.SimpleButton();
            this.btnTechnolog = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTPV
            // 
            this.btnTPV.Image = ((System.Drawing.Image)(resources.GetObject("btnTPV.Image")));
            this.btnTPV.Location = new System.Drawing.Point(10, 79);
            this.btnTPV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTPV.Name = "btnTPV";
            this.btnTPV.Size = new System.Drawing.Size(292, 39);
            this.btnTPV.TabIndex = 1;
            this.btnTPV.TabStop = false;
            this.btnTPV.Tag = "1";
            this.btnTPV.Text = "Uložit a předat do TPV";
            this.btnTPV.Click += new System.EventHandler(this.btnStavZmena_Click);
            // 
            // btnTechnolog
            // 
            this.btnTechnolog.Image = ((System.Drawing.Image)(resources.GetObject("btnTechnolog.Image")));
            this.btnTechnolog.Location = new System.Drawing.Point(10, 123);
            this.btnTechnolog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTechnolog.Name = "btnTechnolog";
            this.btnTechnolog.Size = new System.Drawing.Size(292, 39);
            this.btnTechnolog.TabIndex = 2;
            this.btnTechnolog.TabStop = false;
            this.btnTechnolog.Tag = "3";
            this.btnTechnolog.Text = "Předat do technologie";
            this.btnTechnolog.Click += new System.EventHandler(this.btnStavZmena_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(10, 203);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(292, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Zavřít";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(10, 17);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(292, 39);
            this.btnUlozit.TabIndex = 0;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Pouze uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 2);
            this.label1.TabIndex = 82;
            // 
            // frmObjednavkaPolozkaWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTechnolog);
            this.Controls.Add(this.btnTPV);
            this.Controls.Add(this.btnUlozit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmObjednavkaPolozkaWorkflow";
            this.Text = "Uložit";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTPV;
        private DevExpress.XtraEditors.SimpleButton btnTechnolog;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private System.Windows.Forms.Label label1;
    }
}