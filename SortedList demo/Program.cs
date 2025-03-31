using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace _02_Sorted_List
{
    class Program
    {
        static void Print(IDictionary collection)
        {
            foreach (DictionaryEntry pair in collection)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
        static void Main(string[] args)
        {
            // (object, object), але ключі повинні бути одного типу 
            SortedList sl = new SortedList() // pair DictionaryEntry  (Key, Value), unique keys, sorted by key, допускає роботу з парами по номеру! пари
           {
               { 123, "Petro P." },
               { 23, "Olia P." },
               { 55, "Olexandr P." },

           };
            Print(sl);
            sl.Clear();

            Console.WriteLine();
            sl.Add("hello", "привіт");
            sl.Add("ten", 10);

            if (!sl.ContainsKey("ten"))
                sl.Add("ten", "десять");
            else
                sl["ten"] = "десять";

            sl["hello"] = "доброго дня"; // OK
            sl["bye"] = "бувай";

            Print(sl);

            Console.WriteLine("\nEnter index of pair");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Key  by index {index} : {sl.GetKey(index)}");
            Console.WriteLine($"Value  by index {index} : {sl.GetByIndex(index)}");

            sl.RemoveAt(0);
            sl.Remove("ten");
            Console.WriteLine("\nAfter remove(0) and remove(\"ten\")");
            Print(sl);


            // sl.Add(100, "");
            SortedList<string, double> sl2 = new SortedList<string, double>()
            {
                ["ice-cream"] = 25.5,
                ["coffee"] = 15,
                ["cheese cake"] = 75.7

            };
            //Print(sl2);
            Console.WriteLine();
            foreach (var p in sl2)
            {
                Console.WriteLine($"{p.Key} ---- {p.Value}");
            }
            string key = "coffee";
            Console.WriteLine($"Index of pair with key {key} :{sl2.IndexOfKey(key)}");

            string product = "coffee";// "tea";
            double price = 12;
            if (!sl2.TryAdd(product, price))
            {
                Console.WriteLine($"\t\tProduct {product} is exist, adding  is impossible");
            }
            Console.WriteLine("\nAfter try add");
            Print(sl2);

            Console.WriteLine($"\nAccess for  get []");
            product = "tea";// "ice-cream";
            try
            {
                Console.WriteLine(sl2[product]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (!sl2.TryGetValue(product, out price))
            {
                Console.WriteLine($"Not found value with key {product}");
            }
            if (sl2.Remove("ice-cream", out price))
            {
                Console.WriteLine($"'ice-cream' was removed and its  price was {price}");
            }

        }
    }
}
