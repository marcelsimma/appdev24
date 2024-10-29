using System;

namespace BerkantAkinci.Week04
{

    class Tabelle
    {

        public static void PrintTabelle()
        {

            string[] firstName = { "Berkant", "Cheyenne", "Stefan", "Manuel", "Alessio" };
            string[] lastName = { "Akinci", "Harbarth", "Makanovic", "Hartmann", "Italia" };
            int[] age = { 21, 24, 18, 29, 19 };
            string[] place = { "Lustenau", "Dornbirn", "Montafon", "Bludesch", "Lauterach" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.45763466f, 120.0f, 119.9999f };

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine($"{firstName[i],-20} | {lastName[i],-20} | {age[i],3} | {place[i],-20} | {distanceFromCapital[i],20:F2}");
            }

        }
    }
}