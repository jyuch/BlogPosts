using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AkkaStreamsUdpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new UdpClient())
            {
                while (true)
                {
                    Console.Write("> ");
                    var msg = Console.ReadLine();

                    if (msg == "quit")
                    {
                        break;
                    }

                    var b = Encoding.UTF8.GetBytes(msg);

                    client.Send(b, b.Length, "localhost", 6000);
                }
            }
        }
    }
}
