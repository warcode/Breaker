using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    class ChatMessageDistributor : ReceiveActor
    {
        public ChatMessageDistributor()
        {
            Receive<ChatMessage>(message => {
                Console.Out.WriteLine("out: " + message.Content);
                Context.ActorSelection("/user/signalr").Tell(message);
            });
        }
    }
}
