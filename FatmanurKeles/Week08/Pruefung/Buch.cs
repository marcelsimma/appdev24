using System;

namespace FatmanurKeles.Week08
{
    public class Buch : Medium
    {
        public List<Buch> buecher {get; set;}
        public string Bindung { get; set; }

        public Buch(string titel, string autor, int veroeffentlichungsjahr, string isbn, string bindung) : base( titel,  autor,  veroeffentlichungsjahr,  isbn)
        {
            Bindung = bindung;
        }

        public override string ToString()
        {
            return $"Bindung: {Bindung}";
        }
    }
}