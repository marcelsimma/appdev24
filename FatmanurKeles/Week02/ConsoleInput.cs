using System;

namespace FatmanurKeles.Week02
{
    public class ConsoleInput
    {
        public static void start(string input)
        {
            Console.WriteLine("Verrate mir deinen Namen: ");

            string tmp;
            tmp = Console.ReadLine();

            Console.Write(ReadNextInt() * 2);
            Console.WriteLine(tmp);
        }
        public static int ReadNextInt()
        {
            //Überprüfen ob die Eingabe ein int ist
            do
            {
                string unserInput = Console.ReadLine();
                if (int.TryParse(unserInput, out int result))
                {
                    return result;  // wenn ReadNextInt aufgerufen wird kommt result raus
                }

                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                }
            } while (true);
        }
        public static double ReadNextDouble()

        {
            do
            {
                string unserInput = Console.ReadLine();
                if (double.TryParse(unserInput, out double result))
                {
                    return result;  // wenn ReadNextDouble aufgerufen wird kommt result raus
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
                string unserInput = Console.ReadLine();
                if (char.TryParse(unserInput, out char result))
                {
                    return result;  // wenn ReadNextDouble aufgerufen wird kommt result raus
                }

                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                }
            } while (true);
        }

    }

}
