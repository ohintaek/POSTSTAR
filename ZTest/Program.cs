using Lextm.SharpSnmpLib;
using NmapXmlParser;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;

namespace ZTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine(IPList());
            //Console.WriteLine(IpList2());
            Console.WriteLine("Complete");
            Console.ReadKey();
        }

        public static string IPList()
        {
            string myIp3rdOctet = string.Empty;
            string localHostName = Dns.GetHostName();
            IPAddress[] paddresses = Dns.GetHostAddresses(localHostName);
            string myIp = paddresses.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();
            string[] myIpArray = myIp.Split(new[] { '.' });
            myIp3rdOctet = string.Format("{0}.{1}.{2}.", myIpArray[0], myIpArray[1], myIpArray[2]);

            var results = new string[0x100];
            //System.Threading.Tasks.Parallel.For(1, 0x100, id =>
            System.Threading.Tasks.Parallel.For(100, 109, lastOctet =>
            {
                var pingSender = new Ping();
                string ls = myIp3rdOctet + lastOctet;
                PingReply reply = pingSender.Send(ls, 100);
                if (reply != null)
                {
                    if (reply.Status == IPStatus.Success)
                        results[lastOctet] = reply.Address.ToString();
                }
            });

          //  Trace.WriteLine(DateTime.Now);
            var sb = new StringBuilder();
            results.All(x => {                
                if(x != null)
                    sb.AppendFormat("{0}\r\n", x);

                return true;
            });
            return sb.ToString();
        }

        public static string IpList2()
        {
            var sb = new StringBuilder();
            string myHost = System.Net.Dns.GetHostName();

            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);

            // Loop through all IP addresses and display each 

            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                sb.Append(myIP.ToString());
            }
            return sb.ToString();
        }
    }
}
