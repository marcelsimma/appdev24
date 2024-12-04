using System;
namespace NicoDobler.Week06{


 
public class Motorrad
{
    public int Kilometerstand { get;  set; }
    public bool IstInBewegung { get;  set; }
 
    public Motorrad(int startKilometerstand)
    {
        Kilometerstand = startKilometerstand;
        IstInBewegung = false;
    }
 
    public void Fahren(int strecke)
    {
        IstInBewegung = true;
        Kilometerstand += strecke;
        Console.WriteLine($"Motorrad fährt {strecke} km.");
        Console.WriteLine($"Motorrad ist in Bewegung: {(IstInBewegung ? "Ja" : "Nein")}");
        IstInBewegung = false;
    }
 
    public void StatusAnzeigen()
    {
        Console.WriteLine($"Kilometerstand: {Kilometerstand} km");
        Console.WriteLine($"Ist in Bewegung: {(IstInBewegung ? "Ja" : "Nein")}");
    }
}
 
public class Motorradd
{
    public static void Start()
    {
        Motorrad motorrad1 = new Motorrad(1000);
        Motorrad motorrad2 = new Motorrad(500);
        motorrad1.StatusAnzeigen();
        motorrad1.Fahren(200);
        motorrad1.StatusAnzeigen();
        Console.WriteLine("---");
 
        motorrad2.StatusAnzeigen();
        motorrad2.Fahren(1000);
        motorrad2.StatusAnzeigen();
        Console.WriteLine("---");
 
       
    }
}
}
 