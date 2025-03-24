using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Car_With_Props
{
    // internal біля класу - клас буде видимий тільки у поточному проекті (збірці = assembly)
    // public  біля класу - клас буде видимий  у  інших  проектах (збірках)
    internal class Car
    {
        // поля, описують характеристики Авто         private, protected, public
        private string brand = "Nobrand"; // поле
       
        private int year = 0;
        
        private int id = 1;

        // readonly - поле для читання, його можна встановити (ініціалізувати) 2-ма способами
        // 1) при визначенні поля   public readonly uint MaxSpeed = 220;
        // 2) конструктор класу
        public readonly uint MaxSpeed = 220;

        // методи (функції), виконують певну роботу для Авто

        // ctor - constructor, метод неявно викликається при створенні обєкта (1 раз)
        public Car(string brand, int year, uint maxSpeed = 120) // конструктор із 2-ма параметрами (параметризований к-р)
        {
           //SetBrand(brand);
           Brand = brand;// властивість = параметр конструктора, тут працює set властивості
           SetYear(year);
           MaxSpeed = maxSpeed;
            
        }
        public Car(string brand) // конструктор із 1-м параметром (параметризований к-р)
         : this(brand, 2020)  // к-р каскадно викликає інший к-р з 2-ма параметрами
        {
        }
        public Car()
        {
            this.year = 2020;
            this.brand = "Unknown";
        }
        // full property - поле + get +set
        public string Brand  // відкрита (public) властивість типу string для доступу до поля brand
        {
            get // get - для читання, поверта значення поля 
            {
                return this.brand; 
            }
            set // set - для запису нового значення (value) у поле brand
            {
               if (!string.IsNullOrWhiteSpace(value) && char.IsUpper(value[0]))
                    this.brand = value; 
            } 
        }
        // read only  property - поле + get
        public int Id 
        { 
            get 
            {
                return id;
            }
        }

        // auto-property, автовластивість, компілятор сам створить поле типу uint і для нього пропише властивіть (get, set)
        public uint Speed
        {
            get;
            set;
        } = 40; // можна 
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
           // MaxSpeed = 100; для перевірки, що readonly змінити не можна у методі
        }
        public override string ToString()
        {
            return $"Mark : {Brand}\tYear : {year}\tMaxSpeed : {MaxSpeed}";
        }
    }
}
// Доповнити клас Car властивостями Year та  Color. Перевизначити (override) метод ToString()