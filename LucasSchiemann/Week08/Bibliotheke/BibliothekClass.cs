using System;       

namespace LucasSchiemann.Week08.Bibliotheke;

using System;
using System.Collections.Generic;
using System.Linq;

public class Bibliothek
{
    private List<Medium> Medien { get; set; }

    public Bibliothek()
    {
        Medien = new List<Medium>();
    }

    public void Hinzufügen(Medium medium)
    {
        Medien.Add(medium);
    }

    public void Entfernen(string isbn)
    {
        for (int i = 0; i < Medien.Count; i++)
        {
            if (Medien[i].ISBN == isbn)
            {
                Medien.RemoveAt(i);
                Console.WriteLine($"'{Medien[i]}' wurde entfernt.");
                return;
            }
        }
/*
        var mediumFirstAcouranceOfISBN = Medien. 
        if (medium != null)
        {
            Medien.Remove(medium);
            Console.WriteLine($"Medium mit ISBN {isbn} wurde entfernt.");
        }
        else
        {
            Console.WriteLine($"Medium mit ISBN {isbn} nicht gefunden.");
        }
        */
    }

    public Medium Suchen(Medium suchbegriff)
    {
        foreach(var medien in Medien)
        {
        if(Medien.Contains(suchbegriff))
        {
            System.Console.WriteLine("Ist Enthalten"); 
            return medien;
            
        }
        }
        return null;
    }

    public void ShowBibliotheke()
    {
        foreach (var medium in Medien)
        {
            medium.ShowBook();
            Console.WriteLine();
        }
    }
}
