using System;

namespace FlorianBaier.Week08
{

    public class Medium
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public Medium(string title, string author, int publicationYear, string isbn)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {PublicationYear}, ISBN: {ISBN}";
        }
    }
}
