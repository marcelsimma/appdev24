using System;
using BerkantAkinci.Week04;

namespace BerkantAkinci.ATest
{
    public class Book : Medium
    {
        public string Bonding;

        public Book(string title, string author, DateTime releaseYear, string isbn, string bonding) : base (title, author, releaseYear,isbn)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
            ISBN = isbn;
            Bonding = bonding;
        }

        public override string ToString()
        {
            return $"{Title, -20} {Author, -10} {ReleaseYear, -20} {ISBN, -15} {Bonding, -15}";
        }
    }
}