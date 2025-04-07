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
            arr = new int[DefaultSize];// 4 * 10 000 = 40 000
            Console.WriteLine($"Was created block # {Id}");
        }
        ~Demo() // finalizer/ destructor спрацює при вилученні обєкта (під час збірки сміття)
        {
            Console.WriteLine($"~~~~~~~~~~~ Removed block {Id}");
        }
    }

  
    class Program
    {
        static void Main(string[] args)
        {

            //GC не проацює із зімнними на стеку, працює із обєктами, створеними у дин. памяті

            Console.WriteLine($"\t\tMemory : {GC.GetTotalMemory(false) / Math.Pow(2, 10)}");
            int times = 9;
            Demo a = new Demo(); //  [id = 1  ]
            for (int i = 0; i < times; i++)
            {
                a = new Demo(); // [ id 2]       [id 3]        3 4     a---> [10]
            }

            Demo b = new Demo();// b---> id 11
            for (int i = 0; i < times; i++)
            {
                b = new Demo();//  12 13       b --> 20
            }

            Console.WriteLine($"\n\n___a generation {GC.GetGeneration(a)} # {a.Id}____"); // 0   10
            Console.WriteLine($"___b generation {GC.GetGeneration(b)}  # {b.Id}____"); // 0      20
            Console.WriteLine($"\t\tMemory : {GC.GetTotalMemory(false) / Math.Pow(2, 10)}");


            Console.WriteLine("__________Collection 0 generation______");
            GC.Collect(0);// only in 0-generation  залишаться живими ід = 10 і 20
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine($"\n\n___a generation {GC.GetGeneration(a)}____");// ----> 1
            Console.WriteLine($"___b generation {GC.GetGeneration(b)}____\n"); // ----> 1

            a = null; // id 10
            Demo c = new Demo(); // c = 21
            for (int i = 0; i < times * 40; i++)
            {
                c = new Demo();// c---> 22 ....      c---> 30
            }
           
            GC.Collect(1);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("______________End Main()________");

            
        }
    }
}
