using PostStar.Communicator.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator.TransData.Messages
{
    /// <summary>
    /// 라인체크 메시지
    /// </summary>
    [Serializable]
    public class PingMessage : Message
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        public PingMessage(Member sender, Member receiver) : base(sender, receiver)
        {
        }
    }
}
