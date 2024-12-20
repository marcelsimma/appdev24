using System;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week10.Zoo.Zoostructure
{
    internal class Initialise
    {
        internal static void CreateZoo(string zooname, DateTime foundingyear, MySqlConnection connection)
        {
            try
            {
                string initialiseZooQuery = @"INSERT INTO zoo
                VALUES (@Zooname, @FoundingYear);";

                MySqlCommand initialiseZoocommand = new MySqlCommand(initialiseZooQuery, connection);
                initialiseZoocommand.Parameters.AddWithValue("@Zooname", zooname);
                initialiseZoocommand.Parameters.AddWithValue("@FoundingYear", foundingyear);

                int newRows = initialiseZoocommand.ExecuteNonQuery();

                if (newRows > 0)
                {
                    Console.WriteLine("\nDer Zoo wurde in der DB erstellt!");
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        internal static void CreateEnclosure(string enclosurearea, MySqlConnection connection)
        {
            try
            {
                string getzoonameQuery = @"SELECT Zooname
                FROM zoo;";

                MySqlCommand getzoonamecommand = new MySqlCommand(getzoonameQuery, connection);
                List<string> Zoos = new List<string>();

                using (MySqlDataReader reader = getzoonamecommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Zoos.Add(reader.GetString("Zooname"));
                    }
                }

                while (true)
                {
                    Console.WriteLine("\nZu welchem Zoo gehört das neue Gehege?");

                    foreach (string zoo in Zoos)
                    {
                        Console.WriteLine(zoo);
                    }

                    string zooname = Console.ReadLine();
                    if (Zoos.Contains(zooname))
                    {
                        string initialiseEnclosureQuery = @"INSERT INTO enclosure (Area, Zooname)
                            VALUES (@Area, @Zooname);";

                        MySqlCommand initialiseEnclosurecommand = new MySqlCommand(initialiseEnclosureQuery, connection);
                        initialiseEnclosurecommand.Parameters.AddWithValue("@Area", enclosurearea);
                        initialiseEnclosurecommand.Parameters.AddWithValue("@Zooname", zooname);

                        int newRows = initialiseEnclosurecommand.ExecuteNonQuery();

                        if (newRows > 0)
                        {
                            Console.WriteLine("\nDas Gehege wurde in der DB erstellt!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das ist kein gültiger Zooname oder der Zoo ist nicht in der Datenbank vorhanden!");
                    }

                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        internal static void CreateFood(string foodname, double pricepermeas, string measurement, MySqlConnection connection)
        {
            try
            {
                string initialiseFoodQuery = @"INSERT INTO food (Foodname, Price, Measurement)
                VALUES (@Foodname, @Price, @Measurement);";

                MySqlCommand initialiseFoodcommand = new MySqlCommand(initialiseFoodQuery, connection);
                initialiseFoodcommand.Parameters.AddWithValue("@Foodname", foodname);
                initialiseFoodcommand.Parameters.AddWithValue("@Price", pricepermeas);
                initialiseFoodcommand.Parameters.AddWithValue("@Measurement", measurement);

                int newRows = initialiseFoodcommand.ExecuteNonQuery();

                if (newRows > 0)
                {
                    Console.WriteLine("\nDas Futter wurde in der DB erstellt!");
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        internal static void CreateZookeeper(string firstname, string lastname, MySqlConnection connection)
        {
            try
            {
                Console.WriteLine("\nIn welchem Zoo arbeitet der neue Zoowärter?");

                string getzoonameQuery = @"SELECT Zooname
                FROM zoo;";
                MySqlCommand getzoonamecommand = new MySqlCommand(getzoonameQuery, connection);
                List<string> Zoos = new List<string>();

                using (MySqlDataReader reader = getzoonamecommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Zoos.Add(reader.GetString("Zooname"));
                    }
                }

                foreach (string zoo in Zoos)
                {
                    Console.WriteLine(zoo);
                }

                while (true)
                {
                    string zooname = Console.ReadLine();
                    if (Zoos.Contains(zooname))
                    {
                        string initialiseZookeeperQuery = @"INSERT INTO zookeeper (Firstname, Lastname, Workplace)
                        VALUES (@Firstname, @Lastname, @Workplace);";

                        MySqlCommand initialiseZookeepercommand = new MySqlCommand(initialiseZookeeperQuery, connection);
                        initialiseZookeepercommand.Parameters.AddWithValue("@Firstname", firstname);
                        initialiseZookeepercommand.Parameters.AddWithValue("@Lastname", lastname);
                        initialiseZookeepercommand.Parameters.AddWithValue("@Workplace", zooname);

                        int newRows = initialiseZookeepercommand.ExecuteNonQuery();

                        if (newRows > 0)
                        {
                            Console.WriteLine($"\nDer Zoowärter {firstname} {lastname} wurde in der DB erstellt!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das war ein falscher Zooname, bitte gib den korrekten Namen ein!");
                    }
                }

                //Gehege abfragen
                Console.WriteLine("\nIn welchem Gehege arbeitet der neue Zoowärter? Bitte gib die Gehegenummer an!");
                Console.WriteLine("Gehegenummer | Gehegeareal");

                string getenclosurenrQuery = @"SELECT EnclosureNr, Area
                    FROM enclosure;";
                MySqlCommand getenclosurenrcommand = new MySqlCommand(getenclosurenrQuery, connection);
                Dictionary<int, string> enclosures = new Dictionary<int, string>();
                using (MySqlDataReader reader = getenclosurenrcommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enclosures.Add(reader.GetInt32("EnclosureNr"), reader.GetString("Area"));
                    }
                }

                foreach (KeyValuePair<int, string> habitat in enclosures)
                {
                    Console.WriteLine($"{habitat.Key,-12} | {habitat.Value}");
                }

                while (true)
                {
                    int enclosurenr = Convert.ToInt32(Console.ReadLine());
                    if (enclosures.ContainsKey(enclosurenr))
                    {
                        string getKeeperIDQuery = @"SELECT KeeperID
                            FROM zookeeper
                            WHERE Firstname = @Firstname AND Lastname = @Lastname;";

                        MySqlCommand getKeeperIDcommand = new MySqlCommand(getKeeperIDQuery, connection);
                        getKeeperIDcommand.Parameters.AddWithValue("@Firstname", firstname);
                        getKeeperIDcommand.Parameters.AddWithValue("@Lastname", lastname);
                        int tempID = 0;

                        using (MySqlDataReader reader = getKeeperIDcommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tempID = reader.GetInt32("KeeperID");
                            }
                        }

                        string insertcarelistQuery = @"INSERT INTO carelist (KeeperID, EnclosureNr)
                            VALUES (@KeeperID, @EnclosureNr);";
                        MySqlCommand insertcarelistcommand = new MySqlCommand(insertcarelistQuery, connection);
                        insertcarelistcommand.Parameters.AddWithValue("@KeeperID", tempID);
                        insertcarelistcommand.Parameters.AddWithValue("@EnclosureNr", enclosurenr);

                        int Newrows = insertcarelistcommand.ExecuteNonQuery();

                        if (Newrows > 0)
                        {
                            Console.WriteLine($"\nDer Zoowärter {firstname} {lastname} wurde dem Gehege {enclosurenr} zugeteilt!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das ist keine gültige Gehegenummer! Bitte gib eine neue ein!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        internal static void CreateAnimal(string animalname, string animalrace, MySqlConnection connection)
        {
            try
            {
                Console.WriteLine($"\nIn welchem Gehege lebt {animalname} - {animalrace}? Bitte gib die Gehegenummer an!");
                Console.WriteLine("Gehegenummer | Gehegeareal");

                string getenclosureQuery = @"SELECT EnclosureNr, Area
                FROM enclosure;";
                MySqlCommand getenclosurecommand = new MySqlCommand(getenclosureQuery, connection);
                Dictionary<int, string> enclosures = new Dictionary<int, string>();
                using (MySqlDataReader reader = getenclosurecommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enclosures.Add(reader.GetInt32("EnclosureNr"), reader.GetString("Area"));
                    }
                }

                foreach (KeyValuePair<int, string> habitat in enclosures)
                {
                    Console.WriteLine($"{habitat.Key,-12} | {habitat.Value}");
                }

                while (true)
                {
                    int enclosurenr = Convert.ToInt32(Console.ReadLine());
                    if (enclosures.ContainsKey(enclosurenr))
                    {
                        string insertAnimalQuery = @"INSERT INTO animal (Animalname, Animalrace, Habitat)
                            VALUES (@Animalname, @Animalrace, @Habitat);";

                        MySqlCommand insertAnimalcommand = new MySqlCommand(insertAnimalQuery, connection);
                        insertAnimalcommand.Parameters.AddWithValue("@Animalname", animalname);
                        insertAnimalcommand.Parameters.AddWithValue("@Animalrace", animalrace);
                        insertAnimalcommand.Parameters.AddWithValue("@Habitat", enclosurenr);
                        int newRows = insertAnimalcommand.ExecuteNonQuery();

                        if (newRows > 0)
                        {
                            Console.WriteLine($"Ein neues Tier ist im Zoo eingezogen!");
                        }

                        //Futter abfragen
                        Console.WriteLine($"\nWas für ein Futter frisst {animalname}? Bitte gib die Inventarnummer an!\nBraucht das Tier kein Futter drücke 0!");
                        Console.WriteLine("Inventar Nr. | Futter");

                        string getFoodNrQuery = @"SELECT InventoryNr, Foodname
                            FROM food;";
                        MySqlCommand getFoodNrcommand = new MySqlCommand(getFoodNrQuery, connection);
                        Dictionary<int, string> foods = new Dictionary<int, string>();
                        using (MySqlDataReader reader = getFoodNrcommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                foods.Add(reader.GetInt32("InventoryNr"), reader.GetString("Foodname"));
                            }
                        }

                        foreach (KeyValuePair<int, string> food in foods)
                        {
                            Console.WriteLine($"{food.Key,-12} | {food.Value}");
                        }

                        while (true)
                        {
                            int foodNr = Convert.ToInt32(Console.ReadLine());
                            if (foodNr == 0)
                            {
                                Console.WriteLine("Es wurde kein Eintrag in der foodlist erstellt!");
                            }
                            if (foods.ContainsKey(foodNr))
                            {
                                Console.WriteLine("Wieviel frisst das Tier von dem Futtermittel?");
                                double amount = Convert.ToDouble(Console.ReadLine());

                                string insertfoodlistQuery = @"INSERT INTO foodlist (Animalname, FoodNr, Amount)
                                    VALUES (@Animalname, @FoodNr, @Amount);";
                                MySqlCommand insertfoodlistcommand = new MySqlCommand(insertfoodlistQuery, connection);
                                insertfoodlistcommand.Parameters.AddWithValue("@Animalname", animalname);
                                insertfoodlistcommand.Parameters.AddWithValue("@FoodNr", foodNr);
                                insertfoodlistcommand.Parameters.AddWithValue("@Amount", amount);

                                int Newrows = insertfoodlistcommand.ExecuteNonQuery();

                                if (Newrows > 0)
                                {
                                    Console.WriteLine($"\nDer Eintrag in der DB wurde erstellt!");
                                    break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Das ist keine gültige Gehegenummer, gib bitte einen neue ein!");
                            }
                        }
                        break;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}