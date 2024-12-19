using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace JonasWehinger.Week09
{
    public class River
    {
        public string RiverName { get; set; }
        public float RiverLength { get; set; }

        public River(string riverName, float riverLength)
        {
            RiverName = riverName;
            RiverLength = riverLength;
        }

        public override string ToString()
        {
            return $"{RiverName,-25} {RiverLength,5:0.00} km";
        }
    }

    public class Country
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public List<River> GetRiversByCountryCode(string countryCode)
        {
            var rivers = new List<River>();

            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Tuma4016!;
            database=mondial
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = @"SELECT DISTINCT R.name AS RiverName, R.length AS Length
                                     FROM River R
                                     JOIN geo_river GR ON R.name = GR.river
                                     JOIN Country C ON GR.country = C.code
                                     WHERE C.code = @countryCode
                                     ORDER BY R.length DESC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@countryCode", countryCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string riverName = reader.GetString("RiverName");
                            float riverLength = reader.GetFloat("Length");

                            rivers.Add(new River(riverName, riverLength));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler beim Abrufen der Flüsse: {ex.Message}");
                }
            }

            return rivers;
        }
    }

    
    }

