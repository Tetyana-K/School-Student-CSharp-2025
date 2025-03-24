using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    // абстрактний клас може містити реалізацію (поля, властивості, методи, в тому числі конструктор) та
    // НЕ реалізовану частину (абстрактний метод, властивість, подію)

    // НЕ МОЖНА створити екземпляр абстрактного класу, але можна користвуватися посиланням на абстр. тип
    abstract internal class Human
    {
        public string Name { get; set; } // реалізована автовластивість
        public Human(string name = "Noname") // конструктор
        {
            Name = name;
        }

        public abstract void Busy(); // абстрактний метод Busy() не має реалізаціїї,  потрібно буде реалізувати у похідному типі

        public abstract string Demo { get; } // абстрактна властивість, потрібно буде реалізувати у похідному типі
    }
}
