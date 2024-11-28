using System;

namespace JonasWehinger.Week08
{



class eBook : Medium
{
    public string Dateiformat;

    public eBook(string titel, string autor, int veröffentlichungsjahr, string isbn, string dateiformat)
        : base(titel, autor, veröffentlichungsjahr, isbn)
    {
        Dateiformat = dateiformat;
    }
     public void ZeigeEBookDetails()
    {
        ZeigeDetails(); 
        Console.WriteLine($"Dateiformat: {Dateiformat}");
    }
}
}
