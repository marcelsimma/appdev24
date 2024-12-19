using System;

namespace JonasWehinger.A2;

public class StartOfTheZoo
{

    public static void StarterZoo()
    {

        ZooClass zoo = new ZooClass("Tiergarten Dornbirn", 2022);
 
       
        Gehege alpenwiese = new Gehege("Alpenwiese");
        Gehege ried = new Gehege("Ried");
        Gehege terrarium = new Gehege("Terrarium (warm)");
 
       
        alpenwiese.AddTier(new Tier("Rijska", "Kuh"));
        ried.AddTier(new Tier("Garmond", "Storh"));
        ried.AddTier(new Tier("Hugo", "Storh"));
        ried.AddTier(new Tier("Idaxis", "Storh"));
 
        zoo.AddGehege(alpenwiese);
        zoo.AddGehege(ried);
        zoo.AddGehege(terrarium);
 
       
        zoo.PrintZooStruktur();
    }
}
