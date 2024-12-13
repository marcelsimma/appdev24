using System;
using MySql.Data.MySqlClient;


namespace OliverBedogg.Week10
{
    public class ZooMain
    {
        static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=root;
            database=zoo
            ";

        public static void Start()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM zoo";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int zooId = reader.GetInt32(0);
                            string zooName = reader.GetString("Name");

                            Zoo zoo = new Zoo(zooName);
                            zoo.id = zooId;

                            Console.WriteLine("Zoo: " + zooName + " id: " + zooId);
                            zoo.ReadEnclosures(databaseConnectionString);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write("MySQLConnection Error: " + ex.Message);
                }
            }
        }

        /* Muster für Init-Methode */
        public static void Init()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    Zoo zoo = new Zoo("Wildpark Feldkirch");
                    zoo.Create(connection);

                    Enclosure wald = new Enclosure("Wald");
                    wald.Create(connection, zoo.id);

                    Enclosure wiese = new Enclosure("Wiese");
                    wiese.Create(connection, zoo.id);
                }
                catch (MySqlException ex)
                {
                    Console.Write("MySQLConnection Error: " + ex.Message);
                }
            }
        }
    }
}