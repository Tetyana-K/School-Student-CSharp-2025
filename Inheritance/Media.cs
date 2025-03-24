using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Класи у С# підтримують одиночне успадкування, але множинну (багато) реалізацію інтерфейсів
    internal class Media // base class
    {
        public string Title { get; set; }
        public  virtual string MediaType { get; } = "Media";

        private TimeSpan duration;

        public Media()
        {
            
        }
        public Media(string title, TimeSpan duration)
        {
            Title = title;
            Duration = duration;   
        }
        public  TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public virtual void Play()
        {
            Console.WriteLine($"{MediaType} '{Title}' is playing | Duration : {Duration}");
        }
    }
}
