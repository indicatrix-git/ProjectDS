namespace PCB
{
    partial class frmZmenaHesla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZmenaHesla));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnZmenit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.txtStareHeslo = new DevExpress.XtraEditors.TextEdit();
            this.txtNoveHeslo = new DevExpress.XtraEditors.TextEdit();
            this.txtKontrola = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStareHeslo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoveHeslo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKontrola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Staré heslo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 44);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nové heslo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 70);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Kontrola:";
            // 
            // btnZmenit
            // 
            this.btnZmenit.Image = ((System.Drawing.Image)(resources.GetObject("btnZmenit.Image")));
            this.btnZmenit.Location = new System.Drawing.Point(71, 121);
            this.btnZmenit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZmenit.Name = "btnZmenit";
            this.btnZmenit.Size = new System.Drawing.Size(100, 28);
            this.btnZmenit.TabIndex = 6;
            this.btnZmenit.TabStop = false;
            this.btnZmenit.Text = "Změnit";
            this.btnZmenit.Click += new System.EventHandler(this.btnZmenit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(177, 121);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 7;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // txtStareHeslo
            // 
            this.txtStareHeslo.Location = new System.Drawing.Point(95, 14);
            this.txtStareHeslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStareHeslo.Name = "txtStareHeslo";
            this.txtStareHeslo.Properties.PasswordChar = '*';
            this.txtStareHeslo.Size = new System.Drawing.Size(182, 22);
            this.txtStareHeslo.TabIndex = 8;
            // 
            // txtNoveHeslo
            // 
            this.txtNoveHeslo.Location = new System.Drawing.Point(95, 41);
            this.txtNoveHeslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoveHeslo.Name = "txtNoveHeslo";
            this.txtNoveHeslo.Properties.PasswordChar = '*';
            this.txtNoveHeslo.Size = new System.Drawing.Size(182, 22);
            this.txtNoveHeslo.TabIndex = 9;
            // 
            // txtKontrola
            // 
            this.txtKontrola.Location = new System.Drawing.Point(95, 67);
            this.txtKontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKontrola.Name = "txtKontrola";
            this.txtKontrola.Properties.PasswordChar = '*';
            this.txtKontrola.Size = new System.Drawing.Size(182, 22);
            this.txtKontrola.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 82;
            // 
            // frmZmenaHesla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKontrola);
            this.Controls.Add(this.txtNoveHeslo);
            this.Controls.Add(this.txtStareHeslo);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnZmenit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmZmenaHesla";
            this.Text = "Změna hesla";
            this.Shown += new System.EventHandler(this.frmZmenaHesla_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtStareHeslo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoveHeslo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKontrola.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnZmenit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.TextEdit txtStareHeslo;
        private DevExpress.XtraEditors.TextEdit txtNoveHeslo;
        private DevExpress.XtraEditors.TextEdit txtKontrola;
        private System.Windows.Forms.Label label1;
    }
}