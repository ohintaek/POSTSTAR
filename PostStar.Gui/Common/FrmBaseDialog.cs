using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Gui.Common
{
    public partial class FrmBaseDialog : Form
    {
        public FrmBaseDialog()
        {
            InitializeComponent();
        }

        private void FrmBaseDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
