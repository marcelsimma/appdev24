using System;

namespace JulianStroehle.Week1
{
    public class MalreiheA
    {
        public static void Malreihe()
        {
            Console.WriteLine("Zahl fuer Malreihe: ");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                DoSmth(i*s);
            }
        }
        public static void DoSmth(int value)
        {
            Console.WriteLine(value);
        }
    }
}