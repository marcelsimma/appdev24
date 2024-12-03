using System;

namespace FatmanurKeles.Week08
{
    public class Buch : Medium
    {
        public List<Buch> buecher {get; set;}
        public string Bindung { get; set; }

        public Buch(string titel, string autor, int veroeffentlichungsjahr, string isbn, string bindung)
        {
            Bindung = bindung;
        }

        public override void Ausgabe()
        {
            base.Ausgabe();
            Console.WriteLine($"Bindung: {Bindung}");
        }
    }
}