using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Basic.Help
{
    public partial class FrmBugReport : PostStar.Basic.Common.FrmPopupBaseDialog
    {
        public FrmBugReport()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 창을 닫는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 버그리포트를 개발센터로 보낸다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
