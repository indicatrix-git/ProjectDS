using PCB.Gui;
namespace PCB
{
    partial class frmZakaznikDetail
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZakaznikDetail));
            this.repositoryItemRichEditFontSizeEdit2 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.tabControlDetZak = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.tabControlDetZak2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcKontakt = new DevExpress.XtraGrid.GridControl();
            this.kontaktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.icKontakt = new PCB.Gui.IconHolder();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcPoznamka = new DevExpress.XtraGrid.GridControl();
            this.poznamkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Datum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Oddeleni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypPoznamka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Zaznamenal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Odkaz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNadpis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.icPoznamka = new PCB.Gui.IconHolder();
            this.lblInterni = new PCB.Gui.RequiredLabel();
            this.lblNazev = new PCB.Gui.RequiredLabel();
            this.txtInterNazev = new DevExpress.XtraEditors.TextEdit();
            this.zakaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUlice = new DevExpress.XtraEditors.TextEdit();
            this.lblUlice = new System.Windows.Forms.Label();
            this.txtNazev = new DevExpress.XtraEditors.TextEdit();
            this.lblDIC = new System.Windows.Forms.Label();
            this.txtMisto = new DevExpress.XtraEditors.TextEdit();
            this.lblICO = new System.Windows.Forms.Label();
            this.txtDIC = new DevExpress.XtraEditors.TextEdit();
            this.txtPSC = new DevExpress.XtraEditors.TextEdit();
            this.lblMisto = new System.Windows.Forms.Label();
            this.lblPSC = new System.Windows.Forms.Label();
            this.txtICO = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPageObchoda = new DevExpress.XtraTab.XtraTabPage();
            this.htmlObchod = new PCB.Gui.HtmlControler();
            this.xtraTabPageTPV = new DevExpress.XtraTab.XtraTabPage();
            this.htmlTPV = new PCB.Gui.HtmlControler();
            this.xtraTabPageSpecialniPrani = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAOI = new PCB.Gui.CheckBox();
            this.chbLaser = new PCB.Gui.CheckBox();
            this.cbET = new PCB.Gui.CheckBox();
            this.chbDvojitaKontrola = new PCB.Gui.CheckBox();
            this.chbULOzn = new PCB.Gui.CheckBox();
            this.chbArchivovat = new PCB.Gui.CheckBox();
            this.tabCena = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControlCenik = new DevExpress.XtraGrid.GridControl();
            this.zakaznikcenikpolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCenikPolozka = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cenikpolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnOdstranitCenaPolozka = new DevExpress.XtraEditors.SimpleButton();
            this.btnPridatCenaPolozka = new DevExpress.XtraEditors.SimpleButton();
            this.tabTerminy = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlTermin = new DevExpress.XtraGrid.GridControl();
            this.zakaznikterminslevaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTermin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.termintypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.plosnyspojspecifikacetypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new PCB.Gui.RepositoryCheckBox();
            this.repositoryItemSpinEditTerminy = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnOdstranitTermin = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovyTermin = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.nabidkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objednavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.editingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup();
            this.paragraphRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup();
            this.fontRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.FontRibbonPageGroup();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnFaktury = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNabidky = new DevExpress.XtraEditors.SimpleButton();
            this.btnObjednavky = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblKodAdresa = new System.Windows.Forms.Label();
            this.txtKodAdresa = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlDetZak)).BeginInit();
            this.tabControlDetZak.SuspendLayout();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlDetZak2)).BeginInit();
            this.tabControlDetZak2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKontakt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPoznamka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poznamkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterNazev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUlice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMisto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtICO.Properties)).BeginInit();
            this.xtraTabPageObchoda.SuspendLayout();
            this.xtraTabPageTPV.SuspendLayout();
            this.xtraTabPageSpecialniPrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAOI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLaser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDvojitaKontrola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbULOzn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbArchivovat.Properties)).BeginInit();
            this.tabCena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikcenikpolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCenikPolozka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenikpolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tabTerminy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTermin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikterminslevaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTermin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termintypBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plosnyspojspecifikacetypBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditTerminy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabidkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objednavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodAdresa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemRichEditFontSizeEdit2
            // 
            this.repositoryItemRichEditFontSizeEdit2.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit2.Control = null;
            this.repositoryItemRichEditFontSizeEdit2.Name = "repositoryItemRichEditFontSizeEdit2";
            // 
            // tabControlDetZak
            // 
            this.tabControlDetZak.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlDetZak.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlDetZak.Location = new System.Drawing.Point(0, 42);
            this.tabControlDetZak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlDetZak.Name = "tabControlDetZak";
            this.tabControlDetZak.SelectedTabPage = this.xtraTabPage7;
            this.tabControlDetZak.Size = new System.Drawing.Size(985, 640);
            this.tabControlDetZak.TabIndex = 0;
            this.tabControlDetZak.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage7,
            this.xtraTabPageObchoda,
            this.xtraTabPageTPV,
            this.xtraTabPageSpecialniPrani,
            this.tabCena,
            this.tabTerminy,
            this.xtraTabPage8});
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.txtKodAdresa);
            this.xtraTabPage7.Controls.Add(this.lblKodAdresa);
            this.xtraTabPage7.Controls.Add(this.tabControlDetZak2);
            this.xtraTabPage7.Controls.Add(this.lblInterni);
            this.xtraTabPage7.Controls.Add(this.lblNazev);
            this.xtraTabPage7.Controls.Add(this.txtInterNazev);
            this.xtraTabPage7.Controls.Add(this.txtUlice);
            this.xtraTabPage7.Controls.Add(this.lblUlice);
            this.xtraTabPage7.Controls.Add(this.txtNazev);
            this.xtraTabPage7.Controls.Add(this.lblDIC);
            this.xtraTabPage7.Controls.Add(this.txtMisto);
            this.xtraTabPage7.Controls.Add(this.lblICO);
            this.xtraTabPage7.Controls.Add(this.txtDIC);
            this.xtraTabPage7.Controls.Add(this.txtPSC);
            this.xtraTabPage7.Controls.Add(this.lblMisto);
            this.xtraTabPage7.Controls.Add(this.lblPSC);
            this.xtraTabPage7.Controls.Add(this.txtICO);
            this.xtraTabPage7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xtraTabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(979, 609);
            this.xtraTabPage7.Text = "Přesná fakturační adresa";
            // 
            // tabControlDetZak2
            // 
            this.tabControlDetZak2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDetZak2.Location = new System.Drawing.Point(3, 110);
            this.tabControlDetZak2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlDetZak2.Name = "tabControlDetZak2";
            this.tabControlDetZak2.SelectedTabPage = this.xtraTabPage1;
            this.tabControlDetZak2.Size = new System.Drawing.Size(977, 511);
            this.tabControlDetZak2.TabIndex = 88;
            this.tabControlDetZak2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcKontakt);
            this.xtraTabPage1.Controls.Add(this.icKontakt);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(971, 483);
            this.xtraTabPage1.Text = "Kontakty";
            // 
            // gcKontakt
            // 
            this.gcKontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKontakt.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcKontakt.DataSource = this.kontaktyBindingSource;
            this.gcKontakt.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            this.gcKontakt.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcKontakt.Location = new System.Drawing.Point(4, 28);
            this.gcKontakt.MainView = this.gridView1;
            this.gcKontakt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcKontakt.Name = "gcKontakt";
            this.gcKontakt.Size = new System.Drawing.Size(966, 457);
            this.gcKontakt.TabIndex = 85;
            this.gcKontakt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcKontakt.DoubleClick += new System.EventHandler(this.gcKontakt_DoubleClick);
            // 
            // kontaktyBindingSource
            // 
            this.kontaktyBindingSource.DataSource = typeof(pcb_develModel.kontakt);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gcKontakt;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "oddeleni.nazev", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.AllowHtmlDrawGroups = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Jméno";
            this.gridColumn1.FieldName = "jmeno";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Email";
            this.gridColumn2.FieldName = "email";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Oddělení";
            this.gridColumn3.FieldName = "oddeleni.nazev";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mobil";
            this.gridColumn4.FieldName = "mobil";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fax";
            this.gridColumn5.FieldName = "fax";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Telefon";
            this.gridColumn6.FieldName = "telefon";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // icKontakt
            // 
            this.icKontakt.AutoSize = true;
            this.icKontakt.Dock = System.Windows.Forms.DockStyle.Top;
            this.icKontakt.Location = new System.Drawing.Point(0, 0);
            this.icKontakt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icKontakt.Name = "icKontakt";
            this.icKontakt.Size = new System.Drawing.Size(971, 30);
            this.icKontakt.TabIndex = 86;
            this.icKontakt.VisibleDetail = false;
            this.icKontakt.VisibleOdstranit = false;
            this.icKontakt.VisiblePridat = false;
            this.icKontakt._PridatOnClick += new System.Action(this.icKontakt_PridatOnClick);
            this.icKontakt._DetailOnClick += new System.Action(this.icKontakt_DetailOnClick);
            this.icKontakt._SmazatOnClick += new System.Action(this.icKontakt_SmazatOnClick);
            this.icKontakt.Load += new System.EventHandler(this.icKontakt_Load);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcPoznamka);
            this.xtraTabPage2.Controls.Add(this.icPoznamka);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(971, 501);
            this.xtraTabPage2.Text = "Poznámka";
            // 
            // gcPoznamka
            // 
            this.gcPoznamka.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcPoznamka.DataSource = this.poznamkaBindingSource;
            this.gcPoznamka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPoznamka.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode2.RelationName = "Level1";
            this.gcPoznamka.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcPoznamka.Location = new System.Drawing.Point(0, 30);
            this.gcPoznamka.MainView = this.gridView5;
            this.gcPoznamka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPoznamka.Name = "gcPoznamka";
            this.gcPoznamka.Size = new System.Drawing.Size(971, 471);
            this.gcPoznamka.TabIndex = 86;
            this.gcPoznamka.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gcPoznamka.DoubleClick += new System.EventHandler(this.gcPoznamka_DoubleClick);
            // 
            // poznamkaBindingSource
            // 
            this.poznamkaBindingSource.DataSource = typeof(pcb_develModel.poznamka);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Datum,
            this.Oddeleni,
            this.TypPoznamka,
            this.Zaznamenal,
            this.Odkaz,
            this.gcNadpis});
            this.gridView5.GridControl = this.gcPoznamka;
            this.gridView5.GroupCount = 2;
            this.gridView5.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "oddeleni.nazev", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "poznamka_typ.nazev", null, "")});
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowFooter = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Oddeleni, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TypPoznamka, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Datum
            // 
            this.Datum.Caption = "Datum a čas";
            this.Datum.FieldName = "d_zapsal";
            this.Datum.Name = "Datum";
            this.Datum.Visible = true;
            this.Datum.VisibleIndex = 0;
            // 
            // Oddeleni
            // 
            this.Oddeleni.Caption = "Oddělení";
            this.Oddeleni.FieldName = "oddeleni.nazev";
            this.Oddeleni.Name = "Oddeleni";
            this.Oddeleni.Visible = true;
            this.Oddeleni.VisibleIndex = 1;
            // 
            // TypPoznamka
            // 
            this.TypPoznamka.Caption = "Typ poznámky";
            this.TypPoznamka.FieldName = "poznamka_typ.nazev";
            this.TypPoznamka.Name = "TypPoznamka";
            this.TypPoznamka.Visible = true;
            this.TypPoznamka.VisibleIndex = 2;
            // 
            // Zaznamenal
            // 
            this.Zaznamenal.Caption = "Zaznamenal";
            this.Zaznamenal.FieldName = "uzivatel.celeJmeno";
            this.Zaznamenal.Name = "Zaznamenal";
            this.Zaznamenal.Visible = true;
            this.Zaznamenal.VisibleIndex = 2;
            // 
            // Odkaz
            // 
            this.Odkaz.Caption = "Odkaz na soubor (síť)";
            this.Odkaz.FieldName = "odkaz";
            this.Odkaz.Name = "Odkaz";
            this.Odkaz.Visible = true;
            this.Odkaz.VisibleIndex = 3;
            // 
            // gcNadpis
            // 
            this.gcNadpis.Caption = "Nadpis";
            this.gcNadpis.FieldName = "nadpis";
            this.gcNadpis.Name = "gcNadpis";
            this.gcNadpis.Visible = true;
            this.gcNadpis.VisibleIndex = 1;
            // 
            // icPoznamka
            // 
            this.icPoznamka.AutoSize = true;
            this.icPoznamka.Dock = System.Windows.Forms.DockStyle.Top;
            this.icPoznamka.Location = new System.Drawing.Point(0, 0);
            this.icPoznamka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icPoznamka.Name = "icPoznamka";
            this.icPoznamka.Size = new System.Drawing.Size(971, 30);
            this.icPoznamka.TabIndex = 87;
            this.icPoznamka.VisibleDetail = false;
            this.icPoznamka.VisibleOdstranit = false;
            this.icPoznamka.VisiblePridat = false;
            this.icPoznamka._PridatOnClick += new System.Action(this.IconHolder_PridatClick);
            this.icPoznamka._DetailOnClick += new System.Action(this.icPoznamka_DetailOnClick);
            this.icPoznamka._SmazatOnClick += new System.Action(this.icPoznamka_SmazatOnClick);
            // 
            // lblInterni
            // 
            this.lblInterni.Location = new System.Drawing.Point(19, 11);
            this.lblInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblInterni.Name = "lblInterni";
            this.lblInterni.Size = new System.Drawing.Size(71, 14);
            this.lblInterni.TabIndex = 0;
            this.lblInterni.Text = "Interní název:";
            // 
            // lblNazev
            // 
            this.lblNazev.Location = new System.Drawing.Point(530, 11);
            this.lblNazev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(87, 15);
            this.lblNazev.TabIndex = 12;
            this.lblNazev.Text = "Obchodní název:";
            // 
            // txtInterNazev
            // 
            this.txtInterNazev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "interni_nazev", true));
            this.txtInterNazev.Location = new System.Drawing.Point(93, 8);
            this.txtInterNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInterNazev.Name = "txtInterNazev";
            this.txtInterNazev.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInterNazev.Properties.Mask.EditMask = "[A-Z1 -9_.-]+";
            this.txtInterNazev.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtInterNazev.Properties.Mask.ShowPlaceHolders = false;
            this.txtInterNazev.Properties.MaxLength = 30;
            this.txtInterNazev.Size = new System.Drawing.Size(357, 20);
            this.txtInterNazev.TabIndex = 1;
            // 
            // zakaznikBindingSource
            // 
            this.zakaznikBindingSource.DataSource = typeof(pcb_develModel.zakaznik);
            // 
            // txtUlice
            // 
            this.txtUlice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "ulice", true));
            this.txtUlice.Location = new System.Drawing.Point(93, 31);
            this.txtUlice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUlice.Name = "txtUlice";
            this.txtUlice.Properties.MaxLength = 100;
            this.txtUlice.Size = new System.Drawing.Size(357, 20);
            this.txtUlice.TabIndex = 3;
            // 
            // lblUlice
            // 
            this.lblUlice.AutoSize = true;
            this.lblUlice.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlice.Location = new System.Drawing.Point(56, 32);
            this.lblUlice.Name = "lblUlice";
            this.lblUlice.Size = new System.Drawing.Size(33, 13);
            this.lblUlice.TabIndex = 2;
            this.lblUlice.Text = "Ulice:";
            // 
            // txtNazev
            // 
            this.txtNazev.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "nazev", true));
            this.txtNazev.Location = new System.Drawing.Point(620, 8);
            this.txtNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Properties.MaxLength = 100;
            this.txtNazev.Size = new System.Drawing.Size(336, 20);
            this.txtNazev.TabIndex = 2;
            // 
            // lblDIC
            // 
            this.lblDIC.AutoSize = true;
            this.lblDIC.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDIC.Location = new System.Drawing.Point(584, 54);
            this.lblDIC.Name = "lblDIC";
            this.lblDIC.Size = new System.Drawing.Size(29, 13);
            this.lblDIC.TabIndex = 10;
            this.lblDIC.Text = "DIČ:";
            // 
            // txtMisto
            // 
            this.txtMisto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "misto", true));
            this.txtMisto.Location = new System.Drawing.Point(93, 54);
            this.txtMisto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMisto.Name = "txtMisto";
            this.txtMisto.Properties.MaxLength = 100;
            this.txtMisto.Size = new System.Drawing.Size(183, 20);
            this.txtMisto.TabIndex = 4;
            // 
            // lblICO
            // 
            this.lblICO.AutoSize = true;
            this.lblICO.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.lblICO.Location = new System.Drawing.Point(584, 33);
            this.lblICO.Name = "lblICO";
            this.lblICO.Size = new System.Drawing.Size(30, 13);
            this.lblICO.TabIndex = 8;
            this.lblICO.Text = "IČO:";
            // 
            // txtDIC
            // 
            this.txtDIC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "dic", true));
            this.txtDIC.Location = new System.Drawing.Point(620, 53);
            this.txtDIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDIC.Name = "txtDIC";
            this.txtDIC.Properties.Mask.EditMask = "[A-Z]*[0-9]{1,10}";
            this.txtDIC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDIC.Properties.Mask.ShowPlaceHolders = false;
            this.txtDIC.Properties.MaxLength = 20;
            this.txtDIC.Size = new System.Drawing.Size(128, 20);
            this.txtDIC.TabIndex = 7;
            // 
            // txtPSC
            // 
            this.txtPSC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "psc", true));
            this.txtPSC.Location = new System.Drawing.Point(349, 53);
            this.txtPSC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPSC.Name = "txtPSC";
            this.txtPSC.Properties.MaxLength = 5;
            this.txtPSC.Size = new System.Drawing.Size(101, 20);
            this.txtPSC.TabIndex = 5;
            // 
            // lblMisto
            // 
            this.lblMisto.AutoSize = true;
            this.lblMisto.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMisto.Location = new System.Drawing.Point(52, 54);
            this.lblMisto.Name = "lblMisto";
            this.lblMisto.Size = new System.Drawing.Size(36, 13);
            this.lblMisto.TabIndex = 4;
            this.lblMisto.Text = "Místo:";
            // 
            // lblPSC
            // 
            this.lblPSC.AutoSize = true;
            this.lblPSC.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPSC.Location = new System.Drawing.Point(311, 54);
            this.lblPSC.Name = "lblPSC";
            this.lblPSC.Size = new System.Drawing.Size(30, 13);
            this.lblPSC.TabIndex = 6;
            this.lblPSC.Text = "PSČ:";
            // 
            // txtICO
            // 
            this.txtICO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "ico", true));
            this.txtICO.Location = new System.Drawing.Point(620, 31);
            this.txtICO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtICO.Name = "txtICO";
            this.txtICO.Properties.Mask.EditMask = "[0-9]{1,10}";
            this.txtICO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtICO.Properties.Mask.ShowPlaceHolders = false;
            this.txtICO.Properties.MaxLength = 10;
            this.txtICO.Size = new System.Drawing.Size(128, 20);
            this.txtICO.TabIndex = 6;
            // 
            // xtraTabPageObchoda
            // 
            this.xtraTabPageObchoda.Controls.Add(this.htmlObchod);
            this.xtraTabPageObchoda.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageObchoda.Image")));
            this.xtraTabPageObchoda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPageObchoda.Name = "xtraTabPageObchoda";
            this.xtraTabPageObchoda.Size = new System.Drawing.Size(979, 609);
            this.xtraTabPageObchoda.Text = "Poznámka Obchod";
            // 
            // htmlObchod
            // 
            this.htmlObchod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlObchod.Location = new System.Drawing.Point(0, 0);
            this.htmlObchod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlObchod.MinimumSize = new System.Drawing.Size(17, 16);
            this.htmlObchod.Name = "htmlObchod";
            this.htmlObchod.Size = new System.Drawing.Size(979, 609);
            this.htmlObchod.TabIndex = 0;
            // 
            // xtraTabPageTPV
            // 
            this.xtraTabPageTPV.Controls.Add(this.htmlTPV);
            this.xtraTabPageTPV.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageTPV.Image")));
            this.xtraTabPageTPV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPageTPV.Name = "xtraTabPageTPV";
            this.xtraTabPageTPV.Size = new System.Drawing.Size(979, 609);
            this.xtraTabPageTPV.Text = "Poznámka TPV";
            // 
            // htmlTPV
            // 
            this.htmlTPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTPV.Location = new System.Drawing.Point(0, 0);
            this.htmlTPV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlTPV.MinimumSize = new System.Drawing.Size(17, 16);
            this.htmlTPV.Name = "htmlTPV";
            this.htmlTPV.Size = new System.Drawing.Size(979, 609);
            this.htmlTPV.TabIndex = 0;
            // 
            // xtraTabPageSpecialniPrani
            // 
            this.xtraTabPageSpecialniPrani.Controls.Add(this.panelControl1);
            this.xtraTabPageSpecialniPrani.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageSpecialniPrani.Image")));
            this.xtraTabPageSpecialniPrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPageSpecialniPrani.Name = "xtraTabPageSpecialniPrani";
            this.xtraTabPageSpecialniPrani.Size = new System.Drawing.Size(979, 609);
            this.xtraTabPageSpecialniPrani.Text = "Speciální přání";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(979, 155);
            this.panelControl1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAOI);
            this.groupBox1.Controls.Add(this.chbLaser);
            this.groupBox1.Controls.Add(this.cbET);
            this.groupBox1.Controls.Add(this.chbDvojitaKontrola);
            this.groupBox1.Controls.Add(this.chbULOzn);
            this.groupBox1.Controls.Add(this.chbArchivovat);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(297, 130);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speciální přání";
            // 
            // cbAOI
            // 
            this.cbAOI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "aoi", true));
            this.cbAOI.Location = new System.Drawing.Point(224, 47);
            this.cbAOI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAOI.Name = "cbAOI";
            this.cbAOI.Properties.Caption = "AOI";
            this.cbAOI.Size = new System.Drawing.Size(56, 19);
            this.cbAOI.TabIndex = 5;
            // 
            // chbLaser
            // 
            this.chbLaser.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "laser", true));
            this.chbLaser.Location = new System.Drawing.Point(15, 24);
            this.chbLaser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbLaser.Name = "chbLaser";
            this.chbLaser.Properties.Caption = "Laser";
            this.chbLaser.Size = new System.Drawing.Size(129, 19);
            this.chbLaser.TabIndex = 1;
            // 
            // cbET
            // 
            this.cbET.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "et", true));
            this.cbET.Location = new System.Drawing.Point(224, 24);
            this.cbET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbET.Name = "cbET";
            this.cbET.Properties.Caption = "ET";
            this.cbET.Size = new System.Drawing.Size(56, 19);
            this.cbET.TabIndex = 4;
            // 
            // chbDvojitaKontrola
            // 
            this.chbDvojitaKontrola.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "dvojita_kontrola", true));
            this.chbDvojitaKontrola.Location = new System.Drawing.Point(15, 70);
            this.chbDvojitaKontrola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDvojitaKontrola.Name = "chbDvojitaKontrola";
            this.chbDvojitaKontrola.Properties.Caption = "Dvojitá kontrola";
            this.chbDvojitaKontrola.Size = new System.Drawing.Size(129, 19);
            this.chbDvojitaKontrola.TabIndex = 0;
            // 
            // chbULOzn
            // 
            this.chbULOzn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "ul_znaceni", true));
            this.chbULOzn.Location = new System.Drawing.Point(15, 47);
            this.chbULOzn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbULOzn.Name = "chbULOzn";
            this.chbULOzn.Properties.Caption = "UL označení";
            this.chbULOzn.Size = new System.Drawing.Size(103, 19);
            this.chbULOzn.TabIndex = 3;
            // 
            // chbArchivovat
            // 
            this.chbArchivovat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "archivovat", true));
            this.chbArchivovat.Location = new System.Drawing.Point(15, 93);
            this.chbArchivovat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbArchivovat.Name = "chbArchivovat";
            this.chbArchivovat.Properties.Caption = "Archivovat";
            this.chbArchivovat.Size = new System.Drawing.Size(103, 19);
            this.chbArchivovat.TabIndex = 2;
            // 
            // tabCena
            // 
            this.tabCena.Controls.Add(this.textEdit1);
            this.tabCena.Controls.Add(this.label3);
            this.tabCena.Controls.Add(this.gridControlCenik);
            this.tabCena.Controls.Add(this.panelControl3);
            this.tabCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCena.Name = "tabCena";
            this.tabCena.Size = new System.Drawing.Size(979, 609);
            this.tabCena.Text = "Sazby zákazníka";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "cena_sablona", true));
            this.textEdit1.Location = new System.Drawing.Point(151, 355);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit1.Properties.Mask.EditMask = "N0";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit1.Size = new System.Drawing.Size(106, 20);
            this.textEdit1.TabIndex = 254;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label3.Location = new System.Drawing.Point(9, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 253;
            this.label3.Text = "Cena za šablonu (Kč/ks):";
            // 
            // gridControlCenik
            // 
            this.gridControlCenik.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCenik.DataSource = this.zakaznikcenikpolozkaBindingSource;
            this.gridControlCenik.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCenik.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCenik.Location = new System.Drawing.Point(0, 31);
            this.gridControlCenik.MainView = this.gridView6;
            this.gridControlCenik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCenik.Name = "gridControlCenik";
            this.gridControlCenik.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCenikPolozka});
            this.gridControlCenik.Size = new System.Drawing.Size(979, 314);
            this.gridControlCenik.TabIndex = 251;
            this.gridControlCenik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            this.gridControlCenik.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControlCenik_EditorKeyPress);
            this.gridControlCenik.TextChanged += new System.EventHandler(this.gridControlCenik_TextChanged);
            this.gridControlCenik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControlCenik_KeyPress);
            // 
            // zakaznikcenikpolozkaBindingSource
            // 
            this.zakaznikcenikpolozkaBindingSource.DataSource = typeof(pcb_develModel.zakaznik_cenik_polozka);
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn31});
            this.gridView6.GridControl = this.gridControlCenik;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView6_CustomColumnDisplayText);
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn17.Caption = "Hodnota [Kč]";
            this.gridColumn17.DisplayFormat.FormatString = "n2";
            this.gridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn17.FieldName = "hodnota";
            this.gridColumn17.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            this.gridColumn17.Width = 179;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "kusů / panelů";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Width = 100;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Neshoda";
            this.gridColumn33.Name = "gridColumn33";
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Odepsal";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Width = 113;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Název";
            this.gridColumn35.ColumnEdit = this.cmbCenikPolozka;
            this.gridColumn35.FieldName = "cenik_polozka_id";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 0;
            this.gridColumn35.Width = 354;
            // 
            // cmbCenikPolozka
            // 
            this.cmbCenikPolozka.AutoHeight = false;
            this.cmbCenikPolozka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCenikPolozka.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "Položka", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbCenikPolozka.DataSource = this.cenikpolozkaBindingSource;
            this.cmbCenikPolozka.DisplayMember = "nazev";
            this.cmbCenikPolozka.Name = "cmbCenikPolozka";
            this.cmbCenikPolozka.ValueMember = "cenik_polozka_id";
            // 
            // cenikpolozkaBindingSource
            // 
            this.cenikpolozkaBindingSource.DataSource = typeof(pcb_develModel.cenik_polozka);
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Expedováno";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Width = 72;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Expedice";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Width = 201;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Poznámka";
            this.gridColumn31.FieldName = "poznamka";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 2;
            this.gridColumn31.Width = 573;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnOdstranitCenaPolozka);
            this.panelControl3.Controls.Add(this.btnPridatCenaPolozka);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(979, 31);
            this.panelControl3.TabIndex = 252;
            // 
            // btnOdstranitCenaPolozka
            // 
            this.btnOdstranitCenaPolozka.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOdstranitCenaPolozka.Image = ((System.Drawing.Image)(resources.GetObject("btnOdstranitCenaPolozka.Image")));
            this.btnOdstranitCenaPolozka.Location = new System.Drawing.Point(26, 5);
            this.btnOdstranitCenaPolozka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdstranitCenaPolozka.Name = "btnOdstranitCenaPolozka";
            this.btnOdstranitCenaPolozka.Size = new System.Drawing.Size(21, 19);
            this.btnOdstranitCenaPolozka.TabIndex = 209;
            this.btnOdstranitCenaPolozka.ToolTip = "Odebrat";
            this.btnOdstranitCenaPolozka.Click += new System.EventHandler(this.btnOdstranitCenaPolozka_Click);
            // 
            // btnPridatCenaPolozka
            // 
            this.btnPridatCenaPolozka.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPridatCenaPolozka.Image = ((System.Drawing.Image)(resources.GetObject("btnPridatCenaPolozka.Image")));
            this.btnPridatCenaPolozka.Location = new System.Drawing.Point(4, 5);
            this.btnPridatCenaPolozka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPridatCenaPolozka.Name = "btnPridatCenaPolozka";
            this.btnPridatCenaPolozka.Size = new System.Drawing.Size(21, 19);
            this.btnPridatCenaPolozka.TabIndex = 208;
            this.btnPridatCenaPolozka.ToolTip = "Přidat";
            this.btnPridatCenaPolozka.Click += new System.EventHandler(this.btnPridatCenaPolozka_Click);
            // 
            // tabTerminy
            // 
            this.tabTerminy.Controls.Add(this.gridControlTermin);
            this.tabTerminy.Controls.Add(this.panelControl4);
            this.tabTerminy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTerminy.Name = "tabTerminy";
            this.tabTerminy.Size = new System.Drawing.Size(979, 609);
            this.tabTerminy.Text = "Přirážka/Sleva";
            // 
            // gridControlTermin
            // 
            this.gridControlTermin.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlTermin.DataSource = this.zakaznikterminslevaBindingSource;
            this.gridControlTermin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTermin.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlTermin.Location = new System.Drawing.Point(0, 24);
            this.gridControlTermin.MainView = this.gridView7;
            this.gridControlTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlTermin.Name = "gridControlTermin";
            this.gridControlTermin.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTermin,
            this.cmbLookUpEdit,
            this.repositoryItemSpinEditTerminy,
            this.repositoryItemTextEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControlTermin.Size = new System.Drawing.Size(979, 585);
            this.gridControlTermin.TabIndex = 252;
            this.gridControlTermin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            this.gridControlTermin.Click += new System.EventHandler(this.gridControlTermin_Click);
            // 
            // zakaznikterminslevaBindingSource
            // 
            this.zakaznikterminslevaBindingSource.DataSource = typeof(pcb_develModel.zakaznik_termin_sleva);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn39,
            this.gridColumn41,
            this.gridColumn42,
            this.gridColumn43,
            this.gridColumn44,
            this.gridColumn45,
            this.gridColumn46,
            this.gridColumn47,
            this.gridColumn38,
            this.gridColumn40});
            this.gridView7.GridControl = this.gridControlTermin;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn39
            // 
            this.gridColumn39.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn39.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn39.Caption = "Hodnota [%]";
            this.gridColumn39.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn39.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn39.FieldName = "hodnota";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 3;
            this.gridColumn39.Width = 130;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.MaxLength = 4;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridColumn41
            // 
            this.gridColumn41.Caption = "kusů / panelů";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.Width = 100;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "Neshoda";
            this.gridColumn42.Name = "gridColumn42";
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "Odepsal";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.Width = 113;
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "Termín";
            this.gridColumn44.ColumnEdit = this.cmbTermin;
            this.gridColumn44.FieldName = "termin_typ_id";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.Visible = true;
            this.gridColumn44.VisibleIndex = 0;
            this.gridColumn44.Width = 206;
            // 
            // cmbTermin
            // 
            this.cmbTermin.AutoHeight = false;
            this.cmbTermin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTermin.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "Termín")});
            this.cmbTermin.DataSource = this.termintypBindingSource;
            this.cmbTermin.DisplayMember = "nazev";
            this.cmbTermin.Name = "cmbTermin";
            this.cmbTermin.NullText = "";
            this.cmbTermin.ValueMember = "termin_typ_id";
            // 
            // termintypBindingSource
            // 
            this.termintypBindingSource.DataSource = typeof(pcb_develModel.termin_typ);
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "Expedováno";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.Width = 72;
            // 
            // gridColumn46
            // 
            this.gridColumn46.Caption = "Expedice";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.Width = 201;
            // 
            // gridColumn47
            // 
            this.gridColumn47.Caption = "Typ desky";
            this.gridColumn47.ColumnEdit = this.cmbLookUpEdit;
            this.gridColumn47.FieldName = "plosny_spoj_specifikace_typ_id";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.Visible = true;
            this.gridColumn47.VisibleIndex = 1;
            this.gridColumn47.Width = 262;
            // 
            // cmbLookUpEdit
            // 
            this.cmbLookUpEdit.AutoHeight = false;
            this.cmbLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "Typ desky", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbLookUpEdit.DataSource = this.plosnyspojspecifikacetypBindingSource;
            this.cmbLookUpEdit.DisplayMember = "nazev";
            this.cmbLookUpEdit.Name = "cmbLookUpEdit";
            this.cmbLookUpEdit.NullText = "";
            this.cmbLookUpEdit.ValueMember = "plosny_spoj_specifikace_typ_id";
            // 
            // plosnyspojspecifikacetypBindingSource
            // 
            this.plosnyspojspecifikacetypBindingSource.DataSource = typeof(pcb_develModel.plosny_spoj_specifikace_typ);
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "Poznámka";
            this.gridColumn38.FieldName = "poznamka";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 4;
            this.gridColumn38.Width = 405;
            // 
            // gridColumn40
            // 
            this.gridColumn40.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn40.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn40.Caption = "Základní cena";
            this.gridColumn40.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn40.FieldName = "vychozi";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 2;
            this.gridColumn40.Width = 103;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.PictureChecked = ((System.Drawing.Image)(resources.GetObject("repositoryItemCheckEdit1.PictureChecked")));
            this.repositoryItemCheckEdit1.PictureUnchecked = ((System.Drawing.Image)(resources.GetObject("repositoryItemCheckEdit1.PictureUnchecked")));
            // 
            // repositoryItemSpinEditTerminy
            // 
            this.repositoryItemSpinEditTerminy.AutoHeight = false;
            this.repositoryItemSpinEditTerminy.MaxLength = 4;
            this.repositoryItemSpinEditTerminy.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.repositoryItemSpinEditTerminy.MinValue = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.repositoryItemSpinEditTerminy.Name = "repositoryItemSpinEditTerminy";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnOdstranitTermin);
            this.panelControl4.Controls.Add(this.btnNovyTermin);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(979, 24);
            this.panelControl4.TabIndex = 253;
            // 
            // btnOdstranitTermin
            // 
            this.btnOdstranitTermin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOdstranitTermin.Image = ((System.Drawing.Image)(resources.GetObject("btnOdstranitTermin.Image")));
            this.btnOdstranitTermin.Location = new System.Drawing.Point(26, 3);
            this.btnOdstranitTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdstranitTermin.Name = "btnOdstranitTermin";
            this.btnOdstranitTermin.Size = new System.Drawing.Size(21, 19);
            this.btnOdstranitTermin.TabIndex = 209;
            this.btnOdstranitTermin.Click += new System.EventHandler(this.btnOdstranitTermin_Click);
            // 
            // btnNovyTermin
            // 
            this.btnNovyTermin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNovyTermin.Image = ((System.Drawing.Image)(resources.GetObject("btnNovyTermin.Image")));
            this.btnNovyTermin.Location = new System.Drawing.Point(4, 3);
            this.btnNovyTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovyTermin.Name = "btnNovyTermin";
            this.btnNovyTermin.Size = new System.Drawing.Size(21, 19);
            this.btnNovyTermin.TabIndex = 208;
            this.btnNovyTermin.Click += new System.EventHandler(this.btnNovyTermin_Click);
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.textEdit2);
            this.xtraTabPage8.Controls.Add(this.label4);
            this.xtraTabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Size = new System.Drawing.Size(979, 609);
            this.xtraTabPage8.Text = "Splatnost";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "splatnost_pocet_dni", true));
            this.textEdit2.Location = new System.Drawing.Point(143, 11);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit2.Properties.Mask.EditMask = "N0";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit2.Properties.MaxLength = 3;
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Splatnost (počet dní):";
            // 
            // nabidkaBindingSource
            // 
            this.nabidkaBindingSource.DataSource = typeof(pcb_develModel.nabidka_polozka);
            // 
            // objednavkaBindingSource
            // 
            this.objednavkaBindingSource.DataSource = typeof(pcb_develModel.objednavka_polozka);
            // 
            // fakturaBindingSource
            // 
            this.fakturaBindingSource.DataSource = typeof(pcb_develModel.faktura);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Nový";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // editingRibbonPageGroup1
            // 
            this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            this.editingRibbonPageGroup1.Text = "";
            // 
            // stylesRibbonPageGroup1
            // 
            this.stylesRibbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("stylesRibbonPageGroup1.Glyph")));
            this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            this.stylesRibbonPageGroup1.Text = "";
            // 
            // paragraphRibbonPageGroup1
            // 
            this.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1";
            this.paragraphRibbonPageGroup1.Text = "";
            // 
            // fontRibbonPageGroup1
            // 
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            this.fontRibbonPageGroup1.Text = "";
            // 
            // clipboardRibbonPageGroup1
            // 
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            this.clipboardRibbonPageGroup1.Text = "";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = 1;
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Id = 2;
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Id = 3;
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Id = 4;
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // barButtonGroup5
            // 
            this.barButtonGroup5.Id = 5;
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}";
            // 
            // barButtonGroup6
            // 
            this.barButtonGroup6.Id = 6;
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}";
            // 
            // barButtonGroup7
            // 
            this.barButtonGroup7.Id = 7;
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnFaktury);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnNabidky);
            this.panelControl2.Controls.Add(this.btnObjednavky);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnStorno);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(985, 42);
            this.panelControl2.TabIndex = 89;
            // 
            // btnFaktury
            // 
            this.btnFaktury.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaktury.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnFaktury.Image = ((System.Drawing.Image)(resources.GetObject("btnFaktury.Image")));
            this.btnFaktury.Location = new System.Drawing.Point(837, 5);
            this.btnFaktury.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaktury.Name = "btnFaktury";
            this.btnFaktury.Size = new System.Drawing.Size(137, 32);
            this.btnFaktury.TabIndex = 3;
            this.btnFaktury.Text = "Faktury";
            this.btnFaktury.Click += new System.EventHandler(this.btnFaktury_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakaznikBindingSource, "interni_nazev", true));
            this.labelControl1.Location = new System.Drawing.Point(192, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "labelControl1";
            // 
            // btnNabidky
            // 
            this.btnNabidky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNabidky.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNabidky.Image = ((System.Drawing.Image)(resources.GetObject("btnNabidky.Image")));
            this.btnNabidky.Location = new System.Drawing.Point(555, 4);
            this.btnNabidky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNabidky.Name = "btnNabidky";
            this.btnNabidky.Size = new System.Drawing.Size(137, 32);
            this.btnNabidky.TabIndex = 0;
            this.btnNabidky.Text = "Nabídky";
            this.btnNabidky.Click += new System.EventHandler(this.btnNabidky_Click);
            // 
            // btnObjednavky
            // 
            this.btnObjednavky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjednavky.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnObjednavky.Image = ((System.Drawing.Image)(resources.GetObject("btnObjednavky.Image")));
            this.btnObjednavky.Location = new System.Drawing.Point(697, 5);
            this.btnObjednavky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObjednavky.Name = "btnObjednavky";
            this.btnObjednavky.Size = new System.Drawing.Size(135, 32);
            this.btnObjednavky.TabIndex = 0;
            this.btnObjednavky.Text = "Objednávky";
            this.btnObjednavky.Click += new System.EventHandler(this.btnObjednavky_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(3, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Uložit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(89, 4);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(93, 32);
            this.btnStorno.TabIndex = 1;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblKodAdresa
            // 
            this.lblKodAdresa.AutoSize = true;
            this.lblKodAdresa.Location = new System.Drawing.Point(24, 82);
            this.lblKodAdresa.Name = "lblKodAdresa";
            this.lblKodAdresa.Size = new System.Drawing.Size(63, 13);
            this.lblKodAdresa.TabIndex = 89;
            this.lblKodAdresa.Text = "Kód adresy:";
            // 
            // txtKodAdresa
            // 
            this.txtKodAdresa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.zakaznikBindingSource, "kod_adresa", true));
            this.txtKodAdresa.Location = new System.Drawing.Point(93, 79);
            this.txtKodAdresa.Name = "txtKodAdresa";
            this.txtKodAdresa.Size = new System.Drawing.Size(183, 20);
            this.txtKodAdresa.TabIndex = 90;
            // 
            // frmZakaznikDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 680);
            this.Controls.Add(this.tabControlDetZak);
            this.Controls.Add(this.panelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZakaznikDetail";
            this.Text = "Detail zákazníka";
            this.Shown += new System.EventHandler(this.frmZakaznikDetail_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlDetZak)).EndInit();
            this.tabControlDetZak.ResumeLayout(false);
            this.xtraTabPage7.ResumeLayout(false);
            this.xtraTabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlDetZak2)).EndInit();
            this.tabControlDetZak2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKontakt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPoznamka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poznamkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterNazev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUlice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMisto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtICO.Properties)).EndInit();
            this.xtraTabPageObchoda.ResumeLayout(false);
            this.xtraTabPageTPV.ResumeLayout(false);
            this.xtraTabPageSpecialniPrani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbAOI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLaser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDvojitaKontrola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbULOzn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbArchivovat.Properties)).EndInit();
            this.tabCena.ResumeLayout(false);
            this.tabCena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikcenikpolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCenikPolozka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenikpolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.tabTerminy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTermin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikterminslevaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTermin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termintypBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plosnyspojspecifikacetypBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditTerminy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.xtraTabPage8.ResumeLayout(false);
            this.xtraTabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabidkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objednavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodAdresa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlDetZak;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSpecialniPrani;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup editingRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup stylesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup paragraphRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.FontRibbonPageGroup fontRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup clipboardRibbonPageGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup5;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup6;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup7;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit2;
        private System.Windows.Forms.BindingSource zakaznikBindingSource;
        private PCB.Gui.CheckBox chbArchivovat;
        private PCB.Gui.CheckBox chbLaser;
        private PCB.Gui.CheckBox chbDvojitaKontrola;
        private DevExpress.XtraTab.XtraTabControl tabControlDetZak2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gcKontakt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gcPoznamka;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn Datum;
        private DevExpress.XtraGrid.Columns.GridColumn Oddeleni;
        private DevExpress.XtraGrid.Columns.GridColumn TypPoznamka;
        private DevExpress.XtraGrid.Columns.GridColumn Zaznamenal;
        private System.Windows.Forms.BindingSource poznamkaBindingSource;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private DevExpress.XtraEditors.TextEdit txtNazev;
        private System.Windows.Forms.Label lblDIC;
        private DevExpress.XtraEditors.TextEdit txtMisto;
        private System.Windows.Forms.Label lblICO;
        private DevExpress.XtraEditors.TextEdit txtDIC;
        private DevExpress.XtraEditors.TextEdit txtPSC;
        private System.Windows.Forms.Label lblMisto;
        private System.Windows.Forms.Label lblPSC;
        private DevExpress.XtraEditors.TextEdit txtICO;
        private DevExpress.XtraEditors.TextEdit txtUlice;
        private System.Windows.Forms.Label lblUlice;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageObchoda;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTPV;
        private DevExpress.XtraGrid.Columns.GridColumn Odkaz;
        private PCB.Gui.CheckBox chbULOzn;
        private DevExpress.XtraEditors.TextEdit txtInterNazev;
        private Gui.IconHolder icPoznamka;
        private System.Windows.Forms.BindingSource kontaktyBindingSource;
        private Gui.RequiredLabel lblNazev;
        private Gui.RequiredLabel lblInterni;
        private System.Windows.Forms.BindingSource nabidkaBindingSource;
        private System.Windows.Forms.BindingSource objednavkaBindingSource;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
        private Gui.IconHolder icKontakt;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraGrid.Columns.GridColumn gcNadpis;
        private DevExpress.XtraTab.XtraTabPage tabCena;
        private DevExpress.XtraGrid.GridControl gridControlCenik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraTab.XtraTabPage tabTerminy;
        private DevExpress.XtraGrid.GridControl gridControlTermin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.BindingSource zakaznikcenikpolozkaBindingSource;
        private System.Windows.Forms.BindingSource zakaznikterminslevaBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbCenikPolozka;
        private System.Windows.Forms.BindingSource cenikpolozkaBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOdstranitCenaPolozka;
        private DevExpress.XtraEditors.SimpleButton btnPridatCenaPolozka;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbTermin;
        private System.Windows.Forms.BindingSource termintypBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOdstranitTermin;
        private DevExpress.XtraEditors.SimpleButton btnNovyTermin;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbLookUpEdit;
        private System.Windows.Forms.BindingSource plosnyspojspecifikacetypBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditTerminy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private RepositoryCheckBox repositoryItemCheckEdit1;
        private HtmlControler htmlObchod;
        private HtmlControler htmlTPV;
        private DevExpress.XtraEditors.SimpleButton btnObjednavky;
        private DevExpress.XtraEditors.SimpleButton btnFaktury;
        private DevExpress.XtraEditors.SimpleButton btnNabidky;
        private CheckBox cbAOI;
        private CheckBox cbET;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtKodAdresa;
        private System.Windows.Forms.Label lblKodAdresa;
    }
}

