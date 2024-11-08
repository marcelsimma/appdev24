using System;

namespace AlessioGaudio.Week01
{
    class Program
    {
        public static void Start()
        {
            Console.WriteLine("Gib die erste Zahl ein:");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gib die zweite Zahl ein:");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            double summe = zahl1 + zahl2;
            double differenz = zahl1 - zahl2;
            double produkt = zahl1 * zahl2;
            double quotient = zahl1 / zahl2;

            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Differenz: " + differenz);
            Console.WriteLine("Produkt: " + produkt);
            Console.WriteLine("Quotient: " + quotient);
        }
    }
}
