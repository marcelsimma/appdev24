using System;

namespace BarbaraMarte.Schule.ContactsListFolder;

class AddContact : ContactListFolder
{
    public static void AddContacts()
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
    }

}