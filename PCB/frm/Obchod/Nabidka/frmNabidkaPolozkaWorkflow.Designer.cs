namespace PCB
{
    partial class frmNabidkaPolozkaWorkflow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabidkaPolozkaWorkflow));
            this.btnTPV = new DevExpress.XtraEditors.SimpleButton();
            this.btnTechnolog = new DevExpress.XtraEditors.SimpleButton();
            this.btnPredatDoObchodu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSpustitDoVyroby = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTPV
            // 
            this.btnTPV.Image = ((System.Drawing.Image)(resources.GetObject("btnTPV.Image")));
            this.btnTPV.Location = new System.Drawing.Point(10, 65);
            this.btnTPV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTPV.Name = "btnTPV";
            this.btnTPV.Size = new System.Drawing.Size(341, 48);
            this.btnTPV.TabIndex = 1;
            this.btnTPV.TabStop = false;
            this.btnTPV.Tag = "2";
            this.btnTPV.Text = "Předat do TPV ";
            this.btnTPV.Click += new System.EventHandler(this.btnStavZmena_Click);
            // 
            // btnTechnolog
            // 
            this.btnTechnolog.Image = ((System.Drawing.Image)(resources.GetObject("btnTechnolog.Image")));
            this.btnTechnolog.Location = new System.Drawing.Point(10, 118);
            this.btnTechnolog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTechnolog.Name = "btnTechnolog";
            this.btnTechnolog.Size = new System.Drawing.Size(341, 48);
            this.btnTechnolog.TabIndex = 2;
            this.btnTechnolog.TabStop = false;
            this.btnTechnolog.Tag = "3";
            this.btnTechnolog.Text = "Předat do technologie";
            this.btnTechnolog.Click += new System.EventHandler(this.btnStavZmena_Click);
            // 
            // btnPredatDoObchodu
            // 
            this.btnPredatDoObchodu.Image = ((System.Drawing.Image)(resources.GetObject("btnPredatDoObchodu.Image")));
            this.btnPredatDoObchodu.Location = new System.Drawing.Point(10, 171);
            this.btnPredatDoObchodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPredatDoObchodu.Name = "btnPredatDoObchodu";
            this.btnPredatDoObchodu.Size = new System.Drawing.Size(341, 48);
            this.btnPredatDoObchodu.TabIndex = 3;
            this.btnPredatDoObchodu.TabStop = false;
            this.btnPredatDoObchodu.Tag = "4";
            this.btnPredatDoObchodu.Text = "Předat do obchodu";
            this.btnPredatDoObchodu.Click += new System.EventHandler(this.btnStavZmena_Click);
            // 
            // btnSpustitDoVyroby
            // 
            this.btnSpustitDoVyroby.Image = ((System.Drawing.Image)(resources.GetObject("btnSpustitDoVyroby.Image")));
            this.btnSpustitDoVyroby.Location = new System.Drawing.Point(10, 12);
            this.btnSpustitDoVyroby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpustitDoVyroby.Name = "btnSpustitDoVyroby";
            this.btnSpustitDoVyroby.Size = new System.Drawing.Size(341, 48);
            this.btnSpustitDoVyroby.TabIndex = 4;
            this.btnSpustitDoVyroby.TabStop = false;
            this.btnSpustitDoVyroby.Tag = "5";
            this.btnSpustitDoVyroby.Text = "Uložit a uzavřít";
            this.btnSpustitDoVyroby.Click += new System.EventHandler(this.btnStavZmena_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(252, 249);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Storno";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 82;
            // 
            // frmNabidkaPolozkaWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSpustitDoVyroby);
            this.Controls.Add(this.btnPredatDoObchodu);
            this.Controls.Add(this.btnTechnolog);
            this.Controls.Add(this.btnTPV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNabidkaPolozkaWorkflow";
            this.Text = "Uložit";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTPV;
        private DevExpress.XtraEditors.SimpleButton btnTechnolog;
        private DevExpress.XtraEditors.SimpleButton btnPredatDoObchodu;
        private DevExpress.XtraEditors.SimpleButton btnSpustitDoVyroby;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label1;
    }
}