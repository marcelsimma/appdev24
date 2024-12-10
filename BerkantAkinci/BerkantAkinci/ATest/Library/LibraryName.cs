using System;
using System.Runtime.CompilerServices;

namespace BerkantAkinci.ATest
{
    public class LibraryName
    {
        public string NameOfLibrary;
        public List<Book> LibraryBook = new List<Book>(); // genauer wäre es mit einer List<Medium> um alles in einer Liste zu speichern
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

        public void RemoveBook(string ISBN) // parameter als string mitgeben und nicht als Book, break; am schluss wichtig, 
        {
            foreach (Book book in LibraryBook)
            {
                if (book.ISBN == ISBN)
                {
                    LibraryBook.Remove(book);
                    System.Console.WriteLine($"Das Buch {book.Title} wurde gelöscht!"); // Damit es übersichtlicher ist -> schönere Konsolenausgabe
                    System.Console.WriteLine();
                    break;
                }
            }


        }
        public void RemoveEBook(string eISBN)  // parameter als string mitgeben und nicht als eBook, break; am schluss wichtig, 
        {
            foreach (eBook ebook in LibraryEBook)
            {
                if (ebook.ISBN == eISBN)
                {
                    LibraryEBook.Remove(ebook);
                    System.Console.WriteLine($"Das Buch {ebook.Title} wurde gelöscht!");  // Damit es übersichtlicher ist -> schönere Konsolenausgabe
                    System.Console.WriteLine();
                    break;
                }
            }
        }

        public void SearchBook(string SearchKey)
        {
            System.Console.WriteLine("Diese Bücher wurden gefunden:");

            foreach (Book book in LibraryBook)
            {
                if (book.Author.Contains(SearchKey) || book.Title.Contains(SearchKey))
                {

                    System.Console.WriteLine(book.ToString());
                }
            }
            System.Console.WriteLine();
        }

        public void SearchEBook(string SearchEKey)
        {
            System.Console.WriteLine("Diese eBücher wurden gefunden:");

            foreach (eBook ebook in LibraryEBook)
            {
                if (ebook.Author.Contains(SearchEKey) || ebook.Title.Contains(SearchEKey))
                {

                    System.Console.WriteLine(ebook.ToString());
                }
            }
            System.Console.WriteLine();


        }

        public void Structure()
        {
            System.Console.WriteLine("Books");

            foreach (Book books in LibraryBook)
            {
                System.Console.WriteLine(books.ToString());
            };
            System.Console.WriteLine();

            System.Console.WriteLine("eBooks");

            foreach (eBook eBooks in LibraryEBook)
            {
                System.Console.WriteLine(eBooks.ToString());
            };
            System.Console.WriteLine();
        }
    }
}