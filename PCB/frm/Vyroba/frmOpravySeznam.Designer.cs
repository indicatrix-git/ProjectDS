namespace PCB
{
    partial class frmOpravySeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpravySeznam));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBarNovy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarOdstranit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarVyhledat = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlOpravy = new DevExpress.XtraGrid.GridControl();
            this.opravyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.misto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOpravy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opravyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnBarNovy,
            this.btnBarOdstranit,
            this.btnBarVyhledat,
            this.barCheckItem1,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(892, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnBarNovy
            // 
            this.btnBarNovy.Caption = "Nová";
            this.btnBarNovy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarNovy.Glyph")));
            this.btnBarNovy.Id = 1;
            this.btnBarNovy.Name = "btnBarNovy";
            this.btnBarNovy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBarNovy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarNovy_ItemClick);
            // 
            // btnBarOdstranit
            // 
            this.btnBarOdstranit.Caption = "Odstranit";
            this.btnBarOdstranit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarOdstranit.Glyph")));
            this.btnBarOdstranit.Id = 2;
            this.btnBarOdstranit.Name = "btnBarOdstranit";
            this.btnBarOdstranit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBarOdstranit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarOdstranit_ItemClick);
            // 
            // btnBarVyhledat
            // 
            this.btnBarVyhledat.Caption = "Vyhledat";
            this.btnBarVyhledat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBarVyhledat.Glyph")));
            this.btnBarVyhledat.Id = 3;
            this.btnBarVyhledat.Name = "btnBarVyhledat";
            this.btnBarVyhledat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBarVyhledat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.barButtonItem1.Caption = "Operace";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Opravy";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarNovy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarOdstranit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // gridControlOpravy
            // 
            this.gridControlOpravy.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlOpravy.DataSource = this.opravyBindingSource;
            this.gridControlOpravy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOpravy.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlOpravy.Location = new System.Drawing.Point(0, 117);
            this.gridControlOpravy.MainView = this.gridView1;
            this.gridControlOpravy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlOpravy.Name = "gridControlOpravy";
            this.gridControlOpravy.Size = new System.Drawing.Size(892, 276);
            this.gridControlOpravy.TabIndex = 77;
            this.gridControlOpravy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // opravyBindingSource
            // 
            this.opravyBindingSource.DataSource = typeof(pcb_develModel.oprava);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nazev,
            this.misto,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControlOpravy;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Nazev
            // 
            this.Nazev.Caption = "Operace";
            this.Nazev.FieldName = "pruvodka_operace.nazev";
            this.Nazev.Name = "Nazev";
            this.Nazev.OptionsColumn.AllowEdit = false;
            this.Nazev.Visible = true;
            this.Nazev.VisibleIndex = 0;
            // 
            // misto
            // 
            this.misto.Caption = "Kód";
            this.misto.FieldName = "neshoda_typ.kod";
            this.misto.Name = "misto";
            this.misto.OptionsColumn.AllowEdit = false;
            this.misto.Visible = true;
            this.misto.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Počet kusů";
            this.gridColumn2.FieldName = "pocet_ks";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Zapsal";
            this.gridColumn3.FieldName = "uzivatel.celeJmeno";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Zapsáno";
            this.gridColumn4.FieldName = "d_zapsani";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Počet panelů";
            this.gridColumn1.FieldName = "pocet_panelu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Oprava";
            this.gridColumn6.FieldName = "neshoda_typ.nazev";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // frmOpravySeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 393);
            this.Controls.Add(this.gridControlOpravy);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmOpravySeznam";
            this.Text = "frmOpravySeznam";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOpravy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opravyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnBarNovy;
        private DevExpress.XtraBars.BarButtonItem btnBarOdstranit;
        private DevExpress.XtraBars.BarButtonItem btnBarVyhledat;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControlOpravy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Nazev;
        private DevExpress.XtraGrid.Columns.GridColumn misto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.BindingSource opravyBindingSource;
    }
}