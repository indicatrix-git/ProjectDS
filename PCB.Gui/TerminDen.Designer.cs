namespace PCB.Gui
{
    partial class TerminDen
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
            this.lblDatum = new DevExpress.XtraEditors.LabelControl();
            this.pbRoot = new System.Windows.Forms.PictureBox();
            this.pbValue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.Location = new System.Drawing.Point(0, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(50, 16);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "1.1.2015";
            // 
            // pbRoot
            // 
            this.pbRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRoot.Location = new System.Drawing.Point(74, 0);
            this.pbRoot.Name = "pbRoot";
            this.pbRoot.Size = new System.Drawing.Size(219, 17);
            this.pbRoot.TabIndex = 1;
            this.pbRoot.TabStop = false;
            // 
            // pbValue
            // 
            this.pbValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbValue.Location = new System.Drawing.Point(74, 0);
            this.pbValue.Name = "pbValue";
            this.pbValue.Size = new System.Drawing.Size(50, 17);
            this.pbValue.TabIndex = 2;
            this.pbValue.TabStop = false;
            // 
            // TerminDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbValue);
            this.Controls.Add(this.pbRoot);
            this.Controls.Add(this.lblDatum);
            this.Name = "TerminDen";
            this.Size = new System.Drawing.Size(294, 17);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDatum;
        private System.Windows.Forms.PictureBox pbRoot;
        private System.Windows.Forms.PictureBox pbValue;
    }
}
