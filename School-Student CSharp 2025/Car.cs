using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace School_Student_CSharp_2025
{
    // encapsulation
    // internal біля класу - клас буде видимий тільки у поточному проекті (збірці = assembly)
    // public  біля класу - клас буде видимий  у  інших  проектах (збірках)
    internal class Car // наш клас неявно успадкувався выд супертипу (суперкласу) object
    {
        // поля, описують характеристики Авто         private, protected, public
        private string brand = "Nobrand"; // поле
        private int year = 0;

        // методи (функції), виконують певну роботу для Авто

        // ctor - constructor, метод неявно викликається при створенні обєкта (1 раз)
        public Car(string brand, int year) // конструктор із 2-ма параметрами (параметризований к-р)
        {
           SetBrand(brand);
           SetYear(year);
            // this.brand = brand;
           //this.year = year;
        }
        public Car(string brand) // конструктор із 1-м параметром (параметризований к-р)
         : this(brand, 2020)  // к-р каскадно викликаэ інший к-р з 2-ма параметрами
        {
           // SetBrand(brand); // бачимо, що повторюємо код, можемо уникнути через каскадний виклик підходящого конструктора this(., .)
           // SetYear(2020);
        }
        public Car()
        {
            this.year = 2020;
            this.brand = "Unknown";
        }
        public void SetBrand(string brand) // brand - параметр методи
        {
            //if(brand!="")
            if(!string.IsNullOrWhiteSpace(brand) && char.IsUpper(brand[0]))
                this.brand = brand; // this - посилання на обєкт, для якого працює метод
        }
        public string GetBrand() 
        {
            return brand;
        }
        public void SetYear(int year)
        {
            if (year >= 1886 && year <= DateTime.Now.Year)
            {
                this.year = year;
            }
        }
        public int GetYear()
        {
            return year;
        }
        public void Print()
        {
            Console.WriteLine($"Car brand : {brand}. Car year : {year}");
        }
    }
}
