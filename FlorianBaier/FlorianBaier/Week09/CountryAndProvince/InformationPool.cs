namespace FlorianBaier.Week09
{
    class InformationPool
    {
        public string _Name { get; set; }
        public string _Capital { get; set; }

        public InformationPool(string name, string capital)
        {
            _Name = name;
            _Capital = capital;
        }
        public override string ToString()
        {
            return string.Format($"Name: {_Name,15} Capital: {_Capital}");
        }
    }
}