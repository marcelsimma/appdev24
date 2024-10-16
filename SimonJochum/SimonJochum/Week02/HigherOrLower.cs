using System;

namespace SimonJochum.Week02
{
    public class HigherOrLower
    {
        public static void Start()
        {
            int luckyNumber;
            Random randomNumber = new Random();
            luckyNumber = randomNumber.Next(0, 100);

            Console.Write("Willkommen zum Zahlen Ratespiel. Es wird zufällig eine Zahl von 0 bis 100 generiert.\nFang mit deiner ersten Eingabe an!\n");

            int input = -1; // Initialisierung

            while (input != luckyNumber)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < luckyNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist größer. Versuch es noch ein mal.");
                    }
                    else if (input > luckyNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner. Versuch es noch ein mal.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                }
            }

            Console.WriteLine("Hurra, du hast die Zahl erraten!");
        }
    }
}