using System;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week10.Test
{
    public class Country
    {

        internal string CountryCode { get; }

        internal List<River> Rivers { get; }

        public Country(string countrycode)
        {
            CountryCode = countrycode;
            Rivers = new List<River>();
        }

        internal void SearchAndAddRivers(River river)
        {
            Rivers.Add(river);
        }
        internal string CalculateRiverSum()
        {
            double SumofLengths = 0;
            foreach (River river in Rivers)
            {
                SumofLengths += river.Riverlength;
            }
            return $"Gesamtlänge         {SumofLengths,7:F2} km";
        }
    }
}