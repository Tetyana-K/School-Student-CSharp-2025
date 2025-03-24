using Static_demo;

Student student1 = new Student( "Oleg");
Student student2 = new Student( "Ann");

Student [] group = 
{
    new Student("Serhii"),
    new Student("Vadym") 
};

student2.Name = "Anna";

Console.WriteLine(student1);
Console.WriteLine(student2);

foreach (Student st in group)
{
    Console.WriteLine(st);
}

//Console.WriteLine(student1.School); // error
Student.School = "IT Step Academy";
Console.WriteLine(Student.School); // до статичного елемента звертаємося через назву класу

Console.WriteLine("SOME CODE");