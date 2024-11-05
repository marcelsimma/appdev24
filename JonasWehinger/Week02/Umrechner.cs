using System;

namespace JonasWehinger.Week02
{
    public class Umrechner
    {
        public static void Start2()
        {
        Rechner();
        
        }

    static void Rechner()
    {
        double x = 0.0;
        while (x <= 100)
        {
            x = x + 0.1;
            Console.WriteLine(x);
            Console.WriteLine("");
            
        }
    }
}
}