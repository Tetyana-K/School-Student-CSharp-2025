using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Dancer : IDance, IWalk, IEat
    {
        public string Name { get; set; } = "Noname";
        public void Dance()
        {
            Console.WriteLine($"Dancer {Name} can dance");
        }

        public void Eat()
        {
            Console.WriteLine($"Dancer {Name} can eat");
        }

        public void Walk()
        {
            Console.WriteLine($"Dancer {Name} can walk");
        }
    }
}
