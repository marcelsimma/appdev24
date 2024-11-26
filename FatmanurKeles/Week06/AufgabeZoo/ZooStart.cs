using FatmanurKeles.Week06.ZOO;

namespace FatmanurKeles.Week06.ZOO
{
    public class ZooStart
    {
        public static void Launch()
        {
            Gehege alpenwiese = new Gehege("Alpenwiese Montafon");
            Gehege ried = new Gehege("Ried");
            Gehege terrarium = new Gehege("Terrarium (warm)");

            Console.WriteLine(alpenwiese.ToString());
        }
    }
}

