using PostStar.Gui.Common;
using PostStar.Gui.SendMessage;
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

        EventBroadcastProvider beMouseEnter;
        EventBroadcastProvider beMouseLeave;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            this.KeyPreview = true;

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
            this.initMemberList();

            // 이벤트 계층적 호출처리기를 등록한다.
            this.beMouseEnter = EventBroadcastProvider.CreateProvider(this.flpMemberList, "MouseEnter");
            this.beMouseLeave = EventBroadcastProvider.CreateProvider(this.flpMemberList, "MouseLeave");
        }

        /// <summary>
        /// 멤버목록을 바인딩한다.
        /// </summary>
        private void initMemberList()
        {    
            flpMemberList.Controls.Add(new UcMember("홍길동"));
            flpMemberList.Controls.Add(new UcMember("전지현"));
            flpMemberList.Controls.Add(new UcMember("김팀장"));
            flpMemberList.Controls.Add(new UcMember("김팀원"));
            flpMemberList.Controls.Add(new UcMember("하니"));
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
                case Keys.Escape:
                    if (e.Shift)
                        this.closeAvailableFlag = true;

                    this.Close(); break;
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
            FrmSendMessage frmSendMessage = new FrmSendMessage();
            frmSendMessage.Show();
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
           
            // Recent Receive Message Menu
            this.ctxmTray.MenuItems.Add(new MenuItem("&3 : [송혜교, 10분전] 회의합시다.", new EventHandler(this.menuItemRecentMsg_Click)));
            this.ctxmTray.MenuItems.Add(new MenuItem("&2 : [홍길동, 5분전] 오늘 점심은....", new EventHandler(this.menuItemRecentMsg_Click)));
            this.ctxmTray.MenuItems.Add(new MenuItem("&1 : [왕공주, 2분전] 파일 보냅니다.", new EventHandler(this.menuItemRecentMsg_Click)));

            // 메뉴들의 
            //foreach (MenuItem item in this.ctxmTray.MenuItems)
            //{
            //    item.OwnerDraw = true;
            //    //item.DrawItem += item_DrawItem;
            //    //item.MeasureItem += MeasureMenuItem;
            //}

        }
        
        //void item_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 1/* Recent Message Menu가 시작되는 Index */)
        //        return;
            
        //    e.DrawBackground();
        //    e.Graphics.FillRectangle(new SolidBrush(Color.Orange), e.Bounds);

        //    e.Graphics.DrawString(((MenuItem)sender).Text, new Font("Lucida Sans", 10), new SolidBrush(Color.White), e.Bounds);
        //}

        //void MeasureMenuItem(object sender, MeasureItemEventArgs e)
        //{
        //    MenuItem m = (MenuItem)sender;
        //    Font font = new Font(Font.FontFamily, Font.Size, Font.Style);
        //    SizeF sze = e.Graphics.MeasureString(m.Text, font);
        //    e.ItemHeight = (int)sze.Height * 2;
        //    e.ItemWidth = (int)sze.Width * 2;
        //}

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
