using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PostStar.Basic.Messaging;
using PostStar.Communicator.DataStructure;

namespace PostStar.Basic.Main
{
    /// <summary>
    /// 멤버를 표시하는 UI Control
    /// </summary>
    public partial class UcMember : UserControl
    {
        /// <summary>
        /// 멤버 정보
        /// </summary>
        private Member member = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userName"></param>
        public UcMember(Member member)
        {
            InitializeComponent();

            this.member = member;
        }

        /// <summary>
        /// 화면을 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_Load(object sender, EventArgs e)
        {
            tlpMember.Dock = DockStyle.Fill;
            this.Height = 28/* Control의 높이 */;

            this.ContextMenuStrip = this.cmsMember;

            // 콘트롤의 가로크기를 결정한다.
            this.Width = this.Parent.Width - this.Margin.Left - this.Margin.Right;

            // 멤버의 닉네임을 표시한다.
            this.lblName.Text = member.nickName;
        }

        /// <summary>
        /// 마우스가 컨트롤 밖으로 나가면 배경색을 복구한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        /// <summary>
        /// 마우스가 컨트롤 위에 있으면 HighLight 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// 멤버 정보창을 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmShowMemberInfo_Click(object sender, EventArgs e)
        {
            FrmMemberInfo frmMemberInfo = new FrmMemberInfo();
            frmMemberInfo.Show();
        }

        /// <summary>
        /// 대화창을 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcMember_DoubleClick(object sender, EventArgs e)
        {
         //   FrmChat frmChat = new FrmChat();
         //   frmChat.Show();

        }

        /// <summary>
        /// 메시지 보내기 다이얼로그를 표시한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSendMessage_Click(object sender, EventArgs e)
        {
            if (this.member == null)
                return;

            FrmSendMessage frmSendMessage = new FrmSendMessage(this.member);
            frmSendMessage.Show();
        }
    }
}
