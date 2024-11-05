using System;
namespace JulianStroehle.Week2
{
    public class Counter
    {
        public static void Start()
        {
            Console.WriteLine("1/2");
            switch (Console.ReadLine())
            {
                case "1": Counter1(); break;
                case "2": Counter2(); break;
            }
        }
        public static void Counter1()
        {
            float Num = 0;
            while (Num <= 100)
            {
                Console.WriteLine(Math.Round(Num, 2));
                Num += 0.1F;
            }
        }
        public static void Counter2()
        {
            for (float Num = 0; Num <= 100; Num += 0.1F)
            {
                Console.WriteLine(Math.Round(Num, 2));
            }
        }
    }
}