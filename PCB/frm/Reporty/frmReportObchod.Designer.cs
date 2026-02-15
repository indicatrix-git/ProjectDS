namespace PCB.frm.Reporty
{
    partial class frmReportObchod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportObchod));
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabNabidky = new DevExpress.XtraTab.XtraTabPage();
            this.grdNabidky = new DevExpress.XtraGrid.GridControl();
            this.grvNabidky = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNabZakaznik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabPocetNabidek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabPocetUspesnych = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNabPocetNeuspesnych = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUspesnostProgress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBarUspesnost = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.pnlFilterNabidky = new DevExpress.XtraEditors.PanelControl();
            this.btnZrusitFiltrNabidky = new DevExpress.XtraEditors.SimpleButton();
            this.grpObdobi = new System.Windows.Forms.GroupBox();
            this.lblObdobiDo = new System.Windows.Forms.Label();
            this.lblObdobiOd = new System.Windows.Forms.Label();
            this.dtNabidkyDo = new DevExpress.XtraEditors.DateEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnExportXLS = new DevExpress.XtraBars.BarButtonItem();
            this.btnObnovit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dtNabidkyOd = new DevExpress.XtraEditors.DateEdit();
            this.btnNabidkyHledat = new DevExpress.XtraEditors.SimpleButton();
            this.tabObjednavky = new DevExpress.XtraTab.XtraTabPage();
            this.grdObjednavky = new DevExpress.XtraGrid.GridControl();
            this.grvObjednavky = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colObjZakaznik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjNazevDPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjPocetKs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjTechnologPlusVyrobniPridavek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjTerminVyroby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjTerminExpedice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjDruhTerminu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjTypDesky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjCisloPruvodky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjExpedice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlFilterObjednavky = new DevExpress.XtraEditors.PanelControl();
            this.btnZrusitFiltrObjednavky = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtObjednavkyDo = new DevExpress.XtraEditors.DateEdit();
            this.dtObjednavkyOd = new DevExpress.XtraEditors.DateEdit();
            this.btnObjednavkyHledat = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabNabidky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNabidky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNabidky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBarUspesnost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterNabidky)).BeginInit();
            this.pnlFilterNabidky.SuspendLayout();
            this.grpObdobi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyOd.Properties)).BeginInit();
            this.tabObjednavky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObjednavky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvObjednavky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterObjednavky)).BeginInit();
            this.pnlFilterObjednavky.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyOd.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabControl.Appearance.Options.UseBackColor = true;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabObjednavky;
            this.tabControl.Size = new System.Drawing.Size(1140, 461);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabObjednavky,
            this.tabNabidky});
            // 
            // tabNabidky
            // 
            this.tabNabidky.Controls.Add(this.grdNabidky);
            this.tabNabidky.Controls.Add(this.pnlFilterNabidky);
            this.tabNabidky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNabidky.Name = "tabNabidky";
            this.tabNabidky.Size = new System.Drawing.Size(1134, 433);
            this.tabNabidky.Text = "Nabídky";
            // 
            // grdNabidky
            // 
            this.grdNabidky.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdNabidky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNabidky.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdNabidky.Location = new System.Drawing.Point(0, 120);
            this.grdNabidky.MainView = this.grvNabidky;
            this.grdNabidky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdNabidky.Name = "grdNabidky";
            this.grdNabidky.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBarUspesnost});
            this.grdNabidky.Size = new System.Drawing.Size(1134, 313);
            this.grdNabidky.TabIndex = 0;
            this.grdNabidky.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNabidky});
            // 
            // grvNabidky
            // 
            this.grvNabidky.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNabZakaznik,
            this.colNabPocetNabidek,
            this.colNabPocetUspesnych,
            this.colNabPocetNeuspesnych,
            this.colUspesnostProgress});
            this.grvNabidky.GridControl = this.grdNabidky;
            this.grvNabidky.Name = "grvNabidky";
            this.grvNabidky.OptionsView.ColumnAutoWidth = false;
            this.grvNabidky.OptionsView.ShowGroupPanel = false;
            // 
            // colNabZakaznik
            // 
            this.colNabZakaznik.Caption = "Zákazník";
            this.colNabZakaznik.FieldName = "Zakaznik";
            this.colNabZakaznik.Name = "colNabZakaznik";
            this.colNabZakaznik.OptionsColumn.AllowEdit = false;
            this.colNabZakaznik.Visible = true;
            this.colNabZakaznik.VisibleIndex = 0;
            this.colNabZakaznik.Width = 200;
            // 
            // colNabPocetNabidek
            // 
            this.colNabPocetNabidek.Caption = "Počet nabídek";
            this.colNabPocetNabidek.DisplayFormat.FormatString = "N0";
            this.colNabPocetNabidek.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNabPocetNabidek.FieldName = "PocetNabidek";
            this.colNabPocetNabidek.Name = "colNabPocetNabidek";
            this.colNabPocetNabidek.OptionsColumn.AllowEdit = false;
            this.colNabPocetNabidek.Visible = true;
            this.colNabPocetNabidek.VisibleIndex = 1;
            this.colNabPocetNabidek.Width = 150;
            // 
            // colNabPocetUspesnych
            // 
            this.colNabPocetUspesnych.Caption = "Úspěšných";
            this.colNabPocetUspesnych.DisplayFormat.FormatString = "N0";
            this.colNabPocetUspesnych.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNabPocetUspesnych.FieldName = "PocetUspesnychNabidek";
            this.colNabPocetUspesnych.Name = "colNabPocetUspesnych";
            this.colNabPocetUspesnych.OptionsColumn.AllowEdit = false;
            this.colNabPocetUspesnych.Visible = true;
            this.colNabPocetUspesnych.VisibleIndex = 2;
            this.colNabPocetUspesnych.Width = 110;
            // 
            // colNabPocetNeuspesnych
            // 
            this.colNabPocetNeuspesnych.Caption = "Neúspěšných";
            this.colNabPocetNeuspesnych.DisplayFormat.FormatString = "N0";
            this.colNabPocetNeuspesnych.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNabPocetNeuspesnych.FieldName = "PocetNeuspesnychNabidek";
            this.colNabPocetNeuspesnych.Name = "colNabPocetNeuspesnych";
            this.colNabPocetNeuspesnych.OptionsColumn.AllowEdit = false;
            this.colNabPocetNeuspesnych.Visible = true;
            this.colNabPocetNeuspesnych.VisibleIndex = 3;
            this.colNabPocetNeuspesnych.Width = 110;
            // 
            // colUspesnostProgress
            // 
            this.colUspesnostProgress.Caption = "Úspěšnost";
            this.colUspesnostProgress.ColumnEdit = this.repositoryItemProgressBarUspesnost;
            this.colUspesnostProgress.FieldName = "UspesnostForProgress";
            this.colUspesnostProgress.Name = "colUspesnostProgress";
            this.colUspesnostProgress.OptionsColumn.AllowEdit = false;
            this.colUspesnostProgress.Visible = true;
            this.colUspesnostProgress.VisibleIndex = 4;
            this.colUspesnostProgress.Width = 110;
            // 
            // repositoryItemProgressBarUspesnost
            // 
            this.repositoryItemProgressBarUspesnost.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemProgressBarUspesnost.Name = "repositoryItemProgressBarUspesnost";
            this.repositoryItemProgressBarUspesnost.ShowTitle = true;
            this.repositoryItemProgressBarUspesnost.Step = 1;
            // 
            // pnlFilterNabidky
            // 
            this.pnlFilterNabidky.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilterNabidky.Appearance.Options.UseBackColor = true;
            this.pnlFilterNabidky.Controls.Add(this.btnZrusitFiltrNabidky);
            this.pnlFilterNabidky.Controls.Add(this.grpObdobi);
            this.pnlFilterNabidky.Controls.Add(this.btnNabidkyHledat);
            this.pnlFilterNabidky.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterNabidky.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterNabidky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilterNabidky.Name = "pnlFilterNabidky";
            this.pnlFilterNabidky.Size = new System.Drawing.Size(1134, 120);
            this.pnlFilterNabidky.TabIndex = 1;
            // 
            // btnZrusitFiltrNabidky
            // 
            this.btnZrusitFiltrNabidky.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltrNabidky.Image")));
            this.btnZrusitFiltrNabidky.Location = new System.Drawing.Point(111, 91);
            this.btnZrusitFiltrNabidky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltrNabidky.Name = "btnZrusitFiltrNabidky";
            this.btnZrusitFiltrNabidky.Size = new System.Drawing.Size(100, 23);
            this.btnZrusitFiltrNabidky.TabIndex = 93;
            this.btnZrusitFiltrNabidky.TabStop = false;
            this.btnZrusitFiltrNabidky.Text = "Zrušit filtr";
            this.btnZrusitFiltrNabidky.Click += new System.EventHandler(this.btnZrusitFiltr_Click);
            // 
            // grpObdobi
            // 
            this.grpObdobi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpObdobi.BackColor = System.Drawing.Color.Transparent;
            this.grpObdobi.Controls.Add(this.lblObdobiDo);
            this.grpObdobi.Controls.Add(this.lblObdobiOd);
            this.grpObdobi.Controls.Add(this.dtNabidkyDo);
            this.grpObdobi.Controls.Add(this.dtNabidkyOd);
            this.grpObdobi.Location = new System.Drawing.Point(5, 5);
            this.grpObdobi.Name = "grpObdobi";
            this.grpObdobi.Size = new System.Drawing.Size(1122, 81);
            this.grpObdobi.TabIndex = 91;
            this.grpObdobi.TabStop = false;
            this.grpObdobi.Text = "Období";
            // 
            // lblObdobiDo
            // 
            this.lblObdobiDo.AutoSize = true;
            this.lblObdobiDo.Location = new System.Drawing.Point(8, 49);
            this.lblObdobiDo.Name = "lblObdobiDo";
            this.lblObdobiDo.Size = new System.Drawing.Size(57, 13);
            this.lblObdobiDo.TabIndex = 89;
            this.lblObdobiDo.Text = "Datum do:";
            // 
            // lblObdobiOd
            // 
            this.lblObdobiOd.AutoSize = true;
            this.lblObdobiOd.Location = new System.Drawing.Point(8, 23);
            this.lblObdobiOd.Name = "lblObdobiOd";
            this.lblObdobiOd.Size = new System.Drawing.Size(57, 13);
            this.lblObdobiOd.TabIndex = 88;
            this.lblObdobiOd.Text = "Datum od:";
            // 
            // dtNabidkyDo
            // 
            this.dtNabidkyDo.EditValue = null;
            this.dtNabidkyDo.Location = new System.Drawing.Point(71, 46);
            this.dtNabidkyDo.MenuManager = this.ribbonControl1;
            this.dtNabidkyDo.Name = "dtNabidkyDo";
            this.dtNabidkyDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNabidkyDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNabidkyDo.Size = new System.Drawing.Size(160, 20);
            this.dtNabidkyDo.TabIndex = 87;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnExportXLS,
            this.btnObnovit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1140, 96);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnExportXLS
            // 
            this.btnExportXLS.Caption = "Export do XLS";
            this.btnExportXLS.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportXLS.Glyph")));
            this.btnExportXLS.Id = 1;
            this.btnExportXLS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportXLS.LargeGlyph")));
            this.btnExportXLS.Name = "btnExportXLS";
            this.btnExportXLS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportXLS_ItemClick);
            // 
            // btnObnovit
            // 
            this.btnObnovit.Caption = "Obnovit seznam";
            this.btnObnovit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.Glyph")));
            this.btnObnovit.Id = 2;
            this.btnObnovit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.LargeGlyph")));
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObnovit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpMain});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpMain
            // 
            this.rpMain.ItemLinks.Add(this.btnExportXLS);
            this.rpMain.ItemLinks.Add(this.btnObnovit);
            this.rpMain.Name = "rpMain";
            // 
            // dtNabidkyOd
            // 
            this.dtNabidkyOd.EditValue = null;
            this.dtNabidkyOd.Location = new System.Drawing.Point(71, 20);
            this.dtNabidkyOd.MenuManager = this.ribbonControl1;
            this.dtNabidkyOd.Name = "dtNabidkyOd";
            this.dtNabidkyOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNabidkyOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNabidkyOd.Size = new System.Drawing.Size(160, 20);
            this.dtNabidkyOd.TabIndex = 86;
            // 
            // btnNabidkyHledat
            // 
            this.btnNabidkyHledat.Image = ((System.Drawing.Image)(resources.GetObject("btnNabidkyHledat.Image")));
            this.btnNabidkyHledat.Location = new System.Drawing.Point(5, 91);
            this.btnNabidkyHledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNabidkyHledat.Name = "btnNabidkyHledat";
            this.btnNabidkyHledat.Size = new System.Drawing.Size(100, 23);
            this.btnNabidkyHledat.TabIndex = 4;
            this.btnNabidkyHledat.Text = "Vyhledat";
            this.btnNabidkyHledat.Click += new System.EventHandler(this.btnHledat_Click);
            // 
            // tabObjednavky
            // 
            this.tabObjednavky.Controls.Add(this.grdObjednavky);
            this.tabObjednavky.Controls.Add(this.pnlFilterObjednavky);
            this.tabObjednavky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabObjednavky.Name = "tabObjednavky";
            this.tabObjednavky.Size = new System.Drawing.Size(1134, 433);
            this.tabObjednavky.Text = "Objednávky";
            // 
            // grdObjednavky
            // 
            this.grdObjednavky.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdObjednavky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdObjednavky.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdObjednavky.Location = new System.Drawing.Point(0, 120);
            this.grdObjednavky.MainView = this.grvObjednavky;
            this.grdObjednavky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdObjednavky.Name = "grdObjednavky";
            this.grdObjednavky.Size = new System.Drawing.Size(1134, 313);
            this.grdObjednavky.TabIndex = 2;
            this.grdObjednavky.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvObjednavky});
            // 
            // grvObjednavky
            // 
            this.grvObjednavky.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colObjZakaznik,
            this.colObjNazevDPS,
            this.colObjPocetKs,
            this.colObjTechnologPlusVyrobniPridavek,
            this.colObjTerminVyroby,
            this.colObjTerminExpedice,
            this.colObjDruhTerminu,
            this.colObjTypDesky,
            this.colObjCisloPruvodky,
            this.colObjExpedice});
            this.grvObjednavky.GridControl = this.grdObjednavky;
            this.grvObjednavky.Name = "grvObjednavky";
            this.grvObjednavky.OptionsView.ColumnAutoWidth = false;
            this.grvObjednavky.OptionsView.ShowGroupPanel = false;
            // 
            // colObjZakaznik
            // 
            this.colObjZakaznik.Caption = "Zákazník";
            this.colObjZakaznik.FieldName = "Zakaznik";
            this.colObjZakaznik.Name = "colObjZakaznik";
            this.colObjZakaznik.OptionsColumn.AllowEdit = false;
            this.colObjZakaznik.Visible = true;
            this.colObjZakaznik.VisibleIndex = 0;
            this.colObjZakaznik.Width = 200;
            // 
            // colObjNazevDPS
            // 
            this.colObjNazevDPS.Caption = "Název DPS";
            this.colObjNazevDPS.FieldName = "NazevDPS";
            this.colObjNazevDPS.Name = "colObjNazevDPS";
            this.colObjNazevDPS.OptionsColumn.AllowEdit = false;
            this.colObjNazevDPS.Visible = true;
            this.colObjNazevDPS.VisibleIndex = 1;
            this.colObjNazevDPS.Width = 150;
            // 
            // colObjPocetKs
            // 
            this.colObjPocetKs.Caption = "Počet ks";
            this.colObjPocetKs.FieldName = "PocekKs";
            this.colObjPocetKs.Name = "colObjPocetKs";
            this.colObjPocetKs.OptionsColumn.AllowEdit = false;
            this.colObjPocetKs.Visible = true;
            this.colObjPocetKs.VisibleIndex = 2;
            // 
            // colObjTechnologPlusVyrobniPridavek
            // 
            this.colObjTechnologPlusVyrobniPridavek.Caption = "Tech. + výrob. přídavek";
            this.colObjTechnologPlusVyrobniPridavek.FieldName = "TechnologPlusVyrobniPridavek";
            this.colObjTechnologPlusVyrobniPridavek.Name = "colObjTechnologPlusVyrobniPridavek";
            this.colObjTechnologPlusVyrobniPridavek.OptionsColumn.AllowEdit = false;
            this.colObjTechnologPlusVyrobniPridavek.Visible = true;
            this.colObjTechnologPlusVyrobniPridavek.VisibleIndex = 3;
            this.colObjTechnologPlusVyrobniPridavek.Width = 125;
            // 
            // colObjTerminVyroby
            // 
            this.colObjTerminVyroby.Caption = "Termín výroby";
            this.colObjTerminVyroby.FieldName = "TerminVyroby";
            this.colObjTerminVyroby.Name = "colObjTerminVyroby";
            this.colObjTerminVyroby.OptionsColumn.AllowEdit = false;
            this.colObjTerminVyroby.Visible = true;
            this.colObjTerminVyroby.VisibleIndex = 4;
            this.colObjTerminVyroby.Width = 100;
            // 
            // colObjTerminExpedice
            // 
            this.colObjTerminExpedice.Caption = "Termín expedice";
            this.colObjTerminExpedice.Name = "colObjTerminExpedice";
            this.colObjTerminExpedice.OptionsColumn.AllowEdit = false;
            this.colObjTerminExpedice.Visible = true;
            this.colObjTerminExpedice.VisibleIndex = 5;
            this.colObjTerminExpedice.Width = 100;
            // 
            // colObjDruhTerminu
            // 
            this.colObjDruhTerminu.Caption = "Druh termínu";
            this.colObjDruhTerminu.FieldName = "DruhTerminu";
            this.colObjDruhTerminu.Name = "colObjDruhTerminu";
            this.colObjDruhTerminu.OptionsColumn.AllowEdit = false;
            this.colObjDruhTerminu.Visible = true;
            this.colObjDruhTerminu.VisibleIndex = 6;
            // 
            // colObjTypDesky
            // 
            this.colObjTypDesky.Caption = "Typ desky";
            this.colObjTypDesky.FieldName = "TypDesky";
            this.colObjTypDesky.Name = "colObjTypDesky";
            this.colObjTypDesky.OptionsColumn.AllowEdit = false;
            this.colObjTypDesky.Visible = true;
            this.colObjTypDesky.VisibleIndex = 7;
            this.colObjTypDesky.Width = 100;
            // 
            // colObjCisloPruvodky
            // 
            this.colObjCisloPruvodky.Caption = "Číslo průvodky";
            this.colObjCisloPruvodky.FieldName = "CisloPruvodky";
            this.colObjCisloPruvodky.Name = "colObjCisloPruvodky";
            this.colObjCisloPruvodky.OptionsColumn.AllowEdit = false;
            this.colObjCisloPruvodky.Visible = true;
            this.colObjCisloPruvodky.VisibleIndex = 8;
            this.colObjCisloPruvodky.Width = 125;
            // 
            // colObjExpedice
            // 
            this.colObjExpedice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colObjExpedice.Caption = "Expedice";
            this.colObjExpedice.FieldName = "Expedice";
            this.colObjExpedice.Name = "colObjExpedice";
            this.colObjExpedice.Visible = true;
            this.colObjExpedice.VisibleIndex = 9;
            this.colObjExpedice.Width = 100;
            // 
            // pnlFilterObjednavky
            // 
            this.pnlFilterObjednavky.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilterObjednavky.Appearance.Options.UseBackColor = true;
            this.pnlFilterObjednavky.Controls.Add(this.btnZrusitFiltrObjednavky);
            this.pnlFilterObjednavky.Controls.Add(this.groupBox1);
            this.pnlFilterObjednavky.Controls.Add(this.btnObjednavkyHledat);
            this.pnlFilterObjednavky.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterObjednavky.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterObjednavky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilterObjednavky.Name = "pnlFilterObjednavky";
            this.pnlFilterObjednavky.Size = new System.Drawing.Size(1134, 120);
            this.pnlFilterObjednavky.TabIndex = 3;
            // 
            // btnZrusitFiltrObjednavky
            // 
            this.btnZrusitFiltrObjednavky.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltrObjednavky.Image")));
            this.btnZrusitFiltrObjednavky.Location = new System.Drawing.Point(111, 91);
            this.btnZrusitFiltrObjednavky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltrObjednavky.Name = "btnZrusitFiltrObjednavky";
            this.btnZrusitFiltrObjednavky.Size = new System.Drawing.Size(100, 23);
            this.btnZrusitFiltrObjednavky.TabIndex = 94;
            this.btnZrusitFiltrObjednavky.TabStop = false;
            this.btnZrusitFiltrObjednavky.Text = "Zrušit filtr";
            this.btnZrusitFiltrObjednavky.Click += new System.EventHandler(this.btnZrusitFiltr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtObjednavkyDo);
            this.groupBox1.Controls.Add(this.dtObjednavkyOd);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 81);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Období";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Datum do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Datum od:";
            // 
            // dtObjednavkyDo
            // 
            this.dtObjednavkyDo.EditValue = null;
            this.dtObjednavkyDo.Location = new System.Drawing.Point(71, 46);
            this.dtObjednavkyDo.MenuManager = this.ribbonControl1;
            this.dtObjednavkyDo.Name = "dtObjednavkyDo";
            this.dtObjednavkyDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtObjednavkyDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtObjednavkyDo.Size = new System.Drawing.Size(160, 20);
            this.dtObjednavkyDo.TabIndex = 87;
            // 
            // dtObjednavkyOd
            // 
            this.dtObjednavkyOd.EditValue = null;
            this.dtObjednavkyOd.Location = new System.Drawing.Point(71, 20);
            this.dtObjednavkyOd.MenuManager = this.ribbonControl1;
            this.dtObjednavkyOd.Name = "dtObjednavkyOd";
            this.dtObjednavkyOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtObjednavkyOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtObjednavkyOd.Size = new System.Drawing.Size(160, 20);
            this.dtObjednavkyOd.TabIndex = 86;
            // 
            // btnObjednavkyHledat
            // 
            this.btnObjednavkyHledat.Image = ((System.Drawing.Image)(resources.GetObject("btnObjednavkyHledat.Image")));
            this.btnObjednavkyHledat.Location = new System.Drawing.Point(5, 91);
            this.btnObjednavkyHledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObjednavkyHledat.Name = "btnObjednavkyHledat";
            this.btnObjednavkyHledat.Size = new System.Drawing.Size(100, 23);
            this.btnObjednavkyHledat.TabIndex = 9;
            this.btnObjednavkyHledat.Text = "Vyhledat";
            this.btnObjednavkyHledat.Click += new System.EventHandler(this.btnHledat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 461);
            this.panel1.TabIndex = 1;
            // 
            // frmReportObchod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmReportObchod";
            this.Text = "Report obchod";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabNabidky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNabidky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNabidky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBarUspesnost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterNabidky)).EndInit();
            this.pnlFilterNabidky.ResumeLayout(false);
            this.grpObdobi.ResumeLayout(false);
            this.grpObdobi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNabidkyOd.Properties)).EndInit();
            this.tabObjednavky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdObjednavky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvObjednavky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterObjednavky)).EndInit();
            this.pnlFilterObjednavky.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObjednavkyOd.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabNabidky;
        private DevExpress.XtraTab.XtraTabPage tabObjednavky;
        private DevExpress.XtraGrid.GridControl grdNabidky;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNabidky;
        private DevExpress.XtraEditors.PanelControl pnlFilterNabidky;
        private DevExpress.XtraGrid.GridControl grdObjednavky;
        private DevExpress.XtraGrid.Views.Grid.GridView grvObjednavky;
        private DevExpress.XtraEditors.PanelControl pnlFilterObjednavky;
        private DevExpress.XtraEditors.SimpleButton btnNabidkyHledat;
        private DevExpress.XtraEditors.SimpleButton btnObjednavkyHledat;
        private DevExpress.XtraGrid.Columns.GridColumn colNabZakaznik;
        private DevExpress.XtraGrid.Columns.GridColumn colNabPocetNabidek;
        private DevExpress.XtraGrid.Columns.GridColumn colNabPocetUspesnych;
        private DevExpress.XtraGrid.Columns.GridColumn colNabPocetNeuspesnych;
        private DevExpress.XtraGrid.Columns.GridColumn colObjZakaznik;
        private DevExpress.XtraGrid.Columns.GridColumn colObjNazevDPS;
        private DevExpress.XtraGrid.Columns.GridColumn colObjPocetKs;
        private DevExpress.XtraGrid.Columns.GridColumn colUspesnostProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBarUspesnost;
        private DevExpress.XtraGrid.Columns.GridColumn colObjTechnologPlusVyrobniPridavek;
        private DevExpress.XtraGrid.Columns.GridColumn colObjTerminVyroby;
        private DevExpress.XtraGrid.Columns.GridColumn colObjTerminExpedice;
        private DevExpress.XtraGrid.Columns.GridColumn colObjDruhTerminu;
        private DevExpress.XtraGrid.Columns.GridColumn colObjTypDesky;
        private DevExpress.XtraGrid.Columns.GridColumn colObjCisloPruvodky;
        private DevExpress.XtraGrid.Columns.GridColumn colObjExpedice;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnExportXLS;
        private DevExpress.XtraBars.BarButtonItem btnObnovit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpObdobi;
        private System.Windows.Forms.Label lblObdobiDo;
        private System.Windows.Forms.Label lblObdobiOd;
        private DevExpress.XtraEditors.DateEdit dtNabidkyDo;
        private DevExpress.XtraEditors.DateEdit dtNabidkyOd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dtObjednavkyDo;
        private DevExpress.XtraEditors.DateEdit dtObjednavkyOd;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltrNabidky;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltrObjednavky;
    }
}