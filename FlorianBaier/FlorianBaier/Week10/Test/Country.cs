using System.IO;

namespace FlorianBaier.Week10.Test
{
    public class Country
    {
        public string CountryCode { get; set; }

        public Country(string countryCode)
        {
            CountryCode = countryCode;
        }
    }
}