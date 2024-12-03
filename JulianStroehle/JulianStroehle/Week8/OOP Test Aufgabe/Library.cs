using System;
namespace JulianStroehle.Week8.OOP_Test_Aufgabe
{
    internal class Library
    {
        internal List<Book> books = new List<Book>();
        internal List<EBook> eBooks= new List<EBook>();
        internal Library()
        {}
        internal void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book " + book.Title + " successfully added to the library.");
        }
        internal void AddEBook(EBook eBook)
        {
            eBooks.Add(eBook);
            Console.WriteLine("EBook " + eBook.Title + " successfully added to the library.");
        }
        internal void RemoveBook(string isbn)
        {
            bool removed = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    Console.WriteLine("Successfully removed book " + books[i].Title);
                    books.RemoveAt(i);
                    removed = true;
                }
            }
            for (int i = 0; i < eBooks.Count; i++)
            {
                if (eBooks[i].ISBN == isbn)
                {
                    Console.WriteLine("Successfully removed eBook " + eBooks[i].Title);
                    eBooks.RemoveAt(i);
                    removed = true;
                }
            }
            if (!removed)
            {
                Console.WriteLine("no book with this ISBN found.");
            }
        }
        internal void SearchBook(string search)
        {
            bool found = false;
            foreach (Book book in books)
            {
                if (book.Title.Contains(search) || book.Author.Contains(search))
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublishingYear}, Cover: {book.Binding}");
                    found = true;
                }
            }
            foreach (EBook eBook in eBooks)
            {
                if (eBook.Title.Contains(search) || eBook.Author.Contains(search))
                {
                    Console.WriteLine($"Title: {eBook.Title}, Author: {eBook.Author}, Year: {eBook.PublishingYear}, Format: {eBook.Format}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No books found.");
            }
        }
    }
}