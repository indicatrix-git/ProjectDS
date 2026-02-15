namespace PCB
{
    partial class frmSpecialniPostupDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecialniPostupDetail));
            this.btnStorno = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlozit = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.specialnipostupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.operaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOperace = new System.Windows.Forms.Label();
            this.txtOperace = new DevExpress.XtraEditors.TextEdit();
            this.btnZvolitOperaci = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnipostupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperace.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStorno
            // 
            this.btnStorno.Image = ((System.Drawing.Image)(resources.GetObject("btnStorno.Image")));
            this.btnStorno.Location = new System.Drawing.Point(511, 332);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 28);
            this.btnStorno.TabIndex = 13;
            this.btnStorno.Text = "Storno";
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btnUlozit.Image")));
            this.btnUlozit.Location = new System.Drawing.Point(405, 332);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 28);
            this.btnUlozit.TabIndex = 12;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnipostupBindingSource, "technologicka_poznamka", true));
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(12, 69);
            this.memoEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(599, 231);
            this.memoEdit1.TabIndex = 11;
            // 
            // specialnipostupBindingSource
            // 
            this.specialnipostupBindingSource.DataSource = typeof(pcb_develModel.specialni_postup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Poznámka:";
            // 
            // operaceBindingSource
            // 
            this.operaceBindingSource.DataSource = typeof(pcb_develModel.operace);
            // 
            // lblOperace
            // 
            this.lblOperace.AutoSize = true;
            this.lblOperace.Location = new System.Drawing.Point(12, 15);
            this.lblOperace.Name = "lblOperace";
            this.lblOperace.Size = new System.Drawing.Size(64, 17);
            this.lblOperace.TabIndex = 8;
            this.lblOperace.Text = "Operace:";
            // 
            // txtOperace
            // 
            this.txtOperace.Location = new System.Drawing.Point(82, 12);
            this.txtOperace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOperace.Name = "txtOperace";
            this.txtOperace.Properties.ReadOnly = true;
            this.txtOperace.Size = new System.Drawing.Size(464, 22);
            this.txtOperace.TabIndex = 14;
            // 
            // btnZvolitOperaci
            // 
            this.btnZvolitOperaci.Location = new System.Drawing.Point(563, 9);
            this.btnZvolitOperaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZvolitOperaci.Name = "btnZvolitOperaci";
            this.btnZvolitOperaci.Size = new System.Drawing.Size(48, 28);
            this.btnZvolitOperaci.TabIndex = 15;
            this.btnZvolitOperaci.Text = "...";
            this.btnZvolitOperaci.Click += new System.EventHandler(this.btnZvolitOperaci_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 2);
            this.label2.TabIndex = 82;
            // 
            // frmSpecialniPostupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.btnZvolitOperaci);
            this.Controls.Add(this.txtOperace);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperace);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnipostupBindingSource, "technologicka_poznamka", true));
            this.Name = "frmSpecialniPostupDetail";
            this.Text = "Speciální postup";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnipostupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperace.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStorno;
        private DevExpress.XtraEditors.SimpleButton btnUlozit;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperace;
        private System.Windows.Forms.BindingSource operaceBindingSource;
        private System.Windows.Forms.BindingSource specialnipostupBindingSource;
        private DevExpress.XtraEditors.TextEdit txtOperace;
        private DevExpress.XtraEditors.SimpleButton btnZvolitOperaci;
        private System.Windows.Forms.Label label2;
    }
}