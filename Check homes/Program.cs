using System;

public static class StringExtensions
{
    public static int CountSentences(this string str)
    {
        if (string.IsNullOrWhiteSpace(str)) return 0;
        char[] sentenceEndings = { '.', '!', '?' };
        return str.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

public record Car(string Make, string Model, int Year);
public record ElectricCar(string Make, string Model, int Year, int BatteryCapacity) : Car(Make, Model, Year);
public record Person(string FirstName, string LastName, int Age);
public static class PersonExtensions
{
    public static double AverageAge(this Person[] persons)
    {
        double sum = 0;
        foreach (var person in persons)
        {
            sum += person.Age;
        }
        return persons.Length > 0 ? sum / persons.Length : 0;
    }

    public static Person MinByAge(this Person[] persons)
    {
        if (persons.Length == 0) return null;
        Person min = persons[0];
        foreach (var person in persons)
        {
            if (person.Age < min.Age) min = person;
        }
        return min;
    }

    public static Person MaxByAge(this Person[] persons)
    {
        if (persons.Length == 0) return null;
        Person max = persons[0];
        foreach (var person in persons)
        {
            if (person.Age > max.Age) max = person;
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        string text = "Привіт! Як справи? Це тестовий рядок. Ось ще одне речення.";
        Console.WriteLine($"Кількість речень: {text.CountSentences()}");

        Car car = new Car("Toyota", "Corolla", 2020);
        ElectricCar eCar = new ElectricCar("Tesla", "Model S", 2022, 100);
        Console.WriteLine(car);
        Console.WriteLine(eCar);

        Person[] people = {
            new Person("Іван", "Петров", 30),
            new Person("Марія", "Іваненко", 25),
            new Person("Олексій", "Сидоренко", 40)
        };

        var youngest = people.MinByAge();
        var oldest = people.MaxByAge();
        Console.WriteLine($"Наймолодша людина: {youngest}");
        Console.WriteLine($"Найстарша людина: {oldest}");
        Console.WriteLine($"Середній вік: {people.AverageAge():F2}");
    }
}