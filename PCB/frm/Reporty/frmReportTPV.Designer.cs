namespace PCB.frm.Reporty
{
    partial class frmReportTPV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportTPV));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiObnovit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.rpMenuTPV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpObdobi = new System.Windows.Forms.GroupBox();
            this.lblObdobiDo = new System.Windows.Forms.Label();
            this.lblObdobiOd = new System.Windows.Forms.Label();
            this.deObdobiDo = new DevExpress.XtraEditors.DateEdit();
            this.deObdobiOd = new DevExpress.XtraEditors.DateEdit();
            this.btnZrusitFiltr = new DevExpress.XtraEditors.SimpleButton();
            this.btnVyhledat = new DevExpress.XtraEditors.SimpleButton();
            this.gcReportTPV = new DevExpress.XtraGrid.GridControl();
            this.bsReportTPV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypVyrobyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypVyrobyNazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDruhTerminuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDruhTerminuNazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSestavilId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSestavil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProblemovaData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZakaznikId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZakaznikNazev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypDeskyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypDeskyNazev = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpObdobi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiOd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportTPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportTPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiObnovit,
            this.barButtonGroup1,
            this.bbiExport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMenuTPV});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1290, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiObnovit
            // 
            this.bbiObnovit.Caption = "Obnovit seznam";
            this.bbiObnovit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiObnovit.Glyph")));
            this.bbiObnovit.Id = 3;
            this.bbiObnovit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiObnovit.LargeGlyph")));
            this.bbiObnovit.Name = "bbiObnovit";
            this.bbiObnovit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiObnovit_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 4;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export do XLS";
            this.bbiExport.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExport.Glyph")));
            this.bbiExport.Id = 5;
            this.bbiExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExport.LargeGlyph")));
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // rpMenuTPV
            // 
            this.rpMenuTPV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMenu});
            this.rpMenuTPV.Name = "rpMenuTPV";
            this.rpMenuTPV.Text = "Menu";
            // 
            // rpgMenu
            // 
            this.rpgMenu.ItemLinks.Add(this.bbiExport);
            this.rpgMenu.ItemLinks.Add(this.bbiObnovit);
            this.rpgMenu.Name = "rpgMenu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpObdobi);
            this.panel1.Controls.Add(this.btnZrusitFiltr);
            this.panel1.Controls.Add(this.btnVyhledat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 124);
            this.panel1.TabIndex = 1;
            // 
            // grpObdobi
            // 
            this.grpObdobi.Controls.Add(this.lblObdobiDo);
            this.grpObdobi.Controls.Add(this.lblObdobiOd);
            this.grpObdobi.Controls.Add(this.deObdobiDo);
            this.grpObdobi.Controls.Add(this.deObdobiOd);
            this.grpObdobi.Location = new System.Drawing.Point(12, 6);
            this.grpObdobi.Name = "grpObdobi";
            this.grpObdobi.Size = new System.Drawing.Size(250, 80);
            this.grpObdobi.TabIndex = 87;
            this.grpObdobi.TabStop = false;
            this.grpObdobi.Text = "Objednávka";
            // 
            // lblObdobiDo
            // 
            this.lblObdobiDo.AutoSize = true;
            this.lblObdobiDo.Location = new System.Drawing.Point(8, 49);
            this.lblObdobiDo.Name = "lblObdobiDo";
            this.lblObdobiDo.Size = new System.Drawing.Size(60, 13);
            this.lblObdobiDo.TabIndex = 89;
            this.lblObdobiDo.Text = "Období do:";
            // 
            // lblObdobiOd
            // 
            this.lblObdobiOd.AutoSize = true;
            this.lblObdobiOd.Location = new System.Drawing.Point(8, 23);
            this.lblObdobiOd.Name = "lblObdobiOd";
            this.lblObdobiOd.Size = new System.Drawing.Size(60, 13);
            this.lblObdobiOd.TabIndex = 88;
            this.lblObdobiOd.Text = "Období od:";
            // 
            // deObdobiDo
            // 
            this.deObdobiDo.EditValue = null;
            this.deObdobiDo.Location = new System.Drawing.Point(74, 46);
            this.deObdobiDo.MenuManager = this.ribbonControl1;
            this.deObdobiDo.Name = "deObdobiDo";
            this.deObdobiDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deObdobiDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deObdobiDo.Size = new System.Drawing.Size(160, 20);
            this.deObdobiDo.TabIndex = 87;
            // 
            // deObdobiOd
            // 
            this.deObdobiOd.EditValue = null;
            this.deObdobiOd.Location = new System.Drawing.Point(74, 20);
            this.deObdobiOd.MenuManager = this.ribbonControl1;
            this.deObdobiOd.Name = "deObdobiOd";
            this.deObdobiOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deObdobiOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deObdobiOd.Size = new System.Drawing.Size(160, 20);
            this.deObdobiOd.TabIndex = 86;
            // 
            // btnZrusitFiltr
            // 
            this.btnZrusitFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btnZrusitFiltr.Image")));
            this.btnZrusitFiltr.Location = new System.Drawing.Point(103, 91);
            this.btnZrusitFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZrusitFiltr.Name = "btnZrusitFiltr";
            this.btnZrusitFiltr.Size = new System.Drawing.Size(86, 23);
            this.btnZrusitFiltr.TabIndex = 85;
            this.btnZrusitFiltr.TabStop = false;
            this.btnZrusitFiltr.Text = "Zrušit filtr";
            this.btnZrusitFiltr.Click += new System.EventHandler(this.btnZrusitFiltr_Click);
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.Image = ((System.Drawing.Image)(resources.GetObject("btnVyhledat.Image")));
            this.btnVyhledat.Location = new System.Drawing.Point(11, 91);
            this.btnVyhledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.Size = new System.Drawing.Size(86, 23);
            this.btnVyhledat.TabIndex = 84;
            this.btnVyhledat.TabStop = false;
            this.btnVyhledat.Text = "Vyhledat";
            this.btnVyhledat.Click += new System.EventHandler(this.btnVyhledat_Click);
            // 
            // gcReportTPV
            // 
            this.gcReportTPV.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcReportTPV.DataSource = this.bsReportTPV;
            this.gcReportTPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReportTPV.Location = new System.Drawing.Point(0, 220);
            this.gcReportTPV.MainView = this.gridView1;
            this.gcReportTPV.MenuManager = this.ribbonControl1;
            this.gcReportTPV.Name = "gcReportTPV";
            this.gcReportTPV.Size = new System.Drawing.Size(1290, 507);
            this.gcReportTPV.TabIndex = 2;
            this.gcReportTPV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypVyrobyId,
            this.colTypVyrobyNazev,
            this.colDruhTerminuId,
            this.colDruhTerminuNazev,
            this.colKod,
            this.colSestavilId,
            this.colSestavil,
            this.colProblemovaData,
            this.colZakaznikId,
            this.colZakaznikNazev,
            this.colTypDeskyId,
            this.colTypDeskyNazev});
            this.gridView1.GridControl = this.gcReportTPV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colTypVyrobyId
            // 
            this.colTypVyrobyId.FieldName = "TypVyrobyId";
            this.colTypVyrobyId.Name = "colTypVyrobyId";
            // 
            // colTypVyrobyNazev
            // 
            this.colTypVyrobyNazev.Caption = "Typ výroby";
            this.colTypVyrobyNazev.FieldName = "TypVyrobyNazev";
            this.colTypVyrobyNazev.Name = "colTypVyrobyNazev";
            this.colTypVyrobyNazev.Visible = true;
            this.colTypVyrobyNazev.VisibleIndex = 0;
            this.colTypVyrobyNazev.Width = 212;
            // 
            // colDruhTerminuId
            // 
            this.colDruhTerminuId.FieldName = "DruhTerminuId";
            this.colDruhTerminuId.Name = "colDruhTerminuId";
            // 
            // colDruhTerminuNazev
            // 
            this.colDruhTerminuNazev.Caption = "Druh termínu";
            this.colDruhTerminuNazev.FieldName = "DruhTerminuNazev";
            this.colDruhTerminuNazev.Name = "colDruhTerminuNazev";
            this.colDruhTerminuNazev.Visible = true;
            this.colDruhTerminuNazev.VisibleIndex = 1;
            this.colDruhTerminuNazev.Width = 212;
            // 
            // colKod
            // 
            this.colKod.Caption = "Kód";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 2;
            this.colKod.Width = 212;
            // 
            // colSestavilId
            // 
            this.colSestavilId.FieldName = "SestavilId";
            this.colSestavilId.Name = "colSestavilId";
            // 
            // colSestavil
            // 
            this.colSestavil.Caption = "Sestavil";
            this.colSestavil.FieldName = "Sestavil";
            this.colSestavil.Name = "colSestavil";
            this.colSestavil.Visible = true;
            this.colSestavil.VisibleIndex = 3;
            this.colSestavil.Width = 278;
            // 
            // colProblemovaData
            // 
            this.colProblemovaData.Caption = "Problémová data";
            this.colProblemovaData.FieldName = "ProblemovaData";
            this.colProblemovaData.Name = "colProblemovaData";
            this.colProblemovaData.Visible = true;
            this.colProblemovaData.VisibleIndex = 4;
            this.colProblemovaData.Width = 179;
            // 
            // colZakaznikId
            // 
            this.colZakaznikId.FieldName = "ZakaznikId";
            this.colZakaznikId.Name = "colZakaznikId";
            // 
            // colZakaznikNazev
            // 
            this.colZakaznikNazev.Caption = "Zákazník";
            this.colZakaznikNazev.FieldName = "ZakaznikNazev";
            this.colZakaznikNazev.Name = "colZakaznikNazev";
            this.colZakaznikNazev.Visible = true;
            this.colZakaznikNazev.VisibleIndex = 5;
            this.colZakaznikNazev.Width = 179;
            // 
            // colTypDeskyId
            // 
            this.colTypDeskyId.FieldName = "TypDeskyId";
            this.colTypDeskyId.Name = "colTypDeskyId";
            // 
            // colTypDeskyNazev
            // 
            this.colTypDeskyNazev.FieldName = "TypDeskyNazev";
            this.colTypDeskyNazev.Name = "colTypDeskyNazev";
            // 
            // frmReportTPV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 727);
            this.Controls.Add(this.gcReportTPV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmReportTPV";
            this.Text = "Report TPV";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpObdobi.ResumeLayout(false);
            this.grpObdobi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deObdobiOd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportTPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportTPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMenuTPV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMenu;
        private DevExpress.XtraBars.BarButtonItem bbiObnovit;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcReportTPV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnZrusitFiltr;
        private DevExpress.XtraEditors.SimpleButton btnVyhledat;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraEditors.DateEdit deObdobiOd;
        private System.Windows.Forms.BindingSource bsReportTPV;
        private System.Windows.Forms.GroupBox grpObdobi;
        private System.Windows.Forms.Label lblObdobiOd;
        private DevExpress.XtraEditors.DateEdit deObdobiDo;
        private System.Windows.Forms.Label lblObdobiDo;
        private DevExpress.XtraGrid.Columns.GridColumn colTypVyrobyId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypVyrobyNazev;
        private DevExpress.XtraGrid.Columns.GridColumn colDruhTerminuId;
        private DevExpress.XtraGrid.Columns.GridColumn colDruhTerminuNazev;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colSestavilId;
        private DevExpress.XtraGrid.Columns.GridColumn colSestavil;
        private DevExpress.XtraGrid.Columns.GridColumn colProblemovaData;
        private DevExpress.XtraGrid.Columns.GridColumn colZakaznikId;
        private DevExpress.XtraGrid.Columns.GridColumn colZakaznikNazev;
        private DevExpress.XtraGrid.Columns.GridColumn colTypDeskyId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypDeskyNazev;
    }
}