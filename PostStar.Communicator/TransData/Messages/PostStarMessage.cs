using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostStar.Communicator.DataStructure;

namespace PostStar.Communicator.TransData.Messages
{
    /// <summary>
    /// POST-STAR Defalut 메시지
    /// </summary>
    [Serializable]
    public class PostStarMessage : Message
    {
        public String text;
        //public List fileList;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sender"></param>
        public PostStarMessage(Member sender) : base(sender)
        {
        }
    }
}
