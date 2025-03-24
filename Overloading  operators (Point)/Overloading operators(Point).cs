using System;
using System.Numerics;

public class Point
{
    public double X { get; } // автовластивість
    public double Y { get; set; }

    public Point(double x, double y) // конструктор з 2 параметрами
    {
        X = x;
        Y = y;
    }

    // Перевантаження оператора додавання: p1 + p2
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    // Перевантаження оператора додавання: p1 + 2.5
    public static Point operator +(Point a, double value)
    {
        return new Point(a.X + value, a.Y + value);
    }
    // Перевантаження оператора віднімання: p1 - p2
    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    // Перевантаження оператора множення на дробове число (для масштабування точки): p * factor 
    public static Point operator *(Point a, double factor)
    {
        return new Point(a.X * factor, a.Y * factor);
    }

    // factor * p
    public static Point operator *(double factor, Point a)
    {
        return a * factor;
    }

    // Перевантаження оператора ++:  можемо використовувати дві форми (префіксну та постфіксну) ++p1; p1++;
    public static Point operator ++(Point a)
    {
        return new Point(a.X + 1, a.Y + 1);
    }
    // Перевантаження оператор явного приведення точки до типу double  double res = (double) p1
    public static explicit operator double(Point a)
    {
        return Math.Sqrt(a.X * a.X + a.Y * a.Y);
    }
    // Перевантаження оператора рівності ==
    public static bool operator ==(Point a, Point b)
    {
        // ReferenceEquals(a, b) - чи посилання однакові, якщо так  то а та b посилаються на ОДНУ і ту ж Точку
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false; // якщо одна із точок null
        return a.X == b.X && a.Y == b.Y;
    }

    // Перевантаження оператора нерівності !=
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);// a==b ми викликаємо раніше вище написану операцію == і обертаємо результат
    }

    // Перевизначення Equals для узгодженості з операторами == та !=
    public override bool Equals(object obj) // object сподівємося, що містить Точку 
    {
        if (obj is Point other) // is - перевіряє чи  obj є Точкою, то конвертує obj до other (Point)
            return this == other; // якщо так, то  викликаємо  написане  раніше ==
        return false;
    }

    //// Перевизначення GetHashCode (використовуємо X та Y)
    public override int GetHashCode() // радять при перевизначенні  Equals перевизначати GetHashCode()
    {
        //return X.GetHashCode() ^ Y.GetHashCode();
        return this.ToString().GetHashCode();
    }

    // Перевизначення ToString()
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
// операції > <    >= <=    == !=   перевантажуються парами
class Program
{
    static void Main()
    {
        Point p1 = new Point(2, 3);
        Point p2 = new Point(4, 5);
        Point p3 = new Point(4, 5);
        Point tmp = null;
        
        Point p4 = p1; // p4 посилається на таку саму точку як і p1

        // Використання перевантажених операторів
        Point sum = p1 + p2;       // Додавання точок
        Point diff = p1 - p2;      // Віднімання точок
        Point scaled = p1 * 2;     // Масштабування точки

        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");
        Console.WriteLine($"p2: {p3}");

        Console.WriteLine($"\np1 + p2: {sum}");
        Console.WriteLine($"p1 - p2: {diff}");
        Console.WriteLine($"p1 * 2: {scaled}");

        // Перевірка оператора перетворення до типу double
        double distance = (double) p1;
        Console.WriteLine($"double distance = (double) p1 {distance:F5}");

        // Перевірка операторів рівності
        Console.WriteLine($"\np1 == p2: {p1 == p2}");
        Console.WriteLine($"\np1 == tmp (null): {p1 == tmp}");

        // Equals для КЛАСІВ порівнює ПОСИЛАННЯ, для структур порівнює контент
        Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); 

        Console.WriteLine($"\np2 == p3: {p2 == p3}");
        Console.WriteLine($"p2.Equals(p3): {p2.Equals(p3)}");
        Console.WriteLine($"Hash codes for p2 and p3 : {p2.GetHashCode()}, {p3.GetHashCode()}"); // коли перевизначили GetHashCode(), то для однакових  об'єктів будуть однакові хеші (тобто  діємо узгоджено)

        Console.WriteLine($"\np1 == p4: {p1 == p4}");

        Console.WriteLine($"\np1 != p2: {p1 != p2}");
    }
}
