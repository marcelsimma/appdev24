using System;
using System.Text;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class InitialiseZoo
    {
        public static void StartZoo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Food meat = new Food("Fleisch", "kg", 5.0);
            Food hay = new Food("Heu", "kg", 2.0);
            Food fishFood = new Food("Fischfutter", "kg", 2.5);
            Food water = new Food("Wasser", "L", 0.1);


            Console.WriteLine("Willkommen im Zooprogramm!");

            Console.WriteLine("Bitte gib den Namen des Zoos ein:");
            string zooName = Console.ReadLine();

            Console.WriteLine("Bitte gib das Gründungsdatum des Zoos ein: (YYYY/MM/DD)");
            DateTime foundingYear = Convert.ToDateTime(Console.ReadLine());

            Zoo zoo = new Zoo(zooName, foundingYear);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWas möchtest du machen?\n1.Gehege hinzufügen\n2.Gehege entfernen\n3.Tier zum Gehege hinzufügen\n4.Tier aus dem Gehege entfernen\n5.Futterbedarf und Kosten pro Tag ausgeben\n6.Zoo-Struktur anzeigen\n7.Tierpfleger hinzufügen\n8.Programm beenden");
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
                        Console.WriteLine("Bitte gib den Namen des Geheges an, zu dem ein Tier hinzugefügt werden soll:");
                        string getEnclosure = Console.ReadLine();
                        Enclosure getEnclosureName = zoo.GetEnclosure(getEnclosure);

                        if (getEnclosureName != null)
                        {
                            Console.WriteLine("Bitte gib den Namen des Tieres ein:");
                            string animalName = Console.ReadLine();
                            Console.WriteLine("Bitte gib die Gattung des Tieres ein:");
                            string species = Console.ReadLine();

                            var foodRequirements = new Dictionary<Food, double>();

                            bool addingFood = true;

                            while (addingFood)
                            {
                                Console.WriteLine("Welches Futter frisst das Tier? (fleisch, heu, wasser, fischfutter)");
                                string foodName = Console.ReadLine().ToLower();

                                Food selectedFood = null;

                                if (foodName == "fleisch")
                                {
                                    selectedFood = meat;
                                }
                                else if (foodName == "heu")
                                {
                                    selectedFood = hay;
                                }
                                else if (foodName == "wasser")
                                {
                                    selectedFood = water;
                                }
                                else if (foodName == "fischfutter")
                                {
                                    selectedFood = fishFood;
                                }

                                if (selectedFood != null)
                                {
                                    Console.WriteLine("Wieviel frisst das Tier? (z. B. 5 für 5 kg)");
                                    double quantity = Convert.ToDouble(Console.ReadLine());

                                    if (foodRequirements.ContainsKey(selectedFood))
                                    {
                                        foodRequirements[selectedFood] += quantity;
                                    }
                                    else
                                    {
                                        foodRequirements[selectedFood] = quantity;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ungültige Futterart. Bitte versuche es erneut.");
                                    continue;
                                }

                                Console.WriteLine("Möchtest du noch weiteres Futter hinzufügen? (ja/nein)");
                                string moreFood = Console.ReadLine().ToLower();
                                if (moreFood != "ja")
                                {
                                    addingFood = false;
                                }
                            }

                            Animal animal = new Animal(animalName, species, foodRequirements);

                            getEnclosureName.AddAnimal(animal);
                            Console.WriteLine($"Tier '{animalName}' wurde dem Gehege '{getEnclosure}' hinzugefügt.");
                        }
                        else
                        {
                            Console.WriteLine($"Gehege '{getEnclosure}' wurde nicht gefunden.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Bitte gib den Namen des Geheges an, aus dem ein Tier entfernt werden soll:");
                        string enclosureToRemoveAnimal = Console.ReadLine();
                        Enclosure getEnclosureToRemoveAnimal = zoo.GetEnclosure(enclosureToRemoveAnimal);
                        if (getEnclosureToRemoveAnimal != null)
                        {
                            Console.WriteLine("Bitte gib den Namen des Tieres ein, das entfernt werden soll:");
                            string animalName = Console.ReadLine();
                            getEnclosureToRemoveAnimal.RemoveAnimal(animalName);
                            Console.WriteLine($"Tier '{animalName}' wurde aus dem Gehege '{enclosureToRemoveAnimal}' entfernt.");
                        }
                        else
                        {
                            Console.WriteLine($"Gehege '{enclosureToRemoveAnimal}' wurde nicht gefunden.");
                        }
                        break;
                    case "5":
                        zoo.PrintFoodRequirements();
                        break;
                    case "6":
                        Console.WriteLine(zoo.PrintZoo());
                        break;
                    case "7":
                        Console.WriteLine("Wie ist der Name des Pflegers der hinzugefügt werden soll?");
                        string name = Console.ReadLine();
                        Zookeeper zookeeper = new Zookeeper(name);
                        bool addAgain = true;
                        zoo.AddZookeeper(zookeeper);
                        Console.WriteLine("Tierpfleger hinzugefügt.");
                        while (addAgain)
                        {
                            Console.WriteLine("Welchem Gehege soll der Pfleger hinzugefügt werden?");
                            string enclosureToAddToZookeeper = Console.ReadLine();
                            Enclosure toAdd = zoo.GetEnclosure(enclosureToAddToZookeeper);
                            zookeeper.AddEnclosure(toAdd);
                            

                            Console.WriteLine("Möchtest du den Pfleger noch einem Gehege zuteilen? (ja/nein)");
                            string again = Console.ReadLine().ToLower();
                            if (again != "ja")
                            {
                                addAgain = false;
                            }
                        }
                        break;
                    case "8":
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
