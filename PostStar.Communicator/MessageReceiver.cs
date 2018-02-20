using Mina.Core.Service;
using Mina.Filter.Codec;
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
    /// 
    /// </summary>
    public class MessageReceiver : IMessageReceiver
    {
        IoAcceptor acceptor;

        public MessageReceiver(String ipAddress, int portNo, BaseReceiveHandler baseReceiveHandler)
        {
            IoAcceptor acceptor = new AsyncSocketAcceptor();

            //acceptor.FilterChain.AddLast("logger", new LoggingFilter());
            acceptor.FilterChain.AddLast("codec", new ProtocolCodecFilter(new TextLineCodecFactory()));

            acceptor.Handler = baseReceiveHandler;

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipAddress), portNo);
            acceptor.Bind(ep);

            Console.WriteLine("Listening on " + acceptor.LocalEndPoint);

            
        }
    }
}
