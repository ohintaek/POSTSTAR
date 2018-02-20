using Mina.Core.Future;
using Mina.Core.Service;
using Mina.Core.Session;
using Mina.Filter.Codec;
using Mina.Filter.Codec.TextLine;
using Mina.Filter.Logging;
using Mina.Transport.Socket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PostStar.Communicator
{
    /// <summary>
    /// 메시지를 전송한다.
    /// </summary>
    public class MessageSender : IMessageSender
    {
        IoConnector connector = new AsyncSocketConnector();
        IoSession session = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="portNo"></param>
        public MessageSender(String ipAddress, int portNo)
        {
            try
            {
                connector.FilterChain.AddLast("logger", new LoggingFilter());
                connector.FilterChain.AddLast("codec", new ProtocolCodecFilter(new TextLineCodecFactory()));

                connector.SessionClosed += (o, e) => Append("Connection closed.");
                connector.MessageReceived += OnMessageReceived;

                SetState(false);
                
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipAddress), portNo);

                IConnectFuture connectFuture = connector.Connect(ep).Await();
                if (connectFuture.Connected == false)
                    throw new Exception("상대방으로부터 응답이 없습니다.");

                session = connectFuture.Session;
            }
            catch(Exception ex)
            {
                throw new Exception(String.Format("{0}:{1}에 연결할 수 없습니다.", ipAddress, portNo), ex);
            }
        }

        public void Append(String line)
        {
            Console.WriteLine(line);
            //if (textBoxChat.InvokeRequired)
            //{
            //    textBoxChat.Invoke(new Action<String>(Append), line);
            //    return;
            //}

            //textBoxChat.AppendText(line);
            //textBoxChat.AppendText(Environment.NewLine);
        }

        private void OnMessageReceived(object sender, IoSessionMessageEventArgs e)
        {
            String theMessage = (String)e.Message;
            String[] result = theMessage.Split(new Char[] { ' ' }, 3);
            String status = result[1];
            String theCommand = result[0];

            if ("OK".Equals(status))
            {
                if (String.Equals("BROADCAST", theCommand, StringComparison.OrdinalIgnoreCase))
                {
                    if (result.Length == 3)
                        Append(result[2]);
                }
                else if (String.Equals("LOGIN", theCommand, StringComparison.OrdinalIgnoreCase))
                {
                    SetState(true);
                    Append("You have joined the chat session.");
                }
                else if (String.Equals("QUIT", theCommand, StringComparison.OrdinalIgnoreCase))
                {
                    SetState(false);
                    Append("You have left the chat session.");
                }
            }
            else
            {
                if (result.Length == 3)
                {
                    //MessageBox.Show(result[2]);
                    Console.WriteLine(result[2]);
                }
            }
        }

        private void SetState(Boolean loggedIn)
        {
            //if (this.InvokeRequired)
            //{
            //    this.Invoke(new Action<Boolean>(SetState), loggedIn);
            //    return;
            //}
            //buttonConnect.Enabled = textBoxUser.Enabled = textBoxServer.Enabled = !loggedIn;
            //buttonDisconnect.Enabled = buttonSend.Enabled = buttonQuit.Enabled = textBoxChat.Enabled = textBoxInput.Enabled = loggedIn;
        }

        public void Send(object packet)
        {
            if (session == null)
                return;

            if (packet == null)
                return;


            session.Write(packet);


        }
    }
}
