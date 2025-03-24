// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("------Standard delegates-----");

// Action - делегат на void -функцію

Action<string> action = Hello;
action("Ann");

Action<int, int> actionSum = PrintSum;
actionSum(12, 22);

// Func
Func<int, int, double> func = Avg;
Console.WriteLine($"Avg = {func(2, 3)}");

// Predicate  bool ()
Predicate<int> pred = IsEven;
Console.Write("\nEnter int value: ");
int value = int.Parse(Console.ReadLine());
Console.WriteLine($"IsEven : {pred(value)}");
static void Hello (string name)
{
    Console.WriteLine($"Hello, {name}!");

}
/*static*/ void PrintSum(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");

double Avg(int a, int b) => (a + b) / 2.0;

bool IsEven(int a) => a % 2 == 0;