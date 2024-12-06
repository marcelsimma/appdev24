namespace BarbaraMarte.Week09.CountryAndProvince
{
    class Country : InformationPool
    {
        public List<Province> Provinces;
        public string Continent { get; }

        public Country(string capital, string name, string continent) : base(name, capital)
        {
            Provinces = new List<Province>();
            Continent = continent;
        }
        public override string ToString()
        {
            return string.Format($"Province: {Provinces,15} Continent: {Continent}");
        }
    }
}