
namespace ManuelHartmann.Week06.FotoapparatErweitert
{
    //  Interface kann an alle Klassen gehaengt werden, in welchen man gerne eine Inventarnummber und Preis haben moechte.

    //  Interface Klassenbezeichnungen beginnen immer mit einem grossen I.
    public interface IObjekt
    {
        public string Inventorynumber { get; }
        public double Price { get; set; }
    }
}
