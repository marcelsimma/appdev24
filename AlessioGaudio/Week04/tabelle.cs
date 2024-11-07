using System;

namespace AlessioGaudio.Week02
{
    class Tabelle
    {
        public static void Start()

        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            int[] age = { 40, 78, 5, 15, 81 };
            float[] distanceFromCapital = { 0f, 654.4f, 412.457634366f, 115.0f, 119.9999f };

            Console.WriteLine("{0,-15} {1,-15} {2,4} {3,-20} {4,5}", "First Name", "Last Name", "Age", "Place", "Distance from Capital");
            Console.WriteLine(new string('-', 85));


            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,4} {3,-20} {4,3}", firstName[i], lastName[i], age[i], place[i], distanceFromCapital[i]);
            }
        }
    }
}