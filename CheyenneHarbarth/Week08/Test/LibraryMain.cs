using System;

namespace CheyenneHarbarth.Week08.Test
{
    public class LibraryMain
    {
        public static void Start()
        {
            Library library = new Library("Landesbibliothek Bregenz");

            Book book1 = new Book("The Secret History", "Donna Tart", "1992", "9788401327940", "Hardcover");
            Book book2 = new Book("Tintenherz", "Cornelia Funke", "2003", "9783791504650", "Hardcover");
            Book book3 = new Book("Illuminati", "Dan Brown", "2000", "9783404163441", "Softcover");
            Book book4 = new Book("Nullpunkt", "Lincoln Child", "2010", "9783644203310", "Softcover");

            Ebook ebook1 = new Ebook("Tintenblut", "Cornelia Funke", "2005", "9788498417463", "PDF");
            Ebook ebook2 = new Ebook("Sakrileg", "Dan Brown", "2003", "9780552216012", "PDF");
            Ebook ebook3 = new Ebook("One Dollar Horse", "Lauren St. John", "2012", "9781444003789", "EPUB");
            Ebook ebook4 = new Ebook("Schindlers Liste", "Thomas Keneally", "1982", "9786555873849", "PDF");

            library.AddMedium(book1);
            library.AddMedium(book2);
            library.AddMedium(book3);
            library.AddMedium(book4);
            library.AddMedium(ebook1);
            library.AddMedium(ebook2);
            library.AddMedium(ebook3);
            library.AddMedium(ebook4);

            library.PrintList();

            library.RemoveMedium("9783404163441");

            library.PrintList();


            library.SearchForMedium("Tinte");
        }
    }
}