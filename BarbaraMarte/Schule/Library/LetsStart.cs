using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

namespace BarbaraMarte.Schule.Library;

class LetsGo : BookInformation
{
    public static List<string> AllAboutBooks = new List<string>();
    public static List<string> User = new List<string>();
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
                    // LeaveBookBack();
                    break;
                case "5":
                    // SearchForBook();
                    break;
                case "6":
                    // PrintOutAllBooks();
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
        if (IsAvailable() == true)
        {

        }
        else
        {
            System.Console.WriteLine("The book you are looking for is at the moment not in our library!");
        }
    }
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
    public static void AddBook()
    {
        Console.WriteLine("Title of the Book:");
        string title = Console.ReadLine() ?? "";
        Console.WriteLine("Author:");
        string author = Console.ReadLine() ?? "";
        Console.WriteLine("ISBN");
        string isbn = Console.ReadLine() ?? "";
        AllAboutBooks.Add($"{title}, {author}, {isbn}");
    }
}
class BookInformation
{
    public static void BookInput()
    {
        Book book = new Book("The small prince", "Marge Simpson", "165484", true);
        System.Console.WriteLine(book);
    }
}
class Book
{
    private string Title { get; set; }
    private string Author { get; set; }
    private string ISBN { get; set; }
    private bool IsAvailable { get; set; }

    public Book(string title, string author, string isbn, bool isAvailable)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = isAvailable;
    }
    public override string ToString()
    {
        return string.Format($"Title: {Title} Author {Author} ISBN {ISBN} Is the book available? {IsAvailable}");
    }
}