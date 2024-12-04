using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

namespace BarbaraMarte.Schule.Library;

class Library
{
    public List<Book> AllAboutBooks = new List<Book>();
    public List<User> Users = new List<User>();         // would be a perfect case for a 
    public List<Book> BorrowedBooks = new List<Book>();
    public List<string> SortedBooks = new List<string>();
    public void Start()
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
            string input = Console.ReadLine() ?? "";

            switch (input.ToUpper())
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    AddUser();
                    break;
                case "3":
                    {
                        var currentUser = AskUserForLogin();
                        if (currentUser is null)
                        {
                            System.Console.WriteLine("User not found => please create a User");
                            AddUser();
                        }
                        else
                        {
                            BorrowBook(currentUser);
                        }
                        break;
                    }

                case "4":
                    {
                        var currentUser = AskUserForLogin();
                        if (currentUser is null)
                        {
                            System.Console.WriteLine("User not found => please create a User");
                            AddUser();
                        }
                        else
                        {
                            LeaveBookBack(currentUser);
                        }
                        break;
                    }
                case "5":
                    AskUserForBook();
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
    public void AddBook()
    {
        System.Console.WriteLine("Title:");
        string title = Console.ReadLine() ?? "";
        System.Console.WriteLine("Author:");
        string author = Console.ReadLine() ?? "";
        System.Console.WriteLine("ISBN:");
        string isbn = Console.ReadLine() ?? "";
        bool isAvailable = true;

        Book book1 = new Book(title, author, isbn, isAvailable);
        AllAboutBooks.Add(book1);
        System.Console.WriteLine(book1);
    }
    public void AddUser()
    {
        Console.WriteLine("First Name");
        string firstName = Console.ReadLine() ?? "";
        Console.WriteLine("Last Name");
        string lastName = Console.ReadLine() ?? "";
        Console.WriteLine("ID number");
        string idNumber = Console.ReadLine() ?? "";
        if (SearchUserById(idNumber) is null)
        {
            User library = new User(firstName, lastName, idNumber);
            Users.Add(library);
            System.Console.WriteLine("User is Added");
        }
        else if (SearchUserById(idNumber) is not null)
        {
            System.Console.WriteLine("This user Id is already used. Please try again");
        }
    }

    public User? AskUserForLogin()
    {
        System.Console.WriteLine("Please enter your user ID");
        string inputID = Console.ReadLine() ?? "";
        return SearchUserById(inputID);
    }
    public User? SearchUserById(string inputID)
    {
        for (int m = 0; m < Users.Count; m++)
        {
            if (inputID == Users[m].IdNumber)
            {
                return Users[m];
            }
        }
        return null;
    }
    public void BorrowBook(User currentUser)
    {
        System.Console.WriteLine("Which book do you want to borrow?");
        var book = AskUserForBook();

        if (book is null)
        {
            // book not found
            return;
        }
        // check wether book is available
        else if (book.IsAvailable)
        {
            UserBorrowsBook(book, currentUser);
            System.Console.WriteLine("You have successfully borrowed the book.");
        }
        else
        {
            System.Console.WriteLine("The book is currently not available");
            return;
        }
    }
    public void UserBorrowsBook(Book book, User currentUser)
    {
        if (book.IsAvailable == false)
        {
            throw new ArgumentException("Must not be called for unavailable books.");
        }

        book.IsAvailable = false;
        this.BorrowedBooks.Add(book);
        currentUser.UserBorrowedBooks.Add(book);
    }

    public void UserBookBack(Book book, User currentUser)
    {
        if (book.IsAvailable == true)
        {
            throw new ArgumentException("Must only be called for unavailable books.");
        }

        book.IsAvailable = true;
        this.BorrowedBooks.Remove(book);
        currentUser.UserBorrowedBooks.Remove(book);
    }

    public void LeaveBookBack(User currentUser)
    {
        var book = AskUserForBook();

        if (book is null)
        {
            // book not found
            return;
        }
        // check wether book is available
        else if (!book.IsAvailable)
        {
            UserBookBack(book, currentUser);
            System.Console.WriteLine("Thank you for leaving the book back!");
        }
        else
        {
            System.Console.WriteLine("I am sorry, this book is not from our Library.");
            return;
        }
    }
    public Book? AskUserForBook()   // is for the UserInput
    {
        System.Console.WriteLine("Please enter the book you are looking.");
        string input = Console.ReadLine() ?? "";
        Book? book = SearchForBook(input);

        if (book is not null)
        {
            System.Console.WriteLine($"We have {input} in our Library:\n{book}.");
        }
        else
        {
            System.Console.WriteLine($"I am sorry, we do not have {input} in our Library.");
        }

        return book;
    }

    public Book? SearchForBook(string input)    // Checks if the book is in the System
    {
        for (int i = 0; AllAboutBooks.Count > i; i++)
        {
            if (input == AllAboutBooks[i].Author || input == AllAboutBooks[i].Title || input == AllAboutBooks[i].ISBN)
            {
                return AllAboutBooks[i];
            }
        }
        return null;
    }


    public void PrintOutAllBooks()
    {
        for (int i = 0; i < AllAboutBooks.Count; i++)
        {
            // is missing a exception that old contacts are not supposed to be added to the sorting list.
            // foreach PrintOutAllBooks, one book is added to the list.  
            SortedBooks.Add($"Author: {AllAboutBooks[i].Author,-10} Title: {AllAboutBooks[i].Title,-10} ISBN : {AllAboutBooks[i].ISBN,-10} The book is Available: {AllAboutBooks[i].IsAvailable,-6}");
        }
        SortedBooks.Sort();
        foreach (var book in SortedBooks)
        {
            System.Console.WriteLine(book);
        }

    }
}
