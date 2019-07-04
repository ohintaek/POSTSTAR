using PostStar.Communicator.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator.TransData.Messages
{
    /// <summary>
    /// 멤버정보 메시지
    /// </summary>
    [Serializable]
    class MemberInfoMessage : Message
    {
        Member member;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        public MemberInfoMessage(Member sender, Member receiver) : base(sender, receiver)
        {
        }
    }
}
