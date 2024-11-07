using System;

namespace SimonJochum.Week03
{
    public class ArraySearch
    {
        public static void Start()
        {
            SearchInt();
            SearchChar();
            SearchString();

        }

        public static void SearchInt()
        {
            int[] numbers = { 12, 45, 76, 23, 25, 67, 43, 65, 63, 78 };
            bool found = false;

            do
            {
                Console.WriteLine("Welche Zahl möchtest du suchen?");
                int search = Convert.ToInt32(Console.ReadLine());

                // Verwende Array.IndexOf
                int pos = Array.IndexOf(numbers, search);

                if (pos != -1)
                {
                    Console.WriteLine($"Die Zahl steht am Index {pos}");
                    found = true;
                }
                else
                {
                    Console.WriteLine("Die Zahl wurde nicht gefunden.");
                }
            }
            while (!found);

        }

        public static void SearchChar()
        {
            char[] character = { 'a', '!', '?', '|', 'b', 'c', 'd', 'A', 'B', 'C' };
            bool found = false;

            do
            {
                Console.WriteLine("Welches Zeichen möchtest du suchen?");
                char search = Convert.ToChar(Console.ReadLine());

                int pos = Array.IndexOf(character, search);

                if (pos != -1)
                {
                    Console.WriteLine($"Das Zeichen steht am Index {pos}");
                    found = true;
                }
                else
                {
                    Console.WriteLine("Das Zeichen wurde nicht gefunden!");
                }
            } 
            while(!found);

        }

        public static void SearchString()
        {
            string[] names = { "Simon", "Julian", "Marcel", "Barbara", "Manuel", "Alessio", "Cheyenne", "Berkant", "Magdalena", "Oliver" };
            bool found = false;

            do
            {
                Console.WriteLine("Welchen Namen möchtest du suchen?");
                string? search = Console.ReadLine();

                int pos = Array.IndexOf(names, search);

                if(pos != -1)
                {
                    Console.WriteLine($"Der Name steht am Index {pos}.");
                    found = true;
                }
                else
                {
                    Console.WriteLine("Der Name wurde nicht gefunden.");

                }
            }
            while (!found);
        }
    }
}