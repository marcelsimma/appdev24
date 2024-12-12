using System;

namespace JonasWehinger.A1
{
    public class Zoo
    {
    public string Name { get;  set; }
    public int Gruendungsjahr { get;     set; }
    public List<Gehege> GehegeListe;
 
    public Zoo(string name, int gruendungsjahr)
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
        if (GehegeListe[i].name == gehegeName)
        {
            GehegeListe.RemoveAt(i);
            break;
        }
    }
    }
    public void GehegeStrucktur()
    {
        System.Console.WriteLine($"|--Zoo:{Name} ,gegründet:{Gruendungsjahr}");
        foreach(Gehege Gehege in GehegeListe)
        {
            System.Console.WriteLine($"|   |--Gehege: {Gehege.name}");
 
        }
 
    }
   
}
}