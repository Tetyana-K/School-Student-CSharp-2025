using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_demo
{
    internal class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<int> Grades { get; set;}

        public override string ToString()
        {
            return $"#{Id, -4}{Name, -15} {String.Join(",", Grades)}";
        }
    }
}
