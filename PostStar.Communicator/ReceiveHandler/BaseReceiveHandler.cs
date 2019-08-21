using Mina.Core.Service;
using Mina.Core.Session;
using PostStar.Communicator.TransData.Messages;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator.ReceiveHandler
{

    /// <summary>
    /// Base Recieve Handler
    /// </summary>
    public class BaseReceiveHandler : IoHandlerAdapter
    {
        protected IDictionary<IoSession, Boolean> sessions = new ConcurrentDictionary<IoSession, Boolean>();
        protected IDictionary<String, Boolean> users = new ConcurrentDictionary<String, Boolean>();

        /// <summary>
        /// Constructor
        /// </summary>
        public BaseReceiveHandler()
        {
        }

        public override void SessionCreated(IoSession session)
        {
            base.SessionCreated(session);

            session.Config.ReadBufferSize = 1024 * 1024 * 1/*1MB*/;
        }

        public override void SessionOpened(IoSession session)
        {
            base.SessionOpened(session);
        }

        public override void SessionClosed(IoSession session)
        {
            String user = session.GetAttribute<String>("user");
            sessions.Remove(session);
            if (user != null)
                users.Remove(user);
        }

        public override void MessageReceived(IoSession session, Object message)
        {
            try
            {
                Message baseMessage = (Message)message;
                Console.WriteLine(String.Format("{0} : ", baseMessage.getSender().nickName));

                Type msgType = message.GetType();
                if (msgType == typeof(String))
                {
                    ReceiveStrigMessage(session, (String)message);
                }
                else if (msgType == typeof(PostStarMessage))
                {
                    ReceivePoststarMessage(session, (PostStarMessage)message);
                }
                else if (msgType == typeof(CardMessage))
                {
                    ReceiveCardMessage(session, (CardMessage)message);
                }
                else
                {
                    throw new Exception("알 수 없는 메시지 형식입니다.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                session.Close(false);
            }
        }

        protected void ReceiveStrigMessage(IoSession session, String msg)
        {
            Console.WriteLine(msg);
        }

        protected virtual void ReceivePoststarMessage(IoSession session, PostStarMessage starMessage)
        {
            Console.WriteLine(String.Format("{0}", starMessage.text));

            PostStarMessage reStarMessage = new PostStarMessage(starMessage.getSender());
            reStarMessage.text = "잘 받았어요.";
            session.Write(reStarMessage);
        }

        protected virtual void ReceiveCardMessage(IoSession session, CardMessage cardMessage)
        {
            Console.WriteLine(String.Format("CARD TITLE : {0}", cardMessage.cardTitle));
            Console.WriteLine(String.Format("CARD BODY : {0}", cardMessage.cardBody));
        }

        public override void ExceptionCaught(IoSession session, Exception cause)
        {
            session.Close(true);
            throw cause;
        }

        public override void SessionIdle(IoSession session, IdleStatus status)
        {
            base.SessionIdle(session, status);
        }

        public override void MessageSent(IoSession session, object message)
        {
            base.MessageSent(session, message);
        }


    }
}
