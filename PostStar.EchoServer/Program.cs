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
            try
            {
                ReceiveHandlerEx receiveHandlerEx = new ReceiveHandlerEx();
                IMessageReceiver msgReceiver = new MessageReceiver("127.0.0.1", CommConst.PORT, receiveHandlerEx);
                
                Console.WriteLine("Runing EchoServer...");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
