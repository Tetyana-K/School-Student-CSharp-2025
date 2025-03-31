using System.Collections;

Console.WriteLine();

var s = new Seasons();
foreach (var item in s)
{
    Console.WriteLine(item);
}
class Seasons : IEnumerable<string>
{
    static  string[] seasons = ["win", "spr", "sum"];

    //public IEnumerator<string> GetEnumerator()
    //{
    //    return ((IEnumerable<string>)seasons).GetEnumerator();
    //}

    public IEnumerator<string> GetEnumerator()
    {
        //    yield return "winter";
        //    yield return "spr";
        //    yield return "summer";
        return (seasons as IEnumerable<string>).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return seasons.GetEnumerator();
    }
}