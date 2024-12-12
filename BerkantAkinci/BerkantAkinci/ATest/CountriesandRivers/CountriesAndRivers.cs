using System;

namespace BerkantAkinci.ATest
{
    public class CountriesAndRivers
    {
        public static string DatabaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=mondial
            ";
        public static void Start()
        {
            Country all = new Country("A");
            all.PrintRiversAndLength();
        }
    }
}