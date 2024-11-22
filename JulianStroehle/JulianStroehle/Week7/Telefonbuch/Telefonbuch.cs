using System;
namespace JulianStroehle.Week7.Telefonbuch
{
    internal class Telefonbuch
    {
        static List<Contact> contacts = new List<Contact>();
        internal static void Start()
        {
            if (File.Exists("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Telefonbuch.txt"))
            {
                using (StreamReader str = new("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Telefonbuch.txt"))
                {
                    string[] lines = str.ReadToEnd().Split("\r\n");
                    foreach (string line in lines)
                    {
                        if (line != "")
                        {
                            string[] parts = line.Split("; ");
                            Contact contact = new(parts[0], parts[1], int.Parse(parts[2]), parts[3]);
                            contacts.Add(contact);
                        }
                    }
                }
                Console.WriteLine("Neuen Kontakt hinzufügen? (j/n)");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "j": Add(); break;
                    default: break;
                }
                Print();
            }
            else
            {
                Console.WriteLine("Telefonbuch erstellt.\nFügen sie einen neuen Kontakt hinzu.");
                Add();
                Print();
            }
        }
        static void Add()
        {
            string input;
            do
            {
                Console.WriteLine("Name: (Vorname Nachname)");
                string[] name = Console.ReadLine().Split(" ");
                Console.WriteLine("Nummer:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Wohnort:");
                string place = Console.ReadLine();
                Contact contact = new Contact(name[0], name[1], number, place);
                contacts.Add(contact);
                Console.WriteLine("Weiteren Kontakt hinzufügen? (j/n)");
                input = Console.ReadLine();
            }
            while (input.ToLower() == "j");
        }
        static void Print()
        {
            using (StreamWriter stw = new("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Telefonbuch.txt"))
            {
                foreach (Contact contact in contacts)
                {
                    stw.WriteLine(contact);
                }
            }
        }
    }
}