using System;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week09
{
    public class EUMembers
    {
        public static void Start()
        {
            //Erstelle ein C# Programm, dass auf unsere Mondial Datenbank zugreift. Aus der Datenbank sollen alle Mitgliedsstaaten der EU mit Länderkürzel, Namen und Einwohnerzahl abgefragt werden. Gib die abgefragten Informationen auf der Konsole aus. 
            string databaseConnectionString = @"        
            server=127.0.0.1;
            uid=root;
            pwd=QRUP369_purq;
            database=mondial";
            //dieser String connected uns zum Server, dafür brauchen wir IP-Adresse, Benutzername, Passwort, zu verwendende Datenbank

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))          //using wird wie bei den Dateien/Streamreadern verwendet
            {
                try                                                                                     //try versucht den Code auszführen
                {
                    connection.Open();                                                                  //hier "öffnen" wir die Verbindung zur Datenbank

                    string query = @"                                                                   
                        SELECT ismember.Country, country.Name, country.Population
                        FROM ismember
                        JOIN country ON ismember.Country = country.Code
                        WHERE ismember.Organization = 'EU';";                                       //unser SQL-Code denn wir zur Abfrage nutzen werden

                    MySqlCommand command = new MySqlCommand(query, connection);                         //hier wird die Abfrage erstellt, als neues Objekt, die Parameter sind die Verbindung und der SQL-Code

                    using (MySqlDataReader reader = command.ExecuteReader())                            //um die Daten auszulesen
                    {
                        int counter = 1;
                        while (reader.Read())
                        {
                            Console.Write($"{counter,3}. | {reader.GetString("country"),-5} | {reader.GetString("name"),-15} | {reader.GetInt32("population"),12} \n");
                            counter++;
                        }
                    }
                }
                catch (MySqlException ex)                                                               //catch fängt die Fehler auf und wir können sie mit Console.Write ausgeben, dieser Block bleibt eigentlich immer gleich
                {
                    Console.Write(ex.Message);
                }
            }




        }
    }
}
