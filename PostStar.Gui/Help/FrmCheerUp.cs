using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Gui.Help
{
    public partial class FrmCheerUp : Form
    {
        public FrmCheerUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 확인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
