namespace BarbaraMarte.Zoo.Part1
{
    class Enclosure
    {
        public string _EnclosureType { get; private set; }

        public Enclosure(string enclosureType)
        {
            _EnclosureType = enclosureType;
        }
        public override string ToString()
        {
            return string.Format($"Enclosure Type {_EnclosureType}");
        }
    }
}