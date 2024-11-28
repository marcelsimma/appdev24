using System;
namespace JulianStroehle.Week8.OOP_Test_Aufgabe
{
    internal class LibraryMain
    {
        internal static Library library = new Library();
        internal static void Start()
        {
            string action = "";
            do
            {
                try
                {
                    Console.WriteLine("Add book or eBook (1), remove book or eBook (2), search book or eBook(3), show all books (4) or exit (E)");
                    action = Console.ReadLine();
                    switch (action)
                    {
                        case "1": AddBook(); break;
                        case "2": RemoveBook(); break;
                        case "3": SearchBook(); break;
                        case "4": ShowAllBooks(); break;
                        default: break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input");
                }
            }
            while (action.ToLower() != "e");
        }
        internal static void AddBook()
        {
            Console.WriteLine("Title?");
            string title = Console.ReadLine();
            Console.WriteLine("Author");
            string author = Console.ReadLine();
            Console.WriteLine("Hard or Softcover? (1/2) or for eBooks Dataformat pdf or epub (also 1/2)");
            int format = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Book or eBook? (1/2)");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1": Book book = new Book(title, author, format); library.AddBook(book); break;
                case "2": EBook eBook = new EBook(title, author, format); library.AddEBook(eBook); break;
            }
        }
        internal static void RemoveBook()
        {
            bool found = false;
            Console.WriteLine("ISBN?");
            string isbn = Console.ReadLine();
            library.RemoveBook(isbn);
        }
        internal static void SearchBook()
        {
            Console.WriteLine("Name or Author?");
            string search = Console.ReadLine();
            library.SearchBook(search);
        }
        internal static void ShowAllBooks()
        {
            Console.WriteLine("Books: ");
            foreach (Book book in library.books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublishingYear}, Cover: {book.Binding}, ISBN: {book.ISBN}");
            }
            Console.WriteLine("\nEBooks: ");
            foreach (EBook eBook in library.eBooks)
            {
                Console.WriteLine($"Title: {eBook.Title}, Author: {eBook.Author}, Year: {eBook.PublishingYear}, Format: {eBook.Format}, ISBN: {eBook.ISBN}");
            }

        }
    }
}