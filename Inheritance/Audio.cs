using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Audio : Media
    {
        public string Artist { get; set; }
        public override string MediaType { get; } = "Audio";
        public Audio(string title, TimeSpan duration, string artist)
            : base(title, duration)
        {
            Artist = artist;
        }
        public override void Play()
        {
            Console.WriteLine($"{MediaType} '{Title}' is playing | Duration : {Duration} | Artist : {Artist}");

        }
    }
}

/*
 * Створіть клас Human, який міститиме інформацію про людину (name, age). Визначити конструктор з параметрами.
 * Визначити метод для виведення інормації про діяльність людини virtual метод Info() виду:  Петро 25 років невідомо чим займається
 * virtual властивісь Occupation (string) - рід занять, повертаэ рядок 'невідомо чим займається'

За допомогою механізму успадкування, реалізуйте клас 
Builder (містить інформацію про будівельника - число будинків) , Ctor
    Перевизначити(override) метод  Info() для виведення інормації про діяльність будsвельника  виду:  Петро 25 років будує будинки, побудував 5 будинків
    Перевизначити(override) вірт. властивісь Occupation (string) - рід занять, повертає рядок 'будує будинки'
    
клас Sailor (містить інформацію про моряка - скільки років у морі), Ctor Info()
    Перевизначити(override) метод  Info() для виведення інормації про діяльність будsвельника  виду:  Петро 25 років плаває у морі, пробув у морі  5 років
    Перевизначити(override) вірт. властивісь Occupation (string) - рід занять, повертає рядок 'моряк, працює у морі'

клас Pilot (містить інформацію про льотчика - скільки польотів). Ctor Info()

Створити об`єкти різних класів - Builder, Sailor, Pilot.
 */
