namespace PCB
{
    partial class frmKontrola
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kontrolaItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Level = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTiskova = new DevExpress.XtraEditors.TextEdit();
            this.txtPropustna = new DevExpress.XtraEditors.TextEdit();
            this.txtFatalni = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnCiselnikKontrol = new DevExpress.XtraEditors.SimpleButton();
            this.rbTiskova = new System.Windows.Forms.RadioButton();
            this.rbPropustne = new System.Windows.Forms.RadioButton();
            this.rbFatalni = new System.Windows.Forms.RadioButton();
            this.rbVsechny = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiskova.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPropustna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatalni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.kontrolaItemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(996, 546);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kontrolaItemBindingSource
            // 
            this.kontrolaItemBindingSource.DataSource = typeof(PCB.Data.CustomObjects.KontrolaItem);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colText,
            this.Level,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colText
            // 
            this.colText.Caption = "Text hlášení";
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.Visible = true;
            this.colText.VisibleIndex = 2;
            this.colText.Width = 1017;
            // 
            // Level
            // 
            this.Level.Caption = "Typ chyby";
            this.Level.FieldName = "Level";
            this.Level.Name = "Level";
            this.Level.Visible = true;
            this.Level.VisibleIndex = 0;
            this.Level.Width = 71;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kód";
            this.gridColumn2.FieldName = "Kod";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 93;
            // 
            // txtTiskova
            // 
            this.txtTiskova.EditValue = "0";
            this.txtTiskova.Location = new System.Drawing.Point(548, 58);
            this.txtTiskova.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiskova.Name = "txtTiskova";
            this.txtTiskova.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTiskova.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTiskova.Properties.ReadOnly = true;
            this.txtTiskova.Size = new System.Drawing.Size(39, 20);
            this.txtTiskova.TabIndex = 7;
            // 
            // txtPropustna
            // 
            this.txtPropustna.EditValue = "0";
            this.txtPropustna.Location = new System.Drawing.Point(420, 59);
            this.txtPropustna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPropustna.Name = "txtPropustna";
            this.txtPropustna.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPropustna.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPropustna.Properties.ReadOnly = true;
            this.txtPropustna.Size = new System.Drawing.Size(39, 20);
            this.txtPropustna.TabIndex = 5;
            // 
            // txtFatalni
            // 
            this.txtFatalni.EditValue = "0";
            this.txtFatalni.Location = new System.Drawing.Point(288, 59);
            this.txtFatalni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFatalni.Name = "txtFatalni";
            this.txtFatalni.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFatalni.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFatalni.Properties.ReadOnly = true;
            this.txtFatalni.Size = new System.Drawing.Size(37, 20);
            this.txtFatalni.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnUlozit);
            this.panelControl2.Controls.Add(this.btnStorno);
            this.panelControl2.Controls.Add(this.btnCiselnikKontrol);
            this.panelControl2.Controls.Add(this.txtTiskova);
            this.panelControl2.Controls.Add(this.rbTiskova);
            this.panelControl2.Controls.Add(this.rbPropustne);
            this.panelControl2.Controls.Add(this.txtPropustna);
            this.panelControl2.Controls.Add(this.rbFatalni);
            this.panelControl2.Controls.Add(this.txtFatalni);
            this.panelControl2.Controls.Add(this.rbVsechny);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(996, 101);
            this.panelControl2.TabIndex = 2;
            // 
            // btnUlozit
            // 
            this.btnUlozit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUlozit.Location = new System.Drawing.Point(829, 56);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(75, 23);
            this.btnUlozit.TabIndex = 14;
            this.btnUlozit.Text = "OK";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStorno.Location = new System.Drawing.Point(910, 56);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 23);
            this.btnStorno.TabIndex = 15;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnCiselnikKontrol
            // 
            this.btnCiselnikKontrol.Location = new System.Drawing.Point(16, 56);
            this.btnCiselnikKontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCiselnikKontrol.Name = "btnCiselnikKontrol";
            this.btnCiselnikKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnCiselnikKontrol.TabIndex = 8;
            this.btnCiselnikKontrol.Text = "Číselník chyb";
            this.btnCiselnikKontrol.Click += new System.EventHandler(this.btnCiselnikKontrol_Click);
            // 
            // rbTiskova
            // 
            this.rbTiskova.AutoSize = true;
            this.rbTiskova.Location = new System.Drawing.Point(481, 59);
            this.rbTiskova.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTiskova.Name = "rbTiskova";
            this.rbTiskova.Size = new System.Drawing.Size(61, 17);
            this.rbTiskova.TabIndex = 4;
            this.rbTiskova.Text = "Tisková";
            this.rbTiskova.UseVisualStyleBackColor = true;
            this.rbTiskova.CheckedChanged += new System.EventHandler(this.rbVsechny_CheckedChanged);
            // 
            // rbPropustne
            // 
            this.rbPropustne.AutoSize = true;
            this.rbPropustne.Location = new System.Drawing.Point(340, 59);
            this.rbPropustne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPropustne.Name = "rbPropustne";
            this.rbPropustne.Size = new System.Drawing.Size(74, 17);
            this.rbPropustne.TabIndex = 3;
            this.rbPropustne.Text = "Propustná";
            this.rbPropustne.UseVisualStyleBackColor = true;
            this.rbPropustne.CheckedChanged += new System.EventHandler(this.rbVsechny_CheckedChanged);
            // 
            // rbFatalni
            // 
            this.rbFatalni.AutoSize = true;
            this.rbFatalni.Location = new System.Drawing.Point(225, 59);
            this.rbFatalni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFatalni.Name = "rbFatalni";
            this.rbFatalni.Size = new System.Drawing.Size(57, 17);
            this.rbFatalni.TabIndex = 2;
            this.rbFatalni.Text = "Fatální";
            this.rbFatalni.UseVisualStyleBackColor = true;
            this.rbFatalni.CheckedChanged += new System.EventHandler(this.rbVsechny_CheckedChanged);
            // 
            // rbVsechny
            // 
            this.rbVsechny.AutoSize = true;
            this.rbVsechny.Checked = true;
            this.rbVsechny.Location = new System.Drawing.Point(118, 59);
            this.rbVsechny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVsechny.Name = "rbVsechny";
            this.rbVsechny.Size = new System.Drawing.Size(65, 17);
            this.rbVsechny.TabIndex = 1;
            this.rbVsechny.TabStop = true;
            this.rbVsechny.Text = "Všechny";
            this.rbVsechny.UseVisualStyleBackColor = true;
            this.rbVsechny.CheckedChanged += new System.EventHandler(this.rbVsechny_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontrola parametrů DPS";
            // 
            // frmKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 647);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmKontrola";
            this.Text = "Kontrola DPS";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiskova.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPropustna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatalni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kontrolaItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraGrid.Columns.GridColumn Level;
        private DevExpress.XtraEditors.TextEdit txtPropustna;
        private DevExpress.XtraEditors.TextEdit txtFatalni;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txtTiskova;
        private System.Windows.Forms.RadioButton rbTiskova;
        private System.Windows.Forms.RadioButton rbPropustne;
        private System.Windows.Forms.RadioButton rbFatalni;
        private System.Windows.Forms.RadioButton rbVsechny;
        private DevExpress.XtraEditors.SimpleButton btnCiselnikKontrol;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
    }
}