using Akka;
using Akka.Actor;
using Akka.Event;
using Akka.IO;
using Akka.Streams.Actors;
using System;
using System.Collections.Generic;
using System.Net;
using Akka.Streams.Dsl;

namespace AkkaStreamsUdp
{
    public class UdpSource : Actor​Publisher<Udp.Received>
    {
        public static Props Props(EndPoint listenOn, int maxBufferSize) =>
            Akka.Actor.Props.Create(() => new UdpSource(listenOn, maxBufferSize));

        public static Source<Udp.Received, IActorRef> Create(EndPoint listenOn, int maxBufferSize) =>
            Source.ActorPublisher<Udp.Received>(Props(listenOn, maxBufferSize));

        private Queue<Udp.Received> datagrams = new Queue<Udp.Received>();
        private readonly int maxBufferSize;
        private readonly ILoggingAdapter log = Logging.GetLogger(Context);

        public UdpSource(EndPoint listenOn, int maxBufferSize)
        {
            if (maxBufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxBufferSize));
            }

            this.maxBufferSize = maxBufferSize;
            Context.System.Udp().Tell(new Udp.Bind(Self, listenOn));
        }

        protected override bool Receive(object message)
        {
            return message
                .Match()
                .With<Udp.Bound>(() => Context.Become(Ready(Sender)))
                .With<Cancel>(() => Context.Stop(Self))
                .WasHandled;
        }

        private Receive Ready(IActorRef socket)
        {
            return (object message) =>
            {
                return message
                .Match()
                .With<Udp.Received>(r =>
                {
                    if (datagrams.Count >= maxBufferSize)
                    {
                        log.Warning($"Datagram buffer size {maxBufferSize} exceeded");
                        Context.Become(Suspend(socket));
                    }
                    else if (datagrams.Count == 0 && TotalDemand > 0)
                    {
                        OnNext(r);
                    }
                    else
                    {
                        datagrams.Enqueue(r);
                        Deliver();
                    }
                })
                .With<Request>(() => Deliver())
                .With<Udp.Unbind>(() => socket.Tell(Udp.Unbind.Instance))
                .With<Udp.Unbound>(() => OnCompleteThenStop())
                .With<Cancel>(() => socket.Tell(Udp.Unbind.Instance))
                .WasHandled;
            };
        }

        private Receive Suspend(IActorRef socket)
        {
            return (object message) =>
            {
                return message
                .Match()
                .With<Udp.Received>(() => log.Debug("Dropping UDP datagram while suspended"))
                .With<Request>(() =>
                {
                    Deliver();
                    log.Info("Datagram buffer size is ok, resuming");
                    Context.Become(Ready(socket));
                })
                .WasHandled;
            };
        }

        private void Deliver()
        {
            while (TotalDemand > 0 && datagrams.Count > 0)
            {
                var elem = datagrams.Dequeue();
                OnNext(elem);
            }
        }
    }
}
