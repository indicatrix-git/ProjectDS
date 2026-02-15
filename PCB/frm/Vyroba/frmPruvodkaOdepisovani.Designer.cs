namespace PCB
{
    partial class frmPruvodkaOdepisovani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruvodkaOdepisovani));
            this.lblCisloPruvod = new System.Windows.Forms.Label();
            this.lblOperace = new System.Windows.Forms.Label();
            this.pruvodkaodepisovaniBindingSource = new System.Windows.Forms.BindingSource();
            this.txtPoznKProved = new System.Windows.Forms.TextBox();
            this.lblPoznamkaKProved = new System.Windows.Forms.Label();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.btnOdepsat = new DevExpress.XtraEditors.SimpleButton();
            this.lblPocetKusu = new System.Windows.Forms.Label();
            this.textCisloPruvOdepis = new DevExpress.XtraEditors.TextEdit();
            this.txtPinPruvodky = new DevExpress.XtraEditors.TextEdit();
            this.lblPinPruvodky = new System.Windows.Forms.Label();
            this.txtVadnych = new DevExpress.XtraEditors.TextEdit();
            this.lblVadnych = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.pOdepisovani = new DevExpress.XtraEditors.PanelControl();
            this.lblOpravyPanel = new System.Windows.Forms.Label();
            this.txtOpravyPanel = new DevExpress.XtraEditors.TextEdit();
            this.lblOpravyKs = new System.Windows.Forms.Label();
            this.lblOpravyLomka = new System.Windows.Forms.Label();
            this.txtOpravyKus = new DevExpress.XtraEditors.TextEdit();
            this.lblPocetOprav = new System.Windows.Forms.Label();
            this.txtTechnickaPoznamka = new DevExpress.XtraEditors.MemoEdit();
            this.lblTechnickaPoznámka = new System.Windows.Forms.Label();
            this.btnZrusit = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnOdespatADalsi = new DevExpress.XtraEditors.SimpleButton();
            this.txtPoznamkaObchod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOperace = new DevExpress.XtraEditors.TextEdit();
            this.btnUzavritKooperaci = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPinPracovnika = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pruvodkaodepisovaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCisloPruvOdepis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPinPruvodky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadnych.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOdepisovani)).BeginInit();
            this.pOdepisovani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpravyPanel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpravyKus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnickaPoznamka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPinPracovnika.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCisloPruvod
            // 
            this.lblCisloPruvod.AutoSize = true;
            this.lblCisloPruvod.Location = new System.Drawing.Point(14, 12);
            this.lblCisloPruvod.Name = "lblCisloPruvod";
            this.lblCisloPruvod.Size = new System.Drawing.Size(81, 13);
            this.lblCisloPruvod.TabIndex = 239;
            this.lblCisloPruvod.Text = "Číslo průvodky:";
            // 
            // lblOperace
            // 
            this.lblOperace.AutoSize = true;
            this.lblOperace.Location = new System.Drawing.Point(12, 33);
            this.lblOperace.Name = "lblOperace";
            this.lblOperace.Size = new System.Drawing.Size(52, 13);
            this.lblOperace.TabIndex = 241;
            this.lblOperace.Text = "Operace:";
            // 
            // pruvodkaodepisovaniBindingSource
            // 
            this.pruvodkaodepisovaniBindingSource.DataSource = typeof(pcb_develModel.pruvodka_odepisovani);
            // 
            // txtPoznKProved
            // 
            this.txtPoznKProved.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pruvodkaodepisovaniBindingSource, "poznamka", true));
            this.txtPoznKProved.Location = new System.Drawing.Point(12, 210);
            this.txtPoznKProved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoznKProved.Multiline = true;
            this.txtPoznKProved.Name = "txtPoznKProved";
            this.txtPoznKProved.Size = new System.Drawing.Size(519, 78);
            this.txtPoznKProved.TabIndex = 243;
            // 
            // lblPoznamkaKProved
            // 
            this.lblPoznamkaKProved.AutoSize = true;
            this.lblPoznamkaKProved.Location = new System.Drawing.Point(9, 193);
            this.lblPoznamkaKProved.Name = "lblPoznamkaKProved";
            this.lblPoznamkaKProved.Size = new System.Drawing.Size(155, 13);
            this.lblPoznamkaKProved.TabIndex = 244;
            this.lblPoznamkaKProved.Text = "Poznámka výroby k provedení:";
            // 
            // btnOdepsat
            // 
            this.btnOdepsat.Image = ((System.Drawing.Image)(resources.GetObject("btnOdepsat.Image")));
            this.btnOdepsat.Location = new System.Drawing.Point(12, 394);
            this.btnOdepsat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdepsat.Name = "btnOdepsat";
            this.btnOdepsat.Size = new System.Drawing.Size(191, 33);
            this.btnOdepsat.TabIndex = 254;
            this.btnOdepsat.Text = "Odepsat a další operace";
            this.btnOdepsat.Click += new System.EventHandler(this.btnOdepsat_Click);
            // 
            // lblPocetKusu
            // 
            this.lblPocetKusu.AutoSize = true;
            this.lblPocetKusu.Location = new System.Drawing.Point(12, 129);
            this.lblPocetKusu.Name = "lblPocetKusu";
            this.lblPocetKusu.Size = new System.Drawing.Size(76, 13);
            this.lblPocetKusu.TabIndex = 257;
            this.lblPocetKusu.Text = "Počet neshod:";
            // 
            // textCisloPruvOdepis
            // 
            this.textCisloPruvOdepis.Location = new System.Drawing.Point(108, 10);
            this.textCisloPruvOdepis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCisloPruvOdepis.Name = "textCisloPruvOdepis";
            this.textCisloPruvOdepis.Size = new System.Drawing.Size(129, 20);
            this.textCisloPruvOdepis.TabIndex = 1;
            // 
            // txtPinPruvodky
            // 
            this.txtPinPruvodky.Location = new System.Drawing.Point(108, 32);
            this.txtPinPruvodky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPinPruvodky.Name = "txtPinPruvodky";
            this.txtPinPruvodky.Size = new System.Drawing.Size(129, 20);
            this.txtPinPruvodky.TabIndex = 2;
            // 
            // lblPinPruvodky
            // 
            this.lblPinPruvodky.AutoSize = true;
            this.lblPinPruvodky.Location = new System.Drawing.Point(19, 35);
            this.lblPinPruvodky.Name = "lblPinPruvodky";
            this.lblPinPruvodky.Size = new System.Drawing.Size(76, 13);
            this.lblPinPruvodky.TabIndex = 259;
            this.lblPinPruvodky.Text = "PIN průvodky:";
            // 
            // txtVadnych
            // 
            this.txtVadnych.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pruvodkaodepisovaniBindingSource, "vadny_ks", true));
            this.txtVadnych.EditValue = "0";
            this.txtVadnych.Location = new System.Drawing.Point(109, 127);
            this.txtVadnych.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVadnych.Name = "txtVadnych";
            this.txtVadnych.Size = new System.Drawing.Size(55, 20);
            this.txtVadnych.TabIndex = 5;
            // 
            // lblVadnych
            // 
            this.lblVadnych.AutoSize = true;
            this.lblVadnych.Location = new System.Drawing.Point(169, 129);
            this.lblVadnych.Name = "lblVadnych";
            this.lblVadnych.Size = new System.Drawing.Size(17, 13);
            this.lblVadnych.TabIndex = 266;
            this.lblVadnych.Text = "ks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 271;
            this.label1.Text = " panelů";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pruvodkaodepisovaniBindingSource, "vadny_panelu_ks", true));
            this.textEdit1.EditValue = "0";
            this.textEdit1.Location = new System.Drawing.Point(209, 127);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(56, 20);
            this.textEdit1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 269;
            this.label2.Text = "/";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(151, 83);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 21);
            this.btnOK.TabIndex = 272;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pOdepisovani
            // 
            this.pOdepisovani.Controls.Add(this.lblOpravyPanel);
            this.pOdepisovani.Controls.Add(this.txtOpravyPanel);
            this.pOdepisovani.Controls.Add(this.lblOpravyKs);
            this.pOdepisovani.Controls.Add(this.lblOpravyLomka);
            this.pOdepisovani.Controls.Add(this.txtOpravyKus);
            this.pOdepisovani.Controls.Add(this.lblPocetOprav);
            this.pOdepisovani.Controls.Add(this.txtTechnickaPoznamka);
            this.pOdepisovani.Controls.Add(this.lblTechnickaPoznámka);
            this.pOdepisovani.Controls.Add(this.btnZrusit);
            this.pOdepisovani.Controls.Add(this.progressBarControl1);
            this.pOdepisovani.Controls.Add(this.btnOdespatADalsi);
            this.pOdepisovani.Controls.Add(this.txtPoznamkaObchod);
            this.pOdepisovani.Controls.Add(this.label3);
            this.pOdepisovani.Controls.Add(this.txtOperace);
            this.pOdepisovani.Controls.Add(this.lblVadnych);
            this.pOdepisovani.Controls.Add(this.lblOperace);
            this.pOdepisovani.Controls.Add(this.label1);
            this.pOdepisovani.Controls.Add(this.textEdit1);
            this.pOdepisovani.Controls.Add(this.txtPoznKProved);
            this.pOdepisovani.Controls.Add(this.label2);
            this.pOdepisovani.Controls.Add(this.btnOdepsat);
            this.pOdepisovani.Controls.Add(this.lblPoznamkaKProved);
            this.pOdepisovani.Controls.Add(this.lblPocetKusu);
            this.pOdepisovani.Controls.Add(this.txtVadnych);
            this.pOdepisovani.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pOdepisovani.Location = new System.Drawing.Point(0, 121);
            this.pOdepisovani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pOdepisovani.Name = "pOdepisovani";
            this.pOdepisovani.Size = new System.Drawing.Size(546, 446);
            this.pOdepisovani.TabIndex = 1;
            this.pOdepisovani.Visible = false;
            // 
            // lblOpravyPanel
            // 
            this.lblOpravyPanel.AutoSize = true;
            this.lblOpravyPanel.Location = new System.Drawing.Point(269, 154);
            this.lblOpravyPanel.Name = "lblOpravyPanel";
            this.lblOpravyPanel.Size = new System.Drawing.Size(42, 13);
            this.lblOpravyPanel.TabIndex = 286;
            this.lblOpravyPanel.Text = " panelů";
            // 
            // txtOpravyPanel
            // 
            this.txtOpravyPanel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pruvodkaodepisovaniBindingSource, "oprav_panel_ks", true));
            this.txtOpravyPanel.EditValue = "0";
            this.txtOpravyPanel.Location = new System.Drawing.Point(210, 151);
            this.txtOpravyPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpravyPanel.Name = "txtOpravyPanel";
            this.txtOpravyPanel.Size = new System.Drawing.Size(55, 20);
            this.txtOpravyPanel.TabIndex = 285;
            // 
            // lblOpravyKs
            // 
            this.lblOpravyKs.AutoSize = true;
            this.lblOpravyKs.Location = new System.Drawing.Point(169, 154);
            this.lblOpravyKs.Name = "lblOpravyKs";
            this.lblOpravyKs.Size = new System.Drawing.Size(17, 13);
            this.lblOpravyKs.TabIndex = 283;
            this.lblOpravyKs.Text = "ks";
            // 
            // lblOpravyLomka
            // 
            this.lblOpravyLomka.AutoSize = true;
            this.lblOpravyLomka.Location = new System.Drawing.Point(193, 154);
            this.lblOpravyLomka.Name = "lblOpravyLomka";
            this.lblOpravyLomka.Size = new System.Drawing.Size(11, 13);
            this.lblOpravyLomka.TabIndex = 284;
            this.lblOpravyLomka.Text = "/";
            // 
            // txtOpravyKus
            // 
            this.txtOpravyKus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pruvodkaodepisovaniBindingSource, "oprav_ks", true));
            this.txtOpravyKus.EditValue = "0";
            this.txtOpravyKus.Location = new System.Drawing.Point(109, 151);
            this.txtOpravyKus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpravyKus.Name = "txtOpravyKus";
            this.txtOpravyKus.Size = new System.Drawing.Size(54, 20);
            this.txtOpravyKus.TabIndex = 282;
            // 
            // lblPocetOprav
            // 
            this.lblPocetOprav.AutoSize = true;
            this.lblPocetOprav.Location = new System.Drawing.Point(19, 154);
            this.lblPocetOprav.Name = "lblPocetOprav";
            this.lblPocetOprav.Size = new System.Drawing.Size(69, 13);
            this.lblPocetOprav.TabIndex = 281;
            this.lblPocetOprav.Text = "Počet oprav:";
            // 
            // txtTechnickaPoznamka
            // 
            this.txtTechnickaPoznamka.Location = new System.Drawing.Point(12, 76);
            this.txtTechnickaPoznamka.Name = "txtTechnickaPoznamka";
            this.txtTechnickaPoznamka.Properties.ReadOnly = true;
            this.txtTechnickaPoznamka.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTechnickaPoznamka.Size = new System.Drawing.Size(519, 46);
            this.txtTechnickaPoznamka.TabIndex = 280;
            // 
            // lblTechnickaPoznámka
            // 
            this.lblTechnickaPoznámka.AutoSize = true;
            this.lblTechnickaPoznámka.Location = new System.Drawing.Point(14, 60);
            this.lblTechnickaPoznámka.Name = "lblTechnickaPoznámka";
            this.lblTechnickaPoznámka.Size = new System.Drawing.Size(105, 13);
            this.lblTechnickaPoznámka.TabIndex = 278;
            this.lblTechnickaPoznámka.Text = "Technická poznámka";
            // 
            // btnZrusit
            // 
            this.btnZrusit.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusit.Image")));
            this.btnZrusit.Location = new System.Drawing.Point(392, 394);
            this.btnZrusit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusit.Name = "btnZrusit";
            this.btnZrusit.Size = new System.Drawing.Size(139, 33);
            this.btnZrusit.TabIndex = 277;
            this.btnZrusit.Text = "Zrušit";
            this.btnZrusit.Click += new System.EventHandler(this.btnZrusit_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.EditValue = "50";
            this.progressBarControl1.Location = new System.Drawing.Point(12, 4);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(519, 22);
            this.progressBarControl1.TabIndex = 276;
            // 
            // btnOdespatADalsi
            // 
            this.btnOdespatADalsi.Image = ((System.Drawing.Image)(resources.GetObject("btnOdespatADalsi.Image")));
            this.btnOdespatADalsi.Location = new System.Drawing.Point(208, 394);
            this.btnOdespatADalsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdespatADalsi.Name = "btnOdespatADalsi";
            this.btnOdespatADalsi.Size = new System.Drawing.Size(139, 33);
            this.btnOdespatADalsi.TabIndex = 275;
            this.btnOdespatADalsi.Text = "Odepsat a zavřít";
            this.btnOdespatADalsi.Click += new System.EventHandler(this.btnOdespatAZavrit_Click);
            // 
            // txtPoznamkaObchod
            // 
            this.txtPoznamkaObchod.Location = new System.Drawing.Point(12, 305);
            this.txtPoznamkaObchod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoznamkaObchod.Multiline = true;
            this.txtPoznamkaObchod.Name = "txtPoznamkaObchod";
            this.txtPoznamkaObchod.ReadOnly = true;
            this.txtPoznamkaObchod.Size = new System.Drawing.Size(519, 78);
            this.txtPoznamkaObchod.TabIndex = 273;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 274;
            this.label3.Text = "Informace od zákazníka:";
            // 
            // txtOperace
            // 
            this.txtOperace.Location = new System.Drawing.Point(109, 30);
            this.txtOperace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOperace.Name = "txtOperace";
            this.txtOperace.Properties.ReadOnly = true;
            this.txtOperace.Size = new System.Drawing.Size(422, 20);
            this.txtOperace.TabIndex = 4;
            // 
            // btnUzavritKooperaci
            // 
            this.btnUzavritKooperaci.Image = ((System.Drawing.Image)(resources.GetObject("btnUzavritKooperaci.Image")));
            this.btnUzavritKooperaci.Location = new System.Drawing.Point(392, 11);
            this.btnUzavritKooperaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUzavritKooperaci.Name = "btnUzavritKooperaci";
            this.btnUzavritKooperaci.Size = new System.Drawing.Size(139, 33);
            this.btnUzavritKooperaci.TabIndex = 277;
            this.btnUzavritKooperaci.Text = "Uzavřít kooperaci";
            this.btnUzavritKooperaci.Visible = false;
            this.btnUzavritKooperaci.Click += new System.EventHandler(this.btnUzavritKooperaci_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 278;
            this.label4.Text = "PIN pracovníka:";
            // 
            // txtPinPracovnika
            // 
            this.txtPinPracovnika.Location = new System.Drawing.Point(108, 55);
            this.txtPinPracovnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPinPracovnika.Name = "txtPinPracovnika";
            this.txtPinPracovnika.Size = new System.Drawing.Size(129, 20);
            this.txtPinPracovnika.TabIndex = 3;
            // 
            // frmPruvodkaOdepisovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 567);
            this.Controls.Add(this.txtPinPracovnika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUzavritKooperaci);
            this.Controls.Add(this.pOdepisovani);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPinPruvodky);
            this.Controls.Add(this.lblPinPruvodky);
            this.Controls.Add(this.textCisloPruvOdepis);
            this.Controls.Add(this.lblCisloPruvod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPruvodkaOdepisovani";
            this.Text = "Průvodka odepisovaní";
            ((System.ComponentModel.ISupportInitialize)(this.pruvodkaodepisovaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCisloPruvOdepis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPinPruvodky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadnych.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOdepisovani)).EndInit();
            this.pOdepisovani.ResumeLayout(false);
            this.pOdepisovani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpravyPanel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpravyKus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnickaPoznamka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPinPracovnika.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCisloPruvod;
        private System.Windows.Forms.Label lblOperace;
        private System.Windows.Forms.TextBox txtPoznKProved;
        private System.Windows.Forms.Label lblPoznamkaKProved;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton btnOdepsat;
        private System.Windows.Forms.Label lblPocetKusu;
        private DevExpress.XtraEditors.TextEdit textCisloPruvOdepis;
        private DevExpress.XtraEditors.TextEdit txtPinPruvodky;
        private System.Windows.Forms.Label lblPinPruvodky;
        private DevExpress.XtraEditors.TextEdit txtVadnych;
        private System.Windows.Forms.Label lblVadnych;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource pruvodkaodepisovaniBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.PanelControl pOdepisovani;
        private DevExpress.XtraEditors.TextEdit txtOperace;
        private System.Windows.Forms.TextBox txtPoznamkaObchod;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnOdespatADalsi;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnUzavritKooperaci;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPinPracovnika;
        private DevExpress.XtraEditors.SimpleButton btnZrusit;
        private System.Windows.Forms.Label lblTechnickaPoznámka;
        private DevExpress.XtraEditors.MemoEdit txtTechnickaPoznamka;
        private System.Windows.Forms.Label lblOpravyPanel;
        private DevExpress.XtraEditors.TextEdit txtOpravyPanel;
        private System.Windows.Forms.Label lblOpravyKs;
        private System.Windows.Forms.Label lblOpravyLomka;
        private DevExpress.XtraEditors.TextEdit txtOpravyKus;
        private System.Windows.Forms.Label lblPocetOprav;
    }
}