using System;

// Enumeration for item categories
public enum Category
{
    Electronics,
    Clothing,
    Groceries,
    HomeAppliances,
    Other
}

public class Item
{
    private string name;
    private int? quantity;
    private Category category;
    
    public string Name { 
        get => name;
        set => name = value ?? "Noname"; 
    }

    public int? Quantity 
    {
        get => quantity;
        set => quantity = value is null || value >= 0 ? value : throw new ArgumentOutOfRangeException("Quantity could be null or >=0");
    }

    public Category Category {
        get => category;
        set => category = Enum.IsDefined<Category>(value) ? value : throw new ArgumentOutOfRangeException("Not expected category"); 
    }
    
     
    public Item(string name, int stockQuantity, Category category)
    {
        Name = name;
        Quantity = stockQuantity;
        Category = category;
    }

    // Перевантаження оператора + для додавання кількості товару
    public static Item operator +(Item item, int quantity)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        int newQuantity = item.quantity.GetValueOrDefault() + quantity;
        if (newQuantity < 0)
            throw new ArgumentException("Resulting stock quantity cannot be negative.");

        // Повертаємо новий об’єкт із оновленою кількістю
        return new Item(item.Name, newQuantity, item.Category);
    }

    // Для симетрії визначаємо також оператор + коли число зліва
    public static Item operator +(int quantity, Item item)
    {
        return item + quantity;
    }

    // Перевантаження оператора рівності == (порівнюємо Name та Category)
    public static bool operator ==(Item item1, Item item2)
    {
        if (ReferenceEquals(item1, item2)) // якщо посилання однаокові, то item1, item2 посилаються на  один і той же об'єкт
            return true;
        if (item1 is null || item2 is null)
            return false;

        return item1.Name == item2.Name && item1.Category == item2.Category;
    }

    // Перевантаження оператора нерівності !=
    public static bool operator !=(Item item1, Item item2)
    {
        // викликаємо раніше визначену операцію ==
        return !(item1 == item2);
    }

    // Перевизначення Equals для узгодження з операторами == та !=
    public override bool Equals(object obj)
    {
        var res = obj is Item; // перевіряємо чи obj є типу Item
        return  res && this  == (Item) obj; // якщо так та this  == (Item) obj (this такий самий як obj), то повертається true
    }

    // Перевизначення GetHashCode (використовуємо Name та Category)
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Category);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Stock Quantity: {Quantity}, Category: {Category}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Operators overloading------------");

        try
        {
            // Створення об'єкта Item
            Item laptop = new Item("Laptop", 10, Category.Electronics);
            Console.WriteLine(laptop);

            // Додавання 5 одиниць товару за допомогою +
            laptop = laptop + 5;
            Console.WriteLine("After laptop = laptop + 5;");
            Console.WriteLine(laptop);

            laptop = laptop + (-20);
            Console.WriteLine("After laptop = laptop + (-2);");
            Console.WriteLine(laptop);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }
    }
}