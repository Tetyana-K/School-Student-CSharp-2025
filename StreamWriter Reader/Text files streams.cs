// See https://aka.ms/new-console-template for more information
using System.IO;
string path = "demo.txt";
string text = "Hello files!";
int value = 888;
DateTime today = DateTime.Today;
// StreamWriter - файловий потік для запису у текстовий файл
using (StreamWriter writer = new StreamWriter(path, false))// відкрили файловий потік, повязали з файлом по шляху path
{
    writer.WriteLine(text); //пишемо рядок text у файловий потік
    writer.WriteLine($"Value : {value}");// пишемо форматований текст у файловий потік
    writer.WriteLine($"Today : {today}");// пишемо форматований текст у файловий потік
    
}// спрацює метод Dispose(), який закриє файловий потік

Console.WriteLine($"We have read string and formatted string to file {path}");

// StreamWriter - файловий потік для зчитування з текстового файлу
using (StreamReader reader = new StreamReader(path)) // відкрили файловий потік, пов'язали з файлом по шляху path
{
    //string line = reader.ReadLine(); читаємо з файлу перший рядок
    //Console.WriteLine(line);
    //line = reader.ReadLine(); читаємо з файлу другий рядок
    //Console.WriteLine(line);

    string content = reader.ReadToEnd(); // читаємо весь вміст файлу від поточної позиції файлу до кінця файлу
    Console.WriteLine($"Content of file {path}");
    Console.WriteLine(content);
}//

Console.WriteLine();

//читання файлу порядково
using (StreamReader reader = new StreamReader(path))
{
    int number = 1;
    Console.WriteLine($"Content of file {path} line by line");
    while (!reader.EndOfStream)//line != null)
    {
        string line = reader.ReadLine();
        Console.WriteLine($"#{number++} : {line}");
    }
}

//читання файлу поcимвольно
using (StreamReader reader = new StreamReader(path))
{
    Console.WriteLine($"\nContent of file {path} symbol by symbol");
     int symbol = reader.Read();
    while (!reader.EndOfStream)//  (symbol !=-1)
    {
     Console.Write($" {(char)symbol}");
     symbol = reader.Read();
    }
}
