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
        private Member receiver;

        /// <summary>
        /// Consructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        public Message(Member sender, Member receiver)
        {
            this.sender = sender;
            this.receiver = receiver;
        }

        /// <summary>
        /// Sender를 구한다.
        /// </summary>
        /// <returns></returns>
        public Member getSender()
        {
            return this.sender;
        }

        /// <summary>
        /// Receiver를 구한다.
        /// </summary>
        /// <returns></returns>
        public Member getReceiver()
        {
            return this.receiver;
        }
    }
}
