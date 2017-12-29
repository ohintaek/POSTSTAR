using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostStar.Gui.Main
{
    /// <summary>
    /// 메인화면(TRAY ICON의 마우스 우클릭시 표시)
    /// </summary>
    public partial class RMainFrm : Form
    {
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public RMainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 화면을 최초구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RMainFrm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// About 다이얼로그를 실행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHOW ABOUT DIALOG");
        }

        /// <summary>
        /// Setting 다이얼로그를 실행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHOW SETTING DIALOG");
        }

        /// <summary>
        /// MessageHistoryBox 다이얼로그를 실행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsgHistoryBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHOW MESSAGE HISTORY DIALOG");
        }

        /// <summary>
        /// Send Message 다이얼로그를 실행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHOW SEND MESSAGE DIALOG");
        }

        /// <summary>
        /// [X]ICON을 누를때 TRAY ICON으로 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = true; // tray icon 표시
            this.Hide();

            e.Cancel = true;
        }

        /// <summary>
        /// TRAY ICON 클릭시 메인다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MessageBox.Show("LEFT BUTTON");
            }
            else if(e.Button == MouseButtons.Right)
            {
                notifyIcon.Visible = false;
                this.Show();
            }
            else
            {
                // 
            }

        }
    }
}
