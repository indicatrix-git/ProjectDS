namespace PCB
{
    partial class frmOperaceSeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaceSeznam));
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBarOdstranit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarZrusitFiltr = new DevExpress.XtraBars.BarButtonItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCenik = new DevExpress.XtraGrid.GridControl();
            this.operaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarVyhlSeznFakt = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarZrsFiltrFakt = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.btnBarNova = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnUlozit = new DevExpress.XtraBars.BarButtonItem();
            this.btnZavrit = new DevExpress.XtraBars.BarButtonItem();
            this.btnPropsat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgReload = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnObnovit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // btnBarOdstranit
            // 
            this.btnBarOdstranit.Caption = "Odstranit";
            this.btnBarOdstranit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarOdstranit.Glyph")));
            this.btnBarOdstranit.Id = 2;
            this.btnBarOdstranit.Name = "btnBarOdstranit";
            this.btnBarOdstranit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBarZrusitFiltr
            // 
            this.btnBarZrusitFiltr.Caption = "Zrušit filtr";
            this.btnBarZrusitFiltr.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarZrusitFiltr.Glyph")));
            this.btnBarZrusitFiltr.Id = 4;
            this.btnBarZrusitFiltr.Name = "btnBarZrusitFiltr";
            this.btnBarZrusitFiltr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn15,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControlCenik;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Název";
            this.gridColumn7.FieldName = "nazev";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 362;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "kusů / panelů";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 100;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Neshoda";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Odepsal";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Width = 113;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Kód";
            this.gridColumn12.FieldName = "kod";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 123;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Expedováno";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 72;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Expedice";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Width = 201;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Filtr";
            this.gridColumn1.FieldName = "filtr";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 487;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Popis";
            this.gridColumn2.FieldName = "popis";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 265;
            // 
            // gridControlCenik
            // 
            this.gridControlCenik.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCenik.DataSource = this.operaceBindingSource;
            this.gridControlCenik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCenik.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCenik.Location = new System.Drawing.Point(0, 117);
            this.gridControlCenik.MainView = this.gridView1;
            this.gridControlCenik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCenik.Name = "gridControlCenik";
            this.gridControlCenik.Size = new System.Drawing.Size(1076, 421);
            this.gridControlCenik.TabIndex = 250;
            this.gridControlCenik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // operaceBindingSource
            // 
            this.operaceBindingSource.DataSource = typeof(pcb_develModel.operace);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnBarVyhlSeznFakt,
            this.btnBarZrsFiltrFakt,
            this.btnBarDetail,
            this.barCheckItem1,
            this.btnBarNova,
            this.barButtonItem3,
            this.btnUlozit,
            this.btnZavrit,
            this.btnPropsat,
            this.btnObnovit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1076, 117);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Odstranit";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // btnBarDetail
            // 
            this.btnBarDetail.Caption = "Detail";
            this.btnBarDetail.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarDetail.Glyph")));
            this.btnBarDetail.Id = 5;
            this.btnBarDetail.Name = "btnBarDetail";
            this.btnBarDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Položky";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnUlozit
            // 
            this.btnUlozit.Caption = "Uložit";
            this.btnUlozit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Glyph")));
            this.btnUlozit.Id = 9;
            this.btnUlozit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUlozit.LargeGlyph")));
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUlozit_ItemClick);
            // 
            // btnZavrit
            // 
            this.btnZavrit.Caption = "Zavřít";
            this.btnZavrit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnZavrit.Glyph")));
            this.btnZavrit.Id = 10;
            this.btnZavrit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnZavrit.LargeGlyph")));
            this.btnZavrit.Name = "btnZavrit";
            this.btnZavrit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZavrit_ItemClick);
            // 
            // btnPropsat
            // 
            this.btnPropsat.Caption = "Propsat";
            this.btnPropsat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPropsat.Glyph")));
            this.btnPropsat.Id = 11;
            this.btnPropsat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPropsat.LargeGlyph")));
            this.btnPropsat.Name = "btnPropsat";
            this.btnPropsat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPropsat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.pgReload});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUlozit);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnZavrit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBarNova);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPropsat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // pgReload
            // 
            this.pgReload.ItemLinks.Add(this.btnObnovit);
            this.pgReload.Name = "pgReload";
            // 
            // btnObnovit
            // 
            this.btnObnovit.Caption = "Obnovit seznam";
            this.btnObnovit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.Glyph")));
            this.btnObnovit.Id = 12;
            this.btnObnovit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnObnovit.LargeGlyph")));
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObnovit_ItemClick);
            // 
            // frmOperaceSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 538);
            this.Controls.Add(this.gridControlCenik);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmOperaceSeznam";
            this.Text = "Operace seznam";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBarOdstranit;
        private DevExpress.XtraBars.BarButtonItem btnBarZrusitFiltr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.GridControl gridControlCenik;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnBarVyhlSeznFakt;
        private DevExpress.XtraBars.BarButtonItem btnBarZrsFiltrFakt;
        private DevExpress.XtraBars.BarButtonItem btnBarDetail;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem btnBarNova;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource operaceBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnUlozit;
        private DevExpress.XtraBars.BarButtonItem btnZavrit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem btnPropsat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnObnovit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgReload;
    }
}