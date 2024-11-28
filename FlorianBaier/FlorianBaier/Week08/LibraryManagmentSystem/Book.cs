using System;

namespace FlorianBaier.Week08
{

    public class Book : Medium
    {
        public string Binding { get; set; }

        public Book(string title, string author, int publicationYear, string isbn, string binding)
            : base(title, author, publicationYear, isbn)
        {
            Binding = binding;
        }
    }
}
