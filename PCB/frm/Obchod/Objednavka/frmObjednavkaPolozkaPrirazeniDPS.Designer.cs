namespace PCB
{
    partial class frmPrirazeniDPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrirazeniDPS));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gcSeznam = new DevExpress.XtraGrid.GridControl();
            this.nazevDPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNazev = new DevExpress.XtraEditors.TextEdit();
            this.lblNazev = new DevExpress.XtraEditors.LabelControl();
            this.btnZobrazit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazevDPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Controls.Add(this.txtNazev);
            this.panelControl1.Controls.Add(this.lblNazev);
            this.panelControl1.Controls.Add(this.btnZobrazit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(759, 42);
            this.panelControl1.TabIndex = 271;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 2);
            this.label1.TabIndex = 82;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcSeznam;
            this.searchControl1.Location = new System.Drawing.Point(12, 12);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcSeznam;
            this.searchControl1.Size = new System.Drawing.Size(243, 20);
            this.searchControl1.TabIndex = 7;
            // 
            // gcSeznam
            // 
            this.gcSeznam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcSeznam.DataSource = this.nazevDPSBindingSource;
            this.gcSeznam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSeznam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Location = new System.Drawing.Point(0, 42);
            this.gcSeznam.MainView = this.gridView1;
            this.gcSeznam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Name = "gcSeznam";
            this.gcSeznam.Size = new System.Drawing.Size(759, 407);
            this.gcSeznam.TabIndex = 272;
            this.gcSeznam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcSeznam.DoubleClick += new System.EventHandler(this.gcSeznam_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gcSeznam;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Odepsal";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Width = 113;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "DPS";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Width = 395;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Objednávkový název";
            this.gridColumn1.FieldName = "obj_nazev_dps";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Název - tech. dokumentace";
            this.gridColumn2.FieldName = "nazev_dps";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Majitel - tech. dokumentace";
            this.gridColumn3.FieldName = "majitel";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // txtNazev
            // 
            this.txtNazev.Location = new System.Drawing.Point(422, 12);
            this.txtNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(243, 20);
            this.txtNazev.TabIndex = 6;
            this.txtNazev.Visible = false;
            // 
            // lblNazev
            // 
            this.lblNazev.Location = new System.Drawing.Point(383, 15);
            this.lblNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(34, 13);
            this.lblNazev.TabIndex = 5;
            this.lblNazev.Text = "Název:";
            this.lblNazev.Visible = false;
            // 
            // btnZobrazit
            // 
            this.btnZobrazit.Image = ((System.Drawing.Image)(resources.GetObject("btnZobrazit.Image")));
            this.btnZobrazit.Location = new System.Drawing.Point(12, 52);
            this.btnZobrazit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZobrazit.Name = "btnZobrazit";
            this.btnZobrazit.Size = new System.Drawing.Size(86, 23);
            this.btnZobrazit.TabIndex = 4;
            this.btnZobrazit.TabStop = false;
            this.btnZobrazit.Text = "Vyhledat";
            this.btnZobrazit.Visible = false;
            this.btnZobrazit.Click += new System.EventHandler(this.btnZobrazit_Click);
            // 
            // frmPrirazeniDPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 449);
            this.Controls.Add(this.gcSeznam);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmPrirazeniDPS";
            this.Text = "Přiřazení DPS";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazevDPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNazev;
        private DevExpress.XtraEditors.LabelControl lblNazev;
        private DevExpress.XtraEditors.SimpleButton btnZobrazit;
        private DevExpress.XtraGrid.GridControl gcSeznam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.BindingSource nazevDPSBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Label label1;
    }
}