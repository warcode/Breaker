using Akka.Actor;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    class SignalRActor : ReceiveActor
    {
        IUntypedActorContext c;

        public SignalRActor()
        {
            Receive<ChatMessage>(message => {
                var context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
                context.Clients.All.broadcastMessage(message.To, message.Content);
            });
        }

        public class ChatHub : Hub
        {
            public void Send(string name, string message)
            {
                // Call the broadcastMessage method to update clients.
                //Clients.All.broadcastMessage(name, message);
                
                ActorSystemContainer.receiver.Tell(new ChatMessage(name, "who", message));
            }
        }
    }


}
