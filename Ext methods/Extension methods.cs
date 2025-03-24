// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("-----Extension methods----");

Console.WriteLine("Enter text:");
string text = Console.ReadLine();
Console.WriteLine(text.FirstCaps());

int[] arr = { 10, 2, 3, 4, 5, 6, 7, 88, 99, 100 };
Console.WriteLine(String.Join("\t", arr));

//ExtArray.ReverseFragment(arr, 1, 6); // також можна викликати метод розширення як звичайний стат метод імя класу.Метод()
arr.ReverseFragment(2, 7);
Console.WriteLine(String.Join("\t", arr));

// 1) Пишемо статчиний клас (static class)
// 2) У цьому статичному класі статичний метод, першим параметром якого є параметр типу, який розширюємо + ключове слово this
static class ExtString
{
    public static string FirstCaps(this string str) // цей метод розширює клас String, перший параметр типу string 
    {
        string result = char.ToUpper(str[0]).ToString() + str.Substring(1);
        return result; // першу літеру у верхній регістр
    }
}

static class ExtArray
{
    // цей метод розширює тип одновимірного цілого масиву, перший параметр типу  int[] arr
    public static void ReverseFragment(this int[] arr, int left, int right) // left, right - індекси між початку та кінця фрагменту масиву, що обертається
    {
        if (left >= right)
            return;
        if (left < 0 || right >= arr.Length)
            return;

        for (int i = left, j = right; i < j; ++i, --j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}