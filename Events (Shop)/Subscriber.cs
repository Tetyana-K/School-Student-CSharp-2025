using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Subscriber
    {
        public string Name { get; set; }
        public void Handler(string message) // non static
        {
            Console.WriteLine($"Customer {Name} was notified about : '{message}'");
        }
    }
}
