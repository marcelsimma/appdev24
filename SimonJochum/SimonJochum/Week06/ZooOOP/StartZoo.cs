using System;
using System.Collections.Generic;

namespace SimonJochum.Week06.Zoo
{
    public class StartZoo
    {
        public static void Start()
        {
            Console.WriteLine("Willkommen im Zooprogramm!");

            Console.WriteLine("Bitte gib den Namen des Zoos ein:");
            string zooName = Console.ReadLine();

            Console.WriteLine("Bitte gib das Gründungsjahr des Zoos ein:");
            string foundingYear = Console.ReadLine();

            Zoo zoo = new Zoo(zooName, foundingYear);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("1. Gehege hinzufügen");
                Console.WriteLine("2. Gehege entfernen");
                Console.WriteLine("3. Tier zu einem Gehege hinzufügen");
                Console.WriteLine("4. Tier aus einem Gehege entfernen");
                Console.WriteLine("5. Zoo-Struktur anzeigen");
                Console.WriteLine("6. Programm beenden");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddEnclosure(zoo);
                        break;
                    case "2":
                        RemoveEnclosure(zoo);
                        break;
                    case "3":
                        AddAnimalToEnclosure(zoo);
                        break;
                    case "4":
                        RemoveAnimalFromEnclosure(zoo);
                        break;
                    case "5":
                        Console.WriteLine(zoo.ToString());
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Programm wird beendet.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }
        }

        public static void AddEnclosure(Zoo zoo)
        {
            Console.WriteLine("Bitte gib den Namen des neuen Geheges ein:");
            string enclosureName = Console.ReadLine();
            Enclosure enclosure = new Enclosure(enclosureName);
            zoo.AddEnclosure(enclosure);
            Console.WriteLine($"Gehege '{enclosureName}' wurde hinzugefügt.");
        }

        public static void RemoveEnclosure(Zoo zoo)
        {
            Console.WriteLine("Bitte gib den Namen des zu entfernenden Geheges ein:");
            string enclosureName = Console.ReadLine();
            bool removed = zoo.RemoveEnclosure(enclosureName);
            if (removed)
                Console.WriteLine($"Gehege '{enclosureName}' wurde entfernt.");
            else
                Console.WriteLine($"Gehege '{enclosureName}' wurde nicht gefunden.");
        }

        public static void AddAnimalToEnclosure(Zoo zoo)
        {
            Console.WriteLine("Bitte gib den Namen des Geheges an, zu dem ein Tier hinzugefügt werden soll:");
            string enclosureName = Console.ReadLine();
            Enclosure enclosure = zoo.GetEnclosure(enclosureName);

            if (enclosure != null)
            {
                Console.WriteLine("Bitte gib den Namen des Tieres ein:");
                string animalName = Console.ReadLine();
                Console.WriteLine("Bitte gib die Gattung des Tieres ein:");
                string species = Console.ReadLine();
                Animal animal = new Animal(animalName, species);
                enclosure.AddAnimal(animal);
                Console.WriteLine($"Tier '{animalName}' wurde dem Gehege '{enclosureName}' hinzugefügt.");
            }
            else
            {
                Console.WriteLine($"Gehege '{enclosureName}' wurde nicht gefunden.");
            }
        }

        public static void RemoveAnimalFromEnclosure(Zoo zoo)
        {
            Console.WriteLine("Bitte gib den Namen des Geheges an, aus dem ein Tier entfernt werden soll:");
            string enclosureName = Console.ReadLine();
            Enclosure enclosure = zoo.GetEnclosure(enclosureName);

            if (enclosure != null)
            {
                Console.WriteLine("Bitte gib den Namen des Tieres ein, das entfernt werden soll:");
                string animalName = Console.ReadLine();
                bool removed = enclosure.RemoveAnimal(animalName);
                if (removed)
                    Console.WriteLine($"Tier '{animalName}' wurde aus dem Gehege '{enclosureName}' entfernt.");
                else
                    Console.WriteLine($"Tier '{animalName}' wurde nicht im Gehege '{enclosureName}' gefunden.");
            }
            else
            {
                Console.WriteLine($"Gehege '{enclosureName}' wurde nicht gefunden.");
            }
        }
    }
}