using System;

namespace CheyenneHarbarth.Week08.Test
{
    public class Book : Medium
    {
        internal string Bookcover;
        internal Book(string titel, string author, string releaseyear, string isbn, string bookcover)
        {
            Titel = titel;
            Author = author;
            ReleaseYear = releaseyear;
            ISBN = isbn;
            Bookcover = bookcover;
        }

        public override string ToString()
        {
            return $"Buch: {Titel, 20}, {Author, 15}\nVeröffentlichung: {ReleaseYear}\nISBN: {ISBN}\nBindung: {Bookcover}\n";
        }
    }

    public class Ebook : Medium
    {
        internal string Format;

        internal Ebook(string titel, string author, string releaseyear, string isbn, string format)
        {
            Titel = titel;
            Author = author;
            ReleaseYear = releaseyear;
            ISBN = isbn;
            Format = format;
        }
        public override string ToString()
        {
            return $"Ebook: {Titel, 20}, {Author, 15}\nVeröffentlichung: {ReleaseYear}\nISBN: {ISBN}\nDateiformat: {Format}\n";
        }
    }
}