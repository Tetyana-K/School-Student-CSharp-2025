using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler
{
    internal class NewsStreamEH
    {
        public event EventHandler NewPostAddedEvent;
        public string Title { get; set; } = "Some Title";

        List<string> posts = new List<string>();
        public void AddPost(string content)
        {
            posts.Add($"{DateTime.Now}\t{content}");
            NewPostAddedEvent?.Invoke(this, EventArgs.Empty); // ініціюємо подію : викликаються методи групового делегати(методи subscriber)
        }
        public override string ToString()
        {
            return $"Magazine : {Title}\n\t{String.Join("\n\t", posts)}";
        }
    }
   
}
