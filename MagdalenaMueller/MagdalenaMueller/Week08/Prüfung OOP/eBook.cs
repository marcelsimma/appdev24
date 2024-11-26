using System;
using System.Runtime.CompilerServices;

namespace MagdalenaMueller.Week08
{
    public class eBook : Medium
    {
        private string DateiFormat;

        public eBook(string titel, string autor, DateTime publicationYear, string isbn, string dateiFormat)
        {
            Titel = titel;
            Autor = autor;
            PublicationYear = publicationYear;
            ISBN = isbn;
            DateiFormat = dateiFormat;
        }
    }
}