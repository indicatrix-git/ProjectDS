namespace PCB.Gui
{
    partial class IconHolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconHolder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdstranit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPridat = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.btnOdstranit);
            this.panel1.Controls.Add(this.btnPridat);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.Image")));
            this.btnDetail.Location = new System.Drawing.Point(61, 4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(25, 23);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnOdstranit
            // 
            this.btnOdstranit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOdstranit.Image = ((System.Drawing.Image)(resources.GetObject("btnOdstranit.Image")));
            this.btnOdstranit.Location = new System.Drawing.Point(30, 4);
            this.btnOdstranit.Name = "btnOdstranit";
            this.btnOdstranit.Size = new System.Drawing.Size(25, 23);
            this.btnOdstranit.TabIndex = 1;
            this.btnOdstranit.Click += new System.EventHandler(this.btnOdstranit_Click);
            // 
            // btnPridat
            // 
            this.btnPridat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPridat.Image = ((System.Drawing.Image)(resources.GetObject("btnPridat.Image")));
            this.btnPridat.Location = new System.Drawing.Point(3, 3);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(25, 23);
            this.btnPridat.TabIndex = 0;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // IconHolder
            // 
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "IconHolder";
            this.Size = new System.Drawing.Size(95, 38);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDetail;
        private DevExpress.XtraEditors.SimpleButton btnOdstranit;
        private DevExpress.XtraEditors.SimpleButton btnPridat;


    }
}
