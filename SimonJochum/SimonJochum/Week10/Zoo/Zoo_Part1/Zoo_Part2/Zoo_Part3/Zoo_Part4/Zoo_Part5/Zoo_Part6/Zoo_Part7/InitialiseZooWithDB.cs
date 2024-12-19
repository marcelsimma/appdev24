using System;
using System.Text;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class InitialiseZooWithDB
    {
        public static void StartZoo()
        {
            CreateDatabase();
            Console.OutputEncoding = Encoding.UTF8;
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Food meat = new Food(1003, "Fleisch", "kg", 5.0);
            CreateFood(1003, "Fleisch", "kg", 5.0);
            Food hay = new Food(1002, "Heu", "kg", 2.0);
            CreateFood(1002, "Heu", "kg", 2.0);
            Food fishFood = new Food(1004, "Fischfutter", "kg", 2.5);
            CreateFood(1004, "Fischfutter", "kg", 2.50);
            Food water = new Food(1001, "Wasser", "L", 0.1);
            CreateFood(1001, "Wasser", "L", 0.10);


            Console.WriteLine("Willkommen im Zooprogramm!");

            Console.WriteLine("Bitte gib den Namen des Zoos ein:");
            string zooName = Console.ReadLine();

            Console.WriteLine("Bitte gib das Gründungsdatum des Zoos ein: (YYYY.MM.DD)");
            DateTime foundingYear;

            while (true)
            {
                string input = Console.ReadLine();
                if (DateTime.TryParseExact(input, "yyyy.MM.dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out foundingYear))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültiges Format. Bitte gib das Datum im Format YYYY.MM.DD ein:");
                }
            }

            Zoo zoo = new Zoo(zooName, foundingYear);
            CreateZoo(zooName, foundingYear);

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
                        CreateEnclosure(enclosureName);
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
                            //CreateAnimal(animalName, species);
                            AddEnclosureToAnimal(animalName, species, getEnclosure);
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
                                    AddFoodToAnimal(animalName, foodName, Convert.ToString(quantity));
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
                        CreateZookeeper(name);
                        Console.WriteLine("Tierpfleger hinzugefügt.");
                        while (addAgain)
                        {
                            Console.WriteLine("Welchem Gehege soll der Pfleger hinzugefügt werden?");
                            string enclosureToAddToZookeeper = Console.ReadLine();
                            Enclosure toAdd = zoo.GetEnclosure(enclosureToAddToZookeeper);
                            AddZookeeperToEnclosure(name, enclosureToAddToZookeeper);
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
        public static void CreateFood(int EAN, string Name, string Unit, double UnitPrice)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = $"INSERT INTO zoo.food (EAN, Name, Unit, UnitPrice) VALUES ({EAN}, '{Name}', '{Unit}', {UnitPrice});";
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
        public static void CreateZoo(string zooName, DateTime foundingYear)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string formattedDate = foundingYear.ToString("yyyy-MM-dd");
                    string query = @$"INSERT INTO zoo.zoo (Name, FoundingYear) VALUES ('{zooName}', '{formattedDate}');";
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

        public static void CreateEnclosure(string enclosureName)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"INSERT INTO zoo.enclosure (Name) VALUES ('{enclosureName}');";
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

        // public static void CreateAnimal(string animalName, string animalSpecies)
        // {
        //     string connectionString = Connect();
        //     using (MySqlConnection connection = new MySqlConnection(connectionString))
        //     {
        //         try
        //         {
        //             connection.Open();
        //             Console.WriteLine("Verbindung zur Datenbank hergestellt.");
        //             string query = @$"INSERT INTO zoo.animal (Name, Species) VALUES ('{animalName}', '{animalSpecies}');";
        //             using (MySqlCommand command = new MySqlCommand(query, connection))
        //             {
        //                 using (MySqlDataReader reader = command.ExecuteReader())
        //                 {
        //                     Console.WriteLine("Eintrag wurde erfolgreich hinzugefügt.");
        //                 }
        //             }
        //         }
        //         catch (MySqlException ex)
        //         {
        //             Console.WriteLine($"Fehler: {ex.Message}");
        //         }
        //     }
        // }

        public static void CreateZookeeper(string name)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"INSERT INTO zoo.zookeeper (Name) VALUES ('{name}');";
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

        public static void AddZookeeperToEnclosure(string zookeeperName, string enclosureName)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"INSERT INTO zoo.enclosure_zookeeper (ZookeeperID, EnclosureID)
                                        SELECT 
                                            zookeeper.ZookeeperID, 
                                            enclosure.EnclosureID
                                        FROM 
                                            zoo.zookeeper, 
                                            zoo.enclosure
                                        WHERE 
                                            zookeeper.NAME = '{zookeeperName}' 
                                        AND enclosure.NAME = '{enclosureName}';";
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

        public static void AddFoodToAnimal(string animalName, string foodName, string quantity)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"INSERT INTO zoo.animal_food (AnimalID, EAN, Amount, Unit)
                                        SELECT 
                                        (SELECT AnimalID FROM zoo.animal WHERE Name = '{animalName}') AS AnimalID,
                                        (SELECT EAN FROM zoo.food WHERE Name = '{foodName}') AS EAN,
                                            {quantity} AS Amount,
                                        (SELECT Unit FROM zoo.food WHERE Name = '{foodName}') AS Unit;";
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

        public static void AddEnclosureToAnimal(string animalName, string species, string enclosureName)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"INSERT INTO zoo.animal (Name, Species, EnclosureID)
                                        SELECT 
                                        '{animalName}' AS Name,
                                        '{species}' AS Species,
                                    (SELECT EnclosureID FROM zoo.enclosure WHERE Name = '{enclosureName}') AS EnclosureID;";
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
                                        CREATE TABLE IF NOT EXISTS zoo (
                                            ZooID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL, 
                                            FoundingYear DATE
                                            );
                                        CREATE TABLE IF NOT EXISTS zookeeper (
                                            ZookeeperID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL
                                            );
                                        CREATE TABLE IF NOT EXISTS enclosure (
                                            EnclosureID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL
                                            );
                                        CREATE TABLE IF NOT EXISTS animal (
                                            AnimalID INT AUTO_INCREMENT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL, 
                                            Species VARCHAR(50),
                                            EnclosureID INT,
                                        FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID)
                                            );
                                        CREATE TABLE IF NOT EXISTS food (
                                            EAN INT PRIMARY KEY, 
                                            Name VARCHAR(50) NOT NULL, 
                                            Unit VARCHAR(5) NOT NULL, 
                                            UnitPrice DOUBLE(10,2) NOT NULL
                                            );

                                        -- Beziehungstabellen erstellen (bei viele zu viele Beziehungen)
                                        CREATE TABLE IF NOT EXISTS animal_food (
                                            AnimalID INT, 
                                            EAN INT, 
                                            Amount DOUBLE(8,2) NOT NULL,
                                            Unit VARCHAR(5) NOT NULL,
                                            PRIMARY KEY (AnimalID, EAN),
                                            FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID), 
                                            FOREIGN KEY (EAN) REFERENCES food (EAN));
                                        CREATE TABLE IF NOT EXISTS enclosure_zookeeper (
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
    }
}