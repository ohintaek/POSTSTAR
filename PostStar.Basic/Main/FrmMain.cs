using PostStar.Communicator.DataStructure;
using PostStar.Basic.Common;
using PostStar.Basic.Help;
using PostStar.Basic.SendMessage;
using PostStar.Basic.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostStar.Basic.Main
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
        EventBroadcastProvider beDoubleClick;

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
            // 1. 사용자 정보를 구한다.
            this.initMe();
            
            // 2. 멤버목록을 구한다.
            this.initMemberList();

            // 이벤트 계층적 호출처리기를 등록한다.
            this.beMouseEnter = EventBroadcastProvider.CreateProvider(this.flpMemberList, "MouseEnter");
            this.beMouseLeave = EventBroadcastProvider.CreateProvider(this.flpMemberList, "MouseLeave");
            this.beDoubleClick = EventBroadcastProvider.CreateProvider(this.flpMemberList, "DoubleClick");
        }

        /// <summary>
        /// 사용자 정보를 구한다.
        /// </summary>
        private void initMe()
        {
            // 1. 설정된 nick name을 구한다.(nick name이 없다면 host name으로 대체한다.)
            String nickName = Properties.Settings.Default.nickName;
            String hostName = Dns.GetHostName();
            if (String.IsNullOrEmpty(nickName))
                nickName = hostName;

            // 2. 사용자 객체를 구한다.
            Member me = new Member(nickName);
            me.ipAddress = Dns.GetHostAddresses(hostName)[0/* 첫번째 IP를 사용한다. */];
            me.email = null;
            me.name = null;

            // 3. 메인화면에 표시한다.
            this.ucMe.setMe(me);

            // 9. 전체공용 변수에 저장한다.
            GlobalData.me = me;
        }

        /// <summary>
        /// 멤버목록을 바인딩한다.
        /// </summary>
        private void initMemberList()
        {
            flpMemberList.Controls.Add(new UcMember(new Member("홍길동")));
            flpMemberList.Controls.Add(new UcMember(new Member("테스터")));
        }

        /// <summary>
        /// ESC 키가 눌렸다면 화면을 숨기고 TrayIcon을 표시한다.
        /// (Shift + ESC를 누르면 프로그램을 종료한다.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
#if DEBUG   // DEBUG 일때는 실제로 프로그램을 종료한다.
                    if (e.Shift)
                        this.closeAvailableFlag = true;
#endif

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

        /// <summary>
        /// 프로그램을 종료한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeAvailableFlag = true;
            this.Close();
        }

        /// <summary>
        /// About Dialog를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
          //  frmAbout.Parent = this;
            frmAbout.StartPosition = FormStartPosition.CenterParent;
            frmAbout.ShowDialog();
        }

        /// <summary>
        /// Settings Dialog를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.StartPosition = FormStartPosition.CenterParent;
            frmSettings.ShowDialog();
        }
    }
}
