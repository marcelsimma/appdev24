using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace JulianStroehle.Week10;

internal class Zoo_Main2
{
    private static Zoo zoo = new Zoo(0, "Tirgardn", new DateTime(2024, 12, 11));
    private static StreamReader str = new("C:/Users/JUSR/Desktop/-/PW.txt");
    private static string databaseConnectionString = $"server=localhost;userid=root;password={str.ReadLine()};";
    private static string query = "";
    private static MySqlConnection conn = new(databaseConnectionString);

    internal static void Start()
    {
        using (conn)
        {
            try
            {
                conn.Open();
                query = @"
USE dcvzoo;
CREATE TABLE IF NOT EXISTS zoo (Name VARCHAR(50) PRIMARY KEY, FoundingYear DATE);
CREATE TABLE IF NOT EXISTS enclosure (EnclosureID INT PRIMARY KEY AUTO_INCREMENT, Name VARCHAR(50));
CREATE TABLE IF NOT EXISTS animal (AnimalID INT, Name VARCHAR(50), Type VARCHAR(50), EnclosureID INT, PRIMARY KEY (AnimalID, EnclosureID), FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID));
CREATE TABLE IF NOT EXISTS food (FoodNr INT PRIMARY KEY AUTO_INCREMENT, Name VARCHAR(50), Amount INT, Unit VARCHAR(5), Price DOUBLE);
CREATE TABLE IF NOT EXISTS zookeeper (ZookeeperID INT PRIMARY KEY AUTO_INCREMENT, Name VARCHAR(20), LastName VARCHAR(40));
CREATE TABLE IF NOT EXISTS works_in (ID INT PRIMARY KEY AUTO_INCREMENT, ZookeeperID INT, EnclosureID INT, FOREIGN KEY (ZookeeperID) REFERENCES zookeeper(ZookeeperID), FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID));
CREATE TABLE IF NOT EXISTS eats (ID INT PRIMARY KEY AUTO_INCREMENT, AnimalID INT, FoodNr INT, FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID), FOREIGN KEY (FoodNr) REFERENCES food(FoodNr));";
                MySqlCommand cmd = new(query, conn);
                cmd.ExecuteNonQuery();
                Continue();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                Start();
            }
        }
    }

    static void Continue()
    {
        string action = "";
        do
        {
            Console.WriteLine(
                "\nAction:\n\n1. Add Enclosure\n2. Remove Enclosure\n3. Add Zookeeper\n4. Remove Zookeeper\n5. Add Animal\n6. Remove Animal\n7. Add Food to Animal\n8. Remove Food from Animal\n9. Get Zoo Info\nE. Exit");
            action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    AddEnclosure();
                    break;
                case "2":
                    RemoveEnclosure();
                    break;
                case "3":
                    AddKeeper();
                    break;
                case "4":
                    RemoveKeeper();
                    break;
                case "5":
                    AddAnimal();
                    break;
                case "6":
                    RemoveAnimal();
                    break;
                case "7":
                    AddFood();
                    break;
                case "8":
                    RemoveFood();
                    break;
                case "9":
                    GetInfo();
                    break;
            }
        } while (action.ToLower() != "e");
    }
    static int enclosureCount = 0;
    static void AddEnclosure()
    {
        enclosureCount++;
        Console.WriteLine("Name:");
        string name = Console.ReadLine();
        Enclosure enclosure = new(name, enclosureCount);
        Console.WriteLine("Added Enclosure " + name);
        Init("enclosure", $"NULL, '{name}'");
        zoo.AddEnclosure(enclosure);
    }

    static void RemoveEnclosure()
    {
        Console.WriteLine("ID of Enclosure?");
        int id = int.Parse(Console.ReadLine());
        zoo.RemoveEnclosure(id);
        Outit("works_in", "EnclosureID", id);
        Outit("enclosure", id);
    }
    static int keeperCount = 0;
    static void AddKeeper()
    {
        keeperCount++;
        Console.WriteLine("First Name");
        string fName = Console.ReadLine();
        Console.WriteLine("Last Name");
        string lName = Console.ReadLine();
        Zookeeper zookeeper = new(keeperCount, fName, lName);
        Init("zookeeper", $"NULL, '{fName}', '{lName}'");
        Console.WriteLine("how many Enclosures will the keeper keep?");
        int eCount = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < eCount; i++)
        {
            Console.WriteLine(i + 1 + ". Enclosure");
            string enc = Console.ReadLine();
            foreach (Enclosure enclosure in zoo.Enclosures)
                if (enclosure.Name == enc)
                {
                    zookeeper.EnclosureList.Add(enclosure);
                    Init("works_in", $"NULL, {zookeeper.ID}, '{enclosure.ID}'");
                    Console.WriteLine("Added " + enclosure.Name + " to " + zookeeper.FirstName + "\'s list");
                }
        }

        zoo.AddKeeper(zookeeper);
    }

    static void RemoveKeeper()
    {
        Console.WriteLine("Keeper ID?");
        int id = Convert.ToInt32(Console.ReadLine());
        zoo.RemoveKeeper(id);
        Outit("works_in", "ZookeeperID", id);
        Outit("zookeeper", id);
    }
    static void AddAnimal()
    {
        Console.WriteLine("Enclosure to add animal to:");
        string enclName = Console.ReadLine();
        Console.WriteLine("Animal Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Animal Type:");
        string type = Console.ReadLine();
        foreach (Enclosure enclosure in zoo.Enclosures)
        {
            int animalCount = enclosure.Animals.Count + 1 + enclosure.deletedAnimals;
            if (enclosure.Name == enclName)
            {
                Animal animal = new(name, type, animalCount);
                enclosure.AddAnimal(animal);
                Init("animal", $"{animalCount}, '{name}', '{type}', '{enclosure.ID}'");
                Console.WriteLine(string.Format("Animal {0} added to enclosure {1}", animal.Name, enclosure.Name));
            }
        }
    }

    static void RemoveAnimal()
    {
        Console.WriteLine("Enclosure where to remove animal?");
        string enclName = Console.ReadLine();
        foreach (Enclosure enclosure in zoo.Enclosures)
            if (enclName == enclosure.Name)
            {
                Console.WriteLine("Animal ID?");
                int id = Convert.ToInt32(Console.ReadLine());
                enclosure.RemoveAnimal(id);
                Outit("eats", "AnimalID", id);
                Outit("animal", id, " AND EnclosureID = " + enclosure.ID);
                enclosure.deletedAnimals++;
            }
    }

    private static int invoiceNumber = 0;

    static void AddFood()
    {
        Console.WriteLine("Animal Name?");
        string animalName = Console.ReadLine();
        Console.WriteLine("Type of Food?");
        string foodName = Console.ReadLine();
        Console.WriteLine("Unit?");
        string unit = Console.ReadLine();
        Console.WriteLine("Price? (use , for writing cents)");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How much?");
        int count = Convert.ToInt32(Console.ReadLine());
        invoiceNumber++;
        Food food = new(foodName, unit, count, price, invoiceNumber);
        string priceString = Regex.Replace(price.ToString("F"), ",", ".");
        Init("food", $"{invoiceNumber}, '{foodName}', {count}, '{unit}', {priceString}");
        foreach (Enclosure enclosure in zoo.Enclosures)
        foreach (Animal animal in enclosure.Animals)
        {
            if (animal.Name == animalName)
            {
                animal.SumFood.Add(food, count);
                Console.WriteLine(food.Name + " added to " + animal.Name);
                Init("eats", $"NULL, {animal.ID}, '{invoiceNumber}'");
            }
        }
    }

    static void RemoveFood()
    {
        Console.WriteLine("Enclosure ID?");
        int enclID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Animal ID?");
        int animalID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Which food do you want to remove?");
        string food = Console.ReadLine();
        foreach (Enclosure enclosure in zoo.Enclosures)
            if (enclosure.ID == enclID)
                foreach (Animal animal in enclosure.Animals)
                    if (animal.ID == animalID)
                        foreach (Food anyFood in animal.SumFood.Keys)
                            if (anyFood.Name == food)
                            {
                                animal.SumFood.Remove(anyFood);
                                Outit("eats", "FoodNr", anyFood.InvoiceNumber);
                                Outit("food", anyFood.InvoiceNumber);
                            }
    }

    static void GetInfo()
    {
        Console.WriteLine(zoo.GetInfo());
    }

    static void Init(string table, string values)
    {
        query = $"INSERT INTO {table} VALUES ({values})";
        MySqlCommand cmd = new(query, conn);
        cmd.ExecuteNonQuery();
    }

    static void Outit(string table, int ID, string more = "")
    {
        query = $"SELECT * FROM {table} WHERE {table}ID = {ID}{more}";
        MySqlCommand cmd = new(query, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        string name = "";
        while (rdr.Read())
        {
            name = rdr.GetString("Name");
            Console.WriteLine("Are you sure you want to delete " + name + " (type: yes");
        }
        rdr.Close();
        string sure = Console.ReadLine();
        if (sure == "yes")
            query = $"DELETE FROM {table} WHERE {table}ID = {ID}{more}";
            MySqlCommand cmnd = new(query, conn);
            cmnd.ExecuteNonQuery();
            Console.WriteLine("Successfully deleted " + name);
    }

    static void Outit(string table, string col, int ID)
    {
        query = $"DELETE FROM {table} WHERE {col} = {ID}";
        MySqlCommand cmnd = new(query, conn);
        cmnd.ExecuteNonQuery();
    }
}