namespace FlorianBaier.Week09
{
    class Province : InformationPool
    {
        public int _Population { get; private set; }

        public Province(int population, string capital, string name) : base(name, capital)
        {
            _Population = population;
        }
        public override string ToString()
        {
            return string.Format("---Das Bundesland {0} mit der Hauptstadt {1} hat {2} Einwohner.", _Name, _Capital, _Population);
        }
    }
}