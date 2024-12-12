using System;
using System.Collections.Generic;

public class Zoo3
{
    public string Name { get; set; }
    public int Gruendungsjahr { get; set; }
    private List<Gehege3> GehegeListe;

    public Zoo3(string name, int gruendungsjahr)
    {
        Name = name;
        Gruendungsjahr = gruendungsjahr;
        GehegeListe = new List<Gehege3>();
    }

    public void GehegeHinzufuegen(Gehege3 gehege)
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
        StrukturAusgeben();
        FutterbedarfBerechnen();
    }

    public void StrukturAusgeben()
    {
        Console.Clear();
        Console.WriteLine("════════════════════════════════════════════════════════════");
        Console.WriteLine($"Zoo: {Name}, gegründet {Gruendungsjahr}");
        Console.WriteLine("════════════════════════════════════════════════════════════");
        foreach (var gehege in GehegeListe)
        {
            gehege.StrukturAusgeben();
        }
        Console.WriteLine("════════════════════════════════════════════════════════════");
    }

    public void FutterbedarfBerechnen()
    {
        var gesamtbedarf = new Dictionary<Futter, double>();

        foreach (var gehege in GehegeListe)
        {
            foreach (var bedarf in gehege.FutterbedarfErmitteln())
            {
                if (gesamtbedarf.TryGetValue(bedarf.Key, out double aktuelleMenge))
                {
                    gesamtbedarf[bedarf.Key] = aktuelleMenge + bedarf.Value;
                }
                else
                {
                    gesamtbedarf[bedarf.Key] = bedarf.Value;
                }
            }
        }

        Console.WriteLine("\nFutterbedarf für den Zoo:");
        Console.WriteLine("════════════════════════════════════════════════════════════");
        double gesamtkosten = 0;

        foreach (var eintrag in gesamtbedarf)
        {
            double kosten = eintrag.Key.PreisProEinheit * eintrag.Value;
            gesamtkosten += kosten;

            Console.WriteLine($"{eintrag.Key.Name.PadRight(15)} {eintrag.Value,8:F2} {eintrag.Key.Einheit.PadRight(5)} {kosten,10:F2} €");
        }

        Console.WriteLine("════════════════════════════════════════════════════════════");
        Console.WriteLine($"{"Summe",36} {gesamtkosten,10:F2} €");
        Console.WriteLine("════════════════════════════════════════════════════════════");
    }
}
