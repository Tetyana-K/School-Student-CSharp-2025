using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Array : IOutput
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            Console.WriteLine("Elements of array:");
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }
}
