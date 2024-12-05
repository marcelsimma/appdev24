using System;
using MySqlX.XDevAPI.Common;
using System.Collections.Generic;
using System.Linq;

namespace CheyenneHarbarth.Week09.CountriesAndProvinces
{
    internal class Country
    {
        internal string CountryName { get; }
        internal string CountryCapital { get; }
        internal string Continent { get; }
        internal List<Province> Provinces { get; }

        public Country(string countryname, string countrycapital, string continent)
        {
            CountryName = countryname;
            CountryCapital = countrycapital;
            Continent = continent;
            Provinces = new List<Province>();
        }

        public override string ToString()
        {
            return $"{CountryName,-15} | {CountryCapital,-15} | {Continent,-10}\nBundesländer    | Hauptstadt      | Einwohneranzahl";
        }

        internal int CountPopulation()
        {
            int Result = 0;
            foreach (Province p in Provinces)
            {
                Result += p.Provincepopulation;
            }
            return Result;
        }

        internal void SearchAndAddProvinces(Province province)
        {
            Provinces.Add(province);
        }
    }
}