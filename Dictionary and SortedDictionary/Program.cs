using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Dictionary_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>()
            {
                ["Olia O."] = "1245454545",
                ["Tolia T."] = "7775454545",
                ["Alex A."] = "55545454545",

            };
            foreach (KeyValuePair<string, string> p in contacts)
            {
                Console.WriteLine($"{p.Key} : {p.Value}");
            }
            string phone = contacts.GetValueOrDefault("Olia O..");
            Console.WriteLine(phone ?? "No phone");

            Console.WriteLine($"Count : {contacts.Count(x => x.Key.ToLower().Contains('o'))}");
            //Console.WriteLine(contacts);

            SortedDictionary<string, int> employees = new SortedDictionary<string, int>
            {
                ["Petro"] = 123456,
                ["Ivan"] = 223456,
                ["Ann"] = 17456,

            };
            foreach (KeyValuePair<string, int> p in employees)
            {
                Console.WriteLine(p);
            }
        }
    }
}
