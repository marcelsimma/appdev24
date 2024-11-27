using System;

namespace FlorianBaier.Week08
{
    public class eBook : Medium
    {
        public string FileFormat { get; set; }

        public eBook(string title, string author, int publicationYear, string isbn, string fileFormat)
            : base(title, author, publicationYear, isbn)
        {
            FileFormat = fileFormat;
        }
    }
}