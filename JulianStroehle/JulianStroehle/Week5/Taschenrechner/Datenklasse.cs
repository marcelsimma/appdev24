using System;
using JulianStroehle.Week5.models;
namespace JulianStroehle.Week5
{
    public class Datenklasse
    {
        public static void Start()
        {
            Random rdm = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rdm.Next(-100, 100);
            }
            Taschenrechner taschenrechner = new Taschenrechner(numbers);
            taschenrechner.Highest();
            taschenrechner.Lowest();
            taschenrechner.Average();
            Console.WriteLine("\n" + taschenrechner);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rdm.Next(-100, 100);
            }
            Taschenrechner taschenrechner2 = new Taschenrechner(numbers);
            taschenrechner2.Highest();
            taschenrechner2.Lowest();
            taschenrechner2.Average();
            Console.WriteLine("\n" + taschenrechner2);
        }
    }
}