namespace PCB
{
    partial class frmPravaHodnota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPravaHodnota));
            this.lblPravo = new DevExpress.XtraEditors.LabelControl();
            this.PravaUzivatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pravahodnotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPravoHodnota = new DevExpress.XtraEditors.LabelControl();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPravo = new System.Windows.Forms.ComboBox();
            this.cmbHodnota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PravaUzivatelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravahodnotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPravo
            // 
            this.lblPravo.Location = new System.Drawing.Point(14, 17);
            this.lblPravo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPravo.Name = "lblPravo";
            this.lblPravo.Size = new System.Drawing.Size(37, 16);
            this.lblPravo.TabIndex = 0;
            this.lblPravo.Text = "Právo:";
            // 
            // PravaUzivatelBindingSource
            // 
            this.PravaUzivatelBindingSource.DataSource = typeof(pcb_develModel.prava_uzivatel);
            // 
            // pravaBindingSource
            // 
            this.pravaBindingSource.DataSource = typeof(pcb_develModel.prava);
            // 
            // pravahodnotaBindingSource
            // 
            this.pravahodnotaBindingSource.DataSource = typeof(pcb_develModel.prava_hodnota);
            // 
            // lblPravoHodnota
            // 
            this.lblPravoHodnota.Location = new System.Drawing.Point(14, 49);
            this.lblPravoHodnota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPravoHodnota.Name = "lblPravoHodnota";
            this.lblPravoHodnota.Size = new System.Drawing.Size(52, 16);
            this.lblPravoHodnota.TabIndex = 2;
            this.lblPravoHodnota.Text = "Hodnota:";
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(69, 99);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 28);
            this.btnUlozit.TabIndex = 4;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(175, 99);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 5;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // cmbPravo
            // 
            this.cmbPravo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.PravaUzivatelBindingSource, "prava_id", true));
            this.cmbPravo.DataSource = this.pravaBindingSource;
            this.cmbPravo.DisplayMember = "nazev";
            this.cmbPravo.FormattingEnabled = true;
            this.cmbPravo.Location = new System.Drawing.Point(93, 14);
            this.cmbPravo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPravo.Name = "cmbPravo";
            this.cmbPravo.Size = new System.Drawing.Size(181, 24);
            this.cmbPravo.TabIndex = 6;
            this.cmbPravo.ValueMember = "prava_id";
            // 
            // cmbHodnota
            // 
            this.cmbHodnota.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.PravaUzivatelBindingSource, "prava_hodnota_id", true));
            this.cmbHodnota.DataSource = this.pravahodnotaBindingSource;
            this.cmbHodnota.DisplayMember = "nazev";
            this.cmbHodnota.FormattingEnabled = true;
            this.cmbHodnota.Location = new System.Drawing.Point(93, 46);
            this.cmbHodnota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHodnota.Name = "cmbHodnota";
            this.cmbHodnota.Size = new System.Drawing.Size(181, 24);
            this.cmbHodnota.TabIndex = 7;
            this.cmbHodnota.ValueMember = "prava_hodnota_id";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 82;
            // 
            // frmPravaHodnota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHodnota);
            this.Controls.Add(this.cmbPravo);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.lblPravoHodnota);
            this.Controls.Add(this.lblPravo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPravaHodnota";
            this.Text = "Hodnota práva";
            ((System.ComponentModel.ISupportInitialize)(this.PravaUzivatelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravahodnotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPravo;
        private DevExpress.XtraEditors.LabelControl lblPravoHodnota;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.BindingSource pravaBindingSource;
        private System.Windows.Forms.BindingSource pravahodnotaBindingSource;
        private System.Windows.Forms.BindingSource PravaUzivatelBindingSource;
        private System.Windows.Forms.ComboBox cmbPravo;
        private System.Windows.Forms.ComboBox cmbHodnota;
        private System.Windows.Forms.Label label1;
    }
}