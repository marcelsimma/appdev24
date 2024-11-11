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
        Console.WriteLine("If you want to add a new contact press 1. If you want to search a contact press 2. If you want to leave the program press 3.");
        string choice = Console.ReadLine();

        do
        {
            if (choice == "1")
            {
                AddContact();
            }
            else if (choice == "2")
            {
                SearchContact();
            }
        }
        while (choice != "3");
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

    /// <summary>
    /// Search contacts
    /// </summary>
    public static void SearchContact()
    {
        Console.WriteLine("Which contact are you looking for?");
        for (int i = 0; ; i++)
        {
            if (firstName.Contains(Console.ReadLine()) == true)
            {
                Console.WriteLine("The telephone number from {0} is: {1}", firstName, phoneNumber);
            }
            else
            {
                Console.WriteLine(" is not in your contact list.");
            }
        }

        Start();
    }

}
