namespace PCB
{
    partial class frmCiselnikVet
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            this.vetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbVety = new PCB.Gui.CheckBoxButtonList();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(493, 502);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(599, 503);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 27);
            this.btnStorno.TabIndex = 1;
            this.btnStorno.TabStop = false;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // vetaBindingSource
            // 
            this.vetaBindingSource.DataSource = typeof(pcb_develModel.veta);
            // 
            // cbVety
            // 
            this.cbVety.Location = new System.Drawing.Point(1, 1);
            this.cbVety.Name = "cbVety";
            this.cbVety.RadioButtonMode = false;
            this.cbVety.ShowColumnsCode = false;
            this.cbVety.Size = new System.Drawing.Size(710, 471);
            this.cbVety.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 2);
            this.label1.TabIndex = 82;
            // 
            // frmCiselnikVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVety);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOK);
            this.Name = "frmCiselnikVet";
            this.Text = "Věty";
            this.Load += new System.EventHandler(this.frmCiselnikVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.BindingSource vetaBindingSource;
        private Gui.CheckBoxButtonList cbVety;
        private System.Windows.Forms.Label label1;
    }
}