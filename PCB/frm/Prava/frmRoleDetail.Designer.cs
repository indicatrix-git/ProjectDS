namespace PCB
{
    partial class frmRoleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleDetail));
            this.txtNazev = new DevExpress.XtraEditors.TextEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNazev = new PCB.Gui.RequiredLabel();
            this.gcSeznam = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprava = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprava_hodnota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.hodnotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodnotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazev
            // 
            this.txtNazev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleBindingSource, "jmeno", true));
            this.txtNazev.Location = new System.Drawing.Point(69, 14);
            this.txtNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(274, 22);
            this.txtNazev.TabIndex = 0;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(pcb_develModel.role);
            // 
            // pravaBindingSource
            // 
            this.pravaBindingSource.DataSource = typeof(pcb_develModel.prava_role);
            // 
            // lblNazev
            // 
            this.lblNazev.Location = new System.Drawing.Point(16, 15);
            this.lblNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(49, 22);
            this.lblNazev.TabIndex = 1;
            this.lblNazev.Text = "Název:";
            // 
            // gcSeznam
            // 
            this.gcSeznam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSeznam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcSeznam.DataSource = this.pravaBindingSource;
            this.gcSeznam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Location = new System.Drawing.Point(3, 55);
            this.gcSeznam.MainView = this.gridView1;
            this.gcSeznam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Name = "gcSeznam";
            this.gcSeznam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcSeznam.Size = new System.Drawing.Size(604, 402);
            this.gcSeznam.TabIndex = 2;
            this.gcSeznam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprava,
            this.colprava_hodnota});
            this.gridView1.GridControl = this.gcSeznam;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colprava
            // 
            this.colprava.Caption = "Práva";
            this.colprava.FieldName = "prava.nazev";
            this.colprava.Name = "colprava";
            this.colprava.OptionsColumn.AllowEdit = false;
            this.colprava.Visible = true;
            this.colprava.VisibleIndex = 0;
            // 
            // colprava_hodnota
            // 
            this.colprava_hodnota.Caption = "Hodnota";
            this.colprava_hodnota.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colprava_hodnota.FieldName = "prava_hodnota_id";
            this.colprava_hodnota.Name = "colprava_hodnota";
            this.colprava_hodnota.Visible = true;
            this.colprava_hodnota.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.hodnotaBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "nazev";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "prava_hodnota_id";
            // 
            // hodnotaBindingSource
            // 
            this.hodnotaBindingSource.DataSource = typeof(pcb_develModel.prava_hodnota);
            // 
            // btnStorno
            // 
            this.btnStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(500, 487);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 7;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(394, 487);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 28);
            this.btnUlozit.TabIndex = 6;
            this.btnUlozit.TabStop = false;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 2);
            this.label1.TabIndex = 82;
            // 
            // frmRoleDetail
            // 
            this.AcceptButton = this.btnUlozit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStorno;
            this.ClientSize = new System.Drawing.Size(612, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.gcSeznam);
            this.Controls.Add(this.lblNazev);
            this.Controls.Add(this.txtNazev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRoleDetail";
            this.Text = "Role";
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodnotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNazev;
        private Gui.RequiredLabel lblNazev;
        private DevExpress.XtraGrid.GridControl gcSeznam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource pravaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colprava;
        private DevExpress.XtraGrid.Columns.GridColumn colprava_hodnota;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource hodnotaBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private System.Windows.Forms.Label label1;
    }
}