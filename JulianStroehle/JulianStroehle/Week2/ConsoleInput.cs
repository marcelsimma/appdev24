using System;
namespace JulianStroehle.Week2
{
    public class ConsoleInput
    {
        public static void Start()
        {
            double d = IsDouble();
            Console.WriteLine(d);
            char c = IsChar();
            Console.WriteLine(c);
            int i = IsInt();
            Console.WriteLine(i);
        }
        public static double IsDouble()
        {
            do
            {
                if (double.TryParse(Console.ReadLine(), out double d))
                {
                    return d;
                }
                else
                {
                    Console.WriteLine("Das ist kein Double");
                }
            }
            while (true);
        }
        public static char IsChar()
        {
            do
            {
                if (char.TryParse(Console.ReadLine(), out char c))
                {
                    return c;
                }
                else
                {
                    Console.WriteLine("Das ist kein einzelner Charakter");
                }
            }
            while (true);
        }
        public static int IsInt()
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out int i))
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Das ist keine Zahl");
                }
            }
            while (true);
        }
    }
}