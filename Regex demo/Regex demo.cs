
using System.Text.RegularExpressions;

string input = "My phone number is 097-123-7893. What is you pHONE number? Do you remember old telephone?";

string pattern = @"\d"; // \d — будь-яка цифра

MatchCollection matches = Regex.Matches(input, pattern);

Console.WriteLine($"Count of digits : {matches.Count}");
Console.WriteLine("Found digits:");
foreach (Match match in matches)
{
    Console.WriteLine($"{match.Value} in index {match.Index}");
}

pattern = @"\w{2,3}";
Console.WriteLine($"\nSearch by regex {pattern}");
foreach (Match match in Regex.Matches(input, pattern))
{ 
    Console.WriteLine($"{match.Value} in index {match.Index}");
}

string result = Regex.Replace(input, @"\d", ".");
Console.WriteLine($"After replacements digits to '.'");
Console.WriteLine(result);

pattern = @"\bphone\b";
result = Regex.Replace(input, pattern, String.Empty, RegexOptions.IgnoreCase);
Console.WriteLine($"After removing '{pattern}'");
Console.WriteLine(result);
Console.WriteLine();

result = Regex.Replace(input, pattern, (Match m) =>
{
    return char.ToUpper(m.Value[0]) + m.Value.Substring(1);
}, 
RegexOptions.IgnoreCase);

Console.WriteLine($"After changing first letter to Upper case {pattern} ");
Console.WriteLine(result);


input = "t_kyryk2025@gmail.com";
pattern = @"^(\w{2,}@\w{2,5}\.\w{2,3})$";
if (Regex.IsMatch(input, pattern))
{
    Console.WriteLine($"Good match email : {input}");
}
else
{ 
    Console.WriteLine("Bad match email");
}