namespace BarbaraMarte.Zoo.Part1
{
    class Enclosure
    {
        public string _EnclosureType { get; set; }
        public int _ID { get; set; }

        public Enclosure(string enclosureType)
        {
            _EnclosureType = enclosureType;
        }

    }
}