using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

namespace BarbaraMarte.Schule.Library;

class LetsGo
{
    public static List<Book> AllAboutBooks = new List<Book>();
    public static List<string> User = new List<string>();
    public static List<string> BorrowedBooks = new List<string>();
    public static void Start()
    {
        bool running = true;
        while (running == true)
        {
            Console.WriteLine(
                @"
        Add book = 1
        Add user = 2
        Borrow book = 3
        Leave book back = 4
        Search for a book = 5
        Print out all books = 6
        Exit = E
        ");
            string? input = Console.ReadLine() ?? "";

            switch (input.ToUpper())
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    AddUser();
                    break;
                case "3":
                    BorrowBook();
                    break;
                case "4":
                    LeaveBookBack();
                    break;
                case "5":
                    SearchForBook();
                    break;
                case "6":
                    PrintOutAllBooks();
                    break;
                case "E":

                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Please try again");
                    break;
            }
        }
    }
    public static void PrintOutAllBooks()
    {
        foreach (string print in AllAboutBooks)
        {
            System.Console.WriteLine(print);
        }
    }
    public static void SearchForBook()
    {

    }
    public static void LeaveBookBack()
    {
        string input = Console.ReadLine() ?? "";
        for (int i = 0; i < BorrowedBooks.Count; i++)
        {
            if (input == BorrowedBooks[i])
            {
                AllAboutBooks.Add(BorrowedBooks[i]);
                System.Console.WriteLine($"Thanks for bringing {input} back!");
                BorrowedBooks.RemoveAt(i);
            }
            else
            {
                System.Console.WriteLine("I am sorry, this book is not from our Library.");
            }
        }
    }
    public static void AddUser()
    {
        Console.WriteLine("First Name");
        string firstName = Console.ReadLine() ?? "";
        Console.WriteLine("Last Name");
        string lastName = Console.ReadLine() ?? "";
        Console.WriteLine("ID number");
        string idNumber = Console.ReadLine() ?? "";
        User.Add($"Family name: {lastName} First name: {firstName} User ID: {idNumber}");
    }
    public static void BorrowBook()
    {
        System.Console.WriteLine("Which book are you looking for?");
        string input = Console.ReadLine() ?? "";
        for (int i = 0; i < AllAboutBooks.Count; i++)
        {
            if (AllAboutBooks[i] == input)
            {
                BorrowedBooks.Add(AllAboutBooks[i]);
                System.Console.WriteLine($"Have fun with {input}");
                AllAboutBooks.RemoveAt(i);
            }
            else
            {
                System.Console.WriteLine("The book you are looking for is at the moment not in our library!");
            }
        }
    }
    public static void AddBook()
    {
        Console.WriteLine("Title of the Book:");
        string Title = Console.ReadLine() ?? "";
        Console.WriteLine("Author:");
        string Author = Console.ReadLine() ?? "";
        Console.WriteLine("ISBN");
        string Isbn = Console.ReadLine() ?? "";
        AllAboutBooks.Add($"{Title}, {Author}, {Isbn}");
    }
    public static void BookInput()
    {
        Book book = new Book("The small prince", "Marge Simpson", "165484", true);
        System.Console.WriteLine(book);
        Book book1 = new Book(Title, Author, Isbn, false);
    }
}



/*
private static bool isHere = true;
    private static bool LeaveBookBack()
    {
        return isHere;
    }
    private static bool IsAvailable()
    {
        if (LeaveBookBack() == true && BorrowBookBool() == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private static bool BorrowBookBool()
    {
        if (IsAvailable() == true)
        {
            isHere = false;
        }
        return isHere;
    }
*/