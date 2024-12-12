namespace BarbaraMarte.Zoo.Part4;

class Zookeeper
{
    public string _KeeperName { get; set; }
    public List<Enclosure> _EnclosureKeeper { get; set; }

    public Zookeeper(string keeperName)
    {
        _KeeperName = keeperName;
        _EnclosureKeeper = new List<Enclosure>();
    }

    public void AddEnclosureZookeeper(Enclosure enclosure)
    {
        _EnclosureKeeper.Add(enclosure);
    }

    public void PrintKeeper()
    {
        foreach (var keeper in _EnclosureKeeper)
        {
            System.Console.WriteLine(keeper);
        }
    }
}