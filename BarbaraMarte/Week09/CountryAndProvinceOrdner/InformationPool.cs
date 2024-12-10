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
/*
SELECT country.code, country.name, country.capital, encompasses.Continent
FROM country, encompasses
WHERE country.code = encompasses.Country
-- AND country.code = 'S'
AND encompasses.Continent LIKE 'Asia%'
*/