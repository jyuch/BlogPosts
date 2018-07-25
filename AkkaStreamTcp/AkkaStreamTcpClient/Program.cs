using Akka.Actor;
using Akka.Routing;
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace AkkaStreamTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("client");
            var props = Props.Create<ClientActor>().WithRouter(new BroadcastPool(100)).WithDispatcher("default-fork-join-dispatcher");
            var actor = system.ActorOf(props, "client");

            for (var i = 0; i < 100; i++)
            {
                actor.Tell(10);
            }

            Console.ReadLine();
        }
    }

    public class ClientActor : ReceiveActor
    {
        private Guid id;

        public ClientActor()
        {
            id = Guid.NewGuid();

            ReceiveAsync<int>(async i =>
            {
                var sw = Stopwatch.StartNew();

                using (var client = new TcpClient("localhost", 8888))
                using (var stream = client.GetStream())
                {
                    var message = Encoding.ASCII.GetBytes($"{i,-11}\n");
                    await stream.WriteAsync(message, 0, message.Length);
                    await stream.FlushAsync();
                    var response = new byte[11];
                    await stream.ReadAsync(response, 0, 11);
                    var n = Encoding.ASCII.GetString(response);
                    Console.WriteLine($"{id} {n} {sw.ElapsedMilliseconds}");
                }
            });
        }
    }
}
