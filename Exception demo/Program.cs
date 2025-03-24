// See https://aka.ms/new-console-template for more information
using Exception_demo;

Console.WriteLine("_____Convertor_________");

double inch = 0;
while (true)
{
    Console.WriteLine($"Enter inches");
    try
    {
        inch = double.Parse( Console.ReadLine());
        Console.WriteLine($"{inch} inches = {Convertor.ToCm(inch)} cm");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Exited! See you later!");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Message : {ex.Message}");
    }
}
// Визначити статичний клас, який буде обчислювати площі трикутника за висотою і основою.Викидати винятки, якщо приходять невірні дані 
