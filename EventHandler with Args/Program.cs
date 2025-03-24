using Event_Handler_With_Args;

Subscriber ann = new Subscriber { Name = "Ann" };
Subscriber ivan = new Subscriber { Name = "Ivan" };

NewsStreamWA magazine = new NewsStreamWA
{
    Title = "Forbes"
};

magazine.NewPostAddedEvent += ann.Handler;
magazine.NewPostAddedEvent += ivan.Handler;
magazine.NewPostAddedEvent += ann.Handler;


magazine.AddPost("Inline arrays in C# 12 - concise array declaration and initialization.");

//magazine.NewPostAddedEvent = null;// ann.Handler;
//magazine.NewPostAddedEvent -= ann.Handler;

Console.WriteLine();
magazine.NewPostAddedEvent += NotificationService.Handler;
magazine.AddPost("The ^ operator in C# is used for indexing from the end of an array.");
