using System;

namespace FlorianBaier.Week08
{
    public class LibraryLaunch
    {
        public static void StartLibrary()
        {
            Library library = new Library();

            Book harryPotter1 = new Book("Harry Potter und der Stein der Weisen", "J.K. Rowling", 1997, "1111", "Hardcover");
            Book harryPotter2 = new Book("Harry Potter und die Kammer des Schrecken", "J.K. Rowling", 1998, "2222", "Hardcover");
            Book harryPotter3 = new Book("Harry Potter und der Gefangene von Askaban", "J.K. Rowling", 1999, "3333", "Hardcover");
            Book harryPotter4 = new Book("Harry Potter und der Feuerkelch", "J.K. Rowling", 2000, "4444", "Softcover");
            Book harryPotter5 = new Book("Harry Potter und der Orden des Phönix", "J.K. Rowling", 2003, "5555", "Hardcover");
            Book harryPotter6 = new Book("Harry Potter und der Halbblutprinz", "J.K. Rowling", 2005, "6666", "Softcover");
            Book harryPotter7 = new Book("Harry Potter und die Heiligtümer des Todes", "J.K. Rowling", 2007, "7777", "Hardcover");

            eBook gregDiary1 = new eBook("Gregs Tagebuch - Und Tschüss", "Jeff Kinney", 2017, "1234", "epub");
            eBook gregDiary2 = new eBook("Gregs Tagebuch - Voll daneben", "Jeff Kinney", 2015, "5678", "pdf");

            library.AddMedium(harryPotter1);
            library.AddMedium(harryPotter2);
            library.AddMedium(harryPotter3);
            library.AddMedium(harryPotter4);
            library.AddMedium(harryPotter5);
            library.AddMedium(harryPotter6);
            library.AddMedium(harryPotter7);
            library.AddMedium(gregDiary1);
            library.AddMedium(gregDiary2);

            Console.WriteLine("Media in library:");
            library.DisplayAllMedia();

            Console.WriteLine("\nDelete Medium ISBN '4444' (Harry Potter und der Feuerkelch):");
            library.RemoveMedium("4444");

            Console.WriteLine("\nMedia after deleting:");
            library.DisplayAllMedia();

            var searchResults = library.Search("Jeff Kinney");
            Console.WriteLine("Searchresults 'Jeff Kinney':");
            if (searchResults.Count > 0)
            {
                foreach (var medium in searchResults)
                {
                    Console.WriteLine(medium.ToString());
                }
            }
            else
            {
                Console.WriteLine("No media found.");
            }
        }
    }
}