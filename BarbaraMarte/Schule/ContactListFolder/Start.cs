using System;
namespace BarbaraMarte.Schule.ContactListFolder;

enum ContactCategory
{
    Friend = 1,
    Family = 2,
    Work = 3
}
class ContactListNew
{
    public static List<string> FamilyContacts = new List<string>();
    public static List<string> FriendContacts = new List<string>();
    public static List<string> WorkContacts = new List<string>();
    public static List<string> Tmp = new List<string>();
    public static int count = 0;

    /// <summary>
    /// Start position where you choice what you want to do
    /// </summary>
    public static void Start()
    {
        bool running = true;
        while (running == true)
        {
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
                /* case "3":
                     DeleteContact();
                     break;
                 case "4":
                     PrintOutContacts();
                     break; */
                case "E":
                case "e":
                    Console.WriteLine("You are leaving the program now. Have a lovely day!");
                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Please try again");
                    break;
            }
        }
    }
    public static void AddContact()
    {
        Console.WriteLine("Please enter your first name:");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Please enter a phone number:");
        string? phoneNumber = Console.ReadLine();
        string contact = $"First name: {firstName,-10} last name: {lastName,-10} phone number: {phoneNumber,12}";
        Tmp.Add(contact);

        ContactCategory contactCategory;
        Console.WriteLine("Is the following contact in your Family 1, Friend 2 or Work List 3?");
        char input = Convert.ToChar(Console.ReadLine());
        if (input == '1')
        {
            contactCategory = ContactCategory.Family;
            FamilyContacts.Add(contact);
        }
        else if (input == '2')
        {
            contactCategory = ContactCategory.Friend;
            FriendContacts.Add(contact);
        }
        else if (input == '3')
        {
            contactCategory = ContactCategory.Work;
            WorkContacts.Add(contact);
        }
        else
        {
            Console.WriteLine("Not valid input");
            return;
        }
    }
    public static void SearchContact()     //  use a string instead a void that I can use a return in the if part. Makes it easier to return value
    {
        Console.WriteLine("Which contact are you looking for?");
        string? input = Console.ReadLine();
        bool foundContact = false;
        foreach (string contact in FamilyContacts)
        {
            if (input == contact)
            {
                Console.WriteLine($"{input} is in your Family contact list.");
                foundContact = true;
            }
        }
        foreach (string contact in FriendContacts)
        {
            if (input.Contains(contact))
            {
                Console.WriteLine($"{input} is in your Friends contact list.");
                foundContact = true;
            }
        }
        foreach (string contact in WorkContacts)
        {
            if (input.Contains(contact))
            {
                Console.WriteLine($"{input} is in your Family contact list.");
                foundContact = true;
            }
        }
        if (foundContact == false)
        {
            Console.WriteLine($"{input} is not in your contact list.");
        }
    }

    /*
    public static void DeleteContact()
    {
        Console.WriteLine("Which contact are you looking for?");
        string? input = Console.ReadLine();
        bool contactFound = false;

        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input)
            {
                Console.WriteLine("{0} is now removed from your list", firstName[i]);
                firstName.RemoveAt(i);
                lastName.RemoveAt(i);       // .RemoveAt(i) removes the input ( the contact information ) at the position i
                phoneNumber.RemoveAt(i);
                contactFound = true;
                break;
            }
        }
        if (!contactFound)
        {
            Console.WriteLine($"The name you entered is not in your contact list.");
        }
    }

    public static void PrintOutContacts()
    {
        for (int i = 0; i < firstName.Count; i++)
        {
            Console.WriteLine($"First name: {firstName[i],-10}, family name: {lastName[i],-10}, phone number: {phoneNumber[i],-15}");
        }
        Console.WriteLine();

        List<string> tmp = new List<string>(lastName);
        tmp.Sort();
        foreach (string name in tmp)
        {
            Console.WriteLine($"Sorted Family name: {name}");
        }
    }
    */
}