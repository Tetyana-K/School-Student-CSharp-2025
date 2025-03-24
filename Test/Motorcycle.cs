using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Motorcycle : IDrivable
    {
        public void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Motorcycle engine stopped.");
        }

        public void Drive()
        {
            Console.WriteLine("Motorcycle is being drived.");
        }
    }
}
