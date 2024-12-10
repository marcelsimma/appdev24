using System;

namespace MagdalenaMueller.Week09
{
    public class Province
    {
        public string NameOfCountry;
        public string NameOfProvince;
        public string CapitalProvince;
        public int Population;

        public Province(string nameOfCountry, string nameOfProvince,string capitalProvince, int population)
        {
            NameOfCountry = nameOfCountry;
            NameOfProvince = nameOfProvince;
            CapitalProvince = capitalProvince;
            Population = population;
        }

        public override string ToString()
        {
            return $"│ {NameOfCountry,-20} │ {NameOfProvince,-24} │ {CapitalProvince,-24} │ {Population,19:N0} │";
        }
    }
}