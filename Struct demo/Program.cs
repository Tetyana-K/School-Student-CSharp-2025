using Struct_demo;

Console.WriteLine("-------Demo Struct------------");


Point point1 = new Point(0, 0); // new означає створити новий об'єкт в даному випадку на СТЕКУ (бо  структури - value типи, зберіг на стеку )
Point point2 = new Point(2, 3);

Console.WriteLine($"Point #1 : {point1}");
Console.WriteLine($"Point #2 : {point2}");

double distance = point1.DistanceTo(point2);
Console.WriteLine($"Distance : {distance:f4}");

Point point3 = point2; // copy of point1 Для структур маємо  копіювання ВМІСТУ (значень полів)
Console.WriteLine($"Point #3 as copy of Point #2 : {point3}");

point3.X = 99;
Console.WriteLine("\nAfter point3.X = 99;");
Console.WriteLine($"Point #2 : {point2}");
Console.WriteLine($"Point #3 : {point3}");

Console.WriteLine($"\nCompare point2 and point3 : {point2.Equals(point3)}"); // метод порівнює поелементно поля структури point2 та point3

Point point4 = new () /*Point()*/ {X = 10, Y = 15 }; // створення об'єкта та ініціалізація через властивості
Console.WriteLine($"\nPoint #4 : {point4}");

Console.WriteLine("\n-------------Point's Stock-----------");

PointStock stock = new PointStock();
stock.Add(point1);
stock.Add(point2);
stock.Add(point3);
stock.Add(new Point(4,44));
stock.Print();
