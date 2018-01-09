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
    public partial class frmMain : Form
    {
        private bool closeAvailableFlag;
        private ContextMenu ctxmTray;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            this.closeAvailableFlag = false;

            this.ctxmTray = new ContextMenu();
            notifyIcon.ContextMenu = this.ctxmTray;

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
            //ISendMessage sendMessage;
        }

        /// <summary>
        /// [X]ICON을 누를때 TRAY ICON으로 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.closeAvailableFlag == false)
            {
                notifyIcon.Visible = true; // tray icon 표시
                this.Hide();

                e.Cancel = true;
            }
        }

        /// <summary>
        /// TRAY ICON 클릭시 메인다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Right :
                    // TrayIcon의 Context메뉴를 보여준다.
                    this.showTrayContextMenu();
                    break;
                default :
                    // 메인화면을 보여준다.
                    notifyIcon.Visible = false;
                    this.Show();
                    break;
            }
        }

        /// <summary>
        /// TrayIcon의 ContextMenu를 보여준다.
        /// </summary>
        private void showTrayContextMenu()
        {
            // Initialize contextMenu1
            this.ctxmTray.MenuItems.Clear();

            // Initialize menuItem1
            MenuItem miTrayExit = new System.Windows.Forms.MenuItem();
            miTrayExit.Index = 0;
            miTrayExit.Text = "E&xit";
            miTrayExit.Click += new System.EventHandler(this.menuItemExit_Click);
            this.ctxmTray.MenuItems.Add(miTrayExit);
        }

        /// <summary>
        /// TrayIcon의 ContextMenu의 Exit가 눌렸을때의 처리를 한다.
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click(object Sender, EventArgs e)
        {
            this.closeAvailableFlag = true;
            this.Close();
        }



    }
}
