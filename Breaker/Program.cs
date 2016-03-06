using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka;
using Akka.Actor;

namespace Breaker
{
    class Program
    {
        static void Main(string[] args)
        {

            //var system = ActorSystem.Create("Breaker");

            //system.ActorOf<WebHostActor>("webhost");
            //system.ActorOf<SignalRActor>("signalr");
            //var distributor = system.ActorOf<ChatMessageDistributor>("distributor");


            while(true)
            {
                var input = Console.In.ReadLine();
                if (input == "quit") break;

                ActorSystemContainer.receiver.Tell(new ChatMessage("me", "you", input));

            }


            ActorSystemContainer.system.Terminate();

        }
    }
}
