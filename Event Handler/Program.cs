using Event_Handler;

Subscriber olena = new () { Name = "Olena" };
Subscriber serhii = new() { Name = "Serhii" };

NewsStreamEH newsStream = new NewsStreamEH
{ 
    Title = ".NET NEWS" 
};

newsStream.NewPostAddedEvent += olena.Handler;
newsStream.NewPostAddedEvent += serhii.Handler;
newsStream.NewPostAddedEvent += olena.Handler;


newsStream.AddPost("Inline arrays in C# 12 - concise array declaration and initialization.");

Console.WriteLine();
newsStream.NewPostAddedEvent += NotificationService.Handler;
newsStream.AddPost("The ^ operator in C# is used for indexing from the end of an array.");
