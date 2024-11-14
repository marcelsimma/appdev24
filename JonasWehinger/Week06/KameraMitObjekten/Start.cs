
using System;

namespace JonasWehinger.Week06.KMO
{

    

    public class Start
    {
        public static void SelfStart()
        {
            
            Speicherkarte s1 = new Speicherkarte("ABC 496GB", "ABCDEFG123", 496);
            Fotoapparat f1 = new Fotoapparat("Samsung Megapixel", "KJSWOS7346", s1);

            
            Console.WriteLine("Fotoapparat Seriennummer:" + f1.seriennummer);
            Console.WriteLine("----------------------");
            Console.WriteLine("Speicherplatz der Speicherkarte:" + f1.Speicher.Speicherplatz + " GB");
            
        }
    }
}