namespace BarbaraMarte.Week09.CountryAndProvince
{
    class InformationPool
    {
        public string Name { get; private set; }
        public string Capital { get; private set; }

        public InformationPool(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
        public override string ToString()
        {
            return string.Format($"Name: {Name,15} Capital: {Capital}");
        }
    }
}