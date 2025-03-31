using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Demo
{
    class Demo
    {

        public readonly int Id = ++lastId;
        private static int lastId = 0;
        int[] arr;
        public static int DefaultSize = 10_000;
        public Demo()
        {
            arr = new int[DefaultSize];
            Console.WriteLine($"Was created block # {Id}");
        }
        ~Demo() // finalizer
        {
            Console.WriteLine($"~~~~~~~~~~~ Removed block {Id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\t\tMemory : {GC.GetTotalMemory(false) / Math.Pow(2, 10)}");
            int times = 9;
            Demo a = new Demo(); //  [id = 1  ]
            for (int i = 0; i < times; i++)
            {
                a = new Demo(); // [ id 2]       [id 3]        3 4     a---> [10]
            }

            Demo b = new Demo();//b---> id 11
            for (int i = 0; i < times; i++)
            {
                b = new Demo();//  12 13       b --> 20
            }

            Console.WriteLine($"\n\n___a generation {GC.GetGeneration(a)} # {a.Id}____"); // 0
            Console.WriteLine($"___b generation {GC.GetGeneration(b)}  # {b.Id}____"); // 0
            Console.WriteLine($"\t\tMemory : {GC.GetTotalMemory(false)}");


            Console.WriteLine("__________Collection 0 generation______");
            GC.Collect(0);// only in 0-generation  залишаться живими ід = 10 і 20
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine($"\n\n___a generation {GC.GetGeneration(a)}____");// ----> 1
            Console.WriteLine($"___b generation {GC.GetGeneration(b)}____\n"); // ----> 1

            Demo c = new Demo(); // c = 21
            for (int i = 0; i < times; i++)
            {
                c = new Demo();// c---> 22 ....      c---> 30
            }

            Console.WriteLine("______________End Main()________");
        }
    }
}
