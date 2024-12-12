public class Futter
{
    public string Name { get; set; }
    public string Einheit { get; set; }
    public double PreisProEinheit { get; set; }

    public Futter(string name, string einheit, double preis)
    {
        Name = name;
        Einheit = einheit;
        PreisProEinheit = preis;
    }
}
