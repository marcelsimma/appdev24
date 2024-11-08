using System;

namespace AlessioGaudio.Week04
{
    public class Binärr
    {
        public static void Start()
        {
            Console.Write("Gib eine Binärzahl ein: ");
            string binaer = Console.ReadLine();

            if (gueltig(binaer))
            {
                int dezimal = Convert.ToInt32(binaer, 2);
                Console.WriteLine($"Die Dezimalzahl ist: {dezimal}");
            }
            else
            {
                Console.WriteLine("Ungültiges Format. Bitte gib nur eine gültige Binärzahl (nur 0 und 1) ein.");
            }
        }

        public static bool gueltig(string binaer)
        {
            foreach (char c in binaer)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
