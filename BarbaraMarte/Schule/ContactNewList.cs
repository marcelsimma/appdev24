using System;
namespace BarbaraMarte.Schule;

class ContactsNewList
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
        Console.Clear();
        Console.WriteLine(@"
        Add Contact => 1
        Search Contact => 2
        Delete Contact => 3
        Print out all your contacts => 4
        Leave the Program => E
        ");
        string? choice = Console.ReadLine();

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
            DeleteContact();
        }
        else if (choice == "4")
        {
            PrintOutContacts();
        }
        else if (choice == "E" || choice == "e")
        {
            Console.WriteLine("You are leaving the program now. Have a lovely day!");
            return;
        }
        else
        {
            Start();
        }
    }
    public static void PrintOutContacts()
    {
        for (int i = 0; i < firstName.Count; i++)
        {
            Console.WriteLine($"First name: {firstName[i]}, family name: {lastName[i]}, phone number: {phoneNumber[i]}");
        }

        /*
        Console.WriteLine();
        // Combine all lists in a single structure for sorting
        var contacts = firstName
        .Select((fName, index) => new
        {
            FirstName = fName,
            LastName = lastName[index],
            PhoneNumber = phoneNumber[index]
        })
        .OrderBy(contact => contact.LastName)   // Sort by last name
        .ThenBy(contact => contact.FirstName)   // Optional if the last name accurse mort than once: Sort by first name
        .ToList();
        foreach (var contact in contacts)
        {
            Console.WriteLine($"First name: {contact.FirstName}, Family name: {contact.LastName}, Phone number: {contact.PhoneNumber}.");
        }


        .Sort() saves the sort and the lists don't match after you did that!!

        lastName.Sort();
        for (int x = 0; x < lastName.Count; x++)
        {
            Console.WriteLine($"Family name: {lastName[x]}");
        }
        */


        Start();
    }


    /// <summary>
    /// Adding contacts
    /// </summary>
    public static void AddContact()
    {
        Console.WriteLine("Is the following contact in your 'Friend', 'Family' or 'Work' List?");
        string? input = Console.ReadLine().ToLower();
        if (input == "friend")
        {
            category.Add("Friend");
        }
        else if (input == "family")
        {
            category.Add("Family");
        }
        else if (input == "work")
        {
            category.Add("Work");
        }
        else
        {
            Console.WriteLine("Not valid input");
        }

        Console.WriteLine("Please enter your first name:");
        firstName.Add(Console.ReadLine());

        Console.WriteLine("Please enter your last name:");
        lastName.Add(Console.ReadLine());

        Console.WriteLine("Please enter a phone number:");
        phoneNumber.Add(Console.ReadLine());
        Start();
    }

    /// <summary>
    /// You put in the search for your contact
    /// </summary>
    public static void SearchContact()
    {
        Console.WriteLine("Which contact are you looking for?");
        Console.WriteLine(SearchInList());
        Start();
    }

    /// <summary>
    /// you search in here the contact list
    /// </summary>
    /// <returns></returns>
    public static string SearchInList()     //  use a string instead a void that I can use a return in the if part. Makes it easier to return value
    {
        string? input = Console.ReadLine();
        List<string> foundContacts = new List<string>();
        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (lastName[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (phoneNumber[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (category[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
        }
        if (foundContacts.Count == 0)
        {
            return "The contact detail you entered is not in your contact list.";
        }
        Console.WriteLine("Found contacts:");
        foreach (var contact in foundContacts)
        {
            Console.WriteLine(contact);
        }
        return "";
    }

    /// <summary>
    /// Deletes the contact with all the information attached to it 
    /// </summary>
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
        Start();
    }
}
