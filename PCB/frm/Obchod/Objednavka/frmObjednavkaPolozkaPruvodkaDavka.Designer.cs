namespace PCB
{
    partial class frmPruvodkaDavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruvodkaDavka));
            this.txtPocet = new DevExpress.XtraEditors.TextEdit();
            this.lblPridavek = new System.Windows.Forms.Label();
            this.objednavkapolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtCisloPruvodky = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.lblPocetPruvodek = new System.Windows.Forms.Label();
            this.lblPocetKs = new System.Windows.Forms.Label();
            this.lblCelkovyPocetKusu = new System.Windows.Forms.Label();
            this.btnKontrola = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPocet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objednavkapolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCisloPruvodky.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPocet
            // 
            this.txtPocet.EditValue = "1";
            this.txtPocet.Location = new System.Drawing.Point(164, 118);
            this.txtPocet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPocet.Name = "txtPocet";
            this.txtPocet.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPocet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPocet.Properties.Mask.EditMask = "d";
            this.txtPocet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPocet.Size = new System.Drawing.Size(91, 22);
            this.txtPocet.TabIndex = 2;
            // 
            // lblPridavek
            // 
            this.lblPridavek.AutoSize = true;
            this.lblPridavek.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objednavkapolozkaBindingSource, "tech_pridavek", true));
            this.lblPridavek.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPridavek.Location = new System.Drawing.Point(161, 46);
            this.lblPridavek.Name = "lblPridavek";
            this.lblPridavek.Size = new System.Drawing.Size(35, 17);
            this.lblPridavek.TabIndex = 2;
            this.lblPridavek.Text = "300";
            // 
            // objednavkapolozkaBindingSource
            // 
            this.objednavkapolozkaBindingSource.DataSource = typeof(pcb_develModel.objednavka_polozka);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 313;
            this.label3.Text = "Přídavek:";
            // 
            // txtCisloPruvodky
            // 
            this.txtCisloPruvodky.EditValue = "1";
            this.txtCisloPruvodky.Location = new System.Drawing.Point(164, 90);
            this.txtCisloPruvodky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCisloPruvodky.Name = "txtCisloPruvodky";
            this.txtCisloPruvodky.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCisloPruvodky.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCisloPruvodky.Properties.Mask.EditMask = "d";
            this.txtCisloPruvodky.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCisloPruvodky.Size = new System.Drawing.Size(91, 22);
            this.txtCisloPruvodky.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 311;
            this.label1.Text = "Číslo průvodky:";
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(328, 199);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 309;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(187, 199);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 28);
            this.btnOk.TabIndex = 308;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "Vytvořit průvodku";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPocetPruvodek
            // 
            this.lblPocetPruvodek.AutoSize = true;
            this.lblPocetPruvodek.Location = new System.Drawing.Point(44, 121);
            this.lblPocetPruvodek.Name = "lblPocetPruvodek";
            this.lblPocetPruvodek.Size = new System.Drawing.Size(111, 17);
            this.lblPocetPruvodek.TabIndex = 4;
            this.lblPocetPruvodek.Text = "Počet průvodek:";
            // 
            // lblPocetKs
            // 
            this.lblPocetKs.AutoSize = true;
            this.lblPocetKs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objednavkapolozkaBindingSource, "pozadovano_pocet", true));
            this.lblPocetKs.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPocetKs.Location = new System.Drawing.Point(161, 19);
            this.lblPocetKs.Name = "lblPocetKs";
            this.lblPocetKs.Size = new System.Drawing.Size(35, 17);
            this.lblPocetKs.TabIndex = 1;
            this.lblPocetKs.Text = "300";
            // 
            // lblCelkovyPocetKusu
            // 
            this.lblCelkovyPocetKusu.AutoSize = true;
            this.lblCelkovyPocetKusu.Location = new System.Drawing.Point(22, 19);
            this.lblCelkovyPocetKusu.Name = "lblCelkovyPocetKusu";
            this.lblCelkovyPocetKusu.Size = new System.Drawing.Size(138, 17);
            this.lblCelkovyPocetKusu.TabIndex = 0;
            this.lblCelkovyPocetKusu.Text = "Celkový počet kusů: ";
            // 
            // btnKontrola
            // 
            this.btnKontrola.Image = ((System.Drawing.Image)(resources.GetObject("btnKontrola.Image")));
            this.btnKontrola.Location = new System.Drawing.Point(304, 16);
            this.btnKontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKontrola.Name = "btnKontrola";
            this.btnKontrola.Size = new System.Drawing.Size(124, 48);
            this.btnKontrola.TabIndex = 319;
            this.btnKontrola.TabStop = false;
            this.btnKontrola.Text = "Kontrola";
            this.btnKontrola.Click += new System.EventHandler(this.btnKontrola_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 2);
            this.label2.TabIndex = 320;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCelkovyPocetKusu);
            this.groupBox1.Controls.Add(this.lblPocetKs);
            this.groupBox1.Controls.Add(this.lblPocetPruvodek);
            this.groupBox1.Controls.Add(this.txtPocet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPridavek);
            this.groupBox1.Controls.Add(this.txtCisloPruvodky);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmPruvodkaDavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKontrola);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPruvodkaDavka";
            this.Text = "Dávka";
            this.Load += new System.EventHandler(this.frmPruvodkaDavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPocet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objednavkapolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCisloPruvodky.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCelkovyPocetKusu;
        private System.Windows.Forms.Label lblPocetKs;
        private System.Windows.Forms.Label lblPocetPruvodek;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Windows.Forms.BindingSource objednavkapolozkaBindingSource;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCisloPruvodky;
        private System.Windows.Forms.Label lblPridavek;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPocet;
        private DevExpress.XtraEditors.SimpleButton btnKontrola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}