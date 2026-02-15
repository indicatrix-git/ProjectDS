namespace PCB
{
    partial class frmPruvodkaDetail
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruvodkaDetail));
            this.gridControlPruvodka = new DevExpress.XtraGrid.GridControl();
            this.pruvodkaodepisovaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemNeshoda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpravyKs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpravaPanelKs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionNeshody = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActionNeshoda = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colActionOpravy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActionOprava = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblHotovo = new System.Windows.Forms.Label();
            this.lblCisloPruv = new System.Windows.Forms.Label();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblCisloPruvodky = new System.Windows.Forms.Label();
            this.btnObjednavka = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPruvodka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruvodkaodepisovaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActionNeshoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActionOprava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlPruvodka
            // 
            this.gridControlPruvodka.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlPruvodka.DataSource = this.pruvodkaodepisovaniBindingSource;
            this.gridControlPruvodka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPruvodka.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPruvodka.Location = new System.Drawing.Point(0, 48);
            this.gridControlPruvodka.MainView = this.gridView5;
            this.gridControlPruvodka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPruvodka.Name = "gridControlPruvodka";
            this.gridControlPruvodka.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnActionNeshoda,
            this.btnActionOprava});
            this.gridControlPruvodka.Size = new System.Drawing.Size(1352, 422);
            this.gridControlPruvodka.TabIndex = 241;
            this.gridControlPruvodka.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // pruvodkaodepisovaniBindingSource
            // 
            this.pruvodkaodepisovaniBindingSource.DataSource = typeof(pcb_develModel.pruvodka_odepisovani);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn21,
            this.gridColumn26,
            this.itemNeshoda,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colOpravyKs,
            this.colOpravaPanelKs,
            this.colActionNeshody,
            this.colActionOpravy});
            this.gridView5.GridControl = this.gridControlPruvodka;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView5_CustomRowCellEdit);
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Operace";
            this.gridColumn17.FieldName = "pruvodka_operace.nazev";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 295;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Poznámka z výroby";
            this.gridColumn21.FieldName = "poznamka";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 3;
            this.gridColumn21.Width = 266;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Datum odepsání";
            this.gridColumn26.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.gridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn26.FieldName = "d_odepsani";
            this.gridColumn26.MaxWidth = 110;
            this.gridColumn26.MinWidth = 110;
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 1;
            this.gridColumn26.Width = 110;
            // 
            // itemNeshoda
            // 
            this.itemNeshoda.Caption = "Neshoda";
            this.itemNeshoda.Name = "itemNeshoda";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Odepsal";
            this.gridColumn1.FieldName = "uzivatel.celeJmeno";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 136;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Neshody ks";
            this.gridColumn2.FieldName = "vadny_ks";
            this.gridColumn2.MaxWidth = 75;
            this.gridColumn2.MinWidth = 75;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Neshody panelů";
            this.gridColumn3.FieldName = "vadny_panelu_ks";
            this.gridColumn3.MaxWidth = 100;
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 100;
            // 
            // colOpravyKs
            // 
            this.colOpravyKs.Caption = "Opravy ks";
            this.colOpravyKs.FieldName = "oprav_ks";
            this.colOpravyKs.MaxWidth = 75;
            this.colOpravyKs.MinWidth = 75;
            this.colOpravyKs.Name = "colOpravyKs";
            this.colOpravyKs.OptionsColumn.AllowEdit = false;
            this.colOpravyKs.Visible = true;
            this.colOpravyKs.VisibleIndex = 6;
            // 
            // colOpravaPanelKs
            // 
            this.colOpravaPanelKs.Caption = "Opravy panelů";
            this.colOpravaPanelKs.FieldName = "oprav_panel_ks";
            this.colOpravaPanelKs.MaxWidth = 100;
            this.colOpravaPanelKs.MinWidth = 100;
            this.colOpravaPanelKs.Name = "colOpravaPanelKs";
            this.colOpravaPanelKs.OptionsColumn.AllowEdit = false;
            this.colOpravaPanelKs.Visible = true;
            this.colOpravaPanelKs.VisibleIndex = 7;
            this.colOpravaPanelKs.Width = 100;
            // 
            // colActionNeshody
            // 
            this.colActionNeshody.Caption = "Neshody";
            this.colActionNeshody.ColumnEdit = this.btnActionNeshoda;
            this.colActionNeshody.Name = "colActionNeshody";
            this.colActionNeshody.Visible = true;
            this.colActionNeshody.VisibleIndex = 8;
            // 
            // btnActionNeshoda
            // 
            this.btnActionNeshoda.AutoHeight = false;
            this.btnActionNeshoda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Neshoda", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnActionNeshoda.Name = "btnActionNeshoda";
            this.btnActionNeshoda.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnActionNeshoda.Click += new System.EventHandler(this.btnActionNeshoda_Click);
            // 
            // colActionOpravy
            // 
            this.colActionOpravy.Caption = "Opravy";
            this.colActionOpravy.ColumnEdit = this.btnActionOprava;
            this.colActionOpravy.Name = "colActionOpravy";
            this.colActionOpravy.Visible = true;
            this.colActionOpravy.VisibleIndex = 9;
            // 
            // btnActionOprava
            // 
            this.btnActionOprava.AutoHeight = false;
            this.btnActionOprava.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Oprava", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnActionOprava.Name = "btnActionOprava";
            this.btnActionOprava.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnActionOprava.Click += new System.EventHandler(this.btnActionOprava_Click);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Objednávka";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Filtr";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // lblHotovo
            // 
            this.lblHotovo.AutoSize = true;
            this.lblHotovo.Location = new System.Drawing.Point(240, 18);
            this.lblHotovo.Name = "lblHotovo";
            this.lblHotovo.Size = new System.Drawing.Size(46, 13);
            this.lblHotovo.TabIndex = 242;
            this.lblHotovo.Text = "Hotovo:";
            // 
            // lblCisloPruv
            // 
            this.lblCisloPruv.AutoSize = true;
            this.lblCisloPruv.Location = new System.Drawing.Point(10, 18);
            this.lblCisloPruv.Name = "lblCisloPruv";
            this.lblCisloPruv.Size = new System.Drawing.Size(77, 13);
            this.lblCisloPruv.TabIndex = 186;
            this.lblCisloPruv.Text = "Číslo průvodky";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.EditValue = "50";
            this.progressBarControl1.Location = new System.Drawing.Point(296, 15);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(299, 22);
            this.progressBarControl1.TabIndex = 247;
            // 
            // lblCisloPruvodky
            // 
            this.lblCisloPruvodky.AutoSize = true;
            this.lblCisloPruvodky.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCisloPruvodky.Location = new System.Drawing.Point(100, 18);
            this.lblCisloPruvodky.Name = "lblCisloPruvodky";
            this.lblCisloPruvodky.Size = new System.Drawing.Size(42, 13);
            this.lblCisloPruvodky.TabIndex = 245;
            this.lblCisloPruvodky.Text = "XXXXX";
            // 
            // btnObjednavka
            // 
            this.btnObjednavka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjednavka.Image = ((System.Drawing.Image)(resources.GetObject("btnObjednavka.Image")));
            this.btnObjednavka.Location = new System.Drawing.Point(1221, 9);
            this.btnObjednavka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObjednavka.Name = "btnObjednavka";
            this.btnObjednavka.Size = new System.Drawing.Size(119, 28);
            this.btnObjednavka.TabIndex = 248;
            this.btnObjednavka.Text = "Objednávka";
            this.btnObjednavka.Click += new System.EventHandler(this.btnObjednavka_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObjednavka);
            this.panel1.Controls.Add(this.lblCisloPruvodky);
            this.panel1.Controls.Add(this.progressBarControl1);
            this.panel1.Controls.Add(this.lblCisloPruv);
            this.panel1.Controls.Add(this.lblHotovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 48);
            this.panel1.TabIndex = 248;
            // 
            // frmPruvodkaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 470);
            this.Controls.Add(this.gridControlPruvodka);
            this.Controls.Add(this.panel1);
            this.Name = "frmPruvodkaDetail";
            this.Text = "Průvodka detail";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPruvodka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruvodkaodepisovaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActionNeshoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActionOprava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPruvodka;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn itemNeshoda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource pruvodkaodepisovaniBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label lblHotovo;
        private System.Windows.Forms.Label lblCisloPruv;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Label lblCisloPruvodky;
        private DevExpress.XtraEditors.SimpleButton btnObjednavka;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colOpravyKs;
        private DevExpress.XtraGrid.Columns.GridColumn colOpravaPanelKs;
        private DevExpress.XtraGrid.Columns.GridColumn colActionNeshody;
        private DevExpress.XtraGrid.Columns.GridColumn colActionOpravy;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActionNeshoda;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActionOprava;
    }
}