using System;
namespace JulianStroehle.Week2
{
    public class TeilenA
    {
        public static void Teilen()
        {
            for (int x = 0; x <= 20; x++)
            {
                Console.WriteLine(x);
                Console.WriteLine(x + " / 5 = " + x/5);
                Console.WriteLine(x + " / 5.0 = " + x/5.0);
            }
        }
    }
}