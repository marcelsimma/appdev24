using System;

namespace CheyenneHarbarth.Week08.Test
{
    public class Library
    {
        internal string Titel { get; set; }
        List<Medium> media = new List<Medium>();

        internal Library(string titel)
        {
            Titel = titel;
        }

        internal void AddMedium(Medium medium)
        {
            media.Add(medium);
        }
        internal void RemoveMedium(string isbn)
        {
            foreach (Medium medium in media)
            {
                if (medium is Book book && book.ISBN == isbn)
                {
                    media.Remove(book);
                    Console.WriteLine($"\nDas Buch \"{book.Titel}\" wurde gelöscht!\n");
                    break;
                }
            }
        }
        internal void SearchForMedium(string search)
        {
            foreach (Medium medium in media)
            {
                if (medium.Titel.Contains(search) || medium.Titel.Contains(search))
                {
                    Console.WriteLine($"Gefundenes Medium:\n{medium.ToString()}");
                }
            }
        }

        internal void PrintList()
        {
            foreach (Medium medium in media)
            {
                if (medium is Book book)
                {
                    Console.WriteLine(book.ToString());
                }
                if (medium is Ebook ebook)
                {
                    Console.WriteLine(ebook.ToString());
                }
            }
        }
    }
}