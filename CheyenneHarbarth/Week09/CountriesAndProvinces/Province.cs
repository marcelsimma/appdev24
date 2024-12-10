using System;

namespace CheyenneHarbarth.Week09.CountriesAndProvinces
{
    public class Province
    {
        internal string Provincename { get; }
        internal string Provincecapital { get; }
        internal int Provincepopulation { get; }

        public Province(string provincename, string provincecapital, int provincepopulation)
        {
            Provincename = provincename;
            Provincecapital = provincecapital;
            Provincepopulation = provincepopulation;
        }
        public override string ToString()
        {
            return $"{Provincename,-25} | {Provincecapital,-15} | {Provincepopulation,13}";
        }
    }
}