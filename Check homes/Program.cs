using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public abstract class Book : ICloneable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }

    protected Book(string title, string author, int year, string genre)
    {
        Title = title;
        Author = author;
        Year = year;
        Genre = genre;
    }

    public abstract object Clone();

    public override string ToString() => $"{Title} by {Author}, {Year}, Genre: {Genre}";
}

public class PrintedBook : Book
{
    public PrintedBook(string title, string author, int year, string genre)
        : base(title, author, year, genre) { }

    public override object Clone() => new PrintedBook(Title, Author, Year, Genre);
}

public class EBook : Book
{
    public string Format { get; set; }

    public EBook(string title, string author, int year, string genre, string format)
        : base(title, author, year, genre)
    {
        Format = format;
    }

    public override object Clone() => new EBook(Title, Author, Year, Genre, Format);

    public override string ToString() => base.ToString() + $", Format: {Format}";
}

public class Library<T> : IEnumerable<T>, ICloneable where T : Book
{
    private List<T> books = new List<T>();

    public void AddBook(T book) => books.Add(book);

    public IEnumerable<T> GetBooksByGenre(string genre)
    {
        foreach (var book in books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)))
        {
            yield return book;
        }
    }

    public IEnumerable<T> GetBooksByYear(int year)
    {
        foreach (var book in books.Where(b => b.Year == year))
        {
            yield return book;
        }
    }

    public IEnumerable<T> GetBooksByAuthor(string author)
    {
        foreach (var book in books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)))
        {
            yield return book;
        }
    }

    public IEnumerator<T> GetEnumerator() => books.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public object Clone()
    {
        var newLibrary = new Library<T>();
        foreach (var book in books)
        {
            newLibrary.AddBook((T)book.Clone());
        }
        return newLibrary;
    }
}

public class Program
{
    public static void Main()
    {
        var library = new Library<Book>();
        library.AddBook(new PrintedBook("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy"));
        library.AddBook(new EBook("1984", "George Orwell", 1949, "Dystopian", "PDF"));
        library.AddBook(new PrintedBook("Dune", "Frank Herbert", 1965, "Science Fiction"));

        Console.WriteLine("All Books:");
        foreach (var book in library)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nBooks in Fantasy Genre:");
        foreach (var book in library.GetBooksByGenre("Fantasy"))
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nBooks by George Orwell:");
        foreach (var book in library.GetBooksByAuthor("George Orwell"))
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nBooks published in 1965:");
        foreach (var book in library.GetBooksByYear(1965))
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nCloning Library...");
        var clonedLibrary = (Library<Book>)library.Clone();
        Console.WriteLine("Cloned library contains:");
        foreach (var book in clonedLibrary)
        {
            Console.WriteLine(book);
        }
    }
}