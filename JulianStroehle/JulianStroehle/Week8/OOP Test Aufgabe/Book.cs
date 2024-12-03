using System;
namespace JulianStroehle.Week8.OOP_Test_Aufgabe
{
    internal class Book: Medium
    {
        internal enum Covers
        {
            Hardcover,
            Softcover
        }
        internal string Binding;
        internal Book(string title, string author, int binding = 0)
        {
            Title = title;
            Author = author;
            Binding = Convert.ToString((Covers)binding);
            PublishingYear = DateTime.Now.Year;
            int temp = Convert.ToInt32(ISBN);
            temp = temp + LibraryMain.library.books.Count + LibraryMain.library.eBooks.Count + 1;
            ISBN = Convert.ToString(temp);
        }
    }
}