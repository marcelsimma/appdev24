namespace JonasWehinger.Week06.II
{

class Program
{
    static void Start4()
    {
        Inventarliste inventarliste = new Inventarliste();

        inventarliste.AddInventar(new Fotoapparat("ABCD1234", 1000));
        inventarliste.AddInventar(new Sitzkissen("BDESXF12", 23));
        inventarliste.AddInventar(new Tisch("TBL9876", 150));
        inventarliste.AddInventar(new Speicherkarte("SD456789", 15));
        inventarliste.AddInventar(new Objektiv("OBJ12345", 200));

        inventarliste.AusgabeInventar();
    }
}
}