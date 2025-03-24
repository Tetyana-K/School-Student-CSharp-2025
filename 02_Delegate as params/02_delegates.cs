using System;

namespace _03_Delegate_as_parametr
{
    delegate bool MyPredicate(int number); // делегат під логічну функцію
    static class ArrayMethods // 
    {
        public static int CountElements( int[] arr, MyPredicate predicate) // predicate =   IsNegative
        {
            int counter = 0;
            foreach (var el in arr)
            {
                if (predicate(el))//  IsNegative(el)
                    ++counter;
            }
            return counter;
        }
    }
    class Program
    {
        static bool IsNegative(int number) // іменована функція
        {
            return number < 0;
        }
        static bool IsPositive(int number)
        {
            return number > 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, -2, -3, 22, 33, 44 };

            Console.WriteLine(ArrayMethods.CountElements(arr, IsNegative)); // predicate = IsNegative
            
            Console.WriteLine(ArrayMethods.CountElements(arr, x => x < 0 )); // predicate = IsNegative

            Console.WriteLine(ArrayMethods.CountElements(arr, IsPositive)); // predicate = IsPositive 

            //  x => x % 2 ==0 лямбда функція з параметром x
            Console.WriteLine(ArrayMethods.CountElements(arr, x => x % 2 ==0)); // рахували парні
            
            Console.WriteLine(ArrayMethods.CountElements(arr, x => x % 5 == 0));// рахували кратні 5

        }
    }
}
