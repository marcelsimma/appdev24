using System;
using System.Collections.Generic;

public class Zoo2
{
    public string Name;
    public int Gruendungsjahr;
    private List<Gehege2> gehegeListe;

    public Zoo2(string name, int gruendungsjahr)
    {
        Name = name;
        Gruendungsjahr = gruendungsjahr;
        gehegeListe = new List<Gehege2>();
    }

    public void GehegeHinzufuegen(Gehege2 gehege)
    {
        gehegeListe.Add(gehege);
    }

    public void RemoveGehege(string gehegeName)
    {
        for (int i = 0; i < gehegeListe.Count; i++)
        {
            if (gehegeListe[i].Name == gehegeName)
            {
                gehegeListe.RemoveAt(i);
                break;
            }
        }
    }

    public void StrukturAusgeben()
    {
        Console.WriteLine($"├── Zoo: {Name}, gegruendet {Gruendungsjahr}");
        foreach (var gehege in gehegeListe)
        {
            gehege.StrukturAusgeben();
        }
    }
}
