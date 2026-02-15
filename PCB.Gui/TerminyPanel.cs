using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB.Gui
{
    public partial class TerminyPanel : UserControl
    {
        public TerminyPanel()
        {
            InitializeComponent();
        }

        public void Add(TerminDen td)
        {
            td.Width = 294;
            td.Height = 17;
            td.Left = 0;
            td.Top = GetCountControls() * td.Height;
            td.Visible = true;
            panel.Controls.Add(td);
        }

        private int GetCountControls()
        {
            return panel.Controls.Count;
        }

        private void panel_BindingContextChanged(object sender, EventArgs e)
        {

        }
    }
}
