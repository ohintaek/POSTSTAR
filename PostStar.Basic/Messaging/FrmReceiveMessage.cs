using PostStar.Communicator.TransData.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Basic.Messaging
{
    /// <summary>
    /// 수신된 메시지를 보여주는 화면
    /// </summary>
    public partial class FrmReceiveMessage : PostStar.Basic.Common.FrmPopupBaseDialog
    {
        private PostStarMessage poststarmsg;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="poststarmsg"></param>
        public FrmReceiveMessage(PostStarMessage poststarmsg)
        {
            InitializeComponent();

            this.poststarmsg = poststarmsg;
        }

        /// <summary>
        /// 화면을 구성한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReceiveMessage_Load(object sender, EventArgs e)
        {
            this.Text = this.poststarmsg.getSender().nickName;
            this.txtMessageBody.Text = this.poststarmsg.text;
        }

        /// <summary>
        /// 답장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReply_Click(object sender, EventArgs e)
        {
            // 메시지 보내기 창을 OPEN한다.


            this.Close();
        }

        /// <summary>
        /// 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
