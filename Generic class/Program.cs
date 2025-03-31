// See https://aka.ms/new-console-template for more information
using Generic_class;

Console.WriteLine("---------My  generic Stack <>--------");
MyStack<double> stack = new MyStack<double>();

Console.WriteLine($"Count : {stack.Count}");

stack.Push(1.123);
stack.Push(2.255);
stack.Push(30.33);

foreach(double d in stack)
    Console.WriteLine(d);

var clone = stack.Clone() as Stack<double>;

foreach (double d in clone)
    Console.WriteLine(d);


Console.WriteLine($"Count after Push(): {stack.Count}");

Console.WriteLine($"\nPeek : {stack.Peek()}");
stack.Pop();
Console.WriteLine($"Peek : {stack.Peek()}");
//Console.WriteLine($"Peek : {stack.Pop()}");
