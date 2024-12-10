/*namespace FlorianBaier.Week09
{

    class Country : InformationPool
    {
        public List<Province> _Provinces;
        private string _Continent { get; set; }

        public Country(string capital, string name, string continent) : base(name, capital)
        {
            _Provinces = new List<Province>();
            _Continent = continent;
        }
        public override string ToString()
        {
            return string.Format("Das Land {0} mit der Hauptstadt {1} liegt in {2}", _Name, _Capital, _Continent);
        }
        public int GetTotalPopulation()
        {
            int totalPopulation = 0;
            foreach (var province in _Provinces)
            {
                totalPopulation += province._Population;
            }
            return totalPopulation;
        }
        
        public static void AddProvinces(Province Provinces)
        {
            Provinces.Add(province);
        }

        public static void GetProvinces()
        {
            foreach (var province in Provinces)
            {
                Console.WriteLine(province);
            }
        }

    }
}
*/