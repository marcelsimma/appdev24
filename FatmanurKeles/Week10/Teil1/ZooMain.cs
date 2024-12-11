using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class ZooMain
    {
        public static void Start()
        {
            //List<Gehege> alleGehegen = new List<Gehege>();
            Zoo tiergarten = new Zoo("Tiergarten Feldkirch", "2014");
            Gehege alpenwiese = new Gehege(" Alpenwiese Montafon");
            Gehege ried = new Gehege(" Ried");
            Gehege terrarium = new Gehege(" Terrarium (warm)");

            tiergarten.FuegeGehege(alpenwiese);
            tiergarten.FuegeGehege(ried);
            tiergarten.FuegeGehege(terrarium);
            
            Console.WriteLine(tiergarten);

            tiergarten.PrintZoo();
            
        }
    }
}