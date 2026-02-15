using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Gui
{
    public class RepositoryCheckBox : RepositoryItemCheckEdit
    {
        public RepositoryCheckBox()
        {
            this.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.PictureChecked = global::PCB.Gui.Properties.Resources.checked_checkbox;
            this.PictureUnchecked = global::PCB.Gui.Properties.Resources.unchecked_checkbox;
        }
    }
}
