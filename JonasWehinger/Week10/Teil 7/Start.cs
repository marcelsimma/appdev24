using System;
using MySql.Data.MySqlClient;

namespace JonasWehinger.JaMan
{
    class StartZoo
    {
        public static void Start9()
        {
            string connectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Tuma4016!;
            database=zoo";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

               
                Zoo zooId =new Zoo(connection, "LemonHase", 1999);
                Console.WriteLine($"Zoo ID: {zooId}");

               
                Enclosure enclosureId = new Enclosure (connection, "Hohes C");
                Console.WriteLine($"Enclosure ID: {enclosureId}");

                
                Zookeeper zookeeperId = new Zookeeper (connection, " Kenan(Plü)");
                Console.WriteLine($"Zookeeper ID: {zookeeperId}");

                
                Tier animalId = new Tier(connection, "Qualle", "Quentin");
                Console.WriteLine($"Animal ID: {animalId}");

                
                new Food (connection, "Berliner Luft", "L", 10, "5");
            }
        }
    }
}
