namespace BarbaraMarte.Week09.CountryAndProvince
{
    class Province : InformationPool
    {
        public int Population { get; private set; }

        public Province(int population, string capital, string name) : base(name, capital)
        {
            Population = population;
        }
        public override string ToString()
        {
            return string.Format($"Population: {Population}");
        }
    }
}