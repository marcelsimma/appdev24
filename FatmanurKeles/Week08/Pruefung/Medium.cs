using System;

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
            Veroeffentlichungsjahr = veroeffentlichungsjahr;
            ISBN = isbn;
        }

        public virtual void Ausgabe()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Autor: {Author}");
            Console.WriteLine($"Veröffentlichungsjahr: {Veroeffentlichungsjahr}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }

}