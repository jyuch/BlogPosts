using Akka.Actor;
using Akka.IO;
using Akka.Streams;
using Akka.Streams.Dsl;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tcp = Akka.Streams.Dsl.Tcp;

namespace AkkaStreamTcp
{
    class Program
    {
        private static int i = 0;

        static void Main(string[] args)
        {
            var system = ActorSystem.Create("akka-stream-tcp");
            var materializer = system.Materializer();

            Source<Tcp.IncomingConnection, Task<Tcp.ServerBinding>> connections =
                system.TcpStream().Bind("localhost", 8888);

            connections.RunForeach(connection =>
            {
                Console.WriteLine($"New connection from: {connection.RemoteAddress}");

                var echo = Flow.Create<ByteString>()
                    .Via(Framing.Delimiter(
                        ByteString.FromString("\n"),
                        maximumFrameLength: 256,
                        allowTruncation: true))
                    .Select(c => c.ToString())
                    .SelectAsync(1, Sum)
                    .Select(ByteString.FromString);

                connection.HandleWith(echo, materializer);
            }, materializer);

            Console.ReadLine();
        }

        static async Task<string> Sum(string value)
        {
            if (int.TryParse(value, out int n))
            {
                Interlocked.Add(ref i, n);
            }

            await Task.Delay(1000);
            return $"{i,-11}";
        }
    }
}
