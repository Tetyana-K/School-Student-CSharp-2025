// See https://aka.ms/new-console-template for more information
Console.WriteLine("Null operations");

string name = "John";// null; // немаж значення    name----> ["John"]
//string name =  null; // name  не має значення, name = нульове посилання

//int number = null; // number типу int (тип значення, value-тип)

// ??, ??=  операції null coalescing operation (операції null злиття)
Console.WriteLine(name ?? "Noname"); // name !=null

string text = "my text"; // text ----> ["my text"]
string substring = "my";
Console.WriteLine($"String '{text}' has {text.Length} symbols"); // 7
Console.WriteLine($"Does '{text}' start with '{substring}' : {text.StartsWith(substring)}"); // true
                                                       
text = null;    // 
// ?. null conditional operation

Console.WriteLine($"String '{text}' has {text?.Length} symbols"); // text?.Length - повертає довжину рядка, або null, якщо у рядку нульове посилання
Console.WriteLine();

int[] arr = { 10, 20, 3, 4, 50, 60, 7, 100}; // arr ------> [10, 20, 3, 4, 50, 60, 7, 100]
Console.WriteLine($"First element of array : {arr?[0]}"); // 10
arr = null;
Console.WriteLine($"First element of array : {arr?[0]}");
Console.WriteLine();

double[] prices = { 10.1, 20.2, 4.5 };
//prices = null;//

prices ??= new double[10]; // якщо масив  null, то тоды він (prices) створюється (prices посилається на новий масив з 10 елементів)
Console.WriteLine($"Array prices has {prices.Length} elements");

Console.WriteLine("\nNullable types");
int? mark = 100;
mark = null;
if (mark.HasValue)
{
    Console.WriteLine($"Variable mark has value {mark.Value}");
}
else
{
    Console.WriteLine($"Variable mark does not have value (it is null)");
}

int mark2 = 80;

Console.WriteLine($"Sum mark = {mark.GetValueOrDefault() + mark2}"); // 0 + 80
Console.WriteLine($"Mult mark = {mark.GetValueOrDefault(1) * mark2}"); // 1 * 80

DateTime? date = null; //default;// DateTime.Now;
Console.WriteLine(date);

// Створити клас Учень з полями Імя та  масив нулабельних оцінок (оцінка може бути null).
// Визначити конструктор з параметрами ім'я та число оцінок у масиві. Якщо ім'я передається як null, то сетити (присвоїти) у поле рядок "Noname"
// Визначити метод для зміни оцінки. Метод приймає індекс оцінки та саму оцінку (оцінка може бути null)
// Визначити метод, який повертає середню оцінку, яка рахується як сума усіх не null-оцінок, поділено на кылькысть не null-оцінок.