namespace BarbaraMarte.Zoo.Part1
{
    class ZooInfo
    {
        public string _ZooName { get; private set; }
        public DateTime _FoundingYear { get; private set; }
        private List<Enclosure> EnclosureList { get; set; }
        public ZooInfo(string zooName, DateTime foundingYear)
        {
            _ZooName = zooName;
            _FoundingYear = foundingYear;
            EnclosureList = new List<Enclosure>();
        }
        public void AddEnclosure(Enclosure enclosure)
        {
            EnclosureList.Add(enclosure);
        }
        public void DeleteEnclosure(Enclosure enclosure)
        {
            EnclosureList.Remove(enclosure);
        }
        public void StructureInfo()
        {
            System.Console.WriteLine($"├── Zoo {_ZooName}, founded in the Year {_FoundingYear}");
            foreach (var tmp in EnclosureList)
            {
                System.Console.WriteLine($"│    ├── Enclosure: {tmp._EnclosureType}");
            }
        }
    }
}