using PostStar.Communicator;
using PostStar.Communicator.ReceiveHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Echo Server - Test 용
/// </summary>
namespace PostStar.EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ReceiveHandlerEx receiveHandlerEx = new ReceiveHandlerEx();
                //IMessageReceiver msgReceiver = new MessageReceiver("127.0.0.1", CommConst.PORT, receiveHandlerEx);
                BaseReceiveHandler receiveHandler = new BaseReceiveHandler();
                IMessageReceiver msgReceiver = new MessageReceiver("127.0.0.1", CommConst.PORT, receiveHandler);

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
