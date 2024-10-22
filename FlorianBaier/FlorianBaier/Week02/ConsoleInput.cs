using System;

namespace FlorianBaier.Week02
{

    public class ConsoleInput
    {

        public static void CI()
        {
            // Console.WriteLine("Verrate mir deinen Namen.");
            //  string input;
            //input = Console.ReadLine();
            ReadNextInt();
            // Console.WriteLine(input);
        }

        public static int ReadNextInt()
        {
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
                

            }while (true) ;
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
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                }
                

            }while (true) ;
        }

    }
}