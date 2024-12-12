using System;

namespace BerkantAkinci.Week09
{
    public class Country
    {
        public string CountryName;
        public string CountryCapital;
        public string Continent;
        public int TotalPopulation;
        public static List<Province> Provinces = new List<Province>();

        public Country(string countryName, string countryCapital, string continent, int totalPopulation)
        {
            CountryName = countryName;
            CountryCapital = countryCapital;
            Continent = continent;
            TotalPopulation = totalPopulation;
            Provinces = new List<Province>();
        }

        public static void AddProvinces(Province province)
        {
            Provinces.Add(province);
        }

        public override string ToString()
        {
            return $"{CountryName}, {CountryCapital}, {Continent}, {TotalPopulation}";
        }
    }
}