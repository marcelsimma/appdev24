using System;
namespace JulianStroehle.Week9.CountriesAndProvincesP2
{
    internal class ProvinceP2
    {
        internal string Name;
        internal string Capital;
        internal int Population;
        internal string Country;
        internal string Continent;
        internal string Organization { get; set; }
        internal ProvinceP2(string name, string capital, int population, string country, string continent)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Country = country;
            Continent = continent;
        }
        internal string ToString(int count, int count2)
        {
            return "\n│" + string.Format("{0,-9}", "  " + count + "." + count2) + "│" + string.Format("{0,-35}", "  " + Name) + "│" + string.Format("{0,-27}", "  " + Capital) + "│" + string.Format("{0,-25}", "  " + Continent) + "│" + string.Format("{0,-17}", "  " + Organization) + "│" + string.Format("{0,13}", Population + "  ") + "│";
        }
    }
}