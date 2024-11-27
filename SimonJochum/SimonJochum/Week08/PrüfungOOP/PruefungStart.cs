using System;

namespace SimonJochum.Week08.PrüfungOOP
{
    public class PruefungStart
    {
        static Library CityLibrary = new Library();
        public static void Start()
        {
            bool check = true;
            while (check)
            {
                Book TheLittlePrince = new Book("Der Kleine Prinz", "Johann Göthe", "1970", "12345ABC", "Hardcover");
                Book TheBigPrince = new Book("Der große Prinz", "Johann Schreiber", "1977", "54321CBA", "Softcover");
                EBook IDontKnow = new EBook("Die Prinzessin auf der Erbse", "Julia Writer", "2012", "34512AHJE", "pdf");
                EBook YouDontKnow = new EBook("Die Fünf Fragezeichen", "Jessica Fletcher", "2018", "367gfhHJE", "epub");
                CityLibrary.AddBook(TheLittlePrince);
                CityLibrary.AddBook(TheBigPrince);
                CityLibrary.AddEBook(IDontKnow);
                CityLibrary.AddEBook(YouDontKnow);
                Console.WriteLine("Was möchten Sie tun?(add/delete/search)");
                string choice = Console.ReadLine().ToLower();
                if (choice == "delete")
                {
                    Delete();
                }
                else if (choice == "add")
                {
                    AddBook();
                }
                else if (choice == "search")
                {
                    SearchBook();
                }
                else
                {
                    check = false;
                }
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Welches Buch möchten Sie entfernen. Bitte ISBN eingeben");
            string ISBN = Console.ReadLine();
            CityLibrary.DeleteBook(ISBN);
        }

        public static void AddBook()
        {
            Console.WriteLine("Möchtest du ein Buch oder ein EBook hinzufügen? (Buch/EBook)");
            string choice = Console.ReadLine().ToLower();
            if (choice == "buch")
            {
                Console.WriteLine("Wie ist der Titel?");
                string title = Console.ReadLine();
                Console.WriteLine("Wer ist der Autor?");
                string author = Console.ReadLine();
                Console.WriteLine("Wann wurde das Buch geschrieben?");
                string publishingYear = Console.ReadLine();
                Console.WriteLine("Wie lautet die ISBN?");
                string ISBN = Console.ReadLine();
                Console.WriteLine("Was für ein Cover hat das Buch? (Softcover/Hardcover)");
                string cover = Console.ReadLine();
                Book newBook = new Book(title, author, publishingYear, ISBN, cover);
                CityLibrary.AddBook(newBook);
            }
            else if (choice == "ebook")
            {
                Console.WriteLine("Wie ist der Titel?");
                string title = Console.ReadLine();
                Console.WriteLine("Wer ist der Autor?");
                string author = Console.ReadLine();
                Console.WriteLine("Wann wurde das Buch geschrieben?");
                string publishingYear = Console.ReadLine();
                Console.WriteLine("Wie lautet die ISBN?");
                string ISBN = Console.ReadLine();
                Console.WriteLine("Welches Dateiformat hat das Buch? (PDF/EPUB)");
                string fileFormat = Console.ReadLine();
                EBook newEBook = new EBook(title, author, publishingYear, ISBN, fileFormat);
                CityLibrary.AddEBook(newEBook);
            }

        }

        public static void SearchBook()
        {
            Console.WriteLine("Welches Buch möchten Sie suchen? (Titel oder Autor)");
            string search = Console.ReadLine();
            CityLibrary.SearchBook(search);
        }
    }
}