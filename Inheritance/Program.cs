// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Inheritance and polymorphism");

Media media = new Media() // обєкт  сторений к-ром по замовчуванню та ініціалізується через public properties
{ 
    Title = "Some media",
    Duration = new TimeSpan(0, 33, 10) 
};
media.Play();

Video video = new Video() 
{ 
    Title = "Some video", 
    Duration = new TimeSpan(2, 20, 0), 
    Resoultion = "1920x1080" 
};
video.Play();

Media audio = new Audio("Some song", new TimeSpan(0, 3, 30), "ABC artist");

Console.WriteLine("----------Array of Media --------");
Media [] medias = new Media[] { media, video, audio };
foreach (var medi in medias)
    medi.Play();