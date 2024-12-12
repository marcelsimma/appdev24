namespace BarbaraMarte.Week09.CountryAndProvince
{
    class CountryOld : InformationPool
    {
        public List<Province> Provinces { get; set; }
        public string Continent { get; }

        public CountryOld(string name, string capital, string continent) : base(name, capital)
        {
            Provinces = new List<Province>();
            Continent = continent;

        }
        public override string ToString()
        {
            return string.Format($"Province: {Provinces,15} Continent: {Continent}");
        }
    }

    class Country
    {
        private string Name { get; set; }
        private string Capital { get; set; }
        private string Continent { get; set; }

        private static List<Province> Provinces { get; set; }
        public Country(string name, string capital, string continent)
        {
            Name = name;
            Capital = capital;
            Continent = continent;
            Provinces = new List<Province>();
        }

        public static void GetPopulation()
        {
            int sum = 0;
            foreach (var province in Provinces)
            {
                sum += province.Population;
            }
            System.Console.WriteLine($"Population: {sum,-10}\n");
        }
        public static void AddProvinces(Province province)
        {
            Provinces.Add(province);
        }
        public static void GetProvinces()
        {
            foreach (var province in Provinces)
            {
                System.Console.WriteLine(province);
            }
        }
        public override string ToString()
        {
            return string.Format($"\nCountry: {Name}\nCapital: {Capital}\nContinent: {Continent}");
        }

    }
}