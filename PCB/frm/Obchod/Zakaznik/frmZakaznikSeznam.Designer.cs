namespace PCB
{
    partial class frmZakaznikSeznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZakaznikSeznam));
            this.gcSeznam = new DevExpress.XtraGrid.GridControl();
            this.zakaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.misto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Interni_nazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNovy = new DevExpress.XtraBars.BarButtonItem();
            this.btnVyhledat = new DevExpress.XtraBars.BarButtonItem();
            this.btnZrusFiltr = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.btnZrusitFiltr = new DevExpress.XtraEditors.SimpleButton();
            this.btnVyhle = new DevExpress.XtraEditors.SimpleButton();
            this.txtInterniNazev = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdstranit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterniNazev.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSeznam
            // 
            this.gcSeznam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcSeznam.DataSource = this.zakaznikBindingSource;
            this.gcSeznam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSeznam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Location = new System.Drawing.Point(0, 157);
            this.gcSeznam.MainView = this.gridView1;
            this.gcSeznam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSeznam.Name = "gcSeznam";
            this.gcSeznam.Size = new System.Drawing.Size(826, 358);
            this.gcSeznam.TabIndex = 75;
            this.gcSeznam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcSeznam.DoubleClick += new System.EventHandler(this.gcSeznam_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nazev,
            this.ico,
            this.dic,
            this.misto,
            this.Interni_nazev});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gcSeznam;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Nazev, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Nazev
            // 
            this.Nazev.Caption = "Obchodní název";
            this.Nazev.FieldName = "nazev";
            this.Nazev.Name = "Nazev";
            this.Nazev.OptionsColumn.AllowEdit = false;
            this.Nazev.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.Nazev.Visible = true;
            this.Nazev.VisibleIndex = 1;
            this.Nazev.Width = 263;
            // 
            // ico
            // 
            this.ico.AppearanceCell.Options.UseTextOptions = true;
            this.ico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ico.Caption = "IČ";
            this.ico.FieldName = "ico";
            this.ico.Name = "ico";
            this.ico.OptionsColumn.AllowEdit = false;
            this.ico.Visible = true;
            this.ico.VisibleIndex = 3;
            this.ico.Width = 121;
            // 
            // dic
            // 
            this.dic.AppearanceCell.Options.UseTextOptions = true;
            this.dic.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.dic.Caption = "DIČ";
            this.dic.FieldName = "dic";
            this.dic.Name = "dic";
            this.dic.OptionsColumn.AllowEdit = false;
            this.dic.Visible = true;
            this.dic.VisibleIndex = 4;
            // 
            // misto
            // 
            this.misto.Caption = "Místo";
            this.misto.FieldName = "misto";
            this.misto.Name = "misto";
            this.misto.OptionsColumn.AllowEdit = false;
            this.misto.Visible = true;
            this.misto.VisibleIndex = 2;
            this.misto.Width = 223;
            // 
            // Interni_nazev
            // 
            this.Interni_nazev.Caption = "Interní název";
            this.Interni_nazev.FieldName = "interni_nazev";
            this.Interni_nazev.Name = "Interni_nazev";
            this.Interni_nazev.OptionsColumn.AllowEdit = false;
            this.Interni_nazev.Visible = true;
            this.Interni_nazev.VisibleIndex = 0;
            this.Interni_nazev.Width = 264;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNovy,
            this.btnVyhledat,
            this.btnZrusFiltr,
            this.btnDetail,
            this.barCheckItem1,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(826, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnNovy
            // 
            this.btnNovy.Caption = "Nový";
            this.btnNovy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovy.Glyph")));
            this.btnNovy.Id = 1;
            this.btnNovy.Name = "btnNovy";
            this.btnNovy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNovy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovy_ItemClick);
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.Caption = "Vyhledat";
            this.btnVyhledat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVyhledat.Glyph")));
            this.btnVyhledat.Id = 3;
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnVyhledat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVyhledat_ItemClick);
            // 
            // btnZrusFiltr
            // 
            this.btnZrusFiltr.Caption = "Zrušit filtr";
            this.btnZrusFiltr.Glyph = ((System.Drawing.Image)(resources.GetObject("btnZrusFiltr.Glyph")));
            this.btnZrusFiltr.Id = 4;
            this.btnZrusFiltr.Name = "btnZrusFiltr";
            this.btnZrusFiltr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.barButtonItem1.Caption = "Odstranit";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Adresář firem";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNovy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Záznam";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Zákazník";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.btnZrusitFiltr);
            this.panel1.Controls.Add(this.btnVyhle);
            this.panel1.Controls.Add(this.txtInterniNazev);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 40);
            this.panel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1714, 2);
            this.label1.TabIndex = 82;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcSeznam;
            this.searchControl1.Location = new System.Drawing.Point(82, 10);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControl1.MenuManager = this.ribbonControl1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcSeznam;
            this.searchControl1.Size = new System.Drawing.Size(300, 20);
            this.searchControl1.TabIndex = 16;
            // 
            // btnZrusitFiltr
            // 
            this.btnZrusitFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltr.Image")));
            this.btnZrusitFiltr.Location = new System.Drawing.Point(101, 52);
            this.btnZrusitFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltr.Name = "btnZrusitFiltr";
            this.btnZrusitFiltr.Size = new System.Drawing.Size(86, 20);
            this.btnZrusitFiltr.TabIndex = 15;
            this.btnZrusitFiltr.TabStop = false;
            this.btnZrusitFiltr.Text = "Zrušit filtr";
            this.btnZrusitFiltr.Visible = false;
            this.btnZrusitFiltr.Click += new System.EventHandler(this.btnZrusitFiltr_Click);
            // 
            // btnVyhle
            // 
            this.btnVyhle.Image = ((System.Drawing.Image)(resources.GetObject("btnVyhle.Image")));
            this.btnVyhle.Location = new System.Drawing.Point(10, 52);
            this.btnVyhle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyhle.Name = "btnVyhle";
            this.btnVyhle.Size = new System.Drawing.Size(86, 20);
            this.btnVyhle.TabIndex = 14;
            this.btnVyhle.TabStop = false;
            this.btnVyhle.Text = "Vyhledat";
            this.btnVyhle.Visible = false;
            this.btnVyhle.Click += new System.EventHandler(this.btnVyhle_Click);
            // 
            // txtInterniNazev
            // 
            this.txtInterniNazev.Location = new System.Drawing.Point(469, 10);
            this.txtInterniNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInterniNazev.MenuManager = this.ribbonControl1;
            this.txtInterniNazev.Name = "txtInterniNazev";
            this.txtInterniNazev.Size = new System.Drawing.Size(142, 20);
            this.txtInterniNazev.TabIndex = 3;
            this.txtInterniNazev.Visible = false;
            this.txtInterniNazev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterniNazev_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zákazník:";
            // 
            // btnOdstranit
            // 
            this.btnOdstranit.Caption = "Odstranit";
            this.btnOdstranit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOdstranit.Glyph")));
            this.btnOdstranit.Id = 2;
            this.btnOdstranit.Name = "btnOdstranit";
            this.btnOdstranit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // frmZakaznikSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 515);
            this.Controls.Add(this.gcSeznam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmZakaznikSeznam";
            this.Text = "Adresář zákazníků seznam ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmZakaznikSeznam_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcSeznam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterniNazev.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSeznam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnNovy;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnVyhledat;
        private DevExpress.XtraBars.BarButtonItem btnZrusFiltr;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private System.Windows.Forms.BindingSource zakaznikBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn Nazev;
        private DevExpress.XtraGrid.Columns.GridColumn ico;
        private DevExpress.XtraGrid.Columns.GridColumn dic;
        private DevExpress.XtraGrid.Columns.GridColumn misto;
        private DevExpress.XtraGrid.Columns.GridColumn Interni_nazev;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtInterniNazev;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarButtonItem btnOdstranit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltr;
        private DevExpress.XtraEditors.SimpleButton btnVyhle;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Label label1;
    }
}