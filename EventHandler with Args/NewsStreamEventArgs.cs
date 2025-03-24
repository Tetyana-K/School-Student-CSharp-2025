using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Event_Handler_With_Args
{
    // клас наших параметрів для події, повинен успадкуватися від EventArgs
    internal class NewsStreamEventArgs: EventArgs
    {
        private string message = "No message";
        public string Message => message;

        public NewsStreamEventArgs(string message)
        {
            this.message = message;
        }
    }
}
