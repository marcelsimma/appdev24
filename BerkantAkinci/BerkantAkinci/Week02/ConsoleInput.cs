using System;
using System.Runtime.CompilerServices;

namespace BerkantAkinci.Week02
{

    class ConsoleInput
    {

        public static void PrintConsoleInput()
        {
            System.Console.WriteLine(ReadNextInt());
            System.Console.WriteLine(PrintNextDouble());
            System.Console.WriteLine(PrintNextChar());
        }

        public static int ReadNextInt()
        {
            while (true)
            {
                System.Console.WriteLine("Tippe eine Ganze Zahl deiner Wahl ein: ");
                string tmp = Console.ReadLine();

                if (int.TryParse(tmp, out int tmp2))
                {
                    return tmp2;
                }

                else
                {
                    System.Console.WriteLine("Das war eine ungültige Zahl! \n \nProbiere es nochmal \n");
                }
            }
        }

        public static double PrintNextDouble()
        {
            while (true)
            {
                System.Console.WriteLine("Tippe eine Kommazahl deiner Wahl ein: ");
                string tmp = Console.ReadLine();

                if (double.TryParse(tmp, out double tmp2))
                {
                    return tmp2;
                }

                else
                {
                    System.Console.WriteLine("Das war eine ungültige Zahl! \n \nProbiere es nochmal \n");
                }
            }
        }

        public static char PrintNextChar()
        {
            while (true)
            {
                System.Console.WriteLine("Tippe einen Charakter deiner Wahl ein: ");
                string tmp = Console.ReadLine();

                if (char.TryParse(tmp, out char tmp2))
                {
                    return tmp2;
                }

                else
                {
                    System.Console.WriteLine("Das war eine ungültige Zahl! \n \nProbiere es nochmal \n");
                }
            }
        }
    }
}