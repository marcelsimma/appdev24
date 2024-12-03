using System;

namespace JonasWehinger.Week08
{
    class Medium
{
    public string Titel;
    public string Autor;
    public int Veröffentlichungsjahr;
    public string ISBN;

    public Medium(string titel, string autor, int veröffentlichungsjahr, string isbn)
    {
        Titel = titel;
        Autor = autor;
        Veröffentlichungsjahr = veröffentlichungsjahr;
        ISBN = isbn;
    }

    public void ZeigeDetails()
    {
        Console.WriteLine($"Titel: {Titel}, Autor: {Autor}, Jahr: {Veröffentlichungsjahr}, ISBN: {ISBN}");
    }
}
}

