namespace BarbaraMarte.Zoo.Part2
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
            int id = EnclosureList.Count + 1;
            enclosure._ID = id;
            EnclosureList.Add(enclosure);
        }
        public void DeleteEnclosure(Enclosure enclosure)
        {
            EnclosureList.Remove(enclosure);
        }

        public void StructureInfo()
        {
            System.Console.WriteLine($"├── Zoo {_ZooName}, founded in the Year {_FoundingYear}");
            foreach (var enclosure in EnclosureList)
            {
                System.Console.WriteLine($"│    ├── Enclosure: {enclosure._EnclosureType}");
                foreach (var animal in enclosure.AnimalList)
                {
                    System.Console.WriteLine($"│         ├── Animal Name: {animal._AnimalName}, Species: {animal._AnimalSpecies}");
                }
            }
        }
    }
}