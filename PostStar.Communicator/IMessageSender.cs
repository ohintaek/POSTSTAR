using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator
{
    /// <summary>
    /// 송신메시지 인터페이스
    /// </summary>
    interface IMessageSender
    {
        void Send(Object packet);
    }
}
