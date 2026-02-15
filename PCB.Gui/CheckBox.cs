using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Gui
{
    public class CheckBox : CheckEdit
    {
        
    
        public CheckBox()
        {
            this.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.Properties.PictureChecked = global::PCB.Gui.Properties.Resources.checked_checkbox;
            this.Properties.PictureUnchecked = global::PCB.Gui.Properties.Resources.unchecked_checkbox;
            this.Properties.PictureGrayed = global::PCB.Gui.Properties.Resources.unchecked_checkbox;
            
            this.Properties.AutoWidth = true;
        }

        private void InitializeComponent()
        {
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Name = "fProperties";
            // 
            // CheckBox
            // 
            this.Size = new System.Drawing.Size(75, 20);
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
