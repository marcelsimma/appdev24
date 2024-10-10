using System;

namespace MarcelSimma.Week02
{

    class ConsoleInput
    {
        public static void start(string input)
        {

            //Console.WriteLine("Verrate mir deinen Namen:");

            //string tmp;
            //tmp = Console.ReadLine();

            Console.Write(ReadNextChar());

            //Console.WriteLine(tmp);

        }

        public static int ReadNextInt()
        {
            // Überprüfen, ob die Eingabe ein gültiger Integer ist
            do
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                }
            } while (true);

        }

        public static double ReadNextDouble()
        {
            // Überprüfen, ob die Eingabe ein gültiger Integer ist
            do
            {
                string userInput = Console.ReadLine();
                if (double.TryParse(userInput, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                }
            } while (true);
        }

        public static char ReadNextChar()
        {
            do
            {
                string userInput = Console.ReadLine();
                if (char.TryParse(userInput, out char result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie ein gültiges Zeichen ein.");
                }
            } while (true);
        }
    }
}