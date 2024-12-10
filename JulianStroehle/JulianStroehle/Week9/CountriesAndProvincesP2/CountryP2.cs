using System;
namespace JulianStroehle.Week9.CountriesAndProvincesP2
{
    internal class CountryP2
    {
        internal string Name;
        internal string Code;
        internal string Capital;
        internal string Continent;
        internal int Population;
        internal string Organization { get; set; }
        internal List<ProvinceP2> Provinces;
        internal CountryP2(string name, string code, string capital, string continent, string organization)
        {
            Name = name;
            Code = code;
            Capital = capital;
            Continent = continent;
            Organization = organization;
            Provinces = new List<ProvinceP2>();
        }
        internal string ToString(int count)
        {
            Population = 0;
            foreach (ProvinceP2 p in Provinces)
            {
                Population += p.Population;
            }
            return "\n│" + string.Format("{0,-17}", "  " + $"\x1b[1m{count}\x1b[0m") + "│" + string.Format("{0,-43}", "  " + $"\x1b[1m{Name}\x1b[0m") + "│" + string.Format("{0,-35}", "  " + $"\x1b[1m{Capital}\x1b[0m") + "│" + string.Format("{0,-33}", "  " + $"\x1b[1m{Continent}\x1b[0m") + "│" + string.Format("{0,-25}", "  " + $"\x1b[1m{Organization}\x1b[0m") + "│" + string.Format("{0,21}", $"\x1b[1m{Population}\x1b[0m" + "  ") + "│";
        }
        internal void GetProvinces(int count)
        {
            int count2 = 1;
            for (int j = 0; j < Provinces.Count; j++)
            {
                Console.Write(Provinces[j].ToString(count, count2));
            }
        }
    }
}