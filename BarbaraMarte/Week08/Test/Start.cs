using System;
using System.Net;
using BarbaraMarte.Schule.Library;

namespace BarbaraMarte.Week08.Test;
/*
class Bibliothek
{
    public static List<BookTest> HardShellBooks = new List<BookTest>();
    public static List<BookTest> EBooks = new List<BookTest>();
    public static void Start()
    {
        bool running = true;
        while (true == true)
        {
            Console.Clear();
            Console.WriteLine(
                @"
                Add Book to E-Library 1
                Add Book to Library 2
                Remove Book to E-Library 3
                Remove Book to Library 4
                Enter 0 to exit the program
                 
                 
                 ");
            string decision = Console.ReadLine() ?? "";
            switch (decision)
            {
                case "1":
                    AddBookPdf();
                    break;
                case "2":
                    AddHardShell();
                    break;
                case "3":
                    RemovePdfBook();
                    break;
                case "4":
                    RemoveBook();
                    break;
                case "0":
                    System.Console.WriteLine("Exiting the Program.");
                    running = false;
                    break;
                default:
                    System.Console.WriteLine("Invalid Input. Please try again!");
                    break;
            }
        }
    }
    public static void RemovePdfBook()
    {
        int tmp = EBooks.Count;
        var input = Console.ReadLine();
        for (int i = 0; i < tmp; i++)
        {
            if (EBooks[i].ISBN == input)
            {

            }
        }
    }
    public static void RemoveBook()
    {

    }
    public static void AddBookPdf()
    {
        Console.WriteLine("Adding new E-Book:");
        BookTest newBook = CreateBook();
        if (newBook != null)
        {
            EBooks.Add(newBook);
            Console.WriteLine("Your book was successfully added.");
        }
    }
    public static void AddHardShell()
    {
        Console.WriteLine("Adding new E-Book:");
        BookTest newBook = CreateBook();
        if (newBook != null)
        {
            HardShellBooks.Add(newBook);
            Console.WriteLine("Your book was successfully added.");
        }

    }
    public static BookTest? CreateBook()
    {

        System.Console.WriteLine("Book name:");
        string bookName = Console.ReadLine() ?? "";
        System.Console.WriteLine("Author:");
        string author = Console.ReadLine() ?? "";
        System.Console.WriteLine("Publishing Year:");
        string publishingYear = Console.ReadLine() ?? "";
        System.Console.WriteLine("ISBN:");
        string isbn = Console.ReadLine() ?? "";
        return new BookTest(bookName, author, publishingYear, isbn);
    }
}
class BookTest
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string PublishingYear { get; private set; }
    public string ISBN { get; private set; }

    public BookTest(string title, string author, string publishingYear, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublishingYear = publishingYear;
    }
    public override string ToString()
    {
        return string.Format($"Title: {Title} Author {Author} Publishing Year: {PublishingYear} ISBN {ISBN}");
    }
}

class Hardcover
{
    public string BindingType { get; private set; }
    public Hardcover(string bindingType)
    {
        BindingType = bindingType;
    }
    public override string ToString()
    {
        return $"Hard covered Book with {BindingType} binding.";
    }
}
class EBook
{
    public string OnlineFormat { get; private set; }
    public EBook(string onlineFormat)
    {
        OnlineFormat = onlineFormat;
    }
    public override string ToString()
    {
        return string.Format($"The EBook is in {OnlineFormat} format.");
    }
}
*/
