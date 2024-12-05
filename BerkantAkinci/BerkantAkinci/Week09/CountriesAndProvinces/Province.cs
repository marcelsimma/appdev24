using System;

namespace BerkantAkinci.Week09
{
    public class Province
    {
        public string ProvinceName;
        public string ProvinceCapital;
        public int CityPopulation;

        public Province(string provinceName, string provinceCapital, int cityPopulation)
        {
            ProvinceName = provinceName;
            ProvinceCapital = provinceCapital;
            CityPopulation = cityPopulation;
        }

        public override string ToString()
        {
            return $"- {ProvinceName}, {ProvinceCapital}, {CityPopulation}";
        }
    }
}