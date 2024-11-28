using System;

namespace JonasWehinger.Zoo;

    public class Program2{

public static void PrintZoo()
        {
           Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);

            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium = new Gehege("Terrarium (warm)");

            zoo.GehegeHinzufuegen(alpenwiese);
            zoo.GehegeHinzufuegen(ried);
            zoo.GehegeHinzufuegen(terrarium);

            zoo.StrukturAusgeben();
            Console.WriteLine("------------------");

            zoo.GehegeEntfernen(ried);
            zoo.StrukturAusgeben(); 
        }
    }