using System;

namespace MagdalenaMueller.Week09
{
    public class Country
    {
        public string Name;
        public string Capital;
        public string Continent;
        public int Population;
        public List<Province> ProvicesOfCountry;

        public Country(string name, string capital,string continent, int population, List<Province> provincesOfCountry)
        {
            Name = name;
            Capital = capital;
            Continent = continent;
            Population = population;
            ProvicesOfCountry = provincesOfCountry;
        }

        public override string ToString()
        {
            return $"│ {Name,-20} │ {Capital,-24} │ {Continent,-24} │ {Population,19:N0} │";
        }
    }
}