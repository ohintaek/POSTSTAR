using PostStar.Communicator.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator.TransData.Messages
{
    /// <summary>
    /// 메시지
    /// </summary>
    [Serializable]
    public abstract class Message
    {
        private Member sender;

        /// <summary>
        /// Consructor
        /// </summary>
        /// <param name="sender"></param>
        public Message(Member sender)
        {
            this.sender = sender;
        }

        /// <summary>
        /// Sender를 구한다.
        /// </summary>
        /// <returns></returns>
        public Member getSender()
        {
            return this.sender;
        }

    }
}
