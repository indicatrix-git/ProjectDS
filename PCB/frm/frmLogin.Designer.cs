namespace PCB
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lblUzivJmeno = new DevExpress.XtraEditors.LabelControl();
            this.lblHeslo = new DevExpress.XtraEditors.LabelControl();
            this.txtUzivJm = new DevExpress.XtraEditors.TextEdit();
            this.txtHeslo = new DevExpress.XtraEditors.TextEdit();
            this.btnPrihlasit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUzivJm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeslo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 70);
            this.panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(255, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Definity Systems s.r.o.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "PCB IS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Copyright (c) 2015-2016";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 233);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(396, 20);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Green";
            this.defaultLookAndFeel1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            // 
            // lblUzivJmeno
            // 
            this.lblUzivJmeno.Location = new System.Drawing.Point(30, 97);
            this.lblUzivJmeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblUzivJmeno.Name = "lblUzivJmeno";
            this.lblUzivJmeno.Size = new System.Drawing.Size(108, 16);
            this.lblUzivJmeno.TabIndex = 7;
            this.lblUzivJmeno.Text = "Uživatelské jméno:";
            // 
            // lblHeslo
            // 
            this.lblHeslo.Location = new System.Drawing.Point(102, 137);
            this.lblHeslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblHeslo.Name = "lblHeslo";
            this.lblHeslo.Size = new System.Drawing.Size(36, 16);
            this.lblHeslo.TabIndex = 8;
            this.lblHeslo.Text = "Heslo:";
            // 
            // txtUzivJm
            // 
            this.txtUzivJm.Location = new System.Drawing.Point(144, 94);
            this.txtUzivJm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUzivJm.Name = "txtUzivJm";
            this.txtUzivJm.Size = new System.Drawing.Size(237, 22);
            this.txtUzivJm.TabIndex = 9;
            // 
            // txtHeslo
            // 
            this.txtHeslo.Location = new System.Drawing.Point(144, 134);
            this.txtHeslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeslo.Name = "txtHeslo";
            this.txtHeslo.Properties.PasswordChar = '*';
            this.txtHeslo.Size = new System.Drawing.Size(237, 22);
            this.txtHeslo.TabIndex = 10;
            // 
            // btnPrihlasit
            // 
            this.btnPrihlasit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrihlasit.Image = ((System.Drawing.Image)(resources.GetObject("btnPrihlasit.Image")));
            this.btnPrihlasit.Location = new System.Drawing.Point(175, 188);
            this.btnPrihlasit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrihlasit.Name = "btnPrihlasit";
            this.btnPrihlasit.Size = new System.Drawing.Size(100, 33);
            this.btnPrihlasit.TabIndex = 11;
            this.btnPrihlasit.TabStop = false;
            this.btnPrihlasit.Text = "Přihlásit";
            this.btnPrihlasit.Click += new System.EventHandler(this.btnPrihlasit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(281, 188);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 33);
            this.btnStorno.TabIndex = 12;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 82;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnPrihlasit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnPrihlasit);
            this.Controls.Add(this.txtHeslo);
            this.Controls.Add(this.txtUzivJm);
            this.Controls.Add(this.lblHeslo);
            this.Controls.Add(this.lblUzivJmeno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přihlášení do aplikace";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUzivJm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeslo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lblUzivJmeno;
        private DevExpress.XtraEditors.LabelControl lblHeslo;
        private DevExpress.XtraEditors.TextEdit txtUzivJm;
        private DevExpress.XtraEditors.TextEdit txtHeslo;
        private DevExpress.XtraEditors.SimpleButton btnPrihlasit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.Label label1;
    }
}