using System;

namespace MagdalenaMueller.Week02
{
    public class Words
    {
        public static void Words1()
        {
            Console.WriteLine("Willkommen zum Reverse Programm");
            Console.WriteLine("Gibt ein Wort ein: ");
            string word = Console.ReadLine();

            for(int i = word.Length - 1; i >= 0; i--)// beim letzten buchstaben anfangen um das wort falsch herum auszugeben
            {
                Console.Write(word[i]);
            }
        }
        public static void Word2()
        {
            Console.WriteLine("Willkommen zum Ramdom Programm");
            Console.WriteLine("Gibt ein Wort ein: ");
            string word = Console.ReadLine();

            char[] letters = word.ToCharArray();
            
            // Random erstellen
            Random random = new Random();

            // Buchstaben mischen
            letters = letters.OrderBy(x => random.Next()).ToArray();

            // Ausgeben der gemischten Buchstaben
            Console.WriteLine("Gemischte Buchstaben: ");
            foreach (char letter in letters)
            {
                Console.Write(letter);
            }
            Console.WriteLine(); // Zeilenumbruch
        }
    }
}