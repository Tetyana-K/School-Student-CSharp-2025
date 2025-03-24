using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler
{
    class Subscriber
    {
        public string Name { get; set; }
        public void Handler(object sender, EventArgs args) // non static
        {
            Console.WriteLine($"Customer {Name} was notified from {(sender as NewsStreamEH).Title}");
            //Console.WriteLine($"Customer {Name} was notified about : '{message}'");
        }
    }
}
