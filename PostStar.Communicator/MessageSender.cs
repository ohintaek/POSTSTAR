using Mina.Core.Future;
using Mina.Core.Service;
using Mina.Core.Session;
using Mina.Filter.Codec;
using Mina.Filter.Codec.Serialization;
using Mina.Filter.Codec.TextLine;
using Mina.Filter.Logging;
using Mina.Transport.Socket;
using PostStar.Communicator.DataStructure;
using PostStar.Communicator.TransData.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace PostStar.Communicator
{
    /// <summary>
    /// 메시지를 전송한다.
    /// </summary>
    public class MessageSender : IMessageSender
    {
        const int SEC = 1000;
        const int MAX_TRY_COUNT = 3;

        IoConnector connector = null;
        IPEndPoint endPoint = null;
        IoSession session = null;

        // 메시지 송신자
        Member sender;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sender"></param>
        public MessageSender(Member sender)
        {
            this.sender = sender;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="portNo"></param>
        private void init(IPAddress ipAddress, int portNo)
        {
            try
            {
                // 1. CONNECTOR 를 생성한다.
                this.connector = new AsyncSocketConnector();
                this.connector.FilterChain.AddLast("logger", new LoggingFilter());
                ObjectSerializationCodecFactory objectSerializationCodecFactory = new ObjectSerializationCodecFactory();
                objectSerializationCodecFactory.EncoderMaxObjectSize = CommConst.MAX_TRANSDATA_SIZE;
                this.connector.FilterChain.AddLast("codec", new ProtocolCodecFilter(objectSerializationCodecFactory));                     
                this.connector.SessionClosed += (o, e) => OnSessionClosed();
                this.connector.MessageReceived += OnMessageReceived;

                // 2. 상대방에게 접속을 시도한다.
                this.endPoint = new IPEndPoint(ipAddress, portNo);
                this.Connect();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("{0}:{1}에 연결할 수 없습니다.", ipAddress, portNo), ex);
            }
        }

        /// <summary>
        /// 상대방에 접속처리를 한다.
        /// </summary>
        private void Connect()
        {
            if ((this.connector == null) || (this.endPoint == null))
                return;

            int tryCount = 0;
            IConnectFuture connectFuture;
            while (this.session == null)
            {
                try
                {
                    tryCount++;

                    connectFuture = connector.Connect(this.endPoint);
                    connectFuture.Await();

                    if (connectFuture.Connected)
                        session = connectFuture.Session;
                    else
                        throw new Exception("상대방이 응답이 없습니다.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                    if (tryCount > MAX_TRY_COUNT)
                        break;  // while()

                    Thread.Sleep(SEC);
                }
            }
        }

        /// <summary>
        /// 세션이 종료처리를 한다.
        /// </summary>
        private void OnSessionClosed()
        {
            Console.WriteLine("Session closed...");
        }

        /// <summary>
        /// 응답메시지를 수신한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMessageReceived(object sender, IoSessionMessageEventArgs e)
        {
            StarMessage starMessage = (StarMessage)e.Message;
            Console.WriteLine(String.Format("{0} : ", starMessage.getSender().nickName));
            Console.WriteLine(String.Format("{0}", starMessage.text));

       
        }

        /// <summary>
        /// Message 객체를 전송한다.
        /// </summary>
        /// <param name="packet"></param>
        public void Send(Member receiver, object packet)
        {
            if (packet == null)
                return;

            try
            {
                if ((this.connector == null) || (this.endPoint == null))
                    this.init(receiver.ipAddress, CommConst.PORT);

                if (this.session == null)
                    this.Connect();

                this.session.Write(packet);

                // 전송 후 즉시 세션을 닫을 것인지 판단해야 한다.(2019.08.14)
                // this.session.Close(true);
                // this.session = null;
            }
            catch(Exception ex)
            {
                throw new Exception("메시지 전송 실패",ex);
            }
        }
    }
}
