using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
namespace BarbaraMarte.Schule.ContactsListFolder;

class ContactListFolder
{
    public static List<string> firstName = new List<string>();
    public static List<string> lastName = new List<string>();
    public static List<string> phoneNumber = new List<string>();
    public static List<string> category = new List<string>();
    public static int count = 0;

    /// <summary>
    /// Start position where you choice what you want to do
    /// </summary>
    public static void Start()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine(@"
            Add Contact => 1
            Search Contact => 2
            Delete Contact => 3
            Print out all your contacts => 4
            Leave the Program => E
            ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddContact addContact = new AddContact();
                    Console.WriteLine(addContact);
                    break;
                case "2":
                    SearchContact searchContact = new SearchContact();
                    Console.WriteLine(searchContact);
                    break;
                case "3":
                    DeleteContact deleteContact = new DeleteContact();
                    Console.WriteLine(deleteContact);
                    break;
                case "4":
                    PrintOutContacts printOutContacts = new PrintOutContacts();
                    Console.WriteLine(printOutContacts);
                    break;
                case "E":
                case "e":
                    Console.WriteLine("You are leaving the program now. Have a lovely day!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again");
                    break;
            }
        }
    }
}