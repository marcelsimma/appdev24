using System;

namespace BerkantAkinci.ATest
{
    class LibraryMain
    {
        public static void Start()
        {
            LibraryName nameOfLibrary = new LibraryName("Landesbibliothekt");

            Book book1 = new Book("Harry Potter", "Drake", new DateTime(2024), "AJDHHJAF", "Hardcover");
            Book book2 = new Book("Paulaner", "Martin", new DateTime(2010), "ajfhadjfkh", "Softcover");
            Book book3 = new Book("Gartenblume", "Stefan", new DateTime(2005), "sdfsdfsdf", "Hardcover");

            eBook ebook1 = new eBook("Digitalisierung", "Einstein", new DateTime(2050), "xcvxcvcx", "pdf");
            eBook ebook2 = new eBook("Minze", "Klaus", new DateTime(1977), "xcvcxv", "epub");
            eBook ebook3 = new eBook("Schokoladenfabrik", "Charlie",new DateTime(1998), "xcvcxvxcv", "epub");

            nameOfLibrary.AddBook(book1);
            nameOfLibrary.AddBook(book2);
            nameOfLibrary.AddBook(book3);

            nameOfLibrary.AddEBook(ebook1);
            nameOfLibrary.AddEBook(ebook2);
            nameOfLibrary.AddEBook(ebook3);

            nameOfLibrary.Structure();

            nameOfLibrary.RemoveBook("AJDHHJAF");
            nameOfLibrary.RemoveEBook("xcvxcvcx");

            nameOfLibrary.SearchBook("i");
            nameOfLibrary.Structure();



        }
    }
}