using System;
namespace BarbaraMarte.Schule;

class ContactsArray
{
    public static string[] contactName = new string[1]; // you start with one saved spot in the Array and add on to these
    public static int[] contactNumber = new int[1];
    public static int count = 0;
    /// <summary>
    /// Start position where you choice what you want to do
    /// </summary>
    public static void Start()
    {
        Console.WriteLine("If you want to add a new contact press 1. If you want to search a contact press 2. If you want to leave the program press 3.");
        char choice = Convert.ToChar(Console.ReadLine());
        switch (choice)
        {
            case '1':
                AddContact();
                break;
            case '2':
                SearchContact();
                break;
            case '3':
                return;
            default:
                Console.WriteLine("Please enter a number from above");
                break;
        }
        Start();        // need a Start() here otherwise you can't continue when someone goes in to the default "mode" 
    }
    /// <summary>
    /// Adding contacts
    /// </summary>
    public static void AddContact()
    {
        Console.WriteLine("Please enter your name:");
        string? addName = Console.ReadLine();
        count++;
        if (count == 1)
        {
            contactName[count - 1] = addName;   // without the count-1 you would be one step ahead of the Array. Your Array starts count on the position 0 but you start count on position 1
        }
        else if (count > 1)
        {
            Array.Resize(ref contactName, contactName.Length + 1);
            contactName[contactName.Length - 1] = addName;
        }
        Console.WriteLine("Please enter a phone number:");
        int addNumber = Convert.ToInt32(Console.ReadLine());
        if (count == 1)
        {
            contactNumber[count - 1] = addNumber;               // for the first contact
        }
        else if (count > 1)
        {
            Array.Resize(ref contactNumber, contactNumber.Length + 1);      // for each new contact you need to add one more space
            contactNumber[contactNumber.Length - 1] = addNumber;            // do not forget to remove 1 as otherwise your Array is one number ahead.
        }
        Start();            // you need the start method at the end to go back to the beginning position  
    }

    /// <summary>
    /// Search contacts
    /// </summary>
    public static void SearchContact()
    {
        Console.WriteLine("Which contact are you looking for?");

        string? searchInput = Console.ReadLine();
        bool search = false;

        for (int i = 0; i < contactName.Length; i++)
        {
            if (searchInput == contactName[i])
            {
                Console.WriteLine("The telephone number from {0} is: {1}", searchInput, contactNumber[i]);
                search = true;
            }
            else if (search == false)
            {
                Console.WriteLine(searchInput + " is not in your contact list.");
            }
        }
        int j = 0;
        while (search == false && j < contactName.Length)
            Start();
    }

}
