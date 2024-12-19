using System;
 
namespace JonasWehinger.A2;
 
public class Tier
{
    public string Name { get; set; }
    public string Rasse { get; set; }
 
    public Tier(string name, string rasse)
    {
        Name = name;
        Rasse = rasse;
    }
}