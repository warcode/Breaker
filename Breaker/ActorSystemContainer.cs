using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    public static class ActorSystemContainer
    {

        public static ActorSystem system = ActorSystem.Create("Breaker");

        public static IActorRef webhost = system.ActorOf<WebHostActor>("webhost");
        public static IActorRef signalr = system.ActorOf<SignalRActor>("signalr");
        public static IActorRef receiver = system.ActorOf<ChatMessageReceiver>("receiver");

    }
}
