using System;
namespace JulianStroehle.Week8.OOP_Test_Aufgabe
{
    internal class EBook: Medium
    {
        internal enum Dataformat
        {
            pdf,
            epub
        }
        internal string Format;
        internal EBook(string title, string author, int format = 0)
        {
            Title = title;
            Author = author;
            Format = Convert.ToString((Dataformat)format);
            PublishingYear = DateTime.Now.Year;
            int temp = Convert.ToInt32(ISBN);
            temp += LibraryMain.library.books.Count + LibraryMain.library.eBooks.Count + 1;
            ISBN = Convert.ToString(temp);
        }
    }
}