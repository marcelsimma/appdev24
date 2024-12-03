using System;
using System.ComponentModel;

namespace MagdalenaMueller.Week08
{
    public class Bibliothek
    {
        public static List<Book> books = new List<Book>();
        public static List<eBook> eBooks = new List<eBook>();

        internal static void Add()
        {
            Console.WriteLine("Buch o. eBook");
            string? task = Console.ReadLine().ToLower();
            if(task == "buch")
            {
                Console.WriteLine("Titel");
                string? titel = Console.ReadLine();
                Console.WriteLine("Autor");
                string? autor = Console.ReadLine();
                Console.WriteLine("ISBN");
                string? isbn = Console.ReadLine();
                Console.WriteLine("Bindung");
                string? cover = Console.ReadLine();
                
                Book book = new Book(titel,autor,DateTime.Now,isbn,cover);

                books.Add(book);
            }
            else if(task == "ebook")
            {
                Console.WriteLine("Titel");
                string? titel = Console.ReadLine();
                Console.WriteLine("Autor");
                string? autor = Console.ReadLine();
                Console.WriteLine("ISBN");
                string? isbn = Console.ReadLine();
                Console.WriteLine("Dateiformat");
                string? dateiFormat = Console.ReadLine();
                
                eBook ebook = new eBook(titel,autor,DateTime.Now,isbn,dateiFormat);
                
                eBooks.Add(ebook);
            }
            Console.ReadLine();
        }
        internal static void Remove()
        {
            Console.WriteLine("Isbn: ");
            string? isbn = Console.ReadLine();
            for(int i = 0; i < books.Count; i++)
            {
                if(isbn == books[i].ISBN)
                {
                    books.Remove(books[i]);
                }
            }
            for(int i = 0; i < eBooks.Count; i++)
            {
                if(isbn == eBooks[i].ISBN)
                {
                    eBooks.Remove(eBooks[i]);
                }
            }
            Console.WriteLine();
        }
        internal static void Search()
        {
            Console.WriteLine("Autor oder Titel:");
            string? removeName = Console.ReadLine();

            int counter = 0;
            for(int i = 0; i < books.Count; i++)
            {
                if(removeName == books[i].Autor || removeName == books[i].Titel)
                {
                    Console.WriteLine("Buch gefunden: " + books[i].Titel);
                    counter++;
                }
            }
            for(int i = 0; i < eBooks.Count; i++)
            {
                if(removeName == eBooks[i].Autor || removeName == eBooks[i].Titel)
                {
                    Console.WriteLine("Ebook gefunden: " + eBooks[i].Titel);
                    counter++;
                }
            }
            if(counter == 0)
            {
                Console.WriteLine("Kein Buch oder eBook gefunden");
            }
            Console.WriteLine();
        }
        internal static void Write()
        {
            Console.WriteLine("Bücher: ");
            for(int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i].Titel);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("eBooks: ");
            for(int i = 0; i < eBooks.Count; i++)
            {
                Console.WriteLine(eBooks[i].Titel);
            }
            Console.WriteLine();
        }
    }
}