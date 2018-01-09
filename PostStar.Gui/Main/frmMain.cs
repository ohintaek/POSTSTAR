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
    public partial class FrmMain : Form
    {
        private bool closeAvailableFlag;
        private ContextMenu ctxmTray;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public FrmMain()
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
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        /// <summary>
        /// ESC 키가 눌렸다면 화면을 숨기고 TrayIcon을 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                default: break;
            }
        }

        /// <summary>
        /// [X]ICON을 누를때 TRAY ICON으로 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.closeAvailableFlag == false)
            {
                notifyIcon.Visible = true; // tray icon 표시
                this.Hide();

                e.Cancel = true;
            }
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

        #region TRAYICON CONTEXT MENU
        /// <summary>
        /// TrayIcon의 ContextMenu를 보여준다.
        /// </summary>
        private void showTrayContextMenu()
        {
            // Initialize contextMenu1
            this.ctxmTray.MenuItems.Clear();

            // Initialize Tray Icon
            // Exit Menu
            MenuItem miTrayExit = new MenuItem();
            miTrayExit.Index = 0;
            miTrayExit.Text = "E&xit";
            miTrayExit.Click += new System.EventHandler(this.menuItemExit_Click);
            this.ctxmTray.MenuItems.Add(miTrayExit);

            //this.ctxmTray.MenuItems.

            // About Menu
            MenuItem miTrayRecentMsg1 = new MenuItem();
            miTrayRecentMsg1.Break = true;
            miTrayRecentMsg1.Index = 1;
            miTrayRecentMsg1.Shortcut = Shortcut.Ctrl3;
            miTrayRecentMsg1.Text = "&3 : [송혜교, 10분전] 회의합시다.";
            miTrayRecentMsg1.Click += new System.EventHandler(this.menuItemRecentMsg_Click);
            this.ctxmTray.MenuItems.Add(miTrayRecentMsg1);

            MenuItem miTrayRecentMsg2 = new MenuItem();
            miTrayRecentMsg2.Index = 2;
            miTrayRecentMsg2.Text = "&2 : [홍길동, 5분전] 오늘 점심은....";
            miTrayRecentMsg2.Click += new System.EventHandler(this.menuItemRecentMsg_Click);
            this.ctxmTray.MenuItems.Add(miTrayRecentMsg2);

            MenuItem miTrayRecentMsg3 = new MenuItem();
            miTrayRecentMsg3.Index =3;
            miTrayRecentMsg3.Text = "&1 : [왕공주, 2분전] 파일 보냅니다.";
            miTrayRecentMsg3.Click += new System.EventHandler(this.menuItemRecentMsg_Click);
            this.ctxmTray.MenuItems.Add(miTrayRecentMsg3);

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

        /// <summary>
        /// 수신된 메시지를 보여준다.
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void menuItemRecentMsg_Click(object Sender, EventArgs e)
        {
            MessageBox.Show("SHOW RECEIVE MESSAGE DIALOG");
        }

        #endregion
    }
}
