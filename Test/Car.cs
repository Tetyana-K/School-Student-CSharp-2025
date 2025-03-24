using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Car : IDrivable
    {
        public void StartEngine()
        {
            Console.WriteLine("Car Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }

        public void Drive()
        {
            Console.WriteLine("Car is being drived.");
        }
    }
}
