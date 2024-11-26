using System;

namespace SimonJochum.Week08.PrüfungOOP
{
    public class Library
    {
        public List<Medium> _allBooks = new List<Medium>();

        public Library()
        {

        }

        public void AddBook(Book book)
        {
            _allBooks.Add(book);
        }

        public void AddEBook(EBook eBook)
        {
            _allBooks.Add(eBook);
        }

        public void DeleteBook(string ISBN)
        {
            var bookToRemove = _allBooks.FirstOrDefault(book => book._ISBN == ISBN);

            if (bookToRemove != null)
            {
                _allBooks.Remove(bookToRemove);
                Console.WriteLine($"Das Buch mit der ISBN {ISBN} wurde erfolgreich entfernt.");
            }
            else
            {
                Console.WriteLine($"Kein Buch mit der ISBN {ISBN} gefunden.");
            }
        }


        public void SearchBook(string search)
        {
            var booksToSearch = _allBooks.Where(book =>
                book._author.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                book._title.Contains(search, StringComparison.OrdinalIgnoreCase));

            if (booksToSearch.Any())
            {
                Console.WriteLine($"Gefundene Bücher für '{search}':");
                foreach (var book in booksToSearch)
                {
                    Console.WriteLine(book.GetDetails());
                }
            }
            else
            {
                Console.WriteLine($"Keine Bücher gefunden, die '{search}' entsprechen.");
            }
        }
    }
}