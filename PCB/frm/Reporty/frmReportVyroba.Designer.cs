namespace PCB.frm.Reporty
{
    partial class frmReportVyroba
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportVyroba));
            this.grvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.grdVyroba = new DevExpress.XtraGrid.GridControl();
            this.grvVyroba = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTerminExpedice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTerminVyroby = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTerminZadani = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOdberatel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNazevPs = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPocetObjednano = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPocetPridavekPocetPanelu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPocetZmetkuChybyKs = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCisloPruvodky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterFoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemChck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterLeptani = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterMaska = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand14 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterTaveni = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand17 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterZlatoCin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand15 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterTest = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterDrazka = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterFreza = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterOrgan = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterStrihani = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterLaminace = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand16 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterVrtani = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterChemickaLinka = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterGalvanickaLinka = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFilterMaskaBarevna = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCasFrezovaniMinuty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPocetJizdFrezy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.contextMenuFilter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnExportXLS = new DevExpress.XtraBars.BarButtonItem();
            this.btnObnovit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grpObdobi = new System.Windows.Forms.GroupBox();
            this.lblObdobiDo = new System.Windows.Forms.Label();
            this.lblObdobiOd = new System.Windows.Forms.Label();
            this.dtDo = new DevExpress.XtraEditors.DateEdit();
            this.dtOd = new DevExpress.XtraEditors.DateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZrusitFiltr = new DevExpress.XtraEditors.SimpleButton();
            this.btnHledat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVyroba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVyroba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChck)).BeginInit();
            this.contextMenuFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.grpObdobi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOd.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDetail
            // 
            this.grvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.grvDetail.GridControl = this.grdVyroba;
            this.grvDetail.Name = "grvDetail";
            this.grvDetail.OptionsCustomization.AllowFilter = false;
            this.grvDetail.OptionsCustomization.AllowGroup = false;
            this.grvDetail.OptionsCustomization.AllowRowSizing = true;
            this.grvDetail.OptionsCustomization.AllowSort = false;
            this.grvDetail.OptionsFilter.AllowFilterEditor = false;
            this.grvDetail.OptionsView.ShowColumnHeaders = false;
            this.grvDetail.OptionsView.ShowGroupPanel = false;
            this.grvDetail.OptionsView.ShowIndicator = false;
            this.grvDetail.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.grvDetail.RowHeight = 75;
            this.grvDetail.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.ColumnEdit = this.repositoryItemRichTextEdit1;
            this.gridColumn2.FieldName = "Info";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.ShowCaption = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1000;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // grdVyroba
            // 
            this.grdVyroba.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdVyroba.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grvDetail;
            gridLevelNode1.RelationName = "Level1";
            this.grdVyroba.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdVyroba.Location = new System.Drawing.Point(0, 193);
            this.grdVyroba.MainView = this.grvVyroba;
            this.grdVyroba.Name = "grdVyroba";
            this.grdVyroba.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChck,
            this.repositoryItemRichTextEdit1});
            this.grdVyroba.Size = new System.Drawing.Size(1667, 443);
            this.grdVyroba.TabIndex = 0;
            this.grdVyroba.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvVyroba,
            this.grvDetail});
            // 
            // grvVyroba
            // 
            this.grvVyroba.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand10,
            this.gridBand3,
            this.gridBand4,
            this.gridBand14,
            this.gridBand17,
            this.gridBand15,
            this.gridBand11,
            this.gridBand9,
            this.gridBand12,
            this.gridBand13,
            this.gridBand6,
            this.gridBand16,
            this.gridBand7,
            this.gridBand8,
            this.gridBand5,
            this.gridBand2});
            this.grvVyroba.ColumnPanelRowHeight = 40;
            this.grvVyroba.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colTerminExpedice,
            this.colTerminVyroby,
            this.colTerminZadani,
            this.colOdberatel,
            this.colNazevPs,
            this.colStatus,
            this.colPocetObjednano,
            this.colPocetPridavekPocetPanelu,
            this.colPocetZmetkuChybyKs,
            this.colCisloPruvodky,
            this.colFilterFoto,
            this.colFilterLeptani,
            this.colFilterMaska,
            this.colFilterTaveni,
            this.colFilterZlatoCin,
            this.colFilterTest,
            this.colFilterDrazka,
            this.colFilterFreza,
            this.colFilterOrgan,
            this.colFilterStrihani,
            this.colFilterVrtani,
            this.colFilterChemickaLinka,
            this.colFilterGalvanickaLinka,
            this.colFilterLaminace,
            this.colFilterMaskaBarevna,
            this.colCasFrezovaniMinuty,
            this.colPocetJizdFrezy});
            this.grvVyroba.GridControl = this.grdVyroba;
            this.grvVyroba.Name = "grvVyroba";
            this.grvVyroba.OptionsDetail.ShowDetailTabs = false;
            this.grvVyroba.OptionsView.ColumnAutoWidth = false;
            this.grvVyroba.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grvVyroba.OptionsView.ShowGroupPanel = false;
            this.grvVyroba.CustomDrawBandHeader += new DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventHandler(this.grvVyroba_CustomDrawBandHeader);
            this.grvVyroba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvVyroba_MouseDown);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colTerminExpedice);
            this.gridBand1.Columns.Add(this.colTerminVyroby);
            this.gridBand1.Columns.Add(this.colTerminZadani);
            this.gridBand1.Columns.Add(this.colOdberatel);
            this.gridBand1.Columns.Add(this.colNazevPs);
            this.gridBand1.Columns.Add(this.colStatus);
            this.gridBand1.Columns.Add(this.colPocetObjednano);
            this.gridBand1.Columns.Add(this.colPocetPridavekPocetPanelu);
            this.gridBand1.Columns.Add(this.colPocetZmetkuChybyKs);
            this.gridBand1.Columns.Add(this.colCisloPruvodky);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.RowCount = 5;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 958;
            // 
            // colTerminExpedice
            // 
            this.colTerminExpedice.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerminExpedice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTerminExpedice.Caption = "Termín expedice";
            this.colTerminExpedice.FieldName = "TerminExpedice";
            this.colTerminExpedice.Name = "colTerminExpedice";
            this.colTerminExpedice.OptionsColumn.AllowEdit = false;
            this.colTerminExpedice.Visible = true;
            this.colTerminExpedice.Width = 90;
            // 
            // colTerminVyroby
            // 
            this.colTerminVyroby.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerminVyroby.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTerminVyroby.Caption = "Termín výroby";
            this.colTerminVyroby.FieldName = "TerminVyroby";
            this.colTerminVyroby.Name = "colTerminVyroby";
            this.colTerminVyroby.OptionsColumn.AllowEdit = false;
            this.colTerminVyroby.Visible = true;
            this.colTerminVyroby.Width = 90;
            // 
            // colTerminZadani
            // 
            this.colTerminZadani.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerminZadani.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTerminZadani.Caption = "Termín zadání";
            this.colTerminZadani.FieldName = "TerminZadani";
            this.colTerminZadani.Name = "colTerminZadani";
            this.colTerminZadani.OptionsColumn.AllowEdit = false;
            this.colTerminZadani.Visible = true;
            this.colTerminZadani.Width = 90;
            // 
            // colOdberatel
            // 
            this.colOdberatel.AppearanceHeader.Options.UseTextOptions = true;
            this.colOdberatel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOdberatel.Caption = "Odběratel";
            this.colOdberatel.FieldName = "Odberatel";
            this.colOdberatel.Name = "colOdberatel";
            this.colOdberatel.OptionsColumn.AllowEdit = false;
            this.colOdberatel.Visible = true;
            this.colOdberatel.Width = 125;
            // 
            // colNazevPs
            // 
            this.colNazevPs.AppearanceHeader.Options.UseTextOptions = true;
            this.colNazevPs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNazevPs.Caption = "Název PS";
            this.colNazevPs.FieldName = "NazevPS";
            this.colNazevPs.Name = "colNazevPs";
            this.colNazevPs.OptionsColumn.AllowEdit = false;
            this.colNazevPs.Visible = true;
            this.colNazevPs.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.Width = 115;
            // 
            // colPocetObjednano
            // 
            this.colPocetObjednano.AppearanceHeader.Options.UseTextOptions = true;
            this.colPocetObjednano.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPocetObjednano.Caption = "Počet objednáno";
            this.colPocetObjednano.FieldName = "PocetObjednano";
            this.colPocetObjednano.Name = "colPocetObjednano";
            this.colPocetObjednano.OptionsColumn.AllowEdit = false;
            this.colPocetObjednano.Visible = true;
            // 
            // colPocetPridavekPocetPanelu
            // 
            this.colPocetPridavekPocetPanelu.AppearanceHeader.Options.UseTextOptions = true;
            this.colPocetPridavekPocetPanelu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPocetPridavekPocetPanelu.Caption = "Počet přídavek / Počet panelů";
            this.colPocetPridavekPocetPanelu.FieldName = "PocetPridavekPocetPanelu";
            this.colPocetPridavekPocetPanelu.Name = "colPocetPridavekPocetPanelu";
            this.colPocetPridavekPocetPanelu.OptionsColumn.AllowEdit = false;
            this.colPocetPridavekPocetPanelu.Visible = true;
            this.colPocetPridavekPocetPanelu.Width = 90;
            // 
            // colPocetZmetkuChybyKs
            // 
            this.colPocetZmetkuChybyKs.AppearanceHeader.Options.UseTextOptions = true;
            this.colPocetZmetkuChybyKs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPocetZmetkuChybyKs.Caption = "Počet zmetků / chybí ks";
            this.colPocetZmetkuChybyKs.FieldName = "PocetZmetkuChybyKs";
            this.colPocetZmetkuChybyKs.Name = "colPocetZmetkuChybyKs";
            this.colPocetZmetkuChybyKs.OptionsColumn.AllowEdit = false;
            this.colPocetZmetkuChybyKs.Visible = true;
            this.colPocetZmetkuChybyKs.Width = 83;
            // 
            // colCisloPruvodky
            // 
            this.colCisloPruvodky.AppearanceHeader.Options.UseTextOptions = true;
            this.colCisloPruvodky.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCisloPruvodky.Caption = "Číslo průvodky";
            this.colCisloPruvodky.FieldName = "CisloPruvodky";
            this.colCisloPruvodky.Name = "colCisloPruvodky";
            this.colCisloPruvodky.OptionsColumn.AllowEdit = false;
            this.colCisloPruvodky.Visible = true;
            // 
            // gridBand10
            // 
            this.gridBand10.Caption = "gridBand10";
            this.gridBand10.Columns.Add(this.colFilterFoto);
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.VisibleIndex = 1;
            this.gridBand10.Width = 40;
            // 
            // colFilterFoto
            // 
            this.colFilterFoto.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("colFilterFoto.AppearanceHeader.Image")));
            this.colFilterFoto.AppearanceHeader.Options.UseImage = true;
            this.colFilterFoto.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterFoto.Caption = "Foto";
            this.colFilterFoto.ColumnEdit = this.repositoryItemChck;
            this.colFilterFoto.FieldName = "IsFoto";
            this.colFilterFoto.Image = ((System.Drawing.Image)(resources.GetObject("colFilterFoto.Image")));
            this.colFilterFoto.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colFilterFoto.ImageIndex = 0;
            this.colFilterFoto.Name = "colFilterFoto";
            this.colFilterFoto.OptionsColumn.ShowCaption = false;
            this.colFilterFoto.OptionsFilter.AllowFilter = false;
            this.colFilterFoto.Tag = "Foto";
            this.colFilterFoto.Visible = true;
            this.colFilterFoto.Width = 40;
            // 
            // repositoryItemChck
            // 
            this.repositoryItemChck.AutoHeight = false;
            this.repositoryItemChck.Name = "repositoryItemChck";
            this.repositoryItemChck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "gridBand3 sdafadsfasdf asdfasdfadsfd asdfasdfasdfsda";
            this.gridBand3.Columns.Add(this.colFilterLeptani);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 48;
            // 
            // colFilterLeptani
            // 
            this.colFilterLeptani.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterLeptani.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterLeptani.Caption = "Leptání";
            this.colFilterLeptani.ColumnEdit = this.repositoryItemChck;
            this.colFilterLeptani.FieldName = "IsLeptani";
            this.colFilterLeptani.Name = "colFilterLeptani";
            this.colFilterLeptani.OptionsFilter.AllowFilter = false;
            this.colFilterLeptani.Tag = "Leptání";
            this.colFilterLeptani.Visible = true;
            this.colFilterLeptani.Width = 48;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "gridBand4 a";
            this.gridBand4.Columns.Add(this.colFilterMaska);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 50;
            // 
            // colFilterMaska
            // 
            this.colFilterMaska.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterMaska.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterMaska.Caption = "Maska";
            this.colFilterMaska.ColumnEdit = this.repositoryItemChck;
            this.colFilterMaska.FieldName = "IsMaska";
            this.colFilterMaska.Name = "colFilterMaska";
            this.colFilterMaska.OptionsFilter.AllowFilter = false;
            this.colFilterMaska.Tag = "Maska";
            this.colFilterMaska.Visible = true;
            this.colFilterMaska.Width = 50;
            // 
            // gridBand14
            // 
            this.gridBand14.Caption = "gridBand14";
            this.gridBand14.Columns.Add(this.colFilterTaveni);
            this.gridBand14.Name = "gridBand14";
            this.gridBand14.VisibleIndex = 4;
            this.gridBand14.Width = 50;
            // 
            // colFilterTaveni
            // 
            this.colFilterTaveni.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterTaveni.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterTaveni.Caption = "Tavení";
            this.colFilterTaveni.ColumnEdit = this.repositoryItemChck;
            this.colFilterTaveni.FieldName = "IsTaveni";
            this.colFilterTaveni.Name = "colFilterTaveni";
            this.colFilterTaveni.OptionsFilter.AllowFilter = false;
            this.colFilterTaveni.Tag = "Tavení";
            this.colFilterTaveni.Visible = true;
            this.colFilterTaveni.Width = 50;
            // 
            // gridBand17
            // 
            this.gridBand17.Caption = "gridBand17";
            this.gridBand17.Columns.Add(this.colFilterZlatoCin);
            this.gridBand17.Name = "gridBand17";
            this.gridBand17.VisibleIndex = 5;
            this.gridBand17.Width = 50;
            // 
            // colFilterZlatoCin
            // 
            this.colFilterZlatoCin.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterZlatoCin.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterZlatoCin.Caption = "Zlato cín";
            this.colFilterZlatoCin.ColumnEdit = this.repositoryItemChck;
            this.colFilterZlatoCin.FieldName = "IsZlatoCin";
            this.colFilterZlatoCin.Name = "colFilterZlatoCin";
            this.colFilterZlatoCin.OptionsFilter.AllowFilter = false;
            this.colFilterZlatoCin.Tag = "Zlato cín";
            this.colFilterZlatoCin.Visible = true;
            this.colFilterZlatoCin.Width = 50;
            // 
            // gridBand15
            // 
            this.gridBand15.Caption = "gridBand15";
            this.gridBand15.Columns.Add(this.colFilterTest);
            this.gridBand15.Name = "gridBand15";
            this.gridBand15.VisibleIndex = 6;
            this.gridBand15.Width = 50;
            // 
            // colFilterTest
            // 
            this.colFilterTest.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterTest.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterTest.Caption = "Test";
            this.colFilterTest.ColumnEdit = this.repositoryItemChck;
            this.colFilterTest.FieldName = "IsTest";
            this.colFilterTest.Name = "colFilterTest";
            this.colFilterTest.OptionsFilter.AllowFilter = false;
            this.colFilterTest.Tag = "Test";
            this.colFilterTest.Visible = true;
            this.colFilterTest.Width = 50;
            // 
            // gridBand11
            // 
            this.gridBand11.Caption = "gridBand11";
            this.gridBand11.Columns.Add(this.colFilterDrazka);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.VisibleIndex = 7;
            this.gridBand11.Width = 50;
            // 
            // colFilterDrazka
            // 
            this.colFilterDrazka.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterDrazka.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterDrazka.Caption = "Drážka";
            this.colFilterDrazka.ColumnEdit = this.repositoryItemChck;
            this.colFilterDrazka.FieldName = "IsDrazka";
            this.colFilterDrazka.Name = "colFilterDrazka";
            this.colFilterDrazka.OptionsFilter.AllowFilter = false;
            this.colFilterDrazka.Tag = " Drážka";
            this.colFilterDrazka.Visible = true;
            this.colFilterDrazka.Width = 50;
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "gridBand9";
            this.gridBand9.Columns.Add(this.colFilterFreza);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 8;
            this.gridBand9.Width = 50;
            // 
            // colFilterFreza
            // 
            this.colFilterFreza.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterFreza.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterFreza.Caption = "Fréza";
            this.colFilterFreza.ColumnEdit = this.repositoryItemChck;
            this.colFilterFreza.FieldName = "IsFreza";
            this.colFilterFreza.Name = "colFilterFreza";
            this.colFilterFreza.OptionsFilter.AllowFilter = false;
            this.colFilterFreza.Tag = " Fréza";
            this.colFilterFreza.Visible = true;
            this.colFilterFreza.Width = 50;
            // 
            // gridBand12
            // 
            this.gridBand12.Caption = "gridBand12";
            this.gridBand12.Columns.Add(this.colFilterOrgan);
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = 9;
            this.gridBand12.Width = 50;
            // 
            // colFilterOrgan
            // 
            this.colFilterOrgan.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterOrgan.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterOrgan.Caption = "Orgán";
            this.colFilterOrgan.ColumnEdit = this.repositoryItemChck;
            this.colFilterOrgan.FieldName = "IsOrgan";
            this.colFilterOrgan.Name = "colFilterOrgan";
            this.colFilterOrgan.OptionsFilter.AllowFilter = false;
            this.colFilterOrgan.Tag = " Orgán";
            this.colFilterOrgan.Visible = true;
            this.colFilterOrgan.Width = 50;
            // 
            // gridBand13
            // 
            this.gridBand13.Caption = "gridBand13";
            this.gridBand13.Columns.Add(this.colFilterStrihani);
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.VisibleIndex = 10;
            this.gridBand13.Width = 50;
            // 
            // colFilterStrihani
            // 
            this.colFilterStrihani.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterStrihani.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterStrihani.Caption = "Stříhání";
            this.colFilterStrihani.ColumnEdit = this.repositoryItemChck;
            this.colFilterStrihani.FieldName = "IsStrihani";
            this.colFilterStrihani.Name = "colFilterStrihani";
            this.colFilterStrihani.OptionsFilter.AllowFilter = false;
            this.colFilterStrihani.Tag = "Stříhání";
            this.colFilterStrihani.Visible = true;
            this.colFilterStrihani.Width = 50;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "gridBand6";
            this.gridBand6.Columns.Add(this.colFilterLaminace);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 11;
            this.gridBand6.Width = 50;
            // 
            // colFilterLaminace
            // 
            this.colFilterLaminace.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterLaminace.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterLaminace.Caption = "Laminace";
            this.colFilterLaminace.ColumnEdit = this.repositoryItemChck;
            this.colFilterLaminace.FieldName = "IsLaminace";
            this.colFilterLaminace.Name = "colFilterLaminace";
            this.colFilterLaminace.OptionsFilter.AllowFilter = false;
            this.colFilterLaminace.Tag = "Laminace";
            this.colFilterLaminace.Visible = true;
            this.colFilterLaminace.Width = 50;
            // 
            // gridBand16
            // 
            this.gridBand16.Caption = "gridBand16";
            this.gridBand16.Columns.Add(this.colFilterVrtani);
            this.gridBand16.Name = "gridBand16";
            this.gridBand16.VisibleIndex = 12;
            this.gridBand16.Width = 50;
            // 
            // colFilterVrtani
            // 
            this.colFilterVrtani.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterVrtani.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterVrtani.Caption = "Vrtání";
            this.colFilterVrtani.ColumnEdit = this.repositoryItemChck;
            this.colFilterVrtani.FieldName = "IsVrtani";
            this.colFilterVrtani.Name = "colFilterVrtani";
            this.colFilterVrtani.OptionsFilter.AllowFilter = false;
            this.colFilterVrtani.Tag = "Vrtání";
            this.colFilterVrtani.Visible = true;
            this.colFilterVrtani.Width = 50;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "gridBand7";
            this.gridBand7.Columns.Add(this.colFilterChemickaLinka);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 13;
            this.gridBand7.Width = 50;
            // 
            // colFilterChemickaLinka
            // 
            this.colFilterChemickaLinka.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterChemickaLinka.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterChemickaLinka.Caption = "Chemická linka";
            this.colFilterChemickaLinka.ColumnEdit = this.repositoryItemChck;
            this.colFilterChemickaLinka.FieldName = "IsChemickaLinka";
            this.colFilterChemickaLinka.Name = "colFilterChemickaLinka";
            this.colFilterChemickaLinka.OptionsFilter.AllowFilter = false;
            this.colFilterChemickaLinka.ToolTip = "Chemická linka";
            this.colFilterChemickaLinka.Visible = true;
            this.colFilterChemickaLinka.Width = 50;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "gridBand8";
            this.gridBand8.Columns.Add(this.colFilterGalvanickaLinka);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 14;
            this.gridBand8.Width = 50;
            // 
            // colFilterGalvanickaLinka
            // 
            this.colFilterGalvanickaLinka.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterGalvanickaLinka.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterGalvanickaLinka.Caption = "Galvanická linka";
            this.colFilterGalvanickaLinka.ColumnEdit = this.repositoryItemChck;
            this.colFilterGalvanickaLinka.FieldName = "IsGalvanickaLinka";
            this.colFilterGalvanickaLinka.Name = "colFilterGalvanickaLinka";
            this.colFilterGalvanickaLinka.OptionsFilter.AllowFilter = false;
            this.colFilterGalvanickaLinka.Tag = "Galvanická linka";
            this.colFilterGalvanickaLinka.Visible = true;
            this.colFilterGalvanickaLinka.Width = 50;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "gridBand3 sdafadsfasdf asdfasdfadsfd asdfasdfasdfsda";
            this.gridBand5.Columns.Add(this.colFilterMaskaBarevna);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 15;
            this.gridBand5.Width = 50;
            // 
            // colFilterMaskaBarevna
            // 
            this.colFilterMaskaBarevna.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilterMaskaBarevna.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFilterMaskaBarevna.Caption = "Maska barevná";
            this.colFilterMaskaBarevna.ColumnEdit = this.repositoryItemChck;
            this.colFilterMaskaBarevna.FieldName = "IsMaskaBarevna";
            this.colFilterMaskaBarevna.Name = "colFilterMaskaBarevna";
            this.colFilterMaskaBarevna.OptionsFilter.AllowFilter = false;
            this.colFilterMaskaBarevna.Tag = "Maska barevná";
            this.colFilterMaskaBarevna.Visible = true;
            this.colFilterMaskaBarevna.Width = 50;
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.colCasFrezovaniMinuty);
            this.gridBand2.Columns.Add(this.colPocetJizdFrezy);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.RowCount = 5;
            this.gridBand2.VisibleIndex = 16;
            this.gridBand2.Width = 140;
            // 
            // colCasFrezovaniMinuty
            // 
            this.colCasFrezovaniMinuty.AppearanceHeader.Options.UseTextOptions = true;
            this.colCasFrezovaniMinuty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCasFrezovaniMinuty.Caption = "Čas frézování [min]";
            this.colCasFrezovaniMinuty.FieldName = "CasFrezovaniMinuty";
            this.colCasFrezovaniMinuty.Name = "colCasFrezovaniMinuty";
            this.colCasFrezovaniMinuty.OptionsColumn.AllowEdit = false;
            this.colCasFrezovaniMinuty.Visible = true;
            // 
            // colPocetJizdFrezy
            // 
            this.colPocetJizdFrezy.AppearanceHeader.Options.UseTextOptions = true;
            this.colPocetJizdFrezy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPocetJizdFrezy.Caption = "Počet jízd frézy";
            this.colPocetJizdFrezy.FieldName = "PocetJizdFrezy";
            this.colPocetJizdFrezy.Name = "colPocetJizdFrezy";
            this.colPocetJizdFrezy.OptionsColumn.AllowEdit = false;
            this.colPocetJizdFrezy.Visible = true;
            this.colPocetJizdFrezy.Width = 65;
            // 
            // contextMenuFilter
            // 
            this.contextMenuFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheckAll,
            this.btnUnCheckAll});
            this.contextMenuFilter.Name = "contextMenuFilter";
            this.contextMenuFilter.Size = new System.Drawing.Size(138, 48);
            this.contextMenuFilter.Text = "Menu";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(137, 22);
            this.btnCheckAll.Text = "Vybrat vše";
            this.btnCheckAll.Click += new System.EventHandler(this.btnContextMenu_Click);
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            this.btnUnCheckAll.Size = new System.Drawing.Size(137, 22);
            this.btnUnCheckAll.Text = "Odebrat vše";
            this.btnUnCheckAll.Click += new System.EventHandler(this.btnContextMenu_Click);
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
            this.ribbonControl1.Size = new System.Drawing.Size(1667, 96);
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
            // grpObdobi
            // 
            this.grpObdobi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpObdobi.Controls.Add(this.lblObdobiDo);
            this.grpObdobi.Controls.Add(this.lblObdobiOd);
            this.grpObdobi.Controls.Add(this.dtDo);
            this.grpObdobi.Controls.Add(this.dtOd);
            this.grpObdobi.Location = new System.Drawing.Point(12, 6);
            this.grpObdobi.Name = "grpObdobi";
            this.grpObdobi.Size = new System.Drawing.Size(1643, 50);
            this.grpObdobi.TabIndex = 90;
            this.grpObdobi.TabStop = false;
            this.grpObdobi.Text = "Období";
            // 
            // lblObdobiDo
            // 
            this.lblObdobiDo.AutoSize = true;
            this.lblObdobiDo.Location = new System.Drawing.Point(255, 23);
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
            // dtDo
            // 
            this.dtDo.EditValue = null;
            this.dtDo.Location = new System.Drawing.Point(318, 20);
            this.dtDo.MenuManager = this.ribbonControl1;
            this.dtDo.Name = "dtDo";
            this.dtDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDo.Size = new System.Drawing.Size(160, 20);
            this.dtDo.TabIndex = 87;
            // 
            // dtOd
            // 
            this.dtOd.EditValue = null;
            this.dtOd.Location = new System.Drawing.Point(71, 20);
            this.dtOd.MenuManager = this.ribbonControl1;
            this.dtOd.Name = "dtOd";
            this.dtOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOd.Size = new System.Drawing.Size(160, 20);
            this.dtOd.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnZrusitFiltr);
            this.panel1.Controls.Add(this.btnHledat);
            this.panel1.Controls.Add(this.grpObdobi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1667, 97);
            this.panel1.TabIndex = 92;
            // 
            // btnZrusitFiltr
            // 
            this.btnZrusitFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltr.Image")));
            this.btnZrusitFiltr.Location = new System.Drawing.Point(118, 61);
            this.btnZrusitFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltr.Name = "btnZrusitFiltr";
            this.btnZrusitFiltr.Size = new System.Drawing.Size(100, 23);
            this.btnZrusitFiltr.TabIndex = 92;
            this.btnZrusitFiltr.TabStop = false;
            this.btnZrusitFiltr.Text = "Zrušit filtr";
            this.btnZrusitFiltr.Click += new System.EventHandler(this.btnZrusitFiltr_Click);
            // 
            // btnHledat
            // 
            this.btnHledat.Image = ((System.Drawing.Image)(resources.GetObject("btnHledat.Image")));
            this.btnHledat.Location = new System.Drawing.Point(12, 61);
            this.btnHledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHledat.Name = "btnHledat";
            this.btnHledat.Size = new System.Drawing.Size(100, 23);
            this.btnHledat.TabIndex = 91;
            this.btnHledat.TabStop = false;
            this.btnHledat.Text = "Vyhledat";
            this.btnHledat.Click += new System.EventHandler(this.btnHledat_Click);
            // 
            // frmReportVyroba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 636);
            this.Controls.Add(this.grdVyroba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmReportVyroba";
            this.Text = "Report výroba";
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVyroba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVyroba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChck)).EndInit();
            this.contextMenuFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.grpObdobi.ResumeLayout(false);
            this.grpObdobi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOd.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdVyroba;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChck;
        private System.Windows.Forms.ContextMenuStrip contextMenuFilter;
        private System.Windows.Forms.ToolStripMenuItem btnCheckAll;
        private System.Windows.Forms.ToolStripMenuItem btnUnCheckAll;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpMain;
        private DevExpress.XtraBars.BarButtonItem btnExportXLS;
        private DevExpress.XtraBars.BarButtonItem btnObnovit;
        private System.Windows.Forms.GroupBox grpObdobi;
        private System.Windows.Forms.Label lblObdobiDo;
        private System.Windows.Forms.Label lblObdobiOd;
        private DevExpress.XtraEditors.DateEdit dtDo;
        private DevExpress.XtraEditors.DateEdit dtOd;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltr;
        private DevExpress.XtraEditors.SimpleButton btnHledat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView grvVyroba;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTerminExpedice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTerminVyroby;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTerminZadani;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNazevPs;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOdberatel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPocetObjednano;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCisloPruvodky;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPocetPridavekPocetPanelu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPocetZmetkuChybyKs;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPocetJizdFrezy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCasFrezovaniMinuty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterLeptani;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterMaska;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterMaskaBarevna;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterLaminace;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterChemickaLinka;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterGalvanickaLinka;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterFreza;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterFoto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterDrazka;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterOrgan;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterStrihani;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterTaveni;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterTest;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterVrtani;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFilterZlatoCin;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand14;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand15;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand16;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand17;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
    }
}