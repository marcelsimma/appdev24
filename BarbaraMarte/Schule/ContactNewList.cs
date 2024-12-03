using System;
using System.Threading.Tasks.Dataflow;
namespace BarbaraMarte.Schule;

enum ContactCategory
{
    Friend = 1,
    Family = 2,
    Work = 3
}
class ContactsNewList
{
    public static List<string> firstName = new List<string>();
    public static List<string> lastName = new List<string>();
    public static List<string> phoneNumber = new List<string>();
    public static List<ContactCategory> category = new List<ContactCategory>();
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
            Print out all contacts from one category => 5
            Leave the Program => E
            ");
            string? choice = Console.ReadLine();
            switch (choice.ToUpper())
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
                case "5":
                    SearchCategory();
                    break;
                case "E":
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
    public static void SearchCategory()
    {
        var names = Enum.GetNames(typeof(ContactCategory));
        Console.WriteLine(string.Join(", ", names));
        Console.WriteLine("Please enter the category number, starting with 1:");
        var input = Console.ReadLine() ?? "1";
        PrintOutContacts(Enum.Parse<ContactCategory>(input));
    }
    public static void PrintOutContacts(ContactCategory? filter = null) // with the =(default parameter) after the filter you don't need to write it in on the call side. It becomes optional
    {

        List<string> tmp = new List<string>();
        for (int i = 0; i < firstName.Count; i++)
        {
            if (filter is null || category[i] == filter)    // you use "is" for null checks. Opposite == "is not" 
            {
                tmp.Add($"Family name: {lastName[i],-10} first name: {firstName[i],-10} phone number: {phoneNumber[i],-10} Category: {category[i]}");
            }
        }
        tmp.Sort();
        foreach (string contact in tmp)
        {
            Console.WriteLine($"{contact}");
        }
    }
    public static void AddContact()
    {
        Console.WriteLine("Is the following contact in your Family 1, Friend 2 or Work List 3?");
        char input = Convert.ToChar(Console.ReadLine());
        if (input == '1')
        {
            category.Add(ContactCategory.Family);
        }
        else if (input == '2')
        {
            category.Add(ContactCategory.Friend);
        }
        else if (input == '3')
        {
            category.Add(ContactCategory.Work);
        }
        else
        {
            Console.WriteLine("Not valid input");
            return;
        }

        Console.WriteLine("Please enter your first name:");
        firstName.Add(Console.ReadLine());

        Console.WriteLine("Please enter your last name:");
        lastName.Add(Console.ReadLine());

        Console.WriteLine("Please enter a phone number:");
        phoneNumber.Add(Console.ReadLine());
    }
    public static void SearchContact()
    {
        Console.WriteLine("Which contact are you looking for?");
        Console.WriteLine(SearchInList());
        Start();
    }

    public static string SearchInList()     //  use a string instead a void that I can use a return in the if part. Makes it easier to return value
    {
        string? input = Console.ReadLine();
        List<string> foundContacts = new List<string>();
        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input || lastName[i] == input || phoneNumber[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (Enum.TryParse<ContactCategory>(input, true, out var searchCategory) && category[i] == searchCategory)
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
    }
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
        */
