using FatmanurKeles.Week06.AufgabeZoo;
using FatmanurKeles.Week06.ZOO;

namespace FatmanurKeles.Week06.ZOO
{
    public class ZooStart
    {
        public static void Launch()
        {
            List<Gehege> alleGehegen = new List<Gehege>();
            Gehege alpenwiese = new Gehege("Alpenwiese Montafon");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium = new Gehege("Terrarium (warm)");

            alleGehegen.Add(alpenwiese);
            alleGehegen.Add(ried);
            alleGehegen.Add(terrarium);
            Zoo beschreibung = new Zoo("Tiergarten Feldkirch", "2018", ried, "Gisingen");
            
            
            foreach (Gehege gehegen in alleGehegen)
            {
                Console.WriteLine(gehegen.ToString());
            }
            Console.WriteLine(new string('-', 32));
        }
    }
}
