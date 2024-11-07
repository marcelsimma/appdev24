using System;

namespace CheyenneHarbarth.Week04
{
    class Datatabelle
    {

        public static void Start()
        {

            String[] firstName = { "Cheyenne", "Berkant", "Riccardo", "Timo", "Simon" };
            String[] lastName = { "Harbarth", "Akinci", "'Ceccon'", "Fischer", "Bereuter" };
            int[] age = { 24, 21, 26, 21, 23 };
            String[] place = { "Dornbirn", "Lustenau", "Schwarzenberg", "Feldkirch", "Lingenau" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.Write($"{firstName[i],-16} {lastName[i],-15} | Alter: {age[i],3} | Wohnort {place[i],-20} | Entfernung zur Hauptstadt Wien: {distanceFromCapital[i],20:F2}");
                Console.WriteLine();

            }
        }
    }
}