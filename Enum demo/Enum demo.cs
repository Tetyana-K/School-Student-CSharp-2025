// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------Enum Demo ------");

Season season = Season.Winter; // season = 1
Console.WriteLine($"{season} {(int)season}");
string nameOfSeason = season.ToString();
Console.WriteLine();

Console.WriteLine("Enter season:");
if (Enum.TryParse<Season>(Console.ReadLine(), true, out season))// 4    5
{
    Console.WriteLine($"You entered {season} {(int)season}"); // Autumn 4    5 5 
    if (Enum.IsDefined<Season>(season))
    {
        Console.WriteLine("It is right season"); // It is right
    }
    else
    {
        Console.WriteLine($"It is not right season");
    }
}
Console.WriteLine();

Console.WriteLine("Names of seasons");
string[] seasonsNames = Enum.GetNames<Season>();
foreach (string s in seasonsNames)
{
    Console.WriteLine(s);
}
Console.WriteLine();

var seasonValues = Enum.GetValues<Season>();
foreach (var s in seasonValues)
{
    Console.WriteLine($"season = {s} has value {(int)s}");
}

Console.WriteLine("\nCombined"); // зараз не дуже вдало
season  = Season.Winter | Season.Spring; // 1 | 2      0000000001 (1)   |  000000010 (2) = 00000011
Console.WriteLine($"Combined season : {season}");

Color color = Color.Blue | Color.Yellow;
Console.WriteLine($"Color :{color} Value: {(int)color}");
// усі наші enum-и неявно успадковуються від класу Enum
enum Season /*: byte*/  { Winter = 1, Spring , Summer , Autumn }; // byte = 0..255

[Flags]
enum Color {Blue = 1, Green = 2, Red = 4, Yellow = 8 }; // для вірної роботи комбінованого (flag) enum

// Створити переліковний тип для Категорії товару (наприклад, Electronics = 1, Furniture = 2, Food = 3).
// а) Вивести  назви усіх категорій
// б) ввести з клавіатури категорію та провалідувати введене значення (організувати цикл, що користувач вводить категорію доки не введе вірне значення).