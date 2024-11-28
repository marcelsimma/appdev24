using System;

namespace BerkantAkinci.ATest
{
    public class Medium
    {
        public string Title;
        public string Author;
        public DateTime ReleaseYear;
        public string ISBN;


        public Medium(string title, string author, DateTime releaseYear, string isbn)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
            ISBN = isbn;
        }


    }
}