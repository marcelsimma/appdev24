using System;

namespace SimonJochum.Week09.CountriesAndProvinces
{
    public class Country
    {
        private string _Name { get; set; }
        private string _Capital { get; set; }
        private string _Continent { get; set; }
        private int _TotalPopulation { get; set; }
        private static List<Province> _Provinces {get; set;}
        public Country(string name, string capital, string continent)
        {
            _Name = name;
            _Capital = capital;
            _Continent = continent;
            _Provinces = new List<Province>();
        }

        public static void AddProvinces(Province province)
        {
            _Provinces.Add(province);
        }

        public static void GetProvinces()
        {
            foreach (var province in _Provinces)
            {
                Console.WriteLine(province);
            }
        }

        public static void GetPopulation()
        {
            int sum = 0;
            foreach (var province in _Provinces)
            {
                sum += province._Population;
            }
            Console.WriteLine(" und hat " + sum + " Einwohner.");
        }

        public override string ToString()
        {
            return string.Format("Das Land {0} mit der Hauptstadt {1} liegt in {2}", _Name, _Capital, _Continent);
        }
    }
}