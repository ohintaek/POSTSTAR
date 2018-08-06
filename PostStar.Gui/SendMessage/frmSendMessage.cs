﻿using PostStar.Communicator.DataStructure;
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

        }

    }
}
