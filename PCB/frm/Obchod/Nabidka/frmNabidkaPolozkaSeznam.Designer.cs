namespace PCB
{
    partial class frmNabidkaPolozkaSeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabidkaPolozkaSeznam));
            this.filtrSestaveno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemNeshoda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filtrNazevSpoje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filtrSestavil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filtrZakaznik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlNabPol = new DevExpress.XtraGrid.GridControl();
            this.nabidkapolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBarVyhledat = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarZrusFiltr = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBarNovy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnStorno = new DevExpress.XtraBars.BarButtonItem();
            this.btnObnovit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZrusitFiltr = new DevExpress.XtraEditors.SimpleButton();
            this.btnVyhledat = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditPrijataDo = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStav = new PCB.Gui.PCBLookUpEdit();
            this.nabidkastavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtDPSHledej = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZakaznikHledej = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEditPrijataOd = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.pgReload = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnOvbnovit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNabPol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabidkapolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStav.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabidkastavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDPSHledej.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaznikHledej.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrSestaveno
            // 
            this.filtrSestaveno.Caption = "Sestaveno";
            this.filtrSestaveno.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.filtrSestaveno.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.filtrSestaveno.FieldName = "d_sestaveno";
            this.filtrSestaveno.Name = "filtrSestaveno";
            this.filtrSestaveno.Visible = true;
            this.filtrSestaveno.VisibleIndex = 3;
            this.filtrSestaveno.Width = 127;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Odepsal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 113;
            // 
            // itemNeshoda
            // 
            this.itemNeshoda.Caption = "Neshoda";
            this.itemNeshoda.Name = "itemNeshoda";
            // 
            // filtrNazevSpoje
            // 
            this.filtrNazevSpoje.Caption = "Název DPS";
            this.filtrNazevSpoje.FieldName = "nazev_dps";
            this.filtrNazevSpoje.Name = "filtrNazevSpoje";
            this.filtrNazevSpoje.Visible = true;
            this.filtrNazevSpoje.VisibleIndex = 2;
            this.filtrNazevSpoje.Width = 400;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.filtrNazevSpoje,
            this.itemNeshoda,
            this.gridColumn1,
            this.filtrSestaveno,
            this.filtrSestavil,
            this.filtrZakaznik,
            this.gridColumn2,
            this.gridColumn4});
            this.gridView5.GridControl = this.gridControlNabPol;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsBehavior.ReadOnly = true;
            this.gridView5.OptionsCustomization.AllowColumnMoving = false;
            this.gridView5.OptionsCustomization.AllowColumnResizing = false;
            this.gridView5.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // filtrSestavil
            // 
            this.filtrSestavil.Caption = "Sestavil";
            this.filtrSestavil.FieldName = "sestavil";
            this.filtrSestavil.Name = "filtrSestavil";
            this.filtrSestavil.Visible = true;
            this.filtrSestavil.VisibleIndex = 4;
            this.filtrSestavil.Width = 256;
            // 
            // filtrZakaznik
            // 
            this.filtrZakaznik.Caption = "Zákazník";
            this.filtrZakaznik.FieldName = "zakaznik";
            this.filtrZakaznik.Name = "filtrZakaznik";
            this.filtrZakaznik.Visible = true;
            this.filtrZakaznik.VisibleIndex = 1;
            this.filtrZakaznik.Width = 400;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stav";
            this.gridColumn2.FieldName = "stav_nazev";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 160;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Přijato";
            this.gridColumn4.FieldName = "d_prijato";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 100;
            // 
            // gridControlNabPol
            // 
            this.gridControlNabPol.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlNabPol.DataSource = this.nabidkapolozkaBindingSource;
            this.gridControlNabPol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNabPol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlNabPol.Location = new System.Drawing.Point(0, 228);
            this.gridControlNabPol.MainView = this.gridView5;
            this.gridControlNabPol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlNabPol.Name = "gridControlNabPol";
            this.gridControlNabPol.Size = new System.Drawing.Size(1252, 263);
            this.gridControlNabPol.TabIndex = 249;
            this.gridControlNabPol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gridControlNabPol.DoubleClick += new System.EventHandler(this.gridControlNabPol_DoubleClick);
            // 
            // nabidkapolozkaBindingSource
            // 
            this.nabidkapolozkaBindingSource.DataSource = typeof(pcb_develModel.nabidka_polozka);
            // 
            // btnBarVyhledat
            // 
            this.btnBarVyhledat.Caption = "Vyhledat";
            this.btnBarVyhledat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarVyhledat.Glyph")));
            this.btnBarVyhledat.Id = 3;
            this.btnBarVyhledat.Name = "btnBarVyhledat";
            this.btnBarVyhledat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBarVyhledat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarVyhledat_ItemClick);
            // 
            // btnBarZrusFiltr
            // 
            this.btnBarZrusFiltr.Caption = "Zrušit filtr";
            this.btnBarZrusFiltr.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarZrusFiltr.Glyph")));
            this.btnBarZrusFiltr.Id = 4;
            this.btnBarZrusFiltr.Name = "btnBarZrusFiltr";
            this.btnBarZrusFiltr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBarZrusFiltr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarZrusFiltr_ItemClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarNovy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarDetail);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStorno);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnObnovit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // btnBarNovy
            // 
            this.btnBarNovy.Caption = "Nový";
            this.btnBarNovy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarNovy.Glyph")));
            this.btnBarNovy.Id = 7;
            this.btnBarNovy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBarNovy.LargeGlyph")));
            this.btnBarNovy.Name = "btnBarNovy";
            this.btnBarNovy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarNovy_ItemClick);
            // 
            // btnBarDetail
            // 
            this.btnBarDetail.Caption = "Detail";
            this.btnBarDetail.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarDetail.Glyph")));
            this.btnBarDetail.Id = 5;
            this.btnBarDetail.Name = "btnBarDetail";
            this.btnBarDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBarDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarDetail_ItemClick);
            // 
            // btnStorno
            // 
            this.btnStorno.Caption = "Storno";
            this.btnStorno.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStorno.Glyph")));
            this.btnStorno.Id = 9;
            this.btnStorno.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStorno.LargeGlyph")));
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStorno_ItemClick);
            // 
            // btnObnovit
            // 
            this.btnObnovit.Caption = "Obnovit nabídku";
            this.btnObnovit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.Glyph")));
            this.btnObnovit.Id = 10;
            this.btnObnovit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.LargeGlyph")));
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.pgReload});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.Glyph")));
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nový";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnBarVyhledat,
            this.btnBarZrusFiltr,
            this.btnBarDetail,
            this.barCheckItem1,
            this.btnBarNovy,
            this.btnStorno,
            this.btnObnovit,
            this.btnOvbnovit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1252, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sestavil";
            this.gridColumn3.FieldName = "uzivatel.prijmeni";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 213;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnZrusitFiltr);
            this.panel1.Controls.Add(this.btnVyhledat);
            this.panel1.Controls.Add(this.dateEditPrijataDo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbStav);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDPSHledej);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtZakaznikHledej);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateEditPrijataOd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 111);
            this.panel1.TabIndex = 252;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1714, 2);
            this.label4.TabIndex = 82;
            // 
            // btnZrusitFiltr
            // 
            this.btnZrusitFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltr.Image")));
            this.btnZrusitFiltr.Location = new System.Drawing.Point(101, 75);
            this.btnZrusitFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltr.Name = "btnZrusitFiltr";
            this.btnZrusitFiltr.Size = new System.Drawing.Size(86, 23);
            this.btnZrusitFiltr.TabIndex = 23;
            this.btnZrusitFiltr.TabStop = false;
            this.btnZrusitFiltr.Text = "Zrušit filtr";
            this.btnZrusitFiltr.Click += new System.EventHandler(this.btnBarZrusFiltr_ItemClick);
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.Image = ((System.Drawing.Image)(resources.GetObject("btnVyhledat.Image")));
            this.btnVyhledat.Location = new System.Drawing.Point(10, 75);
            this.btnVyhledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.Size = new System.Drawing.Size(86, 23);
            this.btnVyhledat.TabIndex = 22;
            this.btnVyhledat.TabStop = false;
            this.btnVyhledat.Text = "Vyhledat";
            this.btnVyhledat.Click += new System.EventHandler(this.btnBarVyhledat_ItemClick);
            // 
            // dateEditPrijataDo
            // 
            this.dateEditPrijataDo.EditValue = null;
            this.dateEditPrijataDo.Location = new System.Drawing.Point(593, 32);
            this.dateEditPrijataDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditPrijataDo.MenuManager = this.ribbonControl1;
            this.dateEditPrijataDo.Name = "dateEditPrijataDo";
            this.dateEditPrijataDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataDo.Size = new System.Drawing.Size(142, 20);
            this.dateEditPrijataDo.TabIndex = 15;
            this.dateEditPrijataDo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Přijata do:";
            // 
            // cmbStav
            // 
            this.cmbStav.Location = new System.Drawing.Point(84, 32);
            this.cmbStav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStav.MenuManager = this.ribbonControl1;
            this.cmbStav.Name = "cmbStav";
            this.cmbStav.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStav.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "Stav")});
            this.cmbStav.Properties.DataSource = this.nabidkastavBindingSource;
            this.cmbStav.Properties.DisplayMember = "nazev";
            this.cmbStav.Properties.NullText = "";
            this.cmbStav.Properties.ValueMember = "nabidka_stav_id";
            this.cmbStav.Size = new System.Drawing.Size(171, 20);
            this.cmbStav.TabIndex = 13;
            this.cmbStav.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stav:";
            // 
            // txtDPSHledej
            // 
            this.txtDPSHledej.Location = new System.Drawing.Point(341, 8);
            this.txtDPSHledej.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDPSHledej.MenuManager = this.ribbonControl1;
            this.txtDPSHledej.Name = "txtDPSHledej";
            this.txtDPSHledej.Size = new System.Drawing.Size(171, 20);
            this.txtDPSHledej.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Název DPS:";
            // 
            // txtZakaznikHledej
            // 
            this.txtZakaznikHledej.Location = new System.Drawing.Point(84, 8);
            this.txtZakaznikHledej.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZakaznikHledej.MenuManager = this.ribbonControl1;
            this.txtZakaznikHledej.Name = "txtZakaznikHledej";
            this.txtZakaznikHledej.Size = new System.Drawing.Size(171, 20);
            this.txtZakaznikHledej.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zákazník:";
            // 
            // dateEditPrijataOd
            // 
            this.dateEditPrijataOd.EditValue = null;
            this.dateEditPrijataOd.Location = new System.Drawing.Point(593, 8);
            this.dateEditPrijataOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditPrijataOd.MenuManager = this.ribbonControl1;
            this.dateEditPrijataOd.Name = "dateEditPrijataOd";
            this.dateEditPrijataOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataOd.Size = new System.Drawing.Size(142, 20);
            this.dateEditPrijataOd.TabIndex = 3;
            this.dateEditPrijataOd.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Přijata od:";
            // 
            // pgReload
            // 
            this.pgReload.ItemLinks.Add(this.btnOvbnovit);
            this.pgReload.Name = "pgReload";
            // 
            // btnOvbnovit
            // 
            this.btnOvbnovit.Caption = "Obnovit seznam";
            this.btnOvbnovit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOvbnovit.Glyph")));
            this.btnOvbnovit.Id = 11;
            this.btnOvbnovit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnOvbnovit.LargeGlyph")));
            this.btnOvbnovit.Name = "btnOvbnovit";
            // 
            // frmNabidkaPolozkaSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 491);
            this.Controls.Add(this.gridControlNabPol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmNabidkaPolozkaSeznam";
            this.Text = "Nabídka položky";
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNabPol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabidkapolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStav.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabidkastavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDPSHledej.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaznikHledej.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn filtrSestaveno;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn itemNeshoda;
        private DevExpress.XtraGrid.Columns.GridColumn filtrNazevSpoje;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn filtrSestavil;
        private DevExpress.XtraGrid.GridControl gridControlNabPol;
        private DevExpress.XtraBars.BarButtonItem btnBarVyhledat;
        private DevExpress.XtraBars.BarButtonItem btnBarZrusFiltr;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBarDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnBarNovy;
        private System.Windows.Forms.BindingSource nabidkapolozkaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtDPSHledej;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtZakaznikHledej;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateEditPrijataOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private PCB.Gui.PCBLookUpEdit cmbStav;
        private System.Windows.Forms.BindingSource nabidkastavBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn filtrZakaznik;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.DateEdit dateEditPrijataDo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltr;
        private DevExpress.XtraEditors.SimpleButton btnVyhledat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraBars.BarButtonItem btnStorno;
        private DevExpress.XtraBars.BarButtonItem btnObnovit;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgReload;
        private DevExpress.XtraBars.BarButtonItem btnOvbnovit;
    }
}