using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostStar.Communicator.DataStructure;

namespace PostStar.Communicator.TransData.Messages
{
    /// <summary>
    /// 카드 메시지
    /// </summary>
    [Serializable]
    public class StarMessage : Message
    {
        public String text;
        //public List fileList;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        public StarMessage(Member sender, Member receiver) : base(sender, receiver)
        {
        }
    }
}
