using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Basic.Settings
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 설정내용을 적용한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            // 1. 입력내용을 저장한다.
            Properties.Settings.Default.nickName = txtNickName.Text;
            Properties.Settings.Default.alertOption_Display = cbAlertOption_Display.Checked;
            Properties.Settings.Default.alertOption_UseSound = cbAlertOption_UseSound.Checked;
            Properties.Settings.Default.trayOption_RecentMessage = cbxRecentMessage.SelectedIndex;
            if (Properties.Settings.Default.retrySendOption_Retry == true)
            {
                rbSendFailOption_None.Checked = false;
                rbSendFailOption_Retry.Checked = true;
            }
            else
            {
                rbSendFailOption_None.Checked = true;
                rbSendFailOption_Retry.Checked = false;
            }
            Properties.Settings.Default.autoRunOption = cbAutoRun.Checked;

            // 2. Global 변수에 변경내용을 반영한다.
            // TODO...
            // ...

            // 9. Dialog 를 닫는다.
            this.Close();
        }

        /// <summary>
        /// 다이얼로그를 닫는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Dialog를 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            // 1. 저장된 설정내용을 화면에 표시한다.
            txtNickName.Text = Properties.Settings.Default.nickName;
            cbAlertOption_Display.Checked = Properties.Settings.Default.alertOption_Display;
            cbAlertOption_UseSound.Checked = Properties.Settings.Default.alertOption_UseSound;
            cbxRecentMessage.SelectedIndex = Properties.Settings.Default.trayOption_RecentMessage;
            rbSendFailOption_None.Checked = !Properties.Settings.Default.retrySendOption_Retry;
            rbSendFailOption_Retry.Checked = Properties.Settings.Default.retrySendOption_Retry;
            cbAutoRun.Checked = Properties.Settings.Default.autoRunOption;
        }
    }
}
