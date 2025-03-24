using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler_With_Args
{
    internal class NewsStreamWA
    {

        public event EventHandler<NewsStreamEventArgs> NewPostAddedEvent;
        public string Title { get; set; } = "Some Title";

        List<string> posts = new List<string>();
        public void AddPost(string content)
        {
            posts.Add($"{DateTime.Now}\t{content}");
            NewPostAddedEvent?.Invoke(
                this, // хто винуватецб події = поточний об'єкт, тому передаємо this посилання на поточний обєкт
                new NewsStreamEventArgs($"Post added : {content}")); // також передаємо об'єкт з нашими параметрами (NewsStreamEventArgs)
        }
        public override string ToString()
        {
            return $"Magazine : {Title}\n\t{String.Join("\n\t", posts)}";
        }
    }
   
}
