using System;
namespace JulianStroehle.Week4
{
    public class Datendarstellung
    {
        public static void Start()
        {
            string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
            int count = 0;
            Console.Write("\n" + string.Format("{0, 6}", " "));
            Console.Write(string.Format("{0, -20}", "| " + "Vorname"));
            Console.Write(string.Format("{0, -20}", "| " + "Nachname"));
            Console.Write(string.Format("{0, -8}", "| " + "Alter"));
            Console.Write(string.Format("{0, -20}", "| " + "Wohnort"));
            Console.Write(string.Format("{0, -11}", "| " + "Abstand zur Hauptstadt"));
            Console.Write(string.Format("{0, 3}", "|"));
            Console.WriteLine();
            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.Write(i + 1 + string.Format("{0, 5}", " "));
                Console.Write(string.Format("{0, -20}", "| " + firstName[i]));
                Console.Write(string.Format("{0, -20}", "| " + lastName[i]));
                Console.Write(string.Format("{0, -8}", "| " + age[i]));
                Console.Write(string.Format("{0, -20}", "| " + place[i]));
                Console.Write(string.Format("{0, -11}", "| " + string.Format("{0,8:N2}", distanceFromCapital[i])) + " km");
                Console.Write(string.Format("{0, 13}", "|"));
                Console.WriteLine();
                count++;
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nAnzahl Personen: " + count + "\n");
        }
    }
}