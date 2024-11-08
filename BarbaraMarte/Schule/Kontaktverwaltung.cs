using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

namespace BarbaraMarte.Schule;


class ContactsArray
{
    public static void Print()
    {

    }
    public static void AddContacts()
    {
        Console.WriteLine("Amount of the contacts you want to add:");
        int amount = Convert.ToInt32(Console.ReadLine());
        string[] contactName = new string[amount];
        string[] contactNumber = new string[amount];
        int count = 0;

        for (int i = 0; i < amount; i++)
        {
            AddContact(contactName, contactNumber, count);
            count++;
        }
    }


    public static void AddContact(string[] contactName, string[] contactNumber, int count)
    {
        string name;
        string phoneNumber;
        char answer;

        Console.WriteLine("Please enter your name:");
        name = Console.ReadLine();
        if (name != null)
        {
            contactName[count + 1] = name;
        }

        Console.WriteLine("Please enter a phone number:");
        phoneNumber = Console.ReadLine();
        if (phoneNumber != null)
        {
            contactNumber[count + 1] = phoneNumber;
        }
        Console.Write(name, phoneNumber);
    }
    public static string SearchContact(string[] contactName, string[] contactNumber)
    {
        Console.WriteLine("Which contact are you looking for?");

        string searchInput = Console.ReadLine();

        foreach (string contact in contactName)
        {

            if (contact == searchInput)
            {
                return string.Format("{0}, {1}", contactName, contactNumber);
            }
        }
    }
}


