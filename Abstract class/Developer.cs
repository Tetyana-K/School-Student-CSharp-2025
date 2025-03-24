using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal  class Developer : Human
    {
        private string language;

        public Developer(string name, string language)
            : base(name) 
        {
            this.language = language;
        }

        public override string Demo => "demo"; // реалізація абстр властивості, успадкованої від Human

        public override void Busy() // реалізація абстр методу, успадкованого від Human
        {
            Console.WriteLine($"Developer  {Name} is coding in {language} language");
        }
    }
}
