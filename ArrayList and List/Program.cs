using System;
using System.Collections; // collection and interface for object elements
using System.Collections.Generic; // generics collections and interfaces
namespace _01_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                10, 12, 100, 33, -23
            };
            li.Add(55);
            li.AddRange(new int[] { 22, 330 });

            ArrayList arrLi = new ArrayList()
            {
                "one", "two", "three", "four", 12, 200
            };
            arrLi.AddRange(new string[] { "five", "six" });
            //arrLi.Sort();
            foreach (var e in arrLi)
            {
                Console.Write($"{e,7}");
            }
            Console.WriteLine($"if contsins 12 : {arrLi.Contains(12)}");
        }
    }
}
