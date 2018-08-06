using PostStar.Communicator;
using PostStar.Communicator.DataStructure;
using PostStar.Gui.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Gui.SendMessage
{
    public partial class FrmSendMessage : PostStar.Gui.Common.FrmBaseDialog
    {
        /// <summary>
        /// 메시지를 수신할 멤버목록
        /// </summary>
        private List<Member> targetMemberList;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmSendMessage(Member member)
        {
            InitializeComponent();

            targetMemberList = new List<Member>();
            targetMemberList.Add(member);
        }

        /// <summary>
        /// 화면을 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSendMessage_Load(object sender, EventArgs e)
        {
            if (targetMemberList.Count > 1)
                this.Text = String.Format("{0}외 {1}명에게 메시지 보내기", targetMemberList[0].nickName, targetMemberList.Count);
            else
                this.Text = String.Format("{0}에게 메시지 보내기", targetMemberList[0].nickName);
        }

        /// <summary>
        /// 전송창을 닫는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 메시지 내용을 전송한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // 0. 입력내용이 없다면 Return
                String inputMessage = this.txtMessageBody.Text.Trim();
                if (inputMessage == string.Empty)
                    return;

                // 1. 입력된 내용을 상대방에게 전송한다.  
                IMessageSender msgSender;
                foreach (Member memer in this.targetMemberList)
                {
                    msgSender = new MessageSender(memer.iPAddress.ToString(), CommConst.PORT);
                    msgSender.Send(inputMessage);
                }

                // 2. 전송메시지 History에 기록한다.
                //...

                // 9. 창을 닫는다.
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
