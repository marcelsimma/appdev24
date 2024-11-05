using System;
using JulianStroehle.Week1;
namespace JulianStroehle.Week2
{
    public class KaufmaennischRunden
    {
        public static void Start()
        {
            Console.WriteLine("Zahl zum Runden eingeben:");
            double Zahl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nachkommastellen?");
            int kommastellen = Convert.ToInt32(Console.ReadLine());
            int komma = 10;
            for (int i = 0; i < kommastellen; i++)
            {
                komma *= 10;
            }
            long grossZahl = Convert.ToInt32(Zahl*komma);
            if (grossZahl%10 > 4)
            {
                grossZahl += 10;
            }
            grossZahl /= 10;
            Zahl = Convert.ToDouble(grossZahl);
            Zahl /= komma/10;
            Console.WriteLine("Gerundete Zahl: " + Zahl);
        }
    }
}