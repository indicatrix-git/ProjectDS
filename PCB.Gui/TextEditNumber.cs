using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace PCB.Gui
{
    public class TextEditNumber: DevExpress.XtraEditors.TextEdit
    {
        public TextEditNumber()
        {
            this.Properties.DisplayFormat.FormatString = "{0:0.00}";
            this.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Properties.EditFormat.FormatString = "{0:0.00}";
            this.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;

            
            this.ParseEditValue += TextEditNumber_ParseEditValue;
        }

        void TextEditNumber_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            
        }

    }
}
