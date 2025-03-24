using Car_With_Props;

Console.WriteLine("---- Using properties--------");

Car car = new Car("bmw", 1999, 180);
car.Print();
Console.WriteLine();

car.Brand = "BMW"; // set    value = "BMW"
car.Print();
Console.WriteLine();

car.Brand = "Audi"; // set
car.Print();

Console.WriteLine( $"Brand : {car.Brand}"); // get
string tmpBrand = car.Brand; // get 
Console.WriteLine( $"Tmp brand : {tmpBrand}"); // 
Console.WriteLine();

Console.WriteLine(car.ToString()); // ToString() - повертає об'єкт у вигляді рядка, по замовчуванню - рядок із назвою класу та простору імен
Console.WriteLine(car); // компілятор неявно застосує метод
Console.WriteLine();

car.Speed = 80;
Console.WriteLine($"Car ID : {car.Id}");
Console.WriteLine($"Car speed : {car.Speed}");
Console.WriteLine($"Car max speed : {car.MaxSpeed}");

// Створити клас Смартфон із 
//  камера - readonly поле (int)
//  модель смартфона- readonly властивість (string)
//  номер телефону - повна властивість (string або ulong )
// Визначити конструктори, перевизначити (override) методу ToString()

