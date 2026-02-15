namespace PCB
{
    partial class frmUzivatelDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUzivatelDetail));
            this.txtOsobniCislo = new DevExpress.XtraEditors.TextEdit();
            this.uzivatelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHeslo = new DevExpress.XtraEditors.TextEdit();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.txtJmeno = new DevExpress.XtraEditors.TextEdit();
            this.txtPrijmeni = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblHesloKontrola = new PCB.Gui.RequiredLabel();
            this.txtHesloKontrola = new DevExpress.XtraEditors.TextEdit();
            this.cmbRole = new PCB.Gui.PCBLookUpEdit();
            this.lblEmail = new PCB.Gui.RequiredLabel();
            this.lblPrijmeni = new PCB.Gui.RequiredLabel();
            this.lblJmeno = new PCB.Gui.RequiredLabel();
            this.lblRole = new PCB.Gui.RequiredLabel();
            this.lblHeslo = new PCB.Gui.RequiredLabel();
            this.lblosobniCislo = new PCB.Gui.RequiredLabel();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.clbOddeleni = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.oddeleniBindigSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gcPrava = new DevExpress.XtraGrid.GridControl();
            this.pravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.pravahodnotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPodpis = new DevExpress.XtraEditors.TextEdit();
            this.lblPodpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtOsobniCislo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzivatelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeslo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmeno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrijmeni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesloKontrola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbOddeleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddeleniBindigSource)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravahodnotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPodpis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOsobniCislo
            // 
            this.txtOsobniCislo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uzivatelsBindingSource, "osobni_cislo", true));
            this.txtOsobniCislo.Location = new System.Drawing.Point(114, 16);
            this.txtOsobniCislo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOsobniCislo.Name = "txtOsobniCislo";
            this.txtOsobniCislo.Size = new System.Drawing.Size(180, 20);
            this.txtOsobniCislo.TabIndex = 1;
            // 
            // uzivatelsBindingSource
            // 
            this.uzivatelsBindingSource.DataSource = typeof(pcb_develModel.uzivatel);
            // 
            // txtHeslo
            // 
            this.txtHeslo.Location = new System.Drawing.Point(114, 40);
            this.txtHeslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeslo.Name = "txtHeslo";
            this.txtHeslo.Properties.PasswordChar = '#';
            this.txtHeslo.Size = new System.Drawing.Size(180, 20);
            this.txtHeslo.TabIndex = 2;
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(266, 401);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(86, 23);
            this.btnUlozit.TabIndex = 4;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(357, 401);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(86, 23);
            this.btnStorno.TabIndex = 5;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // txtJmeno
            // 
            this.txtJmeno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uzivatelsBindingSource, "jmeno", true));
            this.txtJmeno.Location = new System.Drawing.Point(114, 124);
            this.txtJmeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(180, 20);
            this.txtJmeno.TabIndex = 4;
            // 
            // txtPrijmeni
            // 
            this.txtPrijmeni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uzivatelsBindingSource, "prijmeni", true));
            this.txtPrijmeni.Location = new System.Drawing.Point(114, 148);
            this.txtPrijmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrijmeni.Name = "txtPrijmeni";
            this.txtPrijmeni.Size = new System.Drawing.Size(180, 20);
            this.txtPrijmeni.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uzivatelsBindingSource, "emial", true));
            this.txtEmail.Location = new System.Drawing.Point(114, 172);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(pcb_develModel.role);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(453, 379);
            this.xtraTabControl1.TabIndex = 16;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lblPodpis);
            this.xtraTabPage1.Controls.Add(this.txtPodpis);
            this.xtraTabPage1.Controls.Add(this.lblHesloKontrola);
            this.xtraTabPage1.Controls.Add(this.txtHesloKontrola);
            this.xtraTabPage1.Controls.Add(this.cmbRole);
            this.xtraTabPage1.Controls.Add(this.lblEmail);
            this.xtraTabPage1.Controls.Add(this.lblPrijmeni);
            this.xtraTabPage1.Controls.Add(this.lblJmeno);
            this.xtraTabPage1.Controls.Add(this.lblRole);
            this.xtraTabPage1.Controls.Add(this.lblHeslo);
            this.xtraTabPage1.Controls.Add(this.lblosobniCislo);
            this.xtraTabPage1.Controls.Add(this.txtEmail);
            this.xtraTabPage1.Controls.Add(this.txtOsobniCislo);
            this.xtraTabPage1.Controls.Add(this.txtJmeno);
            this.xtraTabPage1.Controls.Add(this.txtPrijmeni);
            this.xtraTabPage1.Controls.Add(this.txtHeslo);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(447, 351);
            this.xtraTabPage1.Text = "Obecné";
            // 
            // lblHesloKontrola
            // 
            this.lblHesloKontrola.Location = new System.Drawing.Point(27, 66);
            this.lblHesloKontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblHesloKontrola.Name = "lblHesloKontrola";
            this.lblHesloKontrola.Size = new System.Drawing.Size(74, 18);
            this.lblHesloKontrola.TabIndex = 22;
            this.lblHesloKontrola.Text = "Kontrola hesla:";
            // 
            // txtHesloKontrola
            // 
            this.txtHesloKontrola.Location = new System.Drawing.Point(114, 64);
            this.txtHesloKontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHesloKontrola.Name = "txtHesloKontrola";
            this.txtHesloKontrola.Properties.PasswordChar = '#';
            this.txtHesloKontrola.Size = new System.Drawing.Size(180, 20);
            this.txtHesloKontrola.TabIndex = 21;
            // 
            // cmbRole
            // 
            this.cmbRole.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.uzivatelsBindingSource, "role_id", true));
            this.cmbRole.Location = new System.Drawing.Point(114, 88);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("jmeno", "", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbRole.Properties.DataSource = this.roleBindingSource;
            this.cmbRole.Properties.DisplayMember = "jmeno";
            this.cmbRole.Properties.NullText = "";
            this.cmbRole.Properties.ValueMember = "role_id";
            this.cmbRole.Size = new System.Drawing.Size(180, 20);
            this.cmbRole.TabIndex = 3;
            this.cmbRole.EditValueChanged += new System.EventHandler(this.cmbRole_EditValueChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(64, 175);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 17);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPrijmeni
            // 
            this.lblPrijmeni.Location = new System.Drawing.Point(56, 151);
            this.lblPrijmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPrijmeni.Name = "lblPrijmeni";
            this.lblPrijmeni.Size = new System.Drawing.Size(48, 15);
            this.lblPrijmeni.TabIndex = 19;
            this.lblPrijmeni.Text = "Příjmení:";
            // 
            // lblJmeno
            // 
            this.lblJmeno.Location = new System.Drawing.Point(62, 127);
            this.lblJmeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(46, 15);
            this.lblJmeno.TabIndex = 18;
            this.lblJmeno.Text = "Jméno:";
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(74, 91);
            this.lblRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 15);
            this.lblRole.TabIndex = 17;
            this.lblRole.Text = "Role:";
            // 
            // lblHeslo
            // 
            this.lblHeslo.Location = new System.Drawing.Point(69, 42);
            this.lblHeslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblHeslo.Name = "lblHeslo";
            this.lblHeslo.Size = new System.Drawing.Size(37, 15);
            this.lblHeslo.TabIndex = 16;
            this.lblHeslo.Text = "Heslo:";
            // 
            // lblosobniCislo
            // 
            this.lblosobniCislo.Location = new System.Drawing.Point(39, 19);
            this.lblosobniCislo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblosobniCislo.Name = "lblosobniCislo";
            this.lblosobniCislo.Size = new System.Drawing.Size(62, 19);
            this.lblosobniCislo.TabIndex = 15;
            this.lblosobniCislo.Text = "Osobní číslo:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.clbOddeleni);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(447, 351);
            this.xtraTabPage2.Text = "Patří do oddělení";
            // 
            // clbOddeleni
            // 
            this.clbOddeleni.CheckMember = "Vybrano";
            this.clbOddeleni.DataSource = this.oddeleniBindigSource;
            this.clbOddeleni.DisplayMember = "nazev";
            this.clbOddeleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbOddeleni.Location = new System.Drawing.Point(0, 0);
            this.clbOddeleni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbOddeleni.Name = "clbOddeleni";
            this.clbOddeleni.Size = new System.Drawing.Size(447, 351);
            this.clbOddeleni.TabIndex = 0;
            this.clbOddeleni.ValueMember = "oddeleni_id";
            // 
            // oddeleniBindigSource
            // 
            this.oddeleniBindigSource.DataSource = typeof(pcb_develModel.oddeleni);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gcPrava);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(447, 351);
            this.xtraTabPage3.Text = "Práva";
            // 
            // gcPrava
            // 
            this.gcPrava.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcPrava.DataSource = this.pravaBindingSource;
            this.gcPrava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrava.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPrava.Location = new System.Drawing.Point(0, 0);
            this.gcPrava.MainView = this.gridView1;
            this.gcPrava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPrava.Name = "gcPrava";
            this.gcPrava.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcPrava.Size = new System.Drawing.Size(447, 351);
            this.gcPrava.TabIndex = 0;
            this.gcPrava.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pravaBindingSource
            // 
            this.pravaBindingSource.DataSource = typeof(pcb_develModel.prava_uzivatel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnazev,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gcPrava;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnazev
            // 
            this.colnazev.Caption = "Právo";
            this.colnazev.FieldName = "prava.nazev";
            this.colnazev.Name = "colnazev";
            this.colnazev.OptionsColumn.AllowEdit = false;
            this.colnazev.Visible = true;
            this.colnazev.VisibleIndex = 0;
            this.colnazev.Width = 198;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Hodnota";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn1.FieldName = "prava_hodnota_id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 166;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "nazev")});
            this.repositoryItemLookUpEdit1.DataSource = this.pravahodnotaBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "nazev";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "prava_hodnota_id";
            // 
            // pravahodnotaBindingSource
            // 
            this.pravahodnotaBindingSource.DataSource = typeof(pcb_develModel.prava_hodnota);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Role";
            this.gridColumn2.FieldName = "role_prava_hodnota.nazev";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 2);
            this.label1.TabIndex = 82;
            // 
            // txtPodpis
            // 
            this.txtPodpis.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.uzivatelsBindingSource, "podpis", true));
            this.txtPodpis.Location = new System.Drawing.Point(114, 207);
            this.txtPodpis.Name = "txtPodpis";
            this.txtPodpis.Size = new System.Drawing.Size(180, 20);
            this.txtPodpis.TabIndex = 23;
            // 
            // lblPodpis
            // 
            this.lblPodpis.AutoSize = true;
            this.lblPodpis.Location = new System.Drawing.Point(59, 210);
            this.lblPodpis.Name = "lblPodpis";
            this.lblPodpis.Size = new System.Drawing.Size(42, 13);
            this.lblPodpis.TabIndex = 24;
            this.lblPodpis.Text = "Podpis:";
            // 
            // frmUzivatelDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUzivatelDetail";
            this.Text = "Uživatel";
            ((System.ComponentModel.ISupportInitialize)(this.txtOsobniCislo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzivatelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeslo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmeno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrijmeni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesloKontrola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbOddeleni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddeleniBindigSource)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravahodnotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPodpis.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uzivatelsBindingSource;
        private DevExpress.XtraEditors.TextEdit txtOsobniCislo;
        private DevExpress.XtraEditors.TextEdit txtHeslo;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.TextEdit txtJmeno;
        private DevExpress.XtraEditors.TextEdit txtPrijmeni;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gcPrava;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnazev;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.CheckedListBoxControl clbOddeleni;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource oddeleniBindigSource;
        private System.Windows.Forms.BindingSource pravaBindingSource;
        private System.Windows.Forms.BindingSource pravahodnotaBindingSource;
        private Gui.RequiredLabel lblEmail;
        private Gui.RequiredLabel lblPrijmeni;
        private Gui.RequiredLabel lblJmeno;
        private Gui.RequiredLabel lblRole;
        private Gui.RequiredLabel lblHeslo;
        private Gui.RequiredLabel lblosobniCislo;
        private PCB.Gui.PCBLookUpEdit cmbRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label1;
        private Gui.RequiredLabel lblHesloKontrola;
        private DevExpress.XtraEditors.TextEdit txtHesloKontrola;
        private System.Windows.Forms.Label lblPodpis;
        private DevExpress.XtraEditors.TextEdit txtPodpis;
    }
}