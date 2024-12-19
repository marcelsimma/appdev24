namespace BarbaraMarte.Zoo.Part4;

class Zookeeper
{
    public string _KeeperFirstName { get; set; }
    public string _KeeperLastName { get; set; }
    public int _ID;
    public List<Enclosure> _EnclosureList { get; set; }
    public Animal _FavoriteAnimal { get; set; }

    public Zookeeper(int id, string keeperFirstName, string keeperLastName)
    {
        _KeeperLastName = keeperLastName;
        _ID = id;
        _KeeperFirstName = keeperFirstName;
        _EnclosureList = new List<Enclosure>();
    }
    public void AddEnclosureZookeeper(Enclosure enclosure)
    {
        _EnclosureList.Add(enclosure);
    }
    public void PrintKeeper()
    {
        foreach (var keeper in _EnclosureList)
        {
            System.Console.WriteLine(keeper);
        }
    }
}