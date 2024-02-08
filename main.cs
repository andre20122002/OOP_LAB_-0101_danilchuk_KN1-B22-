using System;

class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public char Group { get; set; }

    public Book()
    {
        Author = "";
        Title = "";
        Year = 0;
        Group = ' ';
    }

    public Book(string author, string title, int year, char group)
    {
        Author = author;
        Title = title;
        Year = year;
        Group = group;
    }

    public Book(Book otherBook)
    {
        Author = otherBook.Author;
        Title = otherBook.Title;
        Year = otherBook.Year;
        Group = otherBook.Group;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Сенкевіч", "Потоп", 1978, 'Х');
        Book book2 = new Book("Ландау", "Механіка", 1989, 'У');
        Book book3 = new Book("Дойль", "Сумчасті", 1990, 'Д');

        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("| Автор        | Назва        | Рік випуску  | Група |");
        Console.WriteLine("-------------------------------------------------------------------");
        PrintBookInfo(book1);
        PrintBookInfo(book2);
        PrintBookInfo(book3);
        Console.WriteLine("-------------------------------------------------------------------");
    }

    static void PrintBookInfo(Book book)
    {
        Console.WriteLine($"| {book.Author,-12} | {book.Title,-12} | {book.Year,-12} | {book.Group,-5} |");
    }
}

