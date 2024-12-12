using System;

namespace SimonJochum.Week09.CountriesAndProvincesAsync
{
    public class Country2
    {
        private string _Name { get; set; }
        private string _Capital { get; set; }
        private string _Continent { get; set; }
        private int _TotalPopulation { get; set; }
        private List<Province2> _Provinces {get; set;}
        public Country2(string name, string capital, string continent)
        {
            _Name = name;
            _Capital = capital;
            _Continent = continent;
            _Provinces = new List<Province2>();
        }

        public void AddProvinces(Province2 province)
        {
            _Provinces.Add(province);
        }

        public void GetProvinces()
        {
            foreach (var province in _Provinces)
            {
                Console.WriteLine(province);
            }
        }

        public void GetPopulation()
        {
            foreach (var province in _Provinces)
            {
                _TotalPopulation += province._Population;
            }
            Console.WriteLine(" und hat " + _TotalPopulation + " Einwohner.");
        }

        public override string ToString()
        {
            return string.Format("Das Land {0} mit der Hauptstadt {1} liegt in {2}", _Name, _Capital, _Continent);
        }
    }
}