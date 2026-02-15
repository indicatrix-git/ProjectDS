using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PCB.Gui
{
    public partial class IconHolder : UserControl
    {
        public event Action _PridatOnClick;
        public event Action _DetailOnClick;
        public event Action _SmazatOnClick;

        public bool VisiblePridat { get { return btnPridat.Visible; } set { btnPridat.Visible = value; } }
        public bool VisibleOdstranit { get { return btnOdstranit.Visible; } set { btnOdstranit.Visible = value; } }
        public bool VisibleDetail { get { return btnDetail.Visible; } set { btnDetail.Visible = value; } }
        
        private int xPosition = 0;
        public IconHolder()
        {
            InitializeComponent();
        }
                
        private void btnPridat_Click(object sender, EventArgs e)
        {
            var eh = _PridatOnClick;
            if (eh != null)
                eh();
        }

        private void btnOdstranit_Click(object sender, EventArgs e)
        {
            var eh = _SmazatOnClick;
            if (eh != null)
                eh();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var eh = _DetailOnClick;
            if (eh != null)
                eh();
        }
                
    }
}
