using System;

namespace JonasWehinger.Week08
{
class Buch : Medium
{
    public string Bindung;

    public Buch(string titel, string autor, int veröffentlichungsjahr, string isbn, string bindung)
        : base(titel, autor, veröffentlichungsjahr, isbn)
    {
        Bindung = bindung;
    }
    public void ZeigeBuchDetails()
    {
        ZeigeDetails();  
        Console.WriteLine($"Bindung: {Bindung}");
    }
}
}
