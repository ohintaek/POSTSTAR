using Mina.Core.Session;
using PostStar.Communicator.ReceiveHandler;
using PostStar.Communicator.TransData.Messages;
using System;

namespace PostStar.EchoServer
{
    /// <summary>
    /// 메시지 수신 핸들러
    /// </summary>
    public class ReceiveHandlerEx : BaseReceiveHandler
    {

        public override void SessionCreated(IoSession session)
        {
            base.SessionCreated(session);

            session.Config.ReadBufferSize = 1024000000;
        }

        /// <summary>
        /// 세션 열기 Handler
        /// </summary>
        /// <param name="session"></param>
        public override void SessionOpened(IoSession session)
        {
            Console.WriteLine("Accept !!!....");
        }


        /// <summary>
        /// 세션 닫기 Handler
        /// </summary>
        /// <param name="session"></param>
        public override void SessionClosed(IoSession session)
        {
            String user = session.GetAttribute<String>("user");
            sessions.Remove(session);
            if (user != null)
            {
                users.Remove(user);
                Broadcast("The user " + user + " has left the chat session.");
            }
            Console.WriteLine("Closed session");
        }

        /// <summary>
        /// 오류 Handler
        /// </summary>
        /// <param name="session"></param>
        /// <param name="cause"></param>
        public override void ExceptionCaught(IoSession session, Exception cause)
        {
            Console.WriteLine("Unexpected exception." + cause);
            session.Close(true);
        }

        /// <summary>
        /// 메시지 수신 Handler
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        public override void MessageReceived(IoSession session, Object message)
        {
            Type msgType = message.GetType();
            if (msgType == typeof(String))
                Console.WriteLine(message);
            else if(msgType == typeof(CardMessage))
            {
                CardMessage cardMessage = (CardMessage) message;
                Console.WriteLine(String.Format("CARD TITLE : {0}", cardMessage.cardTitle));
                Console.WriteLine(String.Format("CARD BODY : {0}", cardMessage.cardBody));
            }
            else
            {
                throw new Exception("잘못된 메시지 형식입니다.");
            }
            
        }

    }
}
