using System;

namespace CheyenneHarbarth.Week03
{

    class ArraySearch
    {

        public static void Start()
        {

            SearchInt();
            SearchChar();
            SearchString();

        }
        public static void SearchInt()
        {
            int[] IntArray = { 2, 3, 4, 5, 7, 8, 9, 12, 13, 15, 16, 17, 18, 20, 25, 29, 34, 37, 41 };
            Console.WriteLine("Wähle eine Zahl aus!");

            while (true)
            {
                int searchfor = Convert.ToInt32(Console.ReadLine());

                int ergebnis = Array.IndexOf(IntArray, searchfor);
                if (ergebnis >= 0)
                {
                    Console.WriteLine($"Index von {searchfor}: " + ergebnis);
                    break;
                }
                else
                {
                    Console.WriteLine("Deine Zahl wurde nicht gefunden, versuche es mit einer anderen!");
                }
            }
        }

        public static void SearchChar()
        {
            char[] IntArray = { '*', '+', '~', '-', '7', '3', '8', '9', 'C', 'E', 'F' };
            Console.WriteLine("Wähle eine Zeichen aus!");

            while (true)
            {
                char searchfor = Convert.ToChar(Console.ReadLine());

                int ergebnis = Array.IndexOf(IntArray, searchfor);
                if (ergebnis >= 0)
                {
                    Console.WriteLine($"Index von {searchfor}: " + ergebnis);
                    break;
                }
                else
                {
                    Console.WriteLine("Deine Zeichen wurde nicht gefunden, versuche es mit einem anderen!");
                }
            }
        }

        public static void SearchString()
        {
            string[] IntArray = { "Berkant", "Cheyenne", "Riccardo", "Simon", "Timo", "Gerhard", "Markus" };
            Console.WriteLine("Wähle einen Namen aus!");

            while (true)
            {
                string searchfor = Console.ReadLine();

                int ergebnis = Array.IndexOf(IntArray, searchfor);
                if (ergebnis >= 0)
                {
                    Console.WriteLine($"Index von {searchfor}: " + ergebnis);
                    break;
                }
                else
                {
                    Console.WriteLine("Dein Name wurde nicht gefunden, versuche es mit einem anderen!");
                }
            }

        }
    }
}