using Serialization_demo;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

Student andrii = new Student() {
    Name = "Andrii", 
    Id = 1, 
    Grades = new() {10 , 11, 12, 12 } 
};
Console.WriteLine($"We have object andrii:\n{andrii}");

string fileName = "student.xml";
XmlSerializer xml = new XmlSerializer(typeof(Student));
using (StreamWriter sw = new StreamWriter(fileName))
{
    xml.Serialize(sw, andrii);
}

if (File.Exists(fileName))
{
    Console.WriteLine("We have serialized this object  to xml file");
    Console.WriteLine();
    Console.WriteLine(File.ReadAllText(fileName));
}

using (StreamReader sr = new StreamReader(fileName))
{
    Student student = xml.Deserialize(sr) as Student;
    Console.WriteLine($"\n\nDeserialized student from XML:\n{student}");
}


string json = JsonSerializer.Serialize(andrii);
File.WriteAllText("student.json", json);
Console.WriteLine($"$Object --- > JSON\n{json}");

Student student2 = JsonSerializer.Deserialize<Student>(json);
Console.WriteLine($"\n\nDeserialized student from JSON:\n{student2}");
