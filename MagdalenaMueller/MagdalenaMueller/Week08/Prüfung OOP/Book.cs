using System;

namespace MagdalenaMueller.Week08
{
    public class Book : Medium
    {
        private string Cover;

        public Book(string titel, string autor, DateTime publicationYear, string isbn, string cover)
        {
            Titel = titel;
            Autor = autor;
            PublicationYear = publicationYear;
            ISBN = isbn;
            Cover = cover;
        }
    }
}