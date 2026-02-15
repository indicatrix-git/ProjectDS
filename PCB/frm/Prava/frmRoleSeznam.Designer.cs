namespace PCB
{
    partial class frmRoleSeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleSeznam));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNovy = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdstranit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcSeznam = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNazev = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNovy,
            this.btnOdstranit,
            this.btnDetail});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(819, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnNovy
            // 
            this.btnNovy.Caption = "Nový";
            this.btnNovy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovy.Glyph")));
            this.btnNovy.Id = 1;
            this.btnNovy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNovy.LargeGlyph")));
            this.btnNovy.Name = "btnNovy";
            this.btnNovy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovy_ItemClick);
            // 
            // btnOdstranit
            // 
            this.btnOdstranit.Caption = "Odstranit";
            this.btnOdstranit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOdstranit.Glyph")));
            this.btnOdstranit.Id = 2;
            this.btnOdstranit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnOdstranit.LargeGlyph")));
            this.btnOdstranit.Name = "btnOdstranit";
            this.btnOdstranit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdstranit_ItemClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Detail";
            this.btnDetail.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetail.Glyph")));
            this.btnDetail.Id = 3;
            this.btnDetail.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetail.LargeGlyph")));
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNovy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOdstranit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Záznam";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(pcb_develModel.role);
            // 
            // gcSeznam
            // 
            this.gcSeznam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcSeznam.DataSource = this.roleBindingSource;
            this.gcSeznam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSeznam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Location = new System.Drawing.Point(0, 117);
            this.gcSeznam.MainView = this.gridView5;
            this.gcSeznam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Name = "gcSeznam";
            this.gcSeznam.Size = new System.Drawing.Size(819, 374);
            this.gcSeznam.TabIndex = 250;
            this.gcSeznam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gcSeznam.DoubleClick += new System.EventHandler(this.gcSeznam_DoubleClick);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNazev});
            this.gridView5.GridControl = this.gcSeznam;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colNazev
            // 
            this.colNazev.Caption = "Název";
            this.colNazev.FieldName = "jmeno";
            this.colNazev.Name = "colNazev";
            this.colNazev.Visible = true;
            this.colNazev.VisibleIndex = 0;
            this.colNazev.Width = 427;
            // 
            // frmRoleSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 491);
            this.Controls.Add(this.gcSeznam);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmRoleSeznam";
            this.Text = "Seznam rolí";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnNovy;
        private DevExpress.XtraBars.BarButtonItem btnOdstranit;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.GridControl gcSeznam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colNazev;
    }
}