namespace PCB
{
    partial class frmUzivatelSeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUzivatelSeznam));
            this.gcOsobniCislo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemNeshoda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlNabPol = new DevExpress.XtraGrid.GridControl();
            this.uzivatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBarNovy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNabPol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzivatelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOsobniCislo
            // 
            this.gcOsobniCislo.Caption = "Osobní číslo";
            this.gcOsobniCislo.FieldName = "osobni_cislo";
            this.gcOsobniCislo.Name = "gcOsobniCislo";
            this.gcOsobniCislo.Visible = true;
            this.gcOsobniCislo.VisibleIndex = 0;
            this.gcOsobniCislo.Width = 123;
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
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.itemNeshoda,
            this.gridColumn1,
            this.gcOsobniCislo,
            this.gridColumn2,
            this.gridColumn3,
            this.Role});
            this.gridView5.GridControl = this.gridControlNabPol;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Příjmení";
            this.gridColumn2.FieldName = "prijmeni";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 214;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Jméno";
            this.gridColumn3.FieldName = "jmeno";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 309;
            // 
            // Role
            // 
            this.Role.Caption = "Role";
            this.Role.FieldName = "role.jmeno";
            this.Role.Name = "Role";
            this.Role.Visible = true;
            this.Role.VisibleIndex = 3;
            this.Role.Width = 427;
            // 
            // gridControlNabPol
            // 
            this.gridControlNabPol.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlNabPol.DataSource = this.uzivatelBindingSource;
            this.gridControlNabPol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNabPol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlNabPol.Location = new System.Drawing.Point(0, 117);
            this.gridControlNabPol.MainView = this.gridView5;
            this.gridControlNabPol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlNabPol.Name = "gridControlNabPol";
            this.gridControlNabPol.Size = new System.Drawing.Size(819, 374);
            this.gridControlNabPol.TabIndex = 249;
            this.gridControlNabPol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gridControlNabPol.DoubleClick += new System.EventHandler(this.gridControlNabPol_DoubleClick);
            // 
            // uzivatelBindingSource
            // 
            this.uzivatelBindingSource.DataSource = typeof(pcb_develModel.uzivatel);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarNovy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetail);
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
            this.btnBarNovy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovy_ItemClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Detail";
            this.btnDetail.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetail.Glyph")));
            this.btnDetail.Id = 5;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            this.btnDetail,
            this.barCheckItem1,
            this.btnBarNovy});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(819, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // frmUzivatelSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 491);
            this.Controls.Add(this.gridControlNabPol);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmUzivatelSeznam";
            this.Text = "Seznam uživatelů";
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNabPol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzivatelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gcOsobniCislo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn itemNeshoda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.GridControl gridControlNabPol;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnBarNovy;
        private System.Windows.Forms.BindingSource uzivatelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn Role;
    }
}