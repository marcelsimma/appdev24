using System;

namespace FlorianBaier.Week02{

    public class KaufmaennischesRunden{
        public static void Start(){

        double zahl = 24.13579;
        double gerundet = KaufmaennischesRunden2Stellen(zahl);
        Console.WriteLine($"Gerundete Zahl: {gerundet}");
        }


        static double KaufmaennischesRunden2Stellen(double zahl)
        {
            double berechnung = zahl * 100;
            if (berechnung - (int)berechnung >= 0.5)
            {
                berechnung = (int)berechnung + 1;
            }
            else
            {
                berechnung = (int)berechnung;
            }
            return berechnung / 100;
        }
    }
}