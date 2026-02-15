namespace PCB
{
    partial class frmPruvodkaOpravna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruvodkaOpravna));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPocetKusu = new DevExpress.XtraEditors.TextEdit();
            this.btnVytisknout = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdstranitZmenyDPS = new DevExpress.XtraEditors.SimpleButton();
            this.btnZmenaNovy = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOperace = new DevExpress.XtraGrid.GridControl();
            this.operaceopravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.txtCisloPruvodky = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPocetKusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaceopravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCisloPruvodky.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Počet kusů:";
            // 
            // txtPocetKusu
            // 
            this.txtPocetKusu.Location = new System.Drawing.Point(111, 43);
            this.txtPocetKusu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPocetKusu.Name = "txtPocetKusu";
            this.txtPocetKusu.Properties.Mask.EditMask = "d";
            this.txtPocetKusu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPocetKusu.Size = new System.Drawing.Size(83, 22);
            this.txtPocetKusu.TabIndex = 2;
            // 
            // btnVytisknout
            // 
            this.btnVytisknout.Image = ((System.Drawing.Image)(resources.GetObject("btnVytisknout.Image")));
            this.btnVytisknout.Location = new System.Drawing.Point(531, 402);
            this.btnVytisknout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVytisknout.Name = "btnVytisknout";
            this.btnVytisknout.Size = new System.Drawing.Size(100, 28);
            this.btnVytisknout.TabIndex = 2;
            this.btnVytisknout.TabStop = false;
            this.btnVytisknout.Text = "Tisk";
            this.btnVytisknout.Click += new System.EventHandler(this.btnVytisknout_Click);
            // 
            // btnOdstranitZmenyDPS
            // 
            this.btnOdstranitZmenyDPS.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOdstranitZmenyDPS.Image = ((System.Drawing.Image)(resources.GetObject("btnOdstranitZmenyDPS.Image")));
            this.btnOdstranitZmenyDPS.Location = new System.Drawing.Point(35, 86);
            this.btnOdstranitZmenyDPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdstranitZmenyDPS.Name = "btnOdstranitZmenyDPS";
            this.btnOdstranitZmenyDPS.Size = new System.Drawing.Size(24, 23);
            this.btnOdstranitZmenyDPS.TabIndex = 217;
            this.btnOdstranitZmenyDPS.ToolTip = "Odebrat";
            // 
            // btnZmenaNovy
            // 
            this.btnZmenaNovy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnZmenaNovy.Image = ((System.Drawing.Image)(resources.GetObject("btnZmenaNovy.Image")));
            this.btnZmenaNovy.Location = new System.Drawing.Point(3, 86);
            this.btnZmenaNovy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZmenaNovy.Name = "btnZmenaNovy";
            this.btnZmenaNovy.Size = new System.Drawing.Size(24, 23);
            this.btnZmenaNovy.TabIndex = 216;
            this.btnZmenaNovy.ToolTip = "Přidat";
            this.btnZmenaNovy.Click += new System.EventHandler(this.btnZmenaNovy_Click);
            // 
            // gridControlOperace
            // 
            this.gridControlOperace.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlOperace.DataSource = this.operaceopravaBindingSource;
            this.gridControlOperace.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlOperace.Location = new System.Drawing.Point(3, 114);
            this.gridControlOperace.MainView = this.gridView5;
            this.gridControlOperace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlOperace.Name = "gridControlOperace";
            this.gridControlOperace.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlOperace.Size = new System.Drawing.Size(745, 256);
            this.gridControlOperace.TabIndex = 218;
            this.gridControlOperace.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // operaceopravaBindingSource
            // 
            this.operaceopravaBindingSource.DataSource = typeof(pcb_develModel.operace_oprava);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn27});
            this.gridView5.GridControl = this.gridControlOperace;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Kód operace";
            this.gridColumn17.FieldName = "operace.KodNazev";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 91;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Odepisovat";
            this.gridColumn27.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn27.FieldName = "odepisovat";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Width = 198;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(637, 402);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 219;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // txtCisloPruvodky
            // 
            this.txtCisloPruvodky.Location = new System.Drawing.Point(111, 14);
            this.txtCisloPruvodky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCisloPruvodky.Name = "txtCisloPruvodky";
            this.txtCisloPruvodky.Size = new System.Drawing.Size(175, 22);
            this.txtCisloPruvodky.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 17);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 16);
            this.labelControl2.TabIndex = 220;
            this.labelControl2.Text = "Číslo průvodky:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 387);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 2);
            this.label1.TabIndex = 221;
            // 
            // frmPruvodkaOpravna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCisloPruvodky);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.gridControlOperace);
            this.Controls.Add(this.btnOdstranitZmenyDPS);
            this.Controls.Add(this.btnZmenaNovy);
            this.Controls.Add(this.btnVytisknout);
            this.Controls.Add(this.txtPocetKusu);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPruvodkaOpravna";
            this.Text = "Opravná průvodka";
            ((System.ComponentModel.ISupportInitialize)(this.txtPocetKusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaceopravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCisloPruvodky.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPocetKusu;
        private DevExpress.XtraEditors.SimpleButton btnVytisknout;
        private DevExpress.XtraEditors.SimpleButton btnOdstranitZmenyDPS;
        private DevExpress.XtraEditors.SimpleButton btnZmenaNovy;
        private DevExpress.XtraGrid.GridControl gridControlOperace;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private System.Windows.Forms.BindingSource operaceopravaBindingSource;
        private DevExpress.XtraEditors.TextEdit txtCisloPruvodky;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
    }
}