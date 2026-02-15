namespace PCB
{
    partial class frmCiselnikChyb
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kontrolaBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkontrola_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpopis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoznamka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfatalni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltiskova = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaktivni = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.kontrolaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(865, 639);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kontrolaBindingSource
            // 
            this.kontrolaBindingSource.DataSource = typeof(pcb_develModel.kontrola);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkontrola_id,
            this.colpopis,
            this.colpoznamka,
            this.colfatalni,
            this.coltiskova,
            this.colaktivni});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colkontrola_id
            // 
            this.colkontrola_id.Caption = "ID";
            this.colkontrola_id.FieldName = "kontrola_id";
            this.colkontrola_id.Name = "colkontrola_id";
            this.colkontrola_id.Visible = true;
            this.colkontrola_id.VisibleIndex = 0;
            this.colkontrola_id.Width = 82;
            // 
            // colpopis
            // 
            this.colpopis.Caption = "Popis";
            this.colpopis.FieldName = "popis";
            this.colpopis.Name = "colpopis";
            this.colpopis.Visible = true;
            this.colpopis.VisibleIndex = 1;
            this.colpopis.Width = 562;
            // 
            // colpoznamka
            // 
            this.colpoznamka.Caption = "Poznámka";
            this.colpoznamka.FieldName = "poznamka";
            this.colpoznamka.Name = "colpoznamka";
            this.colpoznamka.Visible = true;
            this.colpoznamka.VisibleIndex = 2;
            this.colpoznamka.Width = 144;
            // 
            // colfatalni
            // 
            this.colfatalni.AppearanceHeader.Options.UseTextOptions = true;
            this.colfatalni.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfatalni.Caption = "F";
            this.colfatalni.FieldName = "fatalni";
            this.colfatalni.Name = "colfatalni";
            this.colfatalni.Visible = true;
            this.colfatalni.VisibleIndex = 3;
            this.colfatalni.Width = 51;
            // 
            // coltiskova
            // 
            this.coltiskova.AppearanceHeader.Options.UseTextOptions = true;
            this.coltiskova.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltiskova.Caption = "T";
            this.coltiskova.FieldName = "tiskova";
            this.coltiskova.Name = "coltiskova";
            this.coltiskova.Visible = true;
            this.coltiskova.VisibleIndex = 4;
            this.coltiskova.Width = 60;
            // 
            // colaktivni
            // 
            this.colaktivni.AppearanceHeader.Options.UseTextOptions = true;
            this.colaktivni.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaktivni.Caption = "Aktivní";
            this.colaktivni.FieldName = "aktivni";
            this.colaktivni.Name = "colaktivni";
            this.colaktivni.Visible = true;
            this.colaktivni.VisibleIndex = 5;
            this.colaktivni.Width = 72;
            // 
            // frmCiselnikChyb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 639);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCiselnikChyb";
            this.Text = "Číselník chyb";
            this.Load += new System.EventHandler(this.frmCiselnikChyb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kontrolaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colkontrola_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpopis;
        private DevExpress.XtraGrid.Columns.GridColumn colpoznamka;
        private DevExpress.XtraGrid.Columns.GridColumn colfatalni;
        private DevExpress.XtraGrid.Columns.GridColumn coltiskova;
        private DevExpress.XtraGrid.Columns.GridColumn colaktivni;
    }
}