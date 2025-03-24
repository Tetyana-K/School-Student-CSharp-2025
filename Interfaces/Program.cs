// See https://aka.ms/new-console-template for more information
using Interfaces;

Console.WriteLine("-----------Interfaces----------");
NewBorn baby = new NewBorn() { Name = "Anton"};
baby.Eat();
Console.WriteLine();

Dancer dancer = new Dancer() { Name = "Vadym" };
dancer.Eat();
dancer.Walk();
dancer.Dance();

IEat eatable = baby; // посилання на інтерфейс = посилання на обєкт baby
eatable.Eat(); // ok
(eatable as IDance)?.Dance(); //  НІЧОГО НЕ ВІДБУДЕТЬСЯ, бо eatable не можливо привести до інтерфейсу IDance(там зараз baby, для якого не реалізовано інтерфейс IDance)

Console.WriteLine();

eatable = dancer;
eatable.Eat();
(eatable as Dancer)?.Dance(); // ok

//IWalk walk = new IWalk(); compile error