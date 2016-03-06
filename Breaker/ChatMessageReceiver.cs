using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    class ChatMessageReceiver : ReceiveActor
    {
        IActorRef filter = Context.ActorOf<ChatMessageFilter>("filter");

        public ChatMessageReceiver()
        {
            Receive<ChatMessage>(message => {
                filter.Tell(message);
            });
        }
    }
}
