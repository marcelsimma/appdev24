using System;
 
namespace JonasWehinger.A2;
 
public class Gehege
{
    public string Name { get; set; }
    public List<Tier> Tiere { get; set; }
 
    public Gehege(string name)
    {
        Name = name;
        Tiere = new List<Tier>();
    }
 
    public void AddTier(Tier tier)
    {
        Tiere.Add(tier);
    }
 
    public void RemoveTier(string tierName)
    {
        Tiere.RemoveAll(t => t.Name == tierName);
    }
     public void PrintGehegeStruktur()
    {
        if (Tiere.Count == 0)
        {
            Console.WriteLine($"│       ├── (leer)");
        }
        else
        {
            foreach (var tier in Tiere)
            {
                Console.WriteLine($"│       ├── {tier.Name}, {tier.Rasse}");
            }
        }
    }
    
}