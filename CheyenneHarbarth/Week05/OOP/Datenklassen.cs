using System;
using CheyenneHarbarth.Week02;

namespace CheyenneHarbarth.Week05.OOP
{
    class Datenklassen
    {
        public static void Start()
        {
            int[] RandomArray = new int[30];

            Random random = new Random();

            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(-50, 50);
                Console.WriteLine(RandomArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine("kleinster Wert: " + CheckSmallest(RandomArray));
            Console.WriteLine("größter Wert: " + CheckBiggest(RandomArray));
            Console.WriteLine("durchschnittlicher Wert: " + CheckAverage(RandomArray));
        }
        public static int CheckSmallest(int[] RandomArray)
        {
            int Ergebnis;

            Ergebnis = RandomArray.Min();

            return Ergebnis;
        }

        public static int CheckBiggest(int[] RandomArray)
        {
            int Ergebnis;

            Ergebnis = RandomArray.Max();

            return Ergebnis;
        }

        public static int CheckAverage(int[] RandomArray)
        {
            int sum = 0;
            foreach (int num in RandomArray)
            {

                sum += Math.Abs(num);                           //Math.Abs errechnet die Beträge des von dir vorgegebenen Zahlenbereichs
            }
            int average = Convert.ToInt32(RandomArray.Average());
            int BetragAverage = sum / RandomArray.Length;

            return BetragAverage;
        }
    }
}