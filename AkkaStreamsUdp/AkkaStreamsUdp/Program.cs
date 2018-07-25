using Akka.Actor;
using Akka.Streams;
using System;
using System.Net;
using System.Text;

namespace AkkaStreamsUdp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("udp-test"))
            using (var materializer = system.Materializer())
            {
                var source = UdpSource.Create(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6000), 100);

                source.RunForeach(r =>
                {
                    Console.WriteLine(r.Data.ToString(Encoding.UTF8));
                }, materializer);

                Console.ReadLine();
            }
        }
    }
}
