using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// private in Base ----> є, але його не видно
// protected in Base ----> е його  видно всередині похідного класу, але зовні не видно
// public in Base ----> видно як всередині так і зовні похідного класу
namespace Inheritance
{
    internal class Video : Media //  Video успадкував клас Media, тобто успадкував властивосты, поля та методи (окрім к-ра)
    {
        // уcпадковані
        // Title залишається public
        // MediaType залишається public
        // duration - не видно
        // Duration - залишається public
        public string Resoultion { get; set; }
        public Video() { }
        public Video(string title, TimeSpan duration, string resolution) 
            : base (title, duration) // виклик к-ра із базового класу 
        { }

        public override string MediaType { get; } = "Video";

        public  override void Play()
        {
            base.Play();
            //Console.WriteLine($"{MediaType} '{Title}' is playing | Duration : {Duration} | Resolution : {Resoultion}");
            Console.WriteLine($"| Resolution : {Resoultion}");
        }
    }
}
