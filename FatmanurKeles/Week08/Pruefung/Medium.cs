/*using System;

namespace FatmanurKeles.Week08
{

public class Medium
{
    public string Titel { get; set; }
    public string Author { get; set; }
    public int Veroeffentlichungsjahr { get; set; }
    public string ISBN { get; set; }



    public Medium(string titel, string author, int veroeffentlichungsjahr, string isbn)
    {
        Titel = titel;
        Author = author;
        Veroeffentlichungsjahr = veroeffentlichungsjahr
        ISBN = isbn;
    }

    public void Ausgabe()
    {
        Console.WriteLine($"Titel: {Titel}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Veröffentlichungsjahr: {Veroeffentlichungsjahr}");
        Console.WriteLine($"ISBN: {ISBN}");
    }
    
}

public class Buch : Medium
{
    public string Bindung {get; set;}

        public Buch(string titel, string autor, int veroeffentlichungsjahr, string isbn, string bindung )
    {
        Bindung = bindung;
    }

    public override void Ausgabe()
    {
        base.Ausgabe();
        Console.WriteLine($"Bindung: {Bindung}")
    }
}
public class eBook : Medium
{
    public string Dateiformat {get; set;}

    public eBook(string titel, string autor, int veroeffentlichungsjahr, string isbn, string dateiformat )
    {
        Dateiformat = dateiformat;
    }
    
    public override void Ausgabe()
    {
        base.Ausgabe();
        Console.WriteLine($"Dateiformat: {Dateiformat}")
    }
}
} */