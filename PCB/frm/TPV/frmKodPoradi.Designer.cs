namespace PCB
{
    partial class frmKodPoradi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKodPoradi));
            this.produktpostupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprodukt_postup_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprodukt_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprodukt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpostup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnVrstvaDolu = new DevExpress.XtraEditors.SimpleButton();
            this.btnVrstvaNahoru = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnStorno = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produktpostupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // produktpostupBindingSource
            // 
            this.produktpostupBindingSource.DataSource = typeof(pcb_develModel.produkt_postup);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.produktpostupBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(587, 285);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprodukt_postup_id,
            this.colprodukt_id,
            this.colprodukt,
            this.colpostup,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colprodukt_postup_id
            // 
            this.colprodukt_postup_id.FieldName = "produkt_postup_id";
            this.colprodukt_postup_id.Name = "colprodukt_postup_id";
            // 
            // colprodukt_id
            // 
            this.colprodukt_id.FieldName = "produkt_id";
            this.colprodukt_id.Name = "colprodukt_id";
            // 
            // colprodukt
            // 
            this.colprodukt.FieldName = "produkt";
            this.colprodukt.Name = "colprodukt";
            // 
            // colpostup
            // 
            this.colpostup.Caption = "Název";
            this.colpostup.FieldName = "postup.nazev";
            this.colpostup.Name = "colpostup";
            this.colpostup.Visible = true;
            this.colpostup.VisibleIndex = 1;
            this.colpostup.Width = 482;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kód";
            this.gridColumn1.FieldName = "postup.kod";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Pořadí";
            this.gridColumn2.FieldName = "poradi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnVrstvaDolu);
            this.panelControl1.Controls.Add(this.btnVrstvaNahoru);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(587, 33);
            this.panelControl1.TabIndex = 3;
            // 
            // btnVrstvaDolu
            // 
            this.btnVrstvaDolu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnVrstvaDolu.Image = ((System.Drawing.Image)(resources.GetObject("btnVrstvaDolu.Image")));
            this.btnVrstvaDolu.Location = new System.Drawing.Point(5, 4);
            this.btnVrstvaDolu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVrstvaDolu.Name = "btnVrstvaDolu";
            this.btnVrstvaDolu.Size = new System.Drawing.Size(24, 23);
            this.btnVrstvaDolu.TabIndex = 209;
            this.btnVrstvaDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // btnVrstvaNahoru
            // 
            this.btnVrstvaNahoru.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnVrstvaNahoru.Image = ((System.Drawing.Image)(resources.GetObject("btnVrstvaNahoru.Image")));
            this.btnVrstvaNahoru.Location = new System.Drawing.Point(36, 4);
            this.btnVrstvaNahoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVrstvaNahoru.Name = "btnVrstvaNahoru";
            this.btnVrstvaNahoru.Size = new System.Drawing.Size(24, 23);
            this.btnVrstvaNahoru.TabIndex = 208;
            this.btnVrstvaNahoru.Click += new System.EventHandler(this.btnNahoru_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnStorno);
            this.panelControl2.Controls.Add(this.btnOk);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 318);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(587, 59);
            this.panelControl2.TabIndex = 4;
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(491, 18);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(84, 28);
            this.btnStorno.TabIndex = 3;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(402, 18);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmKodPoradi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 377);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKodPoradi";
            this.Text = "Kód v pořadí";
            this.Load += new System.EventHandler(this.frmKodPoradi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktpostupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource produktpostupBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colprodukt_postup_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprodukt_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprodukt;
        private DevExpress.XtraGrid.Columns.GridColumn colpostup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnVrstvaDolu;
        private DevExpress.XtraEditors.SimpleButton btnVrstvaNahoru;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.Button btnOk;
    }
}