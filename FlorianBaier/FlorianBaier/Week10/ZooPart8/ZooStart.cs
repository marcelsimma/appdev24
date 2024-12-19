using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace FlorianBaier.Week10.ZooPart8;

internal class ZooStart
{
    private static Zoo? zoo;
    private static StreamReader str = new("C:/Users/flori/Desktop/DigitalCampus/Password.txt");
    private static string databaseConnectionString = $"server=localhost;userid=root;password={str.ReadLine()};";
    private static string query = "";
    private static MySqlConnection conn = new(databaseConnectionString);

    internal static void Start()
    {
        using (conn)
        {
            conn.Open();
            query = @"
CREATE DATABASE IF NOT EXISTS zoo;

USE zoo;

DROP TABLE IF EXISTS zoo;

CREATE TABLE zoo (ZooID INT PRIMARY KEY AUTO_INCREMENT, Name VARCHAR(50), FoundingYear YEAR);
INSERT INTO zoo VALUES (NULL, 'Tiergarten Dornbirn', 2024);
CREATE TABLE IF NOT EXISTS enclosure (
    EnclosureID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS animal (
    AnimalID INT AUTO_INCREMENT,
    Name VARCHAR(50),
    Type VARCHAR(50),
    EnclosureID INT,
    PRIMARY KEY (AnimalID, EnclosureID),
    FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID)
);

CREATE TABLE IF NOT EXISTS food (
    FoodNr INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50),
    Amount INT,
    Unit VARCHAR(5),
    Price DOUBLE
);

CREATE TABLE IF NOT EXISTS zookeeper (
    ZookeeperID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(20),
    LastName VARCHAR(40)
);

CREATE TABLE IF NOT EXISTS works_in (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    ZookeeperID INT,
    EnclosureID INT,
    FOREIGN KEY (ZookeeperID) REFERENCES zookeeper(ZookeeperID),
    FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID)
);

CREATE TABLE IF NOT EXISTS eats (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    AnimalID INT,
    FoodNr INT,
    FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID),
    FOREIGN KEY (FoodNr) REFERENCES food(FoodNr)
);";

            MySqlCommand cmd = new(query, conn);
            cmd.ExecuteNonQuery();
            for (int i = 0; i < 7; i++)
            {
                string table = "";
                switch (i)
                {
                    case 0: table = "zoo"; break;
                    case 1: table = "enclosure"; break;
                    case 2: table = "animal"; break;
                    case 3: table = "food"; break;
                    case 4: table = "zookeeper"; break;
                    case 5: table = "works_in"; break;
                    case 6: table = "eats"; break;
                }
                query = $"SELECT * FROM {table};";
                MySqlCommand cmnd = new(query, conn);
                MySqlDataReader rdr = cmnd.ExecuteReader();
                List<int> enclosureIDs = new List<int>();
                int animalID;
                while (rdr.Read())
                {
                    switch (table)
                    {
                        case "zoo":
                            zoo = new Zoo(
                                rdr.GetInt32("ZooID"),
                                rdr.GetString("Name"),
                                new DateTime(2024, 12, 11)
                            );
                            break;
                        case "enclosure":
                            Enclosure enclosure = new Enclosure(
                                rdr.GetString("Name"),
                                rdr.GetInt32("EnclosureID")
                            );
                            zoo.Enclosures.Add(enclosure);
                            break;
                        case "animal":
                            Animal animal = new Animal(
                                rdr.GetString("Name"),
                                rdr.GetString("Type"),
                                rdr.GetInt32("AnimalID")
                            );
                            zoo.Enclosures[rdr.GetInt32("EnclosureID") - 1].
                            AddAnimal(animal);
                            break;
                        case "food":
                            Food food = new Food(
                                rdr.GetString("Name"),
                                rdr.GetString("Unit"),
                                rdr.GetInt32("Amount"),
                                rdr.GetDouble("Price"),
                                rdr.GetInt32("FoodNr")
                            );
                            zoo.Foods.Add(food);
                            break;
                        case "zookeeper":
                            Zookeeper keeper = new Zookeeper(
                                rdr.GetInt32("ZookeeperID"),
                                rdr.GetString("Name"),
                                rdr.GetString("LastName")
                            );
                            zoo.Zookeepers.Add(keeper);
                            break;
                        case "works_in":
                            zoo.Zookeepers[rdr.GetInt32("ZookeeperID") - 1].
                            EnclosureList.Add(zoo.Enclosures[rdr.GetInt32("EnclosureID") - 1]);
                            break;
                        case "eats":
                            animalID = rdr.GetInt32("AnimalID");
                            foreach (Enclosure enclosure1 in zoo.Enclosures)
                            {
                                foreach (Animal animal1 in enclosure1.Animals)
                                {
                                    if (animal1.ID == animalID)
                                    {
                                        animal1.SumFood.Add(zoo.Foods[rdr.GetInt32("FoodNr") - 1],
                                        zoo.Foods[rdr.GetInt32("FoodNr") - 1].
                                        Amount);
                                    }
                                }
                            }
                            break;
                    }
                }
                rdr.Close();
            }
            Continue();
        }
    }

    static void Continue()
    {
        string action;
        do
        {
            Console.WriteLine(@"
Which function do you want to use:
                
1. Add Enclosure
2. Remove Enclosure
3. Add Zookeeper
4. Remove Zookeeper
5. Add Animal
6. Remove Animal
7. Add Food to Animal
8. Remove Food from Animal
9. Get Zoo Info
10. Get IDs
11. Start Simulation
12. End Day
E. Exit"
);
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
                case "10":
                    GetIDs();
                    break;
                case "11":
                    Simulation();
                    break;
                case "12":
                    DayEnd();
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
        Insert("enclosure", $"NULL, '{name}'");
        zoo.AddEnclosure(enclosure);
    }

    static void RemoveEnclosure()
    {
        Console.WriteLine("ID of Enclosure?");
        int id = int.Parse(Console.ReadLine());
        zoo.RemoveEnclosure(id - 1);
        Delete("works_in", "EnclosureID", id);
        Delete("enclosure", id);
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
        Insert("zookeeper", $"NULL, '{fName}', '{lName}'");
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
                    Insert("works_in", $"NULL, {zookeeper.ID}, '{enclosure.ID}'");
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
        Delete("works_in", "ZookeeperID", id);
        Delete("zookeeper", id);
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
                Insert("animal", $"{animalCount}, '{name}', '{type}', '{enclosure.ID}'");
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
                Delete("eats", "AnimalID", id);
                Delete("animal", id, " AND EnclosureID = " + enclosure.ID);
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
        Insert("food", $"{invoiceNumber}, '{foodName}', {count}, '{unit}', {priceString}");
        foreach (Enclosure enclosure in zoo.Enclosures)
            foreach (Animal animal in enclosure.Animals)
            {
                if (animal.Name == animalName)
                {
                    animal.SumFood.Add(food, count);
                    Console.WriteLine(food.Name + " added to " + animal.Name);
                    Insert("eats", $"NULL, {animal.ID}, {invoiceNumber}");
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
                                Delete("eats", "FoodNr", anyFood.InvoiceNumber);
                                Delete("food", anyFood.InvoiceNumber);
                            }
    }

    static void GetInfo()
    {
        Console.WriteLine(zoo.GetInfo());
    }
    static void GetIDs()
    {
        Console.WriteLine(zoo.GetIDs());
    }

    static void Insert(string table, string values)
    {
        query = $"INSERT INTO {table} VALUES ({values})";
        MySqlCommand cmd = new(query, conn);
        cmd.ExecuteNonQuery();
    }

    static void Delete(string table, int ID, string more = "")
    {
        query = $"SELECT * FROM {table} WHERE {table}ID = {ID}{more}";
        MySqlCommand cmd = new(query, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        string name = "";
        while (rdr.Read())
        {
            name = rdr.GetString("Name");
            Console.WriteLine("Are you sure you want to delete " + name + " (type: yes)");
        }
        rdr.Close();
        string sure = Console.ReadLine();
        if (sure == "yes")
            query = $"DELETE FROM {table} WHERE {table}ID = {ID}{more}";
        Console.WriteLine("Successfully deleted " + name);
        MySqlCommand cmnd = new(query, conn);
        cmnd.ExecuteNonQuery();

    }

    static void Delete(string table, string col, int ID)
    {
        query = $"DELETE FROM {table} WHERE {col} = {ID}";
        MySqlCommand cmnd = new(query, conn);
        cmnd.ExecuteNonQuery();
    }
    static void Simulation()
    {
        Console.WriteLine("The zookeepers go around the zoo to keep the enclosures clean and feed the animals.");
        foreach (Zookeeper zookeeper in zoo.Zookeepers)
        {
            foreach (Enclosure enclosure in zookeeper.EnclosureList)
            {
                Console.WriteLine();
                foreach (Animal animal in enclosure.Animals)
                {
                    Console.WriteLine(zookeeper.FirstName + " is Feeding the " + animal.Type + " " + animal.Name);
                }
                if (enclosure.Animals.Count != 0)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(zookeeper.FirstName + " is cleaning " + enclosure.Name);
            }
            if (zookeeper.favAnimal is null)
            {
                Random rdm = new Random();
                int favEnclosure = rdm.Next(0, zookeeper.EnclosureList.Count);
                if (zookeeper.EnclosureList[favEnclosure].Animals.Count > 0)
                {
                    int favAnimal = rdm.Next(0, zookeeper.EnclosureList[favEnclosure].Animals.Count);
                    Console.WriteLine("\n" + zookeeper.FirstName + " is watching over his favorite animal " + zookeeper.EnclosureList[favEnclosure].Animals[favAnimal].Name);
                    zookeeper.favAnimal = zookeeper.EnclosureList[favEnclosure].Animals[favAnimal];
                }
                else
                {
                    Console.WriteLine("\n" + zookeeper.FirstName + " has no favorite animal.");
                }
            }
            else
            {
                Console.WriteLine("\n" + zookeeper.FirstName + " is watching over his favorite animal " + zookeeper.favAnimal.Name);
            }
        }
        Console.WriteLine();
        foreach (Enclosure enclosure in zoo.Enclosures)
        {
            foreach (Animal animal in enclosure.Animals)
            {
                if (animal.Health > 0)
                {
                    Attack(animal, enclosure);
                }
                else
                {
                    Console.WriteLine(animal.Name + " can't attack cause it fainted.");
                }
                Random rdm = new Random();
                int heal = rdm.Next(0, 100);
                if (animal.Health < 20 && heal < 11)
                {
                    animal.Health = 100;
                    Console.WriteLine("Ali Gökdemir the vet healed " + animal.Name + " to full health.");
                }
            }
        }
    }
    static void Attack(Animal animal, Enclosure enclosure)
    {
        Random rdm = new Random();
        int percent = rdm.Next(0, 101);
        if (percent < 41)
        {
            int rand = rdm.Next(0, enclosure.Animals.Count);
            if (animal.Name != enclosure.Animals[rand].Name)
            {
                Console.WriteLine(animal.Name + " bit " + enclosure.Animals[rand].Name + " for " + animal.Attack + " damage.");
                enclosure.Animals[rand].Health -= animal.Attack;
            }
            else
            {
                Attack(animal, enclosure);
            }
        }
        else
        {
            Console.WriteLine(animal.Name + " did not attack.");
        }
    }
    static void DayEnd()
    {
        foreach (Enclosure enclosure in zoo.Enclosures)
        {
            List<int> ids = new List<int>();
            foreach (Animal animal in enclosure.Animals)
            {
                if (animal.Health <= 0)
                {
                    ids.Add(animal.ID);
                    Console.WriteLine("Removed " + animal.Name + " cause it was dead");
                }
            }
            foreach (int id in ids)
            {
                enclosure.RemoveAnimal(id);
            }
        }
        Random rdm = new Random();
        foreach (Enclosure enclosure in zoo.Enclosures)
        {
            foreach (Animal animal in enclosure.Animals)
            {
                int regen = rdm.Next(0, 30);
                if (animal.Health + regen < 100)
                {
                    animal.Health += regen;
                    Console.WriteLine(animal.Name + " regenerated " + regen + " health");
                }
                else if (animal.Health + regen >= 100)
                {
                    animal.Health = 100;
                    Console.WriteLine(animal.Name + " is on full health and cant regenerate at the moment");
                }
            }
        }
    }
}