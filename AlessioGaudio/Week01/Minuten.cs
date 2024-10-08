using System;

namespace AlessioGaudio.Week01
{
    class Minuten
    {
        public static void Start()
        {
            ConvertMinutesToHours(); 
        }

        public static void ConvertMinutesToHours()
        {
            Console.WriteLine("Bitte geben Sie die Minuten ein:");
            if (!double.TryParse(Console.ReadLine(), out double minutes) || minutes < 0)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige positive Zahl ein.");
                return;
            }
            Console.WriteLine($"Das sind {Math.Round(minutes / 60, 2)} Stunden!");
        }
    }
}
