using System;
 
namespace JonasWehinger.A3;
 
public class Gehege
{
    public string Name { get; set; }
    public List<Tier> Tiere { get; set; }
 
    public Gehege(string name)
    {
        Name = name;
        Tiere = new List<Tier>();
    }
}
 