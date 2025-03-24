using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    delegate void NewPostAdded(string post);
    class NewsStream // Видавець = клас, який містить подію, містить код, що запускає (ініціює) подію
    {
        // event =  safe use delegate, не  допускає :  подія = null    подія = 
        public event NewPostAdded NewPostAddedEvent;
        public string Title { get; set; } = "Some Title";

        List<string> posts = new List<string>();
        public void AddPost(string content)
        {
            posts.Add($"{DateTime.Now}\t{content}");

            // ініціюємо подію : викликаються методи групового делегату (методи subscribers)
            NewPostAddedEvent?.Invoke(content); 
        }
        public override string ToString()
        {
            return $"Magazine : {Title}\n\t{String.Join("\n\t", posts)}";
        }
    }
   
   
}
// 1. Створити клас Продукт із полями  назва та ціна. У класі має бути подія PriceChanged
// (пам'ятаємо, що подія - це делегат).   При зміні ціни повинна викликатися (запускатися) подія  PriceChanged.
// Створити клас Покупець із полями чи автовластивостями  ім'я та вік. У класі ПОкупець визначити метод, який буде реакцією на подію.
// У Program.cs створити хоча б два продукти та хоча б три покупця.  Попідписувати покупців на події Зміни ціни. Змінити ціну продукта.
// Поспостерігати, що підписані покупції "реагують" на зміну ціни певноготовару (тобто викликаються їхні методи).
// Відписати певних покупців від сповіщень про зміну ціни певних товарів.




// 2. Дом тваринка енергія, мало енергії, тоді подія -- погодувати

