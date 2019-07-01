﻿using Mina.Core.Service;
using Mina.Filter.Codec;
using Mina.Filter.Codec.Serialization;
using Mina.Filter.Codec.TextLine;
using Mina.Filter.Logging;
using Mina.Transport.Socket;
using PostStar.Communicator.ReceiveHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PostStar.Communicator
{
    /// <summary>
    /// Message Receiver
    /// </summary>
    public class MessageReceiver : IMessageReceiver
    {
        IoAcceptor acceptor;

        public MessageReceiver(String ipAddress, int portNo, BaseReceiveHandler receiveHandler)
        {
            try
            {
                // 1. ACCEPTOR 생성
                this.acceptor = new AsyncSocketAcceptor();

                // 2. DEFINE FILTER
                this.acceptor.FilterChain.AddLast("logger", new LoggingFilter());
                ObjectSerializationCodecFactory objectSerializationCodecFactory = new ObjectSerializationCodecFactory();
                //objectSerializationCodecFactory.DecoderMaxObjectSize = 104857600;
                this.acceptor.FilterChain.AddLast("codec", new ProtocolCodecFilter(objectSerializationCodecFactory));
                //this.acceptor.FilterChain.AddLast("codec", new ProtocolCodecFilter(new TextLineCodecFactory()));

                // 3. SET HANDLER
                this.acceptor.Handler = receiveHandler;
                
                // 4. BIND
                this.acceptor.Bind(new IPEndPoint(IPAddress.Any, portNo));

                Console.WriteLine("Listening on " + acceptor.LocalEndPoint);
            }
            catch (Exception ex)
            {
                throw new Exception("Message Receiver를 생성하지 못했습니다.", ex);
            }
        }
    }
}
