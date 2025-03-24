using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class NewBorn : IEat// NewBorn реалізує інтерфейс IEat
    {
        public string Name { get; set; } = "Noname";
        public void Eat()
        {
            Console.WriteLine($"Baby {Name} can eat");

        }
    }
}
