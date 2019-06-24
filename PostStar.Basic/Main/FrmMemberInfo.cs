using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Basic.Main
{
    /// <summary>
    /// 멤버 프로필 다이얼로그
    /// </summary>
    public partial class FrmMemberInfo : PostStar.Basic.Common.FrmBaseDialog
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMemberInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 화면을 닫는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
