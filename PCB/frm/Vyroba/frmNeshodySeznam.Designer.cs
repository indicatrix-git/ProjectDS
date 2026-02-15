namespace PCB
{
    partial class frmNeshodySeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNeshodySeznam));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBarNovy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarOdstranit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarVyhledat = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlNeshody = new DevExpress.XtraGrid.GridControl();
            this.neshodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.misto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNeshody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neshodaBindingSource)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(856, 117);
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
            this.ribbonPage1.Text = "Neshody";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarNovy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarOdstranit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // gridControlNeshody
            // 
            this.gridControlNeshody.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlNeshody.DataSource = this.neshodaBindingSource;
            this.gridControlNeshody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNeshody.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlNeshody.Location = new System.Drawing.Point(0, 117);
            this.gridControlNeshody.MainView = this.gridView1;
            this.gridControlNeshody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlNeshody.Name = "gridControlNeshody";
            this.gridControlNeshody.Size = new System.Drawing.Size(856, 253);
            this.gridControlNeshody.TabIndex = 76;
            this.gridControlNeshody.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // neshodaBindingSource
            // 
            this.neshodaBindingSource.DataSource = typeof(pcb_develModel.neshoda);
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
            this.gridView1.GridControl = this.gridControlNeshody;
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
            this.Nazev.Width = 226;
            // 
            // misto
            // 
            this.misto.Caption = "Kód";
            this.misto.FieldName = "neshoda_typ.kod";
            this.misto.Name = "misto";
            this.misto.OptionsColumn.AllowEdit = false;
            this.misto.Visible = true;
            this.misto.VisibleIndex = 1;
            this.misto.Width = 35;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Počet kusů";
            this.gridColumn2.FieldName = "pocet_ks";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 65;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Zapsal";
            this.gridColumn3.FieldName = "uzivatel.celeJmeno";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 79;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Zapsáno";
            this.gridColumn4.FieldName = "d_zapsani";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 125;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Počet panelů";
            this.gridColumn1.FieldName = "pocet_panelu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 74;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Neshoda";
            this.gridColumn6.FieldName = "neshoda_typ.nazev";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 145;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Neshoda";
            this.gridColumn5.FieldName = "neshoda_typ.kod";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // frmNeshodySeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 370);
            this.Controls.Add(this.gridControlNeshody);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmNeshodySeznam";
            this.Text = "Neshody";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNeshody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neshodaBindingSource)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControlNeshody;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Nazev;
        private DevExpress.XtraGrid.Columns.GridColumn misto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource neshodaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}