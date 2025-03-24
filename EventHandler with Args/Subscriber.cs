using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler_With_Args
{
    class Subscriber
    {
        public string Name { get; set; }
        public void Handler(object sender, NewsStreamEventArgs args) // non static
        {
            Console.WriteLine($"Customer {Name} was notified about : '{args.Message}'");
           // Console.WriteLine(sender);
        }
    }
}
