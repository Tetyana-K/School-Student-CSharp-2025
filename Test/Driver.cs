using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Driver
    {
        public string Name { get;}

        public Driver(string name)
        {
            Name = name;
        }

        public void DriveVehicle(IDrivable vehicle)
        {
            Console.WriteLine($"{Name} is going to drive");
            vehicle.StartEngine();
            vehicle.StopEngine();
            vehicle.Drive();
        }

    }
}
