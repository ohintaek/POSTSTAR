using PostStar.Communicator.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator
{
    /// <summary>
    /// 송신메시지 인터페이스
    /// </summary>
    public interface IMessageSender
    {
        void Send(Member member, Object packet);
    }
}
