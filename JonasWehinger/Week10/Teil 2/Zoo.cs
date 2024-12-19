using System;
using System.Collections.Generic;
namespace JonasWehinger.A2;
 
public class ZooClass
{
    public string Name { get; set; }
    public int Gruendungsjahr { get; set; }
    public List<Gehege> GehegeListe { get; set; }
 
    public ZooClass(string name, int gruendungsjahr)
    {
        Name = name;
        Gruendungsjahr = gruendungsjahr;
        GehegeListe = new List<Gehege>();
    }
 
    public void AddGehege(Gehege gehege)
    {
        GehegeListe.Add(gehege);
    }
 
    public void RemoveGehege(string gehegeName)
    {
        for (int i = 0; i < GehegeListe.Count; i++)
    {
        if (GehegeListe[i].Name == gehegeName)
        {
            GehegeListe.RemoveAt(i);
            break;
        }
    }
    }
 
    public void PrintZooStruktur()
    {
        Console.WriteLine($"├── Zoo: {Name}, gegründet {Gruendungsjahr}");
        foreach (var gehege in GehegeListe)
        {
            Console.WriteLine($"│   ├── Gehege: {gehege.Name}");
            gehege.PrintGehegeStruktur();
        }
    }
   
}