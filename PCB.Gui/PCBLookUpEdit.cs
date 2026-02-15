using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB.Gui
{
    public class PCBLookUpEdit : LookUpEdit
    {
        public PCBLookUpEdit()
        {
            this.KeyDown += PCBLookUpEdit_KeyDown;
        }

        void PCBLookUpEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
            {
                ((LookUpEdit)sender).EditValue = null;
                e.Handled = true;
            }
        }

    }
}
