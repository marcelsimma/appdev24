using System;

namespace JonasWehinger.Week06.II
{

public interface IInventar
{
    string GetInventarnr();
    double GetPreis();
}

public class Fotoapparat : IInventar
{
    public string Inventarnr;
    public double Anschaffungswert;

    public Fotoapparat(string inventarnr, double anschaffungswert)
    {
        Inventarnr = inventarnr;
        Anschaffungswert = anschaffungswert;
    }

    public string GetInventarnr()
    {
        return Inventarnr;
    }

    public double GetPreis()
    {
        return Anschaffungswert;
    }
}

public class Sitzkissen : IInventar
{
    public string Inventarnr;
    public double Anschaffungswert;

    public Sitzkissen(string inventarnr, double anschaffungswert)
    {
        Inventarnr = inventarnr;
        Anschaffungswert = anschaffungswert;
    }

    public string GetInventarnr()
    {
        return Inventarnr;
    }

    public double GetPreis()
    {
        return Anschaffungswert;
    }
}

public class Tisch : IInventar
{
    public string Inventarnr;
    public double Anschaffungswert;

    public Tisch(string inventarnr, double anschaffungswert)
    {
        Inventarnr = inventarnr;
        Anschaffungswert = anschaffungswert;
    }

    public string GetInventarnr()
    {
        return Inventarnr;
    }

    public double GetPreis()
    {
        return Anschaffungswert;
    }
}

public class Speicherkarte : IInventar
{
    public string Inventarnr;
    public double Anschaffungswert;

    public Speicherkarte(string inventarnr, double anschaffungswert)
    {
        Inventarnr = inventarnr;
        Anschaffungswert = anschaffungswert;
    }

    public string GetInventarnr()
    {
        return Inventarnr;
    }

    public double GetPreis()
    {
        return Anschaffungswert;
    }
}

public class Objektiv : IInventar
{
    public string Inventarnr;
    public double Anschaffungswert;

    public Objektiv(string inventarnr, double anschaffungswert)
    {
        Inventarnr = inventarnr;
        Anschaffungswert = anschaffungswert;
    }

    public string GetInventarnr()
    {
        return Inventarnr;
    }

    public double GetPreis()
    {
        return Anschaffungswert;
    }
}

public class Inventarliste
{
    public List<IInventar> Inventar = new List<IInventar>();

    public void AddInventar(IInventar item)
    {
        Inventar.Add(item);
    }

    public void AusgabeInventar()
    {
        double gesamtwert = 0;
        int anzahl = Inventar.Count;

        Console.WriteLine("Inventarnummer       Preis");
        Console.WriteLine("--------------------------");

        foreach (IInventar item in Inventar)
        {
            Console.WriteLine(item.GetInventarnr() + "          " + item.GetPreis());
            gesamtwert += item.GetPreis();
        }

        Console.WriteLine();
        Console.WriteLine("Anzahl der Inventargegenstände: " + anzahl);
        Console.WriteLine("Gesamtwert der Inventargegenstände: " + gesamtwert);
    }
}

}