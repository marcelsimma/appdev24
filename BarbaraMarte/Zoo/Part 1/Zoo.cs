namespace BarbaraMarte.Zoo.Part1
{
    class ZooInfo
    {
        public string _ZooName { get; private set; }
        public DateTime _FoundingYear { get; private set; }
        public ZooInfo(string zooName, DateTime foundingYear)
        {
            _ZooName = zooName;
            _FoundingYear = foundingYear;
        }
        public override string ToString()
        {
            return string.Format($"The Zoo {_ZooName} was found in the year {_FoundingYear}");
        }
    }
}