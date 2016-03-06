using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaker
{
    class ChatMessage
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public string Content { get; private set; }

        public ChatMessage(string from, string to, string content)
        {
            this.From = from;
            this.To = to;
            this.Content = content;
        }
    }
}
