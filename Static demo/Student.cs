using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_demo
{
    internal class Student
    {
        public readonly int Id;
        public string Name { get; set; } //  auto prop

        private static string school = "Academy";

        private static int lastId = 0;// new Random().Next(100, 200);

        static Student() // статичний к-р, викликаэться до 1-го звертання до класу 
        {
            Console.WriteLine("_______Static ctor done_________");
            school = "ACADEMY";
        }
        public Student(string name)
        {
            Id = ++lastId;
            Name = name ?? "Noname"; //Name =  name!= null ? name : "Noname"
        }
        public static string  School // статична властивість може працювати із стат полем
        {
            //get { return Name; } // this не приходить 
            get { return school; } 
            set { school = value ?? "Some school"; }
        }

        public override string ToString()
        {
            return $"#{Id} {Name}";
        }

    }
}
