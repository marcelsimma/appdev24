using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week09.CountriesAndProvinces.Country
{
    public class Country
    {
        public string CountryName { get; private set; }
        public string Continent { get; private set; }
        public string CountryCapital { get; private set; }
        public int CountryPopulation { get; private set; }
        public List<Province> Provinces { get; }    // Wird definiert, dass die Liste nur ausgelesen werden kann, aber nicht beschrieben.

        public Country(string name, string continent, string capital, int population)
        {
            CountryName = name;
            Continent = continent;
            CountryCapital = capital;
            CountryPopulation = population;
            Provinces = new List<Province>(); // Hierbei wird nach jedem Aufruf des Konstruktors eine neue Liste zum Objekt erstellt.
        }
        public override string ToString()
        {
            return

            String.Format(
            @"|- {0}, {1}, {2}, {3}", 
            CountryName, Continent, CountryCapital, CountryPopulation, Provinces.ToString());
            /* 'Alles in 'Teilnehmer.ToString()' definiert wird in dieser Ausgabe mitausgegeben.
               Somit muss lediglich eine ToString()-Methode aufgerufen werden und man kann die Teilnehmer mit
               den Abwesenheiten in Verbindung setzten.                 */
        }
    }
}
