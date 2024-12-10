using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class InitialiseZoo
    {
        public static void StartZoo()
        {
            Console.WriteLine("Willkommen im Zooprogramm!");

            Console.WriteLine("Bitte gib den Namen des Zoos ein:");
            string zooName = Console.ReadLine();

            Console.WriteLine("Bitte gib das Gründungsdatum des Zoos ein: (YYYY/MM/DD)");
            DateTime foundingYear = Convert.ToDateTime(Console.ReadLine());

            Zoo zoo = new Zoo(zooName, foundingYear);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWas möchtest du machen?\n1.Gehege hinzufügen\n2.Gehege entfernen\n3.Zoo-Struktur anzeigen\n4.Programm beenden");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Bitte gib den Namen des neuen Geheges ein:");
                        string enclosureName = Console.ReadLine();
                        Enclosure enclosure = new Enclosure(enclosureName);
                        zoo.AddEnclosure(enclosure);
                        Console.WriteLine($"Gehege '{enclosureName}' wurde hinzugefügt.");
                        break;
                    case "2":
                        Console.WriteLine("Bitte gib den Namen des zu entfernenden Geheges ein:");
                        string enclosureToDelete = Console.ReadLine();
                        zoo.RemoveEnclosure(enclosureToDelete);
                        break;
                    case "3":
                        Console.WriteLine(zoo.PrintZoo());
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Programm wird beendet");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }
            }
        }
    }
}
