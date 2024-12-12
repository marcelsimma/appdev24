using System;
using System.Collections.Generic;

public class Gehege2
{
    public string Name;
    private List<Tier2> tiereListe; 

    public Gehege2(string name)
    {
        Name = name;
        tiereListe = new List<Tier2>();
    }

    public void TierHinzufuegen(Tier2 tier)
    {
        tiereListe.Add(tier);
    }

    public void TierEntfernen(Tier2 Name)
    {
        tiereListe.Remove(Name);
    }

    public void StrukturAusgeben()
    {
        Console.WriteLine($"│   ├── Gehege: {Name}");
        if (tiereListe.Count == 0)
        {
            Console.WriteLine($"│       ├── (leer)");
        }
        else
        {
            foreach (var tier in tiereListe)
            {
                Console.WriteLine($"│       ├── {tier.Name}, {tier.Gattung}");
            }
        }
    }
}
