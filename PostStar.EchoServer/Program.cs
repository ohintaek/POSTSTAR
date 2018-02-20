using PostStar.Communicator;
using PostStar.Communicator.ReceiveHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostStar.EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseReceiveHandler baseReceiveHandler = new BaseReceiveHandler();
            IMessageReceiver msgReceiver = new MessageReceiver("127.0.0.1", 9123, baseReceiveHandler);

            Console.WriteLine("Runing EchoServer...");

            Console.ReadLine();
        }
    }
}
