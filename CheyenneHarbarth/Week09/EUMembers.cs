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
            pwd=...;
            database=mondial";
            //dieser String connected uns zum Server, dafür brauchen wir IP-Adresse, Benutzername, Passwort, zu verwendende Datenbank

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))          //using wird wie bei den Dateien/Streamreadern verwendet
            {
                try                                                                                     //try versucht den Code auszführen
                {
                    connection.Open();                                                                  //hier "öffnen" wir die Verbindung zur Datenbank

                    string query = @"                                                                   
                        SELECT ismember.Country, country.Name, country.Population
                        FROM organization
                        JOIN ismember ON organization.Abbreviation = ismember.Organization
                        JOIN country ON ismember.Country = country.Code
                        WHERE organization.Abbreviation = 'EU';";                                       //unser SQL-Code denn wir zur Abfrage nutzen werden

                    MySqlCommand command = new MySqlCommand(query, connection);                         //hier wird die Abfrage erstellt, als neues Objekt, die Parameter sind die Verbindung und der SQL-Code

                    using (MySqlDataReader reader = command.ExecuteReader())                            //um die Daten auszulesen
                    {
                        while (reader.Read())
                        {
                            Console.Write($"{reader.GetString("country"),-5} | {reader.GetString("name"),-15} | {reader.GetInt32("population")} \n");
                            //Console.Write(reader.GetString("name") + " | ");
                            //Console.Write(" | ");
                            //Console.WriteLine(reader.GetInt32("population"));
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
