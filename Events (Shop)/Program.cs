using System;

namespace Events
{
    class Program
    {
        static void Main()
        {
            Subscriber ann = new Subscriber { Name = "Ann" };
            Subscriber ivan = new Subscriber { Name = "Ivan" };

            NewsStream newsStream = new NewsStream
            { Title = ".NET NEWS" };

            newsStream.NewPostAddedEvent += ann.Handler; // підписали об'єкт ann (метод Handler)
            newsStream.NewPostAddedEvent += ivan.Handler; // підписали об'єкт ivan (метод Handler)
           // newsStream.NewPostAddedEvent += ann.Handler;

            newsStream.AddPost("Inline arrays in C# 12 - concise array declaration and initialization.");

            //newsStream.NewPostAddedEvent = null;// error, якщо позначено через ключове слово event 
           newsStream.NewPostAddedEvent -= ann.Handler;// відєднали обєкт ann 

            Console.WriteLine();
            newsStream.NewPostAddedEvent += NotificationService.Handler;// підписали static метод Handler класу NotificationService
            newsStream.AddPost("The ^ operator in C# is used for indexing from the end of an array. arr[^1]= last elem");
        }
    }
}
