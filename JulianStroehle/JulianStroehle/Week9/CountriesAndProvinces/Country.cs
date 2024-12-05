using System;
namespace JulianStroehle.Week9.CountriesAndProvinces
{
    internal class Country
    {
        internal string Name;
        internal string Code;
        internal string Capital;
        internal string Continent;
        internal int Population;
        internal List<Province> Provinces;
        internal Country(string name, string code, string capital, string continent, int population)
        {
            Name = name;
            Code = code;
            Capital = capital;
            Continent = continent;
            Population = population;
            Provinces = new List<Province>();
        }
        internal string ToString(int count)
        {
            return "\n│" + string.Format("{0,16}", $"\x1b[1m{count}\x1b[0m" + "  ") + "│" + string.Format("{0,-38}", "  " + $"\x1b[1m{Name}\x1b[0m") + "│" + string.Format("{0,-30}", "  " + $"\x1b[1m{Capital}\x1b[0m") + "│" + string.Format("{0,-31}", "  " + $"\x1b[1m{Continent}\x1b[0m") + "  │" + string.Format("{0,21}", $"\x1b[1m{Population}\x1b[0m" + "  ") + "│";
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