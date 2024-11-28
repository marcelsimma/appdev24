using System;

namespace BerkantAkinci.ATest
{
    public class eBook : Medium
    {
        public string Fileformat;


        public eBook(string title, string author, DateTime releaseYear, string isbn, string fileformat) : base (title, author, releaseYear,isbn)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
            ISBN = isbn;
            Fileformat = fileformat;
        }

        public override string ToString()
        {
            return $"{Title, -20} {Author, -10} {ReleaseYear, -20} {ISBN, -15} {Fileformat, 5}";
        }
    }
}