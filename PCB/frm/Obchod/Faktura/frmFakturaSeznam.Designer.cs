namespace PCB
{
    partial class frmFakturaSeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFakturaSeznam));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarVyhlSeznFakt = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarZrsFiltrFakt = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.btnBarNova = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemNeshoda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gcSeznam = new DevExpress.XtraGrid.GridControl();
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTypFaktury = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCisloFaktury = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZrusitFiltr = new DevExpress.XtraEditors.SimpleButton();
            this.btnVyhledat = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditPrijataDo = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStav = new PCB.Gui.PCBLookUpEdit();
            this.fakturastavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtZakaznikHledej = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEditPrijataOd = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.pgReload = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnObnovit = new DevExpress.XtraBars.BarButtonItem();
            this.btnObnovitSeznam = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypFaktury.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCisloFaktury.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStav.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturastavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaznikHledej.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnBarVyhlSeznFakt,
            this.btnBarZrsFiltrFakt,
            this.barCheckItem1,
            this.btnBarNova,
            this.btnDetail,
            this.btnObnovit,
            this.btnObnovitSeznam});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(940, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nový";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBarVyhlSeznFakt
            // 
            this.btnBarVyhlSeznFakt.Caption = "Vyhledat";
            this.btnBarVyhlSeznFakt.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarVyhlSeznFakt.Glyph")));
            this.btnBarVyhlSeznFakt.Id = 3;
            this.btnBarVyhlSeznFakt.Name = "btnBarVyhlSeznFakt";
            this.btnBarVyhlSeznFakt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBarZrsFiltrFakt
            // 
            this.btnBarZrsFiltrFakt.Caption = "Zrušit filtr";
            this.btnBarZrsFiltrFakt.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarZrsFiltrFakt.Glyph")));
            this.btnBarZrsFiltrFakt.Id = 4;
            this.btnBarZrsFiltrFakt.Name = "btnBarZrsFiltrFakt";
            this.btnBarZrsFiltrFakt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.Glyph")));
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBarNova
            // 
            this.btnBarNova.Caption = "Nová";
            this.btnBarNova.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarNova.Glyph")));
            this.btnBarNova.Id = 7;
            this.btnBarNova.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBarNova.LargeGlyph")));
            this.btnBarNova.Name = "btnBarNova";
            this.btnBarNova.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarNova_ItemClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Detail";
            this.btnDetail.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetail.Glyph")));
            this.btnDetail.Id = 8;
            this.btnDetail.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetail.LargeGlyph")));
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.pgReload});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarNova);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Sestavil";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 107;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "DPS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 179;
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
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Sestaveno";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 3;
            this.gridColumn26.Width = 124;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Kód spoje";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            this.gridColumn21.Width = 225;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Zákazník";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            this.gridColumn20.Width = 234;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn26,
            this.itemNeshoda,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl5
            // 
            this.gridControl5.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl5.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl5.Location = new System.Drawing.Point(0, 0);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(940, 526);
            this.gridControl5.TabIndex = 253;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gcSeznam
            // 
            this.gcSeznam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcSeznam.DataSource = this.fakturaBindingSource;
            this.gcSeznam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSeznam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Location = new System.Drawing.Point(0, 223);
            this.gcSeznam.MainView = this.gridView1;
            this.gcSeznam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Name = "gcSeznam";
            this.gcSeznam.Size = new System.Drawing.Size(940, 303);
            this.gcSeznam.TabIndex = 254;
            this.gcSeznam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcSeznam.DoubleClick += new System.EventHandler(this.gcSeznam_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn13});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gcSeznam;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Zákazník";
            this.gridColumn3.FieldName = "zakaznik";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 271;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Stav";
            this.gridColumn5.FieldName = "stav";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 191;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn6.Caption = "Sestaveno";
            this.gridColumn6.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "sestaveno";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 90;
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
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Sestavil";
            this.gridColumn10.FieldName = "sestavil";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 96;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Číslo faktury";
            this.gridColumn11.FieldName = "cislo_faktury";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 102;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Celková cena s DPH";
            this.gridColumn13.FieldName = "cena";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 145;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbTypFaktury);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCisloFaktury);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnZrusitFiltr);
            this.panel1.Controls.Add(this.btnVyhledat);
            this.panel1.Controls.Add(this.dateEditPrijataDo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbStav);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtZakaznikHledej);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateEditPrijataOd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 106);
            this.panel1.TabIndex = 256;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(0, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1714, 2);
            this.label7.TabIndex = 81;
            // 
            // cbTypFaktury
            // 
            this.cbTypFaktury.Location = new System.Drawing.Point(372, 30);
            this.cbTypFaktury.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypFaktury.MenuManager = this.ribbonControl1;
            this.cbTypFaktury.Name = "cbTypFaktury";
            this.cbTypFaktury.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypFaktury.Properties.Items.AddRange(new object[] {
            "Všechny",
            "Tuzemské",
            "Zahraniční"});
            this.cbTypFaktury.Size = new System.Drawing.Size(158, 20);
            this.cbTypFaktury.TabIndex = 28;
            this.cbTypFaktury.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Typ faktury:";
            // 
            // txtCisloFaktury
            // 
            this.txtCisloFaktury.Location = new System.Drawing.Point(372, 6);
            this.txtCisloFaktury.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCisloFaktury.MenuManager = this.ribbonControl1;
            this.txtCisloFaktury.Name = "txtCisloFaktury";
            this.txtCisloFaktury.Size = new System.Drawing.Size(158, 20);
            this.txtCisloFaktury.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Číslo faktury:";
            // 
            // btnZrusitFiltr
            // 
            this.btnZrusitFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltr.Image")));
            this.btnZrusitFiltr.Location = new System.Drawing.Point(107, 72);
            this.btnZrusitFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltr.Name = "btnZrusitFiltr";
            this.btnZrusitFiltr.Size = new System.Drawing.Size(86, 23);
            this.btnZrusitFiltr.TabIndex = 23;
            this.btnZrusitFiltr.TabStop = false;
            this.btnZrusitFiltr.Text = "Zrušit filtr";
            this.btnZrusitFiltr.Click += new System.EventHandler(this.btnZrusitFiltr_Click);
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.Image = ((System.Drawing.Image)(resources.GetObject("btnVyhledat.Image")));
            this.btnVyhledat.Location = new System.Drawing.Point(16, 72);
            this.btnVyhledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.Size = new System.Drawing.Size(86, 23);
            this.btnVyhledat.TabIndex = 22;
            this.btnVyhledat.TabStop = false;
            this.btnVyhledat.Text = "Vyhledat";
            this.btnVyhledat.Click += new System.EventHandler(this.btnVyhledat_Click);
            // 
            // dateEditPrijataDo
            // 
            this.dateEditPrijataDo.EditValue = null;
            this.dateEditPrijataDo.Location = new System.Drawing.Point(647, 30);
            this.dateEditPrijataDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditPrijataDo.MenuManager = this.ribbonControl1;
            this.dateEditPrijataDo.Name = "dateEditPrijataDo";
            this.dateEditPrijataDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataDo.Size = new System.Drawing.Size(158, 20);
            this.dateEditPrijataDo.TabIndex = 15;
            this.dateEditPrijataDo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vystaveno do:";
            // 
            // cmbStav
            // 
            this.cmbStav.Location = new System.Drawing.Point(96, 30);
            this.cmbStav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStav.MenuManager = this.ribbonControl1;
            this.cmbStav.Name = "cmbStav";
            this.cmbStav.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStav.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazev", "Stav")});
            this.cmbStav.Properties.DataSource = this.fakturastavBindingSource;
            this.cmbStav.Properties.DisplayMember = "nazev";
            this.cmbStav.Properties.NullText = "";
            this.cmbStav.Properties.ValueMember = "faktura_stav_id";
            this.cmbStav.Size = new System.Drawing.Size(158, 20);
            this.cmbStav.TabIndex = 13;
            this.cmbStav.TabStop = false;
            // 
            // fakturastavBindingSource
            // 
            this.fakturastavBindingSource.DataSource = typeof(pcb_develModel.faktura_stav);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stav:";
            // 
            // txtZakaznikHledej
            // 
            this.txtZakaznikHledej.Location = new System.Drawing.Point(96, 6);
            this.txtZakaznikHledej.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZakaznikHledej.MenuManager = this.ribbonControl1;
            this.txtZakaznikHledej.Name = "txtZakaznikHledej";
            this.txtZakaznikHledej.Size = new System.Drawing.Size(158, 20);
            this.txtZakaznikHledej.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zákazník:";
            // 
            // dateEditPrijataOd
            // 
            this.dateEditPrijataOd.EditValue = null;
            this.dateEditPrijataOd.Location = new System.Drawing.Point(647, 6);
            this.dateEditPrijataOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditPrijataOd.MenuManager = this.ribbonControl1;
            this.dateEditPrijataOd.Name = "dateEditPrijataOd";
            this.dateEditPrijataOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPrijataOd.Size = new System.Drawing.Size(158, 20);
            this.dateEditPrijataOd.TabIndex = 3;
            this.dateEditPrijataOd.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vystaveno od:";
            // 
            // pgReload
            // 
            this.pgReload.ItemLinks.Add(this.btnObnovitSeznam);
            this.pgReload.Name = "pgReload";
            // 
            // btnObnovit
            // 
            this.btnObnovit.Caption = "Obnovit";
            this.btnObnovit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.Glyph")));
            this.btnObnovit.Id = 10;
            this.btnObnovit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.LargeGlyph")));
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObnovit_ItemClick);
            // 
            // btnObnovitSeznam
            // 
            this.btnObnovitSeznam.Caption = "Obnovit seznam";
            this.btnObnovitSeznam.Glyph = ((System.Drawing.Image)(resources.GetObject("btnObnovitSeznam.Glyph")));
            this.btnObnovitSeznam.Id = 11;
            this.btnObnovitSeznam.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnObnovitSeznam.LargeGlyph")));
            this.btnObnovitSeznam.Name = "btnObnovitSeznam";
            this.btnObnovitSeznam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObnovitSeznam_ItemClick);
            // 
            // frmFakturaSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 526);
            this.Controls.Add(this.gcSeznam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridControl5);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmFakturaSeznam";
            this.Text = "Seznam faktur";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypFaktury.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCisloFaktury.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStav.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturastavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaznikHledej.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPrijataOd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnBarVyhlSeznFakt;
        private DevExpress.XtraBars.BarButtonItem btnBarZrsFiltrFakt;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn itemNeshoda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.GridControl gcSeznam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraBars.BarButtonItem btnBarNova;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltr;
        private DevExpress.XtraEditors.SimpleButton btnVyhledat;
        private DevExpress.XtraEditors.DateEdit dateEditPrijataDo;
        private System.Windows.Forms.Label label1;
        private PCB.Gui.PCBLookUpEdit cmbStav;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtZakaznikHledej;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateEditPrijataOd;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private System.Windows.Forms.BindingSource fakturastavBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.TextEdit txtCisloFaktury;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit cbTypFaktury;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraBars.BarButtonItem btnObnovit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgReload;
        private DevExpress.XtraBars.BarButtonItem btnObnovitSeznam;
    }
}