using System;

namespace AlessioGaudio.Week02
{
    class Converterr
    {
        public static void Start()
        {
            Console.WriteLine("Willkommen zum Hexadezimal-Dezimal-Umrechner!");
            Console.WriteLine("1: Hexadezimal zu Dezimal");
            Console.WriteLine("2: Dezimal zu Hexadezimal");
            Console.Write("Wähle eine Option (1 oder 2): ");
            
            string option = Console.ReadLine();

            if (option == "1")
            {
                // Hexadezimal zu Dezimal
                Console.Write("Bitte gib eine Hexadezimalzahl ein: ");
                string hexInput = Console.ReadLine();

                try
                {
                    int decimalValue = Convert.ToInt32(hexInput, 16);
                    Console.WriteLine($"Die Dezimalzahl für Hexadezimal {hexInput} lautet: {decimalValue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine gültige Hexadezimalzahl ein.");
                }
            }
            else if (option == "2")
            {
                // Dezimal zu Hexadezimal
                Console.Write("Bitte gib eine Dezimalzahl ein: ");
                string decInput = Console.ReadLine();

                try
                {
                    int decimalValue = Convert.ToInt32(decInput);
                    string hexValue = decimalValue.ToString("X");
                    Console.WriteLine($"Die Hexadezimalzahl für Dezimal {decimalValue} lautet: {hexValue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine gültige Dezimalzahl ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl. Bitte wähle 1 oder 2.");
            }
        }
    }
}
