using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/app", siteBuilder => siteBuilder.UseNancy()).MapSignalR();
        }
    }
}
