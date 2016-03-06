using Akka.Actor;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    class WebHostActor : ReceiveActor
    {

        IDisposable server;
        public WebHostActor()
        {
            var url = "http://+:8080";

            server = WebApp.Start<Startup>(url);
        }

        protected override void PostStop()
        {
            server.Dispose();
            base.PostStop();
        }
    }
}
