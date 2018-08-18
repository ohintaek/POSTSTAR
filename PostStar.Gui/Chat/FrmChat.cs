using PostStar.Communicator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Gui.Chat
{
    /// <summary>
    /// 채팅화면
    /// </summary>
    public partial class FrmChat : PostStar.Gui.Common.FrmBaseDialog
    {
        IMessageSender msgSender;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmChat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// <summary>
        /// 화면을 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChat_Load(object sender, EventArgs e)
        {

        }

        /// 입력내용을 상대방에게 전송한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFireSend_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // 0. 입력내용이 없다면 Return
            //    String inputMessage = this.tbxChatMessage.Text.Trim();
            //    if (inputMessage == string.Empty)
            //        return;

            //    // 1. 입력된 내용을 상대방에게 전송한다.                
            //    this.msgSender.Send(inputMessage);

            //    // 2. 전송결과를 Chat History 창에 표시한다.
            //    this.rtbChatHistory.AppendText(String.Format("\r\n나 : {0}", this.tbxChatMessage.Text));

            //    // 9. 입력된 내용을 삭제한다.
            //    this.tbxChatMessage.Text = String.Empty;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        /// <summary>
        /// 입력창의 입력에 따른 제어를 한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxChatMessage_KeyDown(object sender, KeyEventArgs e)
        {
            //switch(e.KeyCode)
            //{                
            //    case Keys.Enter : // Enter가 입력되었다면 입력내용을 전송한다.  --> Form의 AcceptButton 속성으로 대체...
            //        this.btnFireSend.PerformClick();
            //        break;

            //    default: break;
            //}
            
        }

        /// <summary>
        /// 창이 처음열릴때 한번 실행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChat_Shown(object sender, EventArgs e)
        {
            //try
            //{
            //    // --> 백그라운드 쓰래드로 바꿔야 함...


            //    // 채팅상대방과 세션을 오픈한다.
            //    this.msgSender = new MessageSender("127.0.0.1", CommConst.PORT);

            //    // 입력창에 포커스를 준다.
            //    this.tbxChatMessage.Enabled = true;
            //    this.tbxChatMessage.Focus();

            //    // 전송버튼을 활성화 한다.
            //    this.btnFireSend.Enabled = true;
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.Message, "오류");
            //    this.rtbChatHistory.AppendText(ex.Message);
            //}
        }
    }
}
