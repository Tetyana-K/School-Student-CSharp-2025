// See https://aka.ms/new-console-template for more information
Console.WriteLine("----Lambda functions----");

// лямбда функція - неіменована функція, яку можна визначити на льоту при виклику функції

Predicate<int> predicate = (int x) => x % 3 == 0;
int value = new Random().Next(100);
Console.WriteLine($"{value }  is divisable 3 : {predicate(value)}");


Action<int, double, string > action = (a, b, str) => Console.WriteLine($"{a}, {b}, '{str}'");
action(101, 3.4, "Text");

Func<int, int, int> fun = (int left, int right) =>
{
    int sum = 0;
    for (int i = left; i <= right; ++i)
        sum += i;
    return sum;
};
int l = 2, r = 5;
Console.WriteLine($"sum ({l}, {r}) =  {fun(l, r)}");

int[] arr = { 10, -23, 44, 55, 100, -34 };
int countPositive = arr.Count( x => x > 0);
Console.WriteLine($"\n\nCount positive in array = {countPositive}");

Console.WriteLine("\nNew array with even elements from origin array");
int[] evenArray = Array.FindAll(arr, x => x % 2 == 0);
Console.WriteLine($"{String.Join( ", ", evenArray)}");


Console.WriteLine($"{DateTime.UtcNow}");