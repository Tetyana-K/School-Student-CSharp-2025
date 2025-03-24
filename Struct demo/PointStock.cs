using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_demo
{
    internal class PointStock
    {
        private Point[] stock;
        public PointStock()
        {
            stock = new Point[0]; // створили масив нульвої довдини
        }
        public void Add(Point point) // метод додавання новоъ точки у кынець масиву
        {
            Array.Resize(ref stock, stock.Length + 1);// розширили масив на 1 елемент
            stock[stock.Length - 1] = point; // на останнє місце у розширеному масиві записали point
        }
        public void Print()
        {
            foreach (Point point in stock)
            {
                Console.WriteLine(point);
            }
        }
    }
}
