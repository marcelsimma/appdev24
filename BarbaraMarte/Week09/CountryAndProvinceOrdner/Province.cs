namespace BarbaraMarte.Week09.CountryAndProvince
{
    class ProvinceOld : InformationPool
    {
        public int Population1 { get; private set; }

        public ProvinceOld(int population1, string name, string capital) : base(name, capital)
        {
            Population1 = population1;
        }
        public override string ToString()
        {
            return string.Format($"Population: {Population1}");
        }
    }

    class Province
    {
        private string Name1 { get; set; }
        private string Capital { get; set; }
        internal int Population { get; set; }
        public Province(string name1, string capital, int population)
        {
            Name1 = name1;
            Capital = capital;
            Population = population;
        }
        public override string ToString()
        {
            return string.Format($"Province short name: {Name1,-15} | Province Capital: {Capital,-15} | Population: {Population,9}");
        }
    }
}