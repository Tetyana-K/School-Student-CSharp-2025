// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------Generic methods--------"); // узагальнення

int val1 = 10, val2 = 20;
Print(val1, val2);
Swap(ref val1, ref val2);
Print(val1, val2);
Console.WriteLine();

string str1 = "one", str2 = "two";
Print(str1, str2);
Swap(ref str1, ref str2);
Print(str1, str2);

double[] arr = { 1.1, 2.3, 5.6, 7.8 };
int index = FindInArray(arr, 5.6);
Console.WriteLine(index);


void Swap<T>(ref T a, ref T b) // generic
{
    T tmp = a;
    a = b; 
    b = tmp;
}
void Print<T> (T a, T b)
{
    Console.WriteLine($"first = {a}, second = {b}");
}

int FindInArray<T>(T[] arr, T value) // where T: struct
{
    if (arr is null)
        throw new ArgumentNullException(nameof(arr));
   
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Equals(value))
            return i;
    }
    return -1;
}
