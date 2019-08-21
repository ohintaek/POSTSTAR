using Mina.Core.Session;
using PostStar.Communicator.ReceiveHandler;
using PostStar.Communicator.TransData.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Basic.Messaging
{
    /// <summary>
    /// POST-STAR 기본 메시지 리시버
    /// </summary>
    class BasicMessageReceiver : BaseReceiveHandler
    {
        /// <summary>
        /// POST-STAR 메시지를 처리한다.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="starMessage"></param>
        protected override void ReceivePoststarMessage(IoSession session, PostStarMessage starMessage)
        {
            FrmReceiveMessage frmReceiveMessage = new FrmReceiveMessage(starMessage);
            frmReceiveMessage.ShowDialog();
        }
    }
}
