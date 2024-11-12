using System;
namespace BarbaraMarte.Schule;

class ContactsNewList
{
    public static List<string> firstName = new List<string>();
    public static List<string> lastName = new List<string>();
    public static List<string> phoneNumber = new List<string>();
    public static int count = 0;
    /// <summary>
    /// Start position where you choice what you want to do
    /// </summary>
    public static void Start()
    {
        Console.WriteLine("If you want to add a new contact press 1. If you want to search a contact press 2. If you want to delete a contact press 3. If you want to leave the program press 4.");
        string choice = Console.ReadLine();

        if (choice == "1" || choice == "2" || choice == "3")
        {
            if (choice == "1")
            {
                AddContact();
            }
            else if (choice == "2")
            {
                SearchContact();
            }
            else if (choice == "3")
            {

            }
        }
        else if (choice == "4")
        {
            Console.WriteLine("You are leaving the program now. Have a lovely day!");
            return;
        }
        else
        {
            Start();
        }
    }
    public static string RemoveContact()
    {
        Console.WriteLine("Which contact do you want to remove?");
        return "";

    }

    /// <summary>
    /// Adding contacts
    /// </summary>
    public static void AddContact()
    {
        Console.WriteLine("Please enter your first name:");
        firstName.Add(Console.ReadLine());

        Console.WriteLine("Please enter your last name:");
        lastName.Add(Console.ReadLine());

        Console.WriteLine("Please enter a phone number:");
        phoneNumber.Add(Console.ReadLine());
        Start();
    }
    public static void SearchContact()
    {
        Console.WriteLine("Which contact are you looking for?");
        Console.WriteLine(Search());

    }
    public static string Search()
    {
        string? input = Console.ReadLine();
        bool contactFound = false;
        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input)
            {
                return $"{firstName[i]}s last name is: {lastName[i]} and the telephone number from  is: {phoneNumber[i]}";
            }
        }
        if (!contactFound)
        {
            return "The name you entered is not in your contact list.";
        }
        return "";
    }

    public static void SearchContact1()
    {
        Console.WriteLine("Which contact are you looking for?");
        string? input = Console.ReadLine();
        bool contacFound = false;

        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input)
            {
                Console.WriteLine("{0}s last name is: {1} and the telephone number from  is: {2}", firstName[i], lastName[i], phoneNumber[i]);
                contacFound = true;
                break;
            }
        }
        if (!contacFound)
        {
            Console.WriteLine($"The name you entered is not in your contact list.");
        }

        Start();
    }

}
