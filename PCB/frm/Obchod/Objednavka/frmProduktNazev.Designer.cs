namespace PCB
{
    partial class frmProduktNazev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduktNazev));
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBarOdstranit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarZrusitFiltr = new DevExpress.XtraBars.BarButtonItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCenik = new DevExpress.XtraGrid.GridControl();
            this.objednavkapolozkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.btnZrusitFiltr = new DevExpress.XtraEditors.SimpleButton();
            this.btnVyhledat = new DevExpress.XtraEditors.SimpleButton();
            this.txtZakaznikHledej = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objednavkapolozkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaznikHledej.Properties)).BeginInit();
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
            this.gridColumn13,
            this.gridColumn15,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControlCenik;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Objednávkový název ";
            this.gridColumn7.FieldName = "nazev";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
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
            this.gridColumn1.Caption = "Název DPS (technická dokumentace)";
            this.gridColumn1.FieldName = "filtr";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 487;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Popis";
            this.gridColumn2.FieldName = "popis";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 265;
            // 
            // gridControlCenik
            // 
            this.gridControlCenik.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCenik.DataSource = this.objednavkapolozkaBindingSource;
            this.gridControlCenik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCenik.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCenik.Location = new System.Drawing.Point(0, 112);
            this.gridControlCenik.MainView = this.gridView1;
            this.gridControlCenik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCenik.Name = "gridControlCenik";
            this.gridControlCenik.Size = new System.Drawing.Size(1255, 550);
            this.gridControlCenik.TabIndex = 250;
            this.gridControlCenik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // objednavkapolozkaBindingSource
            // 
            this.objednavkapolozkaBindingSource.DataSource = typeof(pcb_develModel.objednavka_polozka);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Controls.Add(this.btnZrusitFiltr);
            this.panelControl1.Controls.Add(this.btnVyhledat);
            this.panelControl1.Controls.Add(this.txtZakaznikHledej);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1255, 112);
            this.panelControl1.TabIndex = 251;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1500, 2);
            this.label1.TabIndex = 82;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlCenik;
            this.searchControl1.Location = new System.Drawing.Point(14, 15);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlCenik;
            this.searchControl1.Size = new System.Drawing.Size(374, 22);
            this.searchControl1.TabIndex = 1;
            // 
            // btnZrusitFiltr
            // 
            this.btnZrusitFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltr.Image")));
            this.btnZrusitFiltr.Location = new System.Drawing.Point(120, 67);
            this.btnZrusitFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltr.Name = "btnZrusitFiltr";
            this.btnZrusitFiltr.Size = new System.Drawing.Size(100, 28);
            this.btnZrusitFiltr.TabIndex = 27;
            this.btnZrusitFiltr.TabStop = false;
            this.btnZrusitFiltr.Text = "Zrušit filtr";
            this.btnZrusitFiltr.Visible = false;
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.Image = ((System.Drawing.Image)(resources.GetObject("btnVyhledat.Image")));
            this.btnVyhledat.Location = new System.Drawing.Point(14, 67);
            this.btnVyhledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.Size = new System.Drawing.Size(100, 28);
            this.btnVyhledat.TabIndex = 26;
            this.btnVyhledat.TabStop = false;
            this.btnVyhledat.Text = "Vyhledat";
            this.btnVyhledat.Visible = false;
            // 
            // txtZakaznikHledej
            // 
            this.txtZakaznikHledej.Location = new System.Drawing.Point(543, 15);
            this.txtZakaznikHledej.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZakaznikHledej.Name = "txtZakaznikHledej";
            this.txtZakaznikHledej.Size = new System.Drawing.Size(226, 22);
            this.txtZakaznikHledej.TabIndex = 2;
            this.txtZakaznikHledej.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Název:";
            this.label3.Visible = false;
            // 
            // frmProduktNazev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 662);
            this.Controls.Add(this.gridControlCenik);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduktNazev";
            this.Text = "Vyhledat název";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objednavkapolozkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaznikHledej.Properties)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.GridControl gridControlCenik;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltr;
        private DevExpress.XtraEditors.SimpleButton btnVyhledat;
        private DevExpress.XtraEditors.TextEdit txtZakaznikHledej;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource objednavkapolozkaBindingSource;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Label label1;
    }
}