using PCB.Data.CustomObjects;
namespace PCB
{
    partial class frmKapacitaVyroby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKapacitaVyroby));
            this.gridControlKapacVyroby = new DevExpress.XtraGrid.GridControl();
            this.kapacitaTabulkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemProgressBar3 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbExpress = new System.Windows.Forms.RadioButton();
            this.rbStandart = new System.Windows.Forms.RadioButton();
            this.btnZobrazit = new DevExpress.XtraEditors.SimpleButton();
            this.deDo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deOd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKapacVyroby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapacitaTabulkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deOd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deOd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKapacVyroby
            // 
            this.gridControlKapacVyroby.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlKapacVyroby.DataSource = this.kapacitaTabulkaBindingSource;
            this.gridControlKapacVyroby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKapacVyroby.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlKapacVyroby.Location = new System.Drawing.Point(0, 173);
            this.gridControlKapacVyroby.MainView = this.gridView4;
            this.gridControlKapacVyroby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlKapacVyroby.Name = "gridControlKapacVyroby";
            this.gridControlKapacVyroby.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemProgressBar2,
            this.repositoryItemProgressBar3});
            this.gridControlKapacVyroby.Size = new System.Drawing.Size(988, 307);
            this.gridControlKapacVyroby.TabIndex = 269;
            this.gridControlKapacVyroby.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // kapacitaTabulkaBindingSource
            // 
            this.kapacitaTabulkaBindingSource.DataSource = typeof(PCB.Data.CustomObjects.KapacitaRow);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14,
            this.gridColumn5,
            this.gridColumn16,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gcDen});
            this.gridView4.GridControl = this.gridControlKapacVyroby;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView4_RowCellStyle);
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gridColumn14.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn14.Caption = "Datum";
            this.gridColumn14.FieldName = "Datum";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 129;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.gridColumn5.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gridColumn5.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn5.Caption = "Jednostranný";
            this.gridColumn5.DisplayFormat.FormatString = "{0:0.00}";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Jednostranky";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 117;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.gridColumn16.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn16.AppearanceHeader.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gridColumn16.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn16.Caption = "%";
            this.gridColumn16.DisplayFormat.FormatString = "{0:00.00}";
            this.gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn16.FieldName = "JednostrankyProcento";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 3;
            this.gridColumn16.Width = 107;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.LightGray;
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Green;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "Vícevrstvé";
            this.gridColumn1.DisplayFormat.FormatString = "{0:0.00}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "Vicevrstve";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 84;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Moccasin;
            this.gridColumn3.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "%";
            this.gridColumn3.DisplayFormat.FormatString = "{0:00.00}";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "OboustrankyProcento";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Moccasin;
            this.gridColumn4.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "Oboustranný";
            this.gridColumn4.DisplayFormat.FormatString = "{0:0.00}";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Oboustranky";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 102;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.BackColor = System.Drawing.Color.LightGray;
            this.gridColumn6.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Green;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "%";
            this.gridColumn6.DisplayFormat.FormatString = "{0:0.00}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "VicevrstveProcento";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 126;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 197;
            // 
            // gcDen
            // 
            this.gcDen.Caption = "Den";
            this.gcDen.FieldName = "Den";
            this.gcDen.Name = "gcDen";
            this.gcDen.Visible = true;
            this.gcDen.VisibleIndex = 0;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // repositoryItemProgressBar2
            // 
            this.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2";
            this.repositoryItemProgressBar2.ShowTitle = true;
            // 
            // repositoryItemProgressBar3
            // 
            this.repositoryItemProgressBar3.Name = "repositoryItemProgressBar3";
            this.repositoryItemProgressBar3.ShowTitle = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "%";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.rbExpress);
            this.panelControl1.Controls.Add(this.rbStandart);
            this.panelControl1.Controls.Add(this.btnZobrazit);
            this.panelControl1.Controls.Add(this.deDo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.deOd);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(988, 173);
            this.panelControl1.TabIndex = 270;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2000, 2);
            this.label2.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kapacita výroby";
            // 
            // rbExpress
            // 
            this.rbExpress.AutoSize = true;
            this.rbExpress.Location = new System.Drawing.Point(567, 79);
            this.rbExpress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbExpress.Name = "rbExpress";
            this.rbExpress.Size = new System.Drawing.Size(157, 21);
            this.rbExpress.TabIndex = 6;
            this.rbExpress.Text = "Express / Poloexpres";
            this.rbExpress.UseVisualStyleBackColor = true;
            // 
            // rbStandart
            // 
            this.rbStandart.AutoSize = true;
            this.rbStandart.Location = new System.Drawing.Point(460, 79);
            this.rbStandart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbStandart.Name = "rbStandart";
            this.rbStandart.Size = new System.Drawing.Size(82, 21);
            this.rbStandart.TabIndex = 5;
            this.rbStandart.Text = "Standart";
            this.rbStandart.UseVisualStyleBackColor = true;
            // 
            // btnZobrazit
            // 
            this.btnZobrazit.Image = ((System.Drawing.Image)(resources.GetObject("btnZobrazit.Image")));
            this.btnZobrazit.Location = new System.Drawing.Point(12, 130);
            this.btnZobrazit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZobrazit.Name = "btnZobrazit";
            this.btnZobrazit.Size = new System.Drawing.Size(100, 28);
            this.btnZobrazit.TabIndex = 4;
            this.btnZobrazit.TabStop = false;
            this.btnZobrazit.Text = "Zobrazit";
            this.btnZobrazit.Click += new System.EventHandler(this.btnZobrazit_Click);
            // 
            // deDo
            // 
            this.deDo.EditValue = null;
            this.deDo.Location = new System.Drawing.Point(241, 78);
            this.deDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deDo.Name = "deDo";
            this.deDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDo.Size = new System.Drawing.Size(162, 22);
            this.deDo.TabIndex = 3;
            this.deDo.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(216, 80);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Do:";
            // 
            // deOd
            // 
            this.deOd.EditValue = null;
            this.deOd.Location = new System.Drawing.Point(38, 78);
            this.deOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deOd.Name = "deOd";
            this.deOd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deOd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deOd.Size = new System.Drawing.Size(162, 22);
            this.deOd.TabIndex = 1;
            this.deOd.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 80);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Od:";
            // 
            // frmKapacitaVyroby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 480);
            this.Controls.Add(this.gridControlKapacVyroby);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKapacitaVyroby";
            this.Text = "Kapacita výroby";
            this.Load += new System.EventHandler(this.frmKapacitaVyroby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKapacVyroby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapacitaTabulkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deOd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deOd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKapacVyroby;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private System.Windows.Forms.BindingSource kapacitaTabulkaBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnZobrazit;
        private DevExpress.XtraEditors.DateEdit deDo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deOd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.RadioButton rbExpress;
        private System.Windows.Forms.RadioButton rbStandart;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar3;
        private DevExpress.XtraGrid.Columns.GridColumn gcDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}