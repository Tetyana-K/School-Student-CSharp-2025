// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Xml;

Console.WriteLine("---Records-----");
// Записи (records) - типи посилання, використовують для незмінних (immutable) об'єктів

Person mykola = new Person("Mykola", 19);
Console.WriteLine(mykola); // Tostring() ...

Person person =  new Person("Mykola", 19);
Console.WriteLine($"Equals)person, mykola) : {Equals(person, mykola)}"); // Equals() для записів працює, як для структур, тобто порівнює вміст 
Console.WriteLine($"person== mykola : {person == mykola}"); // == порівнює  вміст записів
Console.WriteLine($"\nPerson's name : {person.Name}");
Console.WriteLine($"Person's age : {person.Age}");

//person.Age = 20; // помилка, намагаэмося змінити вік запису person

// Можна створити нову копію об'єкта з деякими зміненими полями за допомогою with:
Person newPerson = mykola with {Name = "Taras"};
Console.WriteLine($"newPerson : {newPerson}");

Employee emp = new Employee("Anton", 25, "Developer");
Console.WriteLine($"\nemp : {emp}");
//emp.Position = "New position";

Person[] people = { mykola, newPerson, emp };
foreach (var p in people)
{
    Console.WriteLine(p.Name);
}

Company company = new Company() { Title = "SoftServe", Country = "Ukraine"};
company.Title = "SOFTSERVE"; // властивість Title має set
 //company.Country = "UKRAINE";// помилка компіляції // властивість Title має init - тільки стартова ініціалізація
//Company company2 = new Company("a", "b");// 
Console.WriteLine($"\ncompany : {company}");


record Person(string Name, int Age);

// можна успадкуватися від Запису
record Employee(string Name, int Age, string Position) : Person(Name, Age);

//щоб зробити record частково змінним, можна використовувати init
record Company
{
    public string Title { get; set; }// init; }
    public string Country { get; init; }
    //public Company(string title, string country) // можна визначити конструктор
    //{
    //    this.Title = title;
    //    this.Country = country;
    //}

}
