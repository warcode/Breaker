using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    public class WebHostModule : NancyModule
    {
        public WebHostModule()
        {
            Get["/"] = parameters => 
            {
                return View["Chat.html"];
            };
        }
    }

}
