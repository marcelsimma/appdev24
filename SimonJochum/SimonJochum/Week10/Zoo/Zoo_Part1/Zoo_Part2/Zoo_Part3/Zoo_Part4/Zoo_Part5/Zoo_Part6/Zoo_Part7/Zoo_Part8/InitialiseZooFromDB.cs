using System;
using System.Text;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class InitialiseZooFromDB
    {
        private static Zoo? zoo;
        public static void StartZooWithDB()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string query = "";
            LoadZooFromDB();
            for (int i = 0; i < 7; i++)
            {
                string table = "";

                switch (i)
                {
                    case 0: table = "zoo.zoo"; break;
                    case 1: table = "zoo.enclosure"; break;
                    case 2: table = "zoo.animal"; break;
                    case 3: table = "zoo.food"; break;
                    case 4: table = "zoo.zookeeper"; break;
                    case 5: table = "zoo.enclosure_zookeeper"; break;
                    case 6: table = "zoo.animal_food"; break;
                }
                query = $"SELECT * FROM {table};";
                string connectionString = Connect();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Verbindung erfolgreich.");
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            using MySqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                switch (table)
                                {
                                    case "zoo.zoo":
                                        zoo = new Zoo(
                                            reader.GetString("Name"),
                                            reader.GetDateTime("FoundingYear")
                                        );
                                        break;
                                    case "zoo.enclosure":
                                        Enclosure enclosure = new Enclosure(
                                            reader.GetString("Name")
                                        );
                                        zoo.AddEnclosure(enclosure);
                                        break;
                                    case "zoo.animal":
                                        Random random = new Random();
                                        double biteStrength = random.Next(1, 26);
                                        Animal animal = new Animal(
                                            reader.GetString("Name"),
                                            reader.GetString("Species"),
                                            biteStrength
                                        );
                                        int enclosureId = reader.GetInt32("EnclosureID");
                                        string getEnclosure = null;

                                        using (var enclosureConnection = new MySqlConnection(connectionString))
                                        {
                                            enclosureConnection.Open();
                                            using (var command = new MySqlCommand("SELECT Name FROM zoo.enclosure WHERE EnclosureID = @EnclosureID", enclosureConnection))
                                            {
                                                command.Parameters.AddWithValue("@EnclosureID", enclosureId);

                                                using (var rdr = command.ExecuteReader())
                                                {
                                                    if (rdr.Read())
                                                    {
                                                        getEnclosure = rdr.GetString(0);
                                                    }
                                                }
                                            }
                                        }
                                        Enclosure toAdd = zoo.GetEnclosure(getEnclosure);
                                        toAdd.AddAnimal(animal);
                                        break;
                                    case "zoo.food":
                                        Food food = new Food(
                                            reader.GetInt32("EAN"),
                                            reader.GetString("Name"),
                                            reader.GetString("Unit"),
                                            reader.GetDouble("UnitPrice")
                                        );
                                        zoo.AddFood(food);
                                        break;
                                    case "zoo.zookeeper":
                                        Zookeeper zookeeper = new Zookeeper(
                                            reader.GetString("Name")
                                        );
                                        zoo.AddZookeeper(zookeeper);
                                        break;
                                    case "zoo.enclosure_zookeeper":
                                        int zookeeperID = reader.GetInt32("ZookeeperID");
                                        int enclosureID = reader.GetInt32("EnclosureID");
                                        string getKeeperName = null;
                                        string getEnclosureName = null;

                                        using (var zookeeperConnection = new MySqlConnection(connectionString))
                                        {
                                            zookeeperConnection.Open();
                                            using (var keeperCommand = new MySqlCommand("SELECT Name FROM zoo.zookeeper WHERE ZookeeperID = @ZookeeperID", zookeeperConnection))
                                            {
                                                keeperCommand.Parameters.AddWithValue("@ZookeeperID", zookeeperID);

                                                using (var keeperReader = keeperCommand.ExecuteReader())
                                                {
                                                    if (keeperReader.Read())
                                                    {
                                                        getKeeperName = keeperReader.GetString(0);
                                                    }
                                                }
                                            }
                                        }

                                        using (var enclosureConnection = new MySqlConnection(connectionString))
                                        {
                                            enclosureConnection.Open();
                                            using (var enclosureCommand = new MySqlCommand("SELECT Name FROM zoo.enclosure WHERE EnclosureID = @EnclosureID", enclosureConnection))
                                            {
                                                enclosureCommand.Parameters.AddWithValue("@EnclosureID", enclosureID);

                                                using (var enclosureReader = enclosureCommand.ExecuteReader())
                                                {
                                                    if (enclosureReader.Read())
                                                    {
                                                        getEnclosureName = enclosureReader.GetString(0);
                                                    }
                                                }
                                            }
                                        }

                                        Zookeeper zookeeperToAddToEnclosure = zoo.GetZookeeper(getKeeperName);
                                        Enclosure toAddTo = zoo.GetEnclosure(getEnclosureName);
                                        zookeeperToAddToEnclosure.AddEnclosure(toAddTo);
                                        break;
                                    case "zoo.animal_food":
                                        int dbAnimalID = reader.GetInt32("AnimalID");
                                        int ean = reader.GetInt32("EAN");
                                        double amount = reader.GetDouble("Amount");

                                        string animalName = null;
                                        string species = null;

                                        using (var animalConnection = new MySqlConnection(connectionString))
                                        {
                                            animalConnection.Open();
                                            using (var command = new MySqlCommand("SELECT Name, Species FROM zoo.animal WHERE AnimalID = @AnimalID", animalConnection))
                                            {
                                                command.Parameters.AddWithValue("@AnimalID", dbAnimalID);

                                                using (var rdr = command.ExecuteReader())
                                                {
                                                    if (rdr.Read())
                                                    {
                                                        animalName = rdr.GetString("Name");
                                                        species = rdr.GetString("Species");
                                                    }
                                                }
                                            }
                                        }

                                        if (!string.IsNullOrEmpty(animalName) && !string.IsNullOrEmpty(species))
                                        {
                                            Animal animalToAddFood = null;
                                            foreach (var enclosure1 in zoo.Enclosures)
                                            {
                                                animalToAddFood = enclosure1.Animals.Find(animal =>
                                                    animal.Name == animalName && animal.Species == species);
                                                if (animalToAddFood != null) break;
                                            }

                                            if (animalToAddFood != null)
                                            {
                                                Food foodToAdd = zoo.Foods.Find(food => food.EAN == ean);
                                                if (foodToAdd != null)
                                                {
                                                    if (animalToAddFood.FoodRequirements.ContainsKey(foodToAdd))
                                                    {
                                                        animalToAddFood.FoodRequirements[foodToAdd] += amount;
                                                    }
                                                    else
                                                    {
                                                        animalToAddFood.FoodRequirements[foodToAdd] = amount;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Futter mit EAN {ean} nicht gefunden.");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Tier '{animalName}' mit Gattung '{species}' nicht gefunden.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Tier mit ID {dbAnimalID} nicht in der Tabelle animal gefunden.");
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Fehler: {ex.Message}");
                    }
                }
            }
            Continue();
        }

        public static void Continue()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Was möchtest du machen?\n1.Zoostruktur ausgeben\n2.Futterbedarf ausgeben\n3.Zootag simulieren\n9.Programm beenden");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(zoo.PrintZoo());
                        break;
                    case "2":
                        zoo.PrintFoodRequirements();
                        break;
                    case "3":
                        zoo.SimulateDay();
                        
                        break;
                    case "9":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Bitte gib eine gültige Aktion ein.");
                        break;
                }
            }
        }

        public static void LoadZooFromDB()
        {
            CreateDatabase();
            InsertIntoDatabase();
        }

        public static string Connect()
        {
            string connectionString = "";
            using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
            {
                connectionString = str.ReadToEnd();
                return connectionString;
            }
        }

        public static void CreateDatabase()
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"DROP DATABASE IF EXISTS zoo;
                                        CREATE DATABASE zoo;
                                        USE zoo;

                                        -- Zootabellen erstellen
                                        CREATE TABLE IF NOT EXISTS zoo.zoo (
                                            ZooID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL, 
                                            FoundingYear DATE
                                            );
                                        CREATE TABLE IF NOT EXISTS zoo.zookeeper (
                                            ZookeeperID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL
                                            );
                                        CREATE TABLE IF NOT EXISTS zoo.enclosure (
                                            EnclosureID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL
                                            );
                                        CREATE TABLE IF NOT EXISTS zoo.animal (
                                            AnimalID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL, 
                                            Species VARCHAR(50),
                                            EnclosureID INT,
                                        FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID)
                                            );
                                        CREATE TABLE IF NOT EXISTS zoo.food (
                                            EAN INT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL, 
                                            Unit VARCHAR(5) NOT NULL, 
                                            UnitPrice DOUBLE(10,2) NOT NULL
                                            );

                                        -- Beziehungstabellen erstellen (bei viele zu viele Beziehungen)
                                        CREATE TABLE IF NOT EXISTS zoo.animal_food (
                                            AnimalID INT, 
                                            EAN INT, 
                                            Amount DOUBLE(8,2) NOT NULL,
                                            Unit VARCHAR(5) NOT NULL,
                                            PRIMARY KEY (AnimalID, EAN),
                                            FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID), 
                                            FOREIGN KEY (EAN) REFERENCES food (EAN));
                                        CREATE TABLE IF NOT EXISTS zoo.enclosure_zookeeper (
                                            ZookeeperID INT NOT NULL, 
                                            EnclosureID INT NOT NULL,
                                        PRIMARY KEY (ZookeeperID, EnclosureID), 
                                        FOREIGN KEY (ZookeeperID) REFERENCES zookeeper (ZookeeperID), 
                                        FOREIGN KEY (EnclosureID) REFERENCES enclosure (EnclosureID));";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Eintrag wurde erfolgreich hinzugefügt.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }

        public static void InsertIntoDatabase()
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"INSERT INTO zoo.zoo (Name, FoundingYear) 
                                        VALUES ('Schoenbrunn', '1970.10.10');
                                        INSERT INTO zoo.enclosure (Name) 
                                        VALUES ('Savanne'), ('Steppe'), ('Aquarium');
                                        INSERT INTO zoo.animal (AnimalID, Name, Species, EnclosureID) 
                                        VALUES (1, 'Simba', 'Loewe', 1), (2, 'Nala', 'Loewe', 1), (3, 'Nayla', 'Loewe', 1), 
                                                (4, 'Benjamin', 'Elefant', 2), (5, 'Stampfi', 'Elefant', 2), (6, 'Ruessel', 'Elefant', 2), 
                                                (7, 'Nemo', 'Clownfisch', 3), (8, 'Dori', 'Doktorfisch', 3), (9, 'Sharky', 'Hai', 3);
                                        INSERT INTO zoo.food (EAN, Name, Unit, UnitPrice) 
                                        VALUES (1001, 'Wasser', 'L', 0.50), (1002, 'Heu', 'KG', 1.00), (1003, 'Fleisch', 'KG', 5.00), (1004, 'Fischfutter', 'KG', 2.50);
                                        INSERT INTO zoo.zookeeper (Name) 
                                        VALUES ('Simon'), ('Julian'), ('Barbara');
                                        INSERT INTO zoo.animal_food (AnimalID, EAN, Amount, Unit)
                                        VALUES (1, 1001, 5, 'L'), (1, 1003, 10, 'KG'), (2, 1001, 6, 'L'), (2, 1003, 12, 'KG'), (3, 1001, 3, 'L'), (3, 1003, 6, 'KG'), 
                                        (4, 1001, 10, 'L'), (4, 1002, 20, 'KG'), (5, 1001, 12, 'L'), (5, 1002, 24, 'KG'), (6, 1001, 7, 'L'), (6, 1002, 14, 'KG'),
                                        (7, 1004, 2, 'KG'), (8, 1004, 2.5, 'KG'), (9, 1003, 12, 'KG');
                                        INSERT INTO zoo.enclosure_zookeeper 
                                        VALUES (1, 1), (1, 2), (2, 2), (3, 3);";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Eintrag wurde erfolgreich hinzugefügt.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }
    }
}