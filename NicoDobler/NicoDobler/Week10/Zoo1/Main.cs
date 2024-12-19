using System;
namespace NicoDobler.Week10;
 
class Zoo1
{
    public static void los()
    {
        Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);
 
        Gehege gehege1 = new Gehege("Alpenwiese");
        Gehege gehege2 = new Gehege("Aquarium");
        Gehege gehege3 = new Gehege("Terrarium");
 
        zoo.GehegeHinzufuegen(gehege1);
        zoo.GehegeHinzufuegen(gehege2);
        zoo.GehegeHinzufuegen(gehege3);
 
        zoo.StrukturAusgeben();
    }
}