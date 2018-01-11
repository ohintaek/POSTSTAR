﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Gui.Common
{
    /// <summary>
    /// Base Dialog Form
    /// </summary>
    public partial class FrmBaseDialog : Form
    {
        /// <summary>
        /// Contrsructor
        /// </summary>
        public FrmBaseDialog()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        /// <summary>
        /// Key Down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
