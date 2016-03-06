using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    class ChatMessageFilter : ReceiveActor
    {
        IActorRef distributor = Context.ActorOf<ChatMessageDistributor>("distributor");

        public ChatMessageFilter()
        {
            Receive<ChatMessage>(message => {

                if(message.To == "test")
                {
                    distributor.Tell(message);
                }
            });
        }
    }
}
