using Mina.Core.Session;
using PostStar.Communicator.ReceiveHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostStar.EchoServer
{
    /// <summary>
    /// 메시지 수신 핸들러
    /// </summary>
    public class ReceiveHandlerEx : BaseReceiveHandler
    {

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
        /// 메시지 수신 Handler
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        public override void MessageReceived(IoSession session, Object message)
        {
            //
            Console.WriteLine("수신 메시지 : ");
            
            if(message.GetType() == typeof(String))
                Console.WriteLine(message);


            //String theMessage = (String)message;
            //String[] result = theMessage.Split(new Char[] { ' ' }, 2);
            //String theCommand = result[0];

            //String user = session.GetAttribute<String>("user");

            //if (String.Equals("QUIT", theCommand, StringComparison.OrdinalIgnoreCase))
            //{
            //    session.Write("QUIT OK");
            //    session.Close(true);
            //}
            //else if (String.Equals("LOGIN", theCommand, StringComparison.OrdinalIgnoreCase))
            //{
            //    if (user != null)
            //    {
            //        session.Write("LOGIN ERROR user " + user + " already logged in.");
            //        return;
            //    }

            //    if (result.Length == 2)
            //    {
            //        user = result[1];
            //    }
            //    else
            //    {
            //        session.Write("LOGIN ERROR invalid login command.");
            //        return;
            //    }

            //    // check if the username is already used
            //    if (users.ContainsKey(user))
            //    {
            //        session.Write("LOGIN ERROR the name " + user + " is already used.");
            //        return;
            //    }

            //    sessions[session] = true;
            //    session.SetAttribute("user", user);

            //    // Allow all users
            //    users[user] = true;
            //    session.Write("LOGIN OK");
            //    Broadcast("The user " + user + " has joined the chat session.");
            //}
            //else if (String.Equals("BROADCAST", theCommand, StringComparison.OrdinalIgnoreCase))
            //{
            //    if (result.Length == 2)
            //    {
            //        Broadcast(user + ": " + result[1]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Unhandled command: " + theCommand);
            //}
        }

        public override void SessionCreated(IoSession session)
        {
            base.SessionCreated(session);

            session.Config.ReadBufferSize = 1024000000;

            //SocketSessionConfig ssc = (SocketSessionConfig)ssn.getConfig();
            //ssc.setReceiveBufferSize(17/*로그시간*/ +
            //                            2/*로그발생시스템*/ +
            //                            1/*메시지코드(로그종류+로그분류)*/ +
            //                            1004/*로그내용*/);
        }
    }
}
