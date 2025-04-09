// See https://aka.ms/new-console-template for more information

int[] numbers = { 500, 200, -90, 23, 110, -32, 70,  60, 41 };

// Linq to objects можна застосувати двома способами
// 1) через команду
// 2) через методи розширення

// 1 спосіб
var negativeNumbers = 
    from e in numbers // e формальний  параметр команди LINQ, позначаэ поточний елемент масиву numbers
    where e < 0 // умова відбору даних (фільтруємо) 
    select e; // що відбираємо, з чого буде формуватися вибірка

//int[] negElements = Array.FindAll(numbers, x => x < 0); - так можемо виконати завдання через метод FindAll() з класу Array

Console.WriteLine("Negative elements");
foreach (var num in negativeNumbers)
{
    Console.Write($"{num,5}");
}
Console.WriteLine();

// Отримати всі парні числа, відсортувати за спаданням, використали  2) через методи розширення
var evenNumbers = numbers
    .Where(n => n % 2 == 0)
    .OrderByDescending(n => n);
    //.OrderBy(n => n);  //за зростанням

Console.WriteLine("Even elements:");
foreach (var num in evenNumbers)
{
    Console.Write($"{num, 5}");
}
Console.WriteLine();

var sum = numbers.Sum();
Console.WriteLine($"\nSum of all elements :\n{sum, 5}");

var sumGreater100 = numbers.Where(e => e >= 100).Sum();
Console.WriteLine($"\nSum of elements >=100 :\n{sum, 5}");

var max = numbers.Max();
Console.WriteLine($"\nMax element :\n{max, 5}");

var maxAfterFirstAndSecond = numbers.Skip(2).Max(); // пропустили перших два елементи, серед інших шукаємо максимальне
Console.WriteLine($"\nMax after first and second elements :\n{maxAfterFirstAndSecond, 5}");

var maxAfterFifthAndTakeThree = numbers.Skip(5).Take(3).Max(); // пропустили перших 5 елементів, взяли 3 елементи,  серед яких шукаємо максимальне
Console.WriteLine($"\nMax after first and second elements and Take :\n{maxAfterFifthAndTakeThree, 5}");

List<Employee> employees = new()
{
    new Employee("John", "Developer", 28),
    new Employee("Emily", "HR", 32),
    new Employee("Mark", "Developer", 24),
    new Employee("Sophie", "Manager", 35),
    new Employee("Daniel", "HR", 26),
    new Employee("Anna", "Manager", 29),
    new Employee("Ihor", "Developer", 29),
};

// працівники старші 30
var over30 = employees.Where(e => e.Age > 30);
Console.WriteLine("Employees over 30:");
foreach (var e in over30)
{
    Console.WriteLine($"\t{e.Name}, {e.Position}, {e.Age} years old");
}
Console.WriteLine("\n");

var developers = from e in employees
                 where e.Position == "Developer"
                 select   e.Name ;

Console.WriteLine("Employees with position 'Developer':");
foreach (var name in  developers)
{
    Console.WriteLine($"\t{name}");
}
Console.WriteLine("\n");

// Сортування по віку
var sorted = employees.OrderBy(e => e.Age);
Console.WriteLine("Employees sorted by age:");
foreach (var e in sorted)
{
    Console.WriteLine($"\t{e.Name}, {e.Position}, {e.Age} years old");
}
Console.WriteLine("\n");

// Групування по посаді
var grouped = employees.GroupBy(e => e.Position);
Console.WriteLine("Employees grouped by position:");
foreach (var group in grouped)
{
    // group.Key - тут буде назва посади (назва групи, бо групували по посаді)
    // group.Count() - число елементів в групі ( у нас число праціників по певній посаді)
    // group.Average(x => x.Age) - середній вік працівників поточної групи
    Console.WriteLine($"--------{group.Key}------\nCount - {group.Count()} Average age - {group.Average(x=>x.Age)}");
    foreach (var e in group) // так переглядаємо праціників, які попали в одну групу
    {
        Console.WriteLine($"\t{e.Name}, {e.Age} years old");
    }
}

Console.WriteLine("\n");

//вибір імен та посад (використали анонімні об'єкти)
var shortInfo = employees.Select(e => new { e.Name, e.Position }); // new { e.Name, e.Position } - створюються обєкти анонімного типу з іменем та посадою
Console.WriteLine("Short employee info:");
foreach (var item in shortInfo)
{
    Console.WriteLine($"{item.Name, 10}: {item.Position, 10}");
}
Console.WriteLine("\n");

// групування : парні та непарні
Console.WriteLine($"Grouped elements of array\n{String.Join("\t", numbers)}");
var intGrouped = from e in numbers 
                 group e by e % 2 ==0  // по чому групуємо (парні чи ні)
                 into g select g;
foreach (var g in intGrouped)
{
    Console.WriteLine($"Even numbers ? {g.Key}, Count - {g.Count()}");
    foreach (var el in g)
    {
        Console.Write($"{el, 4}");
    }
    Console.WriteLine();
}


public record Employee(string Name, string Position, int Age);