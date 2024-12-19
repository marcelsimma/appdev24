// using System;
// using MySql.Data.MySqlClient;
// namespace JulianStroehle.Week10
// {
//     internal class Zoo_Main
//     {
//         static Zoo zoo = new(0, "Animal Well", new DateTime(2024,12,11));
//         internal static void Start()
//         {
//             string action = "";
//             do
//             {
//                 try
//                 {
//                     Console.WriteLine("\nAction:\n\n1. Add Enclosure\n2. Remove Enclosure\n3. Add Zookeeper\n4. Remove Zookeeper\n5. Add Animal\n6. Remove Animal\n7. Add Food to Animal\n8. Remove Food from Animal\n9. Get Zoo Info\nE. Exit");
//                     action = Console.ReadLine();
//                     switch (action)
//                     {
//                         case "1": AddEnclosure(); break;
//                         case "2": RemoveEnclosure(); break;
//                         case "3": AddKeeper(); break;
//                         case "4": RemoveKeeper(); break;
//                         case "5": AddAnimal(); break;
//                         case "6": RemoveAnimal(); break;
//                         case "7": AddFood(); break;
//                         case "8": RemoveFood(); break;
//                         case "9": GetInfo(); break;
//                     }
//                 }
//                 catch (Exception)
//                 {
//                     Console.WriteLine("Incorrect input, try again");
//                 }
//             }
//             while (action.ToLower() != "e");
//         }
//         internal static void AddEnclosure()
//         {
//             int enclosureCount = zoo.Enclosures.Count + 1;
//             Console.WriteLine("Name:");
//             string name = Console.ReadLine();
//             Enclosure enclosure = new Enclosure(name, enclosureCount);
//             Console.WriteLine("Added Enclosure " + name);
//             zoo.AddEnclosure(enclosure);
//         }
//         internal static void RemoveEnclosure()
//         {
//             Console.WriteLine("ID of Enclosure?");
//             int id = int.Parse(Console.ReadLine());
//             Console.WriteLine("Removed Enclosure " + zoo.Enclosures[id].Name);
//             zoo.RemoveEnclosure(id);
//         }
//         internal static void AddKeeper()
//         {
//             int keeperCount = zoo.Zookeepers.Count + 1;
//             Console.WriteLine("First Name");
//             string fName = Console.ReadLine();
//             Console.WriteLine("Last Name");
//             string lName = Console.ReadLine();
//             Zookeeper zookeeper = new Zookeeper(keeperCount, fName, lName);
//             Console.WriteLine("how many Enclosures will the keeper keep?");
//             int eCount = Convert.ToInt32(Console.ReadLine());
//             for (int i = 0; i < eCount; i++)
//             {
//                 Console.WriteLine(i + ". Enclosure");
//                 foreach (Enclosure enclosure in zoo.Enclosures)
//                 {
//                     if (enclosure.Name == Console.ReadLine())
//                     {
//                         zookeeper.EnclosureList.Add(enclosure);
//                         Console.WriteLine("Added " + enclosure.Name + " to " + zookeeper.FirstName + "\'s list");
//                     }
//                 }
//             }
//             zoo.AddKeeper(zookeeper);
//         }
//         internal static void RemoveKeeper()
//         {
//             Console.WriteLine("Keeper ID?");
//             int id = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Removed keeper " + zoo.Zookeepers[id].FirstName);
//             zoo.RemoveKeeper(id);
//         }
//         internal static void AddAnimal()
//         {
//             Console.WriteLine("Enclosure to add animal to:");
//             string enclName = Console.ReadLine();
//             Console.WriteLine("Animal Name:");
//             string name = Console.ReadLine();
//             Console.WriteLine("Animal Type:");
//             string type = Console.ReadLine();
//             foreach (Enclosure enclosure in zoo.Enclosures)
//             {
//                 int animalCount = enclosure.Animals.Count + 1;
//                 if (enclosure.Name == enclName)
//                 {
//                     Animal animal = new Animal(name, type, animalCount);
//                     enclosure.AddAnimal(animal);
//                     Console.WriteLine(string.Format("Animal {0} added to enclosure {1}", animal.Name, enclosure.Name));
//                 }
//             }
//         }
//         internal static void RemoveAnimal()
//         {
//             Console.WriteLine("Enclosure where to remove animal?");
//             string enclName = Console.ReadLine();
//             foreach (Enclosure enclosure in zoo.Enclosures)
//             {
//                 if (enclName == enclosure.Name)
//                 {
//                     Console.WriteLine("Animal ID?");
//                     int id = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Successfully removed " + enclosure.Animals[id].Name);
//                     enclosure.RemoveAnimal(id);
//                 }
//             }
//         }
//         static int invoiceNumber = 0;
//         internal static void AddFood()
//         {
//             Console.WriteLine("Animal Name?");
//             string animalName = Console.ReadLine();
//             Console.WriteLine("Type of Food?");
//             string foodName = Console.ReadLine();
//             Console.WriteLine("Unit?");
//             string unit = Console.ReadLine();
//             Console.WriteLine("Price? (use , for writing cents)");
//             double price = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("How much?");
//             int count = Convert.ToInt32(Console.ReadLine());
//             invoiceNumber++;
//             Food food = new Food(foodName, unit, count, price, invoiceNumber);
//             foreach (Enclosure enclosure in zoo.Enclosures)
//             {
//                 foreach (Animal animal in enclosure.Animals)
//                 {
//                     if (animal.Name == animalName)
//                     {
//                         animal.SumFood.Add(food, count);
//                         Console.WriteLine(food.Name + " added to " + animal.Name);
//                     }
//                 }
//             }
//         }
//         public static void RemoveFood()
//         {
//             Console.WriteLine("Enclosure ID?");
//             int enclID = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Animal ID?");
//             int animalID = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Which food do you want to remove?");
//             string food = Console.ReadLine();
//             foreach (Enclosure enclosure in zoo.Enclosures)
//             {
//                 if (enclosure.ID == enclID)
//                 {
//                     foreach (Animal animal in enclosure.Animals)
//                     {
//                         if (animal.ID == animalID)
//                         {
//                             foreach (Food anyFood in animal.SumFood.Keys)
//                             {
//                                 if (anyFood.Name == food)
//                                 {
//                                     animal.SumFood.Remove(anyFood);
//                                     Console.WriteLine("Successfully removed " + anyFood.Name);
//                                 }
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//         internal static void GetInfo()
//         {
//             Console.WriteLine(zoo.GetInfo());
//         }
//     }
// }