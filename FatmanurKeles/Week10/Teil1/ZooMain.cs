using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class ZooMain
    {
        public static void Start()
        {
            List<Gehege> alleGehegen = new List<Gehege>();
            Gehege alpenwiese = new Gehege("Alpenwiese Montafon");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium = new Gehege("Terrarium (warm)");

            alleGehegen.Add(alpenwiese);
            alleGehegen.Add(ried);
            alleGehegen.Add(terrarium);
            Zoo beschreibung = new Zoo("Tiergarten Feldkirch", "2014");
            
        
            foreach (Gehege GehegeListe in alleGehegen)
            {
                Console.WriteLine(GehegeListe.ToString());
            }
            Console.WriteLine(new string('-', 32));
        }
    }
}