// See https://aka.ms/new-console-template for more information
using Abstract_class;

Console.WriteLine("----- Abstract class-----");

//Human human = new Human("Olena"); створити екземпляр абстр типу НЕ МОЖНА

Human dev = new Developer("Andrii", "C#"); // посиланню на абстр клас можна присвоїти посилання на обєкт похідного типу
dev.Busy();
Console.WriteLine($"{dev.Demo}");