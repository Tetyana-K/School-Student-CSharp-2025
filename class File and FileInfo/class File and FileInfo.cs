using System.IO;

string content = @"Hello students!
Today's
topic
is
'Files'";

string path = "../../../hello.txt";

File.WriteAllText(path, content);

Console.WriteLine($"File content:\n{File.ReadAllText(path)}");

string[] lines = { "First line", "Second line" };
File.WriteAllLines(path, lines);
File.AppendAllText(path, "Third Line");
Console.WriteLine($"\nNow file content:\n{File.ReadAllText(path)}");

//File.Copy(path, "../../../hello-copy.txt"); // exception if file exists
File.Copy(path, "../../../hello-copy.txt", true); // rewrite destination if file exists

//File.Delete(path);
Console.WriteLine();

if (File.Exists(path))
{
    Console.WriteLine($"File {path} exists");
}
else
{
    Console.WriteLine($"File {path} does not exist");
}
Console.WriteLine($" Attributes : {File.GetAttributes(path)}");

FileInfo f = new FileInfo(path); // create object FileInfo
Console.WriteLine($"File exists : {f.Exists}");
Console.WriteLine($"File size : {f.Length}");
Console.WriteLine($"File creation time : {f.CreationTime}");




