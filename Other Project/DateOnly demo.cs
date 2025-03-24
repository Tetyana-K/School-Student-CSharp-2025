// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo DateOnly");

// DateOnly - тип для збереження Дати

DateOnly date = new DateOnly(2024, 12, 31); //  створили об'єкт date типу DateOnly
Console.WriteLine(date);// 31.12.2024
Console.WriteLine(date.Day); // отримуємо день із дати (31)
Console.WriteLine(date.Month); // отримуємо номер місяця із дати  (12)
Console.WriteLine(date.DayOfWeek); // отримуємо день тижня із дати (Tuesday)

Console.WriteLine($"{date:dddd}"); // вивід дати у форматі - покаже повну назву дня тижня (вівторок)
Console.WriteLine($"{date:dd-MMM-yyy}"); // вивід дати у форматі - покаже день-місяць скорочено- рік (31-груд.-2024)

Console.WriteLine("\nInput date (year-month-day)");
DateOnly date2 = DateOnly.Parse(Console.ReadLine()); // зчитуємо з клавіатури рядок із датою, цей рядок парситься(перетворюється) у DateOnly
Console.WriteLine(date2);


