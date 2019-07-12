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
    public class CardMessage : Message
    {
        public String cardTitle { get; set; }
        public String cardBody { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sender"></param>
        public CardMessage(Member sender) : base(sender)
        {
        }

    }
}
