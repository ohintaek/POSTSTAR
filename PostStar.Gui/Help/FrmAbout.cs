using PostStar.Gui.Common;
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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 응원하기 다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheerUp_Click(object sender, EventArgs e)
        {
            FrmCheerUp frmCheerUp = new FrmCheerUp();
            frmCheerUp.StartPosition = FormStartPosition.CenterScreen;
            frmCheerUp.ShowDialog();

        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 라이센스 고지 다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLicenseNote frmLicenseNote = new FrmLicenseNote();
            frmLicenseNote.StartPosition = FormStartPosition.CenterScreen;
            frmLicenseNote.ShowDialog();
        }

        /// <summary>
        /// 버그 알려주기 다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendBugReport_Click(object sender, EventArgs e)
        {
            FrmBugReport frmBugReport = new FrmBugReport();
            frmBugReport.StartPosition = FormStartPosition.CenterScreen;
            frmBugReport.ShowDialog();
        }

        /// <summary>
        /// 기능추가 요청 다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMoreFunctionReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TBD");
        }
    }
}
