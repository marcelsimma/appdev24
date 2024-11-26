using System;       

namespace LucasSchiemann.Week08.Bibliotheke;

public class eBook : Medium
{
    public string Dateiformat { get; set; } 

    public eBook(string titel, string autor, int veröffentlichungsjahr, string isbn, string dateiformat): base(titel, autor, releaseDate, isbn)
    {
        Dateiformat = dateiformat;
    }

    public override void ShowBook()
    { 
        base.ShowBook();
        Console.WriteLine($"Ist Buch Online: {Dateiformat}");
    }
}
