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
            // 입력창에 포커스를 준다.
            this.tbxChatMessage.Focus();
        }

        /// 입력내용을 상대방에게 전송한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFireSend_Click(object sender, EventArgs e)
        {
            // 0. 입력내용이 없다면 Return
            if (this.tbxChatMessage.Text.Trim() == string.Empty)
                return;

            // 1. 입력된 내용을 상대방에게 전송한다.
            // ...

            // 2. 전송결과를 Chat History 창에 표시한다.
            rtbChatHistory.Text = String.Format("{0}\r\n나 : {1}", rtbChatHistory.Text, this.tbxChatMessage.Text);             

            // 9. 입력된 내용을 삭제한다.
            this.tbxChatMessage.Text = String.Empty;
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
    }
}
