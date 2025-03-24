using System.Net;

Console.WriteLine("----- Methods--------");

//Console.WriteLine(IsValidIPAddress("0.0.0.255"));


bool IsValidIPAddress(string ipAddress)
{
    return IPAddress.TryParse(ipAddress, out _);
}

bool IsValidUri(string ipAddress)
{
    return Uri.TryCreate("http://a.com", 0, out _);
}
Print("I love C#");


double number = 10.2;
DoubleValue(ref number);
Console.WriteLine($"After DoubleValue() number = {number}");

int[] arr1 = { 10, 11, 20 };
IncArray(arr1);
PrintArray(arr1);

int size = 10;
int[] arr2 = new int[size];
FillRandomArray(arr2);  
PrintArray(arr2);


RemoveLastInArray(ref arr2);
PrintArray(arr2);

double a = 22, b = 33, c = 44.5, x1, x2; // out параметри можуть НЕ ініціалізуватися перед викликом функції
SquareRoots(a, b, c, out x1, out x2);
Console.WriteLine($"\nx1 = {x1} x2 = {x2}");

int val1 = 10, val2 = 33, val3 = 100;
Console.WriteLine($"\nAverage = {Average(val1, val2, val3):F4}");

// для коротких функцій (на 1 оператор, але if-switch-цикли не можна) можна використати стрілковий запис
void Print(string message) => Console.WriteLine(message);

double Average(int a, int b, int c) => (double)(a + b + c) / 3;

//void Print(string  message)
//{
//    Console.WriteLine(message);
//}
// ref параметр передається за посиланням, тобто функція(метод) приймає оригінал
void DoubleValue(ref double value) // double - тип значення, 
{
    value *= 2;// зміна оригіналу
}

// out параметр передається за посиланням, використовуэться для вихідних параметрів (результатів)
void SquareRoots(double a, double b, double c, out double x1, out double x2)
{
    x1 = a;
    x2 = b;
}

void FillRandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 201); // 100..200
}
void IncArray(int[] array) // збільшує елементи  масиву на 1, int[] - посилання на масив
{
    for (int i = 0; i < array.Length; i++)
        ++array[i];
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Array : ");
    foreach (int el in array) // foreach - вміє тільки читати
        Console.Write($"{el, 4}");
    Console.WriteLine();
}

void RemoveLastInArray(ref int[] array) =>

    Array.Resize(ref array, array.Length-1);
