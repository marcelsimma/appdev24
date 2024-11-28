using System;

namespace BerkantAkinci.ATest
{
    class LibraryMain
    {
        public static void Start()
        {
            LibraryName nameOfLibrary = new LibraryName("Landesbibliothekt");

            Book book1 = new Book("Harry Potter", "Drake", DateTime.Now, "AJDHHJAF", "Hardcover");
            Book book2 = new Book("Paulaner", "Martin", DateTime.Now, "ajfhadjfkh", "Softcover");
            Book book3 = new Book("Gartenblume", "Stefan", DateTime.Now, "sdfsdfsdf", "Hardcover");

            eBook ebook1 = new eBook("Digitalisierung", "Einstein", DateTime.Now, "xcvxcvcx", "pdf");
            eBook ebook2 = new eBook("Minze", "Klaus", DateTime.Now, "xcvcxv", "epub");
            eBook ebook3 = new eBook("Schokoladenfabrik", "Charlie", DateTime.Now, "xcvcxvxcv", "epub");

            nameOfLibrary.AddBook(book1);
            nameOfLibrary.AddBook(book2);
            nameOfLibrary.AddBook(book3);

            nameOfLibrary.AddEBook(ebook1);
            nameOfLibrary.AddEBook(ebook2);
            nameOfLibrary.AddEBook(ebook3);

            nameOfLibrary.Structure();

            nameOfLibrary.RemoveBook(book1);
            nameOfLibrary.Structure();



        }
    }
}