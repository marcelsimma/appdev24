using System;

namespace SimonJochum.Week02
{
    public class ConsoleInput
    {
        public static void Start()
        {
            //ReadNextInt();
            //ReadNextDouble();
            ReadNextChar();
        }

        public static int ReadNextInt()
        {
            int fromInput;
            string input;

            do
            {
                input = Console.ReadLine();

                // Überprüfen, ob die Eingabe eine gültige Zahl ist
                if (int.TryParse(input, out fromInput))
                {
                    return fromInput; // Rückgabe der gültigen Zahl
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein!");
                }

            } 
            while (true); // Die Schleife läuft solange, bis eine gültige Zahl eingegeben wird
        }

         public static double ReadNextDouble()
        {
            double fromInput;
            string input;

            do
            {
                input = Console.ReadLine();

                // Überprüfen, ob die Eingabe eine gültige Zahl ist
                if (double.TryParse(input, out fromInput))
                {
                    return fromInput; // Rückgabe der gültigen Zahl
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein!");
                }

            } 
            while (true); // Die Schleife läuft solange, bis eine gültige Zahl eingegeben wird
        }

        public static double ReadNextChar()
        {
            char fromInput;
            string input;

            do
            {
                input = Console.ReadLine();

                // Überprüfen, ob die Eingabe ein gültiges Zeichen ist
                if (char.TryParse(input, out fromInput))
                {
                    return fromInput; // Rückgabe des gültigen Zeichens
                }
                else
                {
                    Console.WriteLine("Bitte gib nur ein Zeichen ein!");
                }

            } 
            while (true); // Die Schleife läuft solange, bis nur ein Zeichen eingegeben wird
        }
    }
}