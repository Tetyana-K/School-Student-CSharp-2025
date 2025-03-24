using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Task 1  Array.cs,  IOutput.cs
            Console.WriteLine("Task 1");
            Console.WriteLine();
            int[] data = { 123, 234, 345, 456, 567 };
            Array array = new Array(data);

            Console.WriteLine("Without message");
            array.Show();

            Console.WriteLine();
            Console.WriteLine("With message");
            array.Show("This is your array:");
            /// Task 1
            /// Task 2  ArrayT2.cs, IMath.cs
            Console.WriteLine("Task 2");
            Console.WriteLine();
            int[] testData = { 4, 2, 13, 3, 4, 5 };
            ArrayT2 arr = new ArrayT2(testData);

            Console.WriteLine("Max: " + arr.Max());
            Console.WriteLine("Min: " + arr.Min());
            Console.WriteLine("Avg: " + arr.Avg());
            Console.WriteLine("Search 7: " + arr.Search(7));
            Console.WriteLine("Search 10: " + arr.Search(5));
            /// Task 2
            /// Task 3 IDrivable.cs, Car.cs, Motorcycle.cs, Driver.cs
            Console.WriteLine("Task 3");
            Console.WriteLine();
            Car myCar = new Car();
            Motorcycle myMotorcycle = new Motorcycle();
            Driver driver = new Driver("Artem");

            Console.WriteLine("Driving a car");
            driver.DriveVehicle(myCar);

            Console.WriteLine("Driving a motorcycle");
            driver.DriveVehicle(myMotorcycle);
            /// Task 3
        }
    }
}
