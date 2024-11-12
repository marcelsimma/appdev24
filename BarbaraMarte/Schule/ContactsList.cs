using System;
using System.Security.Cryptography.X509Certificates;

namespace BarbaraMarte.Schule;
class ContactsList
{
    public static void Start()
    {
        Console.WriteLine(@"Where do you want to save your contact? Family, Friends or Work?
        If you are searching for someone press next. If you want to leave the program enter Break");
        string? decition = Console.ReadLine();


        if (decition == "Family")
        {
            Family();
        }
        else if (decition == "Friends")
        {
            Friends();
        }
        else if (decition == "Work")
        {
            Work();
        }
        else if (decition == "Break")
        {
            return;
        }
        else
        {
           Search();
            // Console.WriteLine("I don't understand you. Please try again");
        }
    }

    public static void Print()
    {

    }
    public static void Search()
    {
        List<string> search = new List<string>();
        Console.WriteLine("Which Person are you looking for? Friend (1), Family member (2) or a working friend (3?");
        char number = Convert.ToChar(Console.ReadLine());
        if (number == '1')
        {
            search.Contains(Console.ReadLine());
            Family();
            Console.WriteLine(search);
        }
        else if (number == '2')
        {
            search.Contains(Console.ReadLine());
            Friends();
        }
        else if (number == '3')
        {
            search.Contains(Console.ReadLine());
            Work();
        }
    }
    public static void Family()
    {
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> phoneNumber = new List<string>();
        Console.WriteLine("Please enter the first Name");
        firstName.Add(Console.ReadLine());
        Console.WriteLine("Please enter the last Name");
        lastName.Add(Console.ReadLine());
        Console.WriteLine("Please enter the phone number");
        phoneNumber.Add(Console.ReadLine());
        Start();
    }
    public static void Friends()
    {
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> phoneNumber = new List<string>();
        Console.WriteLine("Please enter the first Name");
        firstName.Add(Console.ReadLine());
        Console.WriteLine("Please enter the last Name");
        lastName.Add(Console.ReadLine());
        Console.WriteLine("Please enter the phone number");
        phoneNumber.Add(Console.ReadLine());
        Start();
    }
    public static void Work()
    {
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> phoneNumber = new List<string>();
        Console.WriteLine("Please enter the first Name");
        firstName.Add(Console.ReadLine());
        Console.WriteLine("Please enter the last Name");
        lastName.Add(Console.ReadLine());
        Console.WriteLine("Please enter the phone number");
        phoneNumber.Add(Console.ReadLine());
        Start();
    }
}