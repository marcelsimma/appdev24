using System;

namespace OliverBedogg.Week02
{

    public class StringMethoden2
    {
        public static void Start()
        {
            // String zerlegen
            string text1 = "The quick brown fox jumps over the lazy dog.";
            string[] words1 = text1.Split(" ");
            Print(words1);

            // String beinhaltet
            bool containsFox = text1.Contains("fox");
            Console.WriteLine("Text enthält \"fox\": " + containsFox);
            Console.WriteLine("--------------------");

            // Entferne Leerzeichen
            string wort1 = "  Leer zeichen  ";
            string wort2 = "Hallo  !";
            Console.WriteLine("Entferne  |" + wort1.TrimStart() + "|");
            Console.WriteLine("Entferne  |" + wort1.TrimEnd() + "|");
            Console.WriteLine("Entferne  |" + wort1.Trim() + "|"); // Start und Ende
            Console.WriteLine("Entferne ! |" + wort2.TrimEnd('!') + "|");
            Console.WriteLine("Entferne  |" + wort1.Replace(" ", "") + "|"); // Alle
            Console.WriteLine("--------------------");

            // Formatierung
            // String.Format(formatierung, parameter...)
            string text = "Hello";
            string name = "Michael";
            // format string
            string strFormat = String.Format("Hallo {0}!", name);
            Console.WriteLine(strFormat);
            Console.WriteLine("--------------------");

            // fixe Ausgabenlänge und Orientierung
            Console.WriteLine(string.Format("{0, 20}", text)); // 0 = text, 20 = Zeichenlänge
            Console.WriteLine(string.Format("{0, 20}", "Universe"));
            Console.WriteLine(string.Format("{0, 20}", "!"));

            Console.WriteLine(string.Format("{0, -20}", "Hi!")); // linksbündig
            Console.WriteLine(string.Format("{0, -10}{1,10}", "Hi", "there!")); // mehrere Parameter
            // Nummern
            Console.WriteLine(string.Format("€ {0:N}", 323));
            Console.WriteLine(string.Format("{0:N2}", 323.358));
            Console.WriteLine(string.Format("{0,20:N}", 323.358));
            Console.WriteLine(string.Format("{0,20:N2}", 323.358));
            Console.WriteLine("--------------------");

            // Übung: Daten tabellarisch darstellen ------------
            // Erstelle einen schönen tabellarischen Ausgabe aus den folgenden Arrays:
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
        }

        public static void Print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }
            Console.WriteLine("\n--------------------");
        }
    }
}