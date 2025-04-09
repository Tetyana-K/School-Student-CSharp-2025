string path = "../../..";
Console.WriteLine($"Current directory : {Directory.GetCurrentDirectory()}");
Directory.SetCurrentDirectory(path);
Console.WriteLine($"Current directory : {Directory.GetCurrentDirectory()}");

Directory.CreateDirectory("Folder A");
Directory.CreateDirectory("Folder B");
Directory.CreateDirectory("Folder A/AA");

File.WriteAllText("Folder A/a.txt", "Hello from a.txt");

string pathExample = "D:\\It Step Examples\\School-Student CSharp 2025";


if (Directory.Exists(pathExample))
{
    Console.WriteLine($"\n\nDirectory {pathExample} exists");
	foreach (var dir in Directory.GetDirectories(pathExample))
	{
        Console.WriteLine(dir); // <dir> CreationTime
	}
    Console.WriteLine();
	foreach (var file in Directory.GetFiles(pathExample))
	{
        Console.WriteLine(file); // size
		//FileInfo info = new FileInfo(file);
		//info.Length
	}
}