using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace JonasWehinger.Week09
{

public class CountriesAndRivers
    {
        public static void Start()
        {
            string countryCode = "A";
            Country country = new Country { CountryCode = countryCode };

            List<River> rivers = country.GetRiversByCountryCode(countryCode);

            if (rivers.Count > 0)
            {
                Console.WriteLine($"Flüsse in {countryCode}");
                Console.WriteLine("----------------------------------");

                float totalLength = 0;

                foreach (var river in rivers)
                {
                    Console.WriteLine(river.ToString());
                    totalLength += river.RiverLength;
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Gesamtlänge: {totalLength,8:0.00} km");
            }
            else
            {
                Console.WriteLine($"Keine Flüsse für das Land mit dem Code {countryCode} gefunden.");
            }
        }
    }
}