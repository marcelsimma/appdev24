using System;

namespace AlessioGaudio.Week04
{
    public class dezimall
    {
        public static void Start()
        {
            int dezimal;
            bool gültig;

            do       
            {
                Console.WriteLine("Gib eine Dezimalzahl ein: ");
                gültig = int.TryParse(Console.ReadLine(), out dezimal);

                if (!gültig)
                {
                    Console.WriteLine("Falsche Eingabe");
                }

            } while (!gültig);

           
            string binaer = Convert.ToString(dezimal, 2);
            Console.WriteLine($"Die Binärzahl ist: {binaer}");
        }
    }
}
