using System;
using System.Security.Cryptography.X509Certificates;

namespace BarbaraMarte.Schule;
class ContactsList
{
    private static List<Contact> contactDetails = new List<Contact>();
    public static void Start()
    {
        while (true)
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
                    AddContact();
                    break;
                case "2":
                    SearchContact();
                    break;
                case "3":
                    DeleteContact();
                    break;
                case "4":
                    PrintOutContacts();
                    break;
                case "E":
                case "e":
                    Console.WriteLine("You are leaving the program now. Have a lovely day!");
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again");
                    break;

            }

        }
    }
    public static void AddContact()
    {
        Console.WriteLine("Enter the Family name:");
        string? familyN = Console.ReadLine();
        Console.WriteLine("Enter the First name:");
        string? firstN = Console.ReadLine();
        Console.WriteLine("Enter the Phone number:");
        string? phoneN = Console.ReadLine();

        contactDetails.Add(new Contact(familyN, firstN, phoneN));
        Start();
    }
    public static void SearchContact()
    {
        Console.WriteLine("Which contact are you looking for?");
        Console.WriteLine(SearchInList());
        Start();
    }
    public static void DeleteContact()
    {

    }
    public static void PrintOutContacts()
    {

    }
    public static string SearchInList()
    {
        string? input = Console.ReadLine();
        List<string> foundContacts = new List<string>();
        for (int i = 0; i < contactDetails.Count; i++)
        {
            if (i == 1)
            {
                foundContacts.Add($"The person you are searching for: {contactDetails[i]}");
            }
        }
        if (contactDetails.Count == 0)
        {
            return "The contact detail you entered is not in your contact list.";
        }
        foreach (var contact in foundContacts)
        {
            Console.WriteLine(contact);
        }
        return "";
    }
    class Contact
    {
        public string FamilyName { get; }
        public string FirstName { get; }
        public string PhoneNumber { get; }
        public Contact(string familyName, string firstName, string phoneNumber)
        {
            FamilyName = familyName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"{FamilyName}, {FirstName} - {PhoneNumber}";
        }
    }
}