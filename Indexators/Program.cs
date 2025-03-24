
Console.WriteLine("---Indexators------");

Colors cols = new Colors();
try
{

    Console.WriteLine($"index 0 : {cols[0]}"); // get індексатора
    Console.WriteLine($"index 1 : {cols[1]}");
    Console.WriteLine($"index 2 : {cols[2]}");
    cols[0] = "violet"; // set індексатора

    Console.WriteLine($"\nindex 0 : {cols[0]}");
    Console.WriteLine($"index 3 : {cols[3]}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error : {ex.Message}");
}

class Colors
{
    private string[] colors;
    public Colors()
    {
        colors = new string[] { "blue", "green", "white"};
        colors[0] = "red";
    }

    // одновимірний індексатор з цілим індексом  = пишемо як властивість  typeResult this[type index]
    public string this[int index]
    {
        get => colors[index];
        set => colors[index] = value;
    }
}
