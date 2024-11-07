using System;

namespace AlessioGaudio.Week02
{
    class KaufmaennischesRundenn
    {
        public static double RundeKaufmaennisch(double zahl)
        {
            return Math.Round(zahl, 2, MidpointRounding.ToEven);
        }

        public static void Start()
        {
            Console.Write("Bitte eine Zahl eingeben, die gerundet werden soll: ");
            string eingabe = Console.ReadLine();
            
            if (double.TryParse(eingabe, out double zahl))
            {
                double gerundeteZahl = RundeKaufmaennisch(zahl);
                
                Console.WriteLine("Ursprüngliche Zahl: " + zahl);
                Console.WriteLine("Gerundete Zahl: " + gerundeteZahl);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Kommazahl eingeben.");
            }
        }
    }
}
