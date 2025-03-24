using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_demo
{
    // Структури відносяьться до value-типпів.
    // Тобто
    //          1) створюються на стеку
    //          2) при копіюванні - копіюється вміст (контент, значення полів) з однієї структури у іншу
    //          3) метод Equals() порівнює контент (поля) структур поелементно

    struct Point
    {
        //private string name = "Point";
        public int X { get; set; }// auto prop
        public int Y { get; set; }// auto prop

        //public Point()
        //{
        //    X = 0;
        //    Y = 0;
        //}
        public Point(int x, int y) // конструктор із параметрами
        {
            X = x;
            Y = y;
        }
        public double DistanceTo(Point other)
        {
            int deltaX = X - other.X;
            int deltaY = Y - other.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    //class ClassA : Point  // від структури НЕ можливо успадкуватися
    //{ }
    // Але структура може реалізовувати інтерфейси
}
