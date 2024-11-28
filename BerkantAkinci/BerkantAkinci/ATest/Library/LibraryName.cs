using System;
using System.Runtime.CompilerServices;

namespace BerkantAkinci.ATest
{
    public class LibraryName
    {
        public string NameOfLibrary;
        public List<Book> LibraryBook = new List<Book>();
        public List<eBook> LibraryEBook = new List<eBook>();

        public LibraryName(string nameOfLibrary)
        {
            NameOfLibrary = nameOfLibrary;
        }

        public void AddBook(Book book)
        {
            LibraryBook.Add(book);
        }

        public void AddEBook(eBook ebook)
        {
            LibraryEBook.Add(ebook);
        }

        public void RemoveBook(Book isbn)
        {
            LibraryBook.Remove(isbn);

        }
        public void RemoveEBook(eBook ISBN)
        {
            LibraryEBook.Remove(ISBN);
        }

        public void SearchBook(string SearchKey)
        { string nameBook = Console.ReadLine();

        


        }

        public void SearchEBook(string SearchEKey)
        {


        }

        public void Structure()
        {
            System.Console.WriteLine("Books");

            foreach (var books in LibraryBook)
            {
                System.Console.WriteLine(books.ToString());
            };
            System.Console.WriteLine();

            System.Console.WriteLine("eBooks");

            foreach (var eBooks in LibraryEBook)
            {
                System.Console.WriteLine(eBooks.ToString());
            };
            System.Console.WriteLine();
        }
    }
}