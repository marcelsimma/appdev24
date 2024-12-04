using System;

namespace SimonJochum.Week09.CountriesAndProvinces
{
    public class Province
    {
        private string _Name {get; set;}
        private string _Capital {get; set;}
        internal int _Population {get; set;}

        public Province (string name, string capital, int population)
        {
            _Name = name;
            _Capital = capital;
            _Population = population;
        }

        public override string ToString()
        {
            return string.Format("---Das Bundesland {0} mit der Hauptstadt {1} hat {2} Einwohner.", _Name, _Capital, _Population);
        }
    }
}