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
    public partial class TerminDen : UserControl
    {
        public TerminDen()
        {
            InitializeComponent();
        }

        public TerminDen(DateTime datum, int hodiny, int maxHodin)
        {
            InitializeComponent();
            lblDatum.Text = datum.ToShortDateString();
            setValue(hodiny, maxHodin);
        }

        public TerminDen(DateTime datum, bool isVikend = false)
        {
            InitializeComponent();
            lblDatum.Text = datum.ToShortDateString();
            setValue(16, 16);
            if (isVikend)
                pbValue.BackColor = Color.DarkRed;
            else
                setValue(0, 16);
        }

        private void setValue(int h, int m)
        {
            double cWidth = pbRoot.Width;
            double hWidth = cWidth / m;
            pbValue.Width = (int)(hWidth * h);
        }
    }
}
