using System;
namespace JulianStroehle.Week9.CountriesAndProvinces
{
    internal class Province
    {
        internal string Name;
        internal string Capital;
        internal int Population;
        internal string Country;
        internal string Continent;
        internal Province(string name, string capital, int population, string country, string continent)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Country = country;
            Continent = continent;
        }
        internal string ToString(int count, int count2)
        {
            return "\n│" + string.Format("{0,8}", count + "." + count2 + "  ") + "│" + string.Format("{0,-30}", "  " + Name) + "│" + string.Format("{0,-22}", "  " + Capital) + "│" + string.Format("{0,-23}", "  " + Continent) + "  │" + string.Format("{0,13}", Population + "  ") + "│";
        }
    }
}