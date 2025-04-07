using System.IO;

string path = "../../my_bin_file.dat";
string text = "Hello students\n";
int value = 90; // Z
double valueD = 12.3455;

using (BinaryWriter fs = new BinaryWriter(new FileStream(path, FileMode.Create)))
{
    fs.Write(text);
    fs.Write(value);
    fs.Write(valueD);
}

using (BinaryReader fs = new BinaryReader(new FileStream(path, FileMode.Open)))
{
    string readText = fs.ReadString();
    int readValue = fs.ReadInt32();
    double readValueD = fs.ReadDouble();
    Console.WriteLine($"Read text : {readText}");
    Console.WriteLine($"Read value : {readValue}");
    Console.WriteLine($"Read double value : {readValueD}");
}

//Визначити клас(або структуру або запис) з полями string, int, DateTime (Продукт, Людина, Працівник).
//Визначити  статичний клас з методами запису обєкта  у бінарний файловий потік, відновлення обєкта із файлового потоку.
