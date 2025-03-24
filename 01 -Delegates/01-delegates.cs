using System;

namespace _01_Delegates;

delegate void MDelegate(string message); // визначення ТИПУ MDelegate делегату (class)
class Greeting
{
    public static void Hello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    public static void Bye(string name)
    {
        Console.WriteLine($"Bye {name}!");
    }
}
class Program {
    static void Main(string[] args)
    {
        // делегати - посилальний тип
        MDelegate md = new MDelegate(Greeting.Hello); // md посилається на  статичний метод Hello із класу Greeting
        Console.WriteLine($"Now md ---> to method {md.Method}");
        md("Oleh"); // виклик функції Hello("OLeh") через делегат
        md.Invoke("Vlad"); // виклик функції Hello() через делегат
        md.Invoke("Alex");


        md = Greeting.Bye; // md посилається на  статичний метод Bye
        Console.WriteLine($"\nNow md ---> to method {md?.Method}");
        md("Vadym");// працює ф-я Bye

        md = null; // 
        Console.WriteLine($"\nNow md ---> to method {md?.Method}");
        md?.Invoke("T");

        md = Greeting.Hello;
        Console.WriteLine($"\nNow md ---> to method {md.Method}");
        md += Greeting.Bye; // md ---- Hello, Bye
//        md += Greeting.Hello; // md ---- Hello, Bye, Hello
        Console.WriteLine($"\nNow md ---> to method {md.Method}, but really ---> for list of methods Hello and Bye");
        md("Viktor");// Hello Viktor!  Bye Viktor!

        Console.WriteLine("\nAfter md-= Greeting.Bye");
        md -= Greeting.Bye; // від'єднує метод 
        md("Andriy"); // Hello Andriy
    }

} 
/* 
 * Створити статичний метод FindAll (масив, делегат), який отримує одновимірний масив та делегат(предикат) логічного типу для перевірки елемента масиву.
Метод повинен повертати новий масив із тих елементів масиву, які задовільняють певній ознаці.
*/