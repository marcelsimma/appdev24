using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo tiergarten = new Zoo("Tiergarten Feldkirch", "2014");
            Gehege alpenwiese = new Gehege("Alpenwiese Montafon");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium = new Gehege("Terrarium (warm)");

            tiergarten.FuegeGehege(alpenwiese);
            tiergarten.FuegeGehege(ried);
            tiergarten.FuegeGehege(terrarium);
            
            Console.WriteLine(tiergarten);

            Tier kuh = new Tier("Rijska", "Kuh"); 
            Tier storch1 = new Tier("Garmond", "Storch");
            Tier storch2 = new Tier("Hugo", "Storch");
            Tier storch3 = new Tier( "Idaxis", "Storch");
            Tier leer = new Tier("(leer)", "leer"); 

            alpenwiese.FuegeTier(kuh);
            ried.FuegeTier(storch1);
            ried.FuegeTier(storch2);
            ried.FuegeTier(storch3);
            terrarium.FuegeTier(leer);

            Futter heu = new Futter("Heu", "kg", 5);
            Futter heuschrecke = new Futter("Heuschrecke", "kg", 10);
            Futter wasser = new Futter("Wasser", "l", 2);
            Futter fisch = new Futter("Fisch", "kg", 7);

            kuh.FuegeFutter(heu, 2);
            storch1.FuegeFutter(wasser, 50);
            
            storch2.FuegeFutter(heuschrecke, 5);
            storch3.FuegeFutter(fisch, 10);
            storch3.FuegeFutter(heu, 10);

            Pfleger Max = new Pfleger("Max");
            Pfleger Peter = new Pfleger("Peter");
            Pfleger Lisa = new Pfleger("Lisa");
            Pfleger Paul = new Pfleger("Paul");

            alpenwiese.FuegePfleger(Max);
            ried.FuegePfleger(Lisa);
            terrarium.FuegePfleger(Paul);

            tiergarten.PrintGehege();
        }
    }
}
