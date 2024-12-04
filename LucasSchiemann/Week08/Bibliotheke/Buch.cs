using System;       

namespace LucasSchiemann.Week08.Bibliotheke;

public class Buch : Medium
{
    public string Bindung { get; set; } 

    public Buch(string titel, string autor, int veröffentlichungsjahr, string isbn, string bindung) : base(titel, autor, releaseDate, isbn)
    {
        Bindung = bindung;
    }

    public override void ShowBook ()
    {
        base.ShowBook();
        Console.WriteLine($"Bindung: {Bindung}");
    }
}
