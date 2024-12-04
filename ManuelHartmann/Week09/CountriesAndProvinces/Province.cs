using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week09.CountriesAndProvinces.Provinces
{
    public class Province
    {
        public string PronviceName { get; private set; }
        public string ProvinceCapital {  get; private set; }
        public int ProvincePopulation { get; private set; }

        public Province(string pronviceName, string provinceCapital, int provincePopulation)
        {
            PronviceName = pronviceName;
            ProvinceCapital = provinceCapital;
            ProvincePopulation = provincePopulation;
        }
        public override string ToString()
        {
            return

            String.Format(
            @" |--- {0,-20} | {1, -15} | {2, -15}", 
            PronviceName, ProvinceCapital, ProvincePopulation);
        }
    }
}
