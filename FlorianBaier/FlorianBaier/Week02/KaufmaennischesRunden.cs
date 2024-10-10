using System;

namespace FlorianBaier.Week02{

    public class KaufmaennischesRunden{
        public static void Start(){

        double zahl = 43.13579;
        double gerundet = KaufmaennischRunden(zahl);
        Console.WriteLine($"Gerundete Zahl: {gerundet}");
        }


        public static double KaufmaennischRunden(double value)
    {
        return Math.Round(value, 2, MidpointRounding.ToEven);
    }
    }
}