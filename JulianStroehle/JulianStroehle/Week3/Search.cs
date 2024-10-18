using System;
namespace JulianStroehle.Week3
{
    public class Search
    {
        public static void Start()
        {
            Console.WriteLine("Text eingeben: ");
            string Text = Console.ReadLine();
            Console.WriteLine("Wort das gesucht werden soll: ");
            string Word = Console.ReadLine();
            int startPos  = Text.IndexOf(Word);
            int pos = -1;
            int count = -1;
            do
            {
                pos = Text.IndexOf(Word, pos + 1);
                if (pos != -1)
                {
                    Console.WriteLine($"Gefunden an Index: {pos}");
                }
                count++;
            }
            while (pos >= 0);
            Console.WriteLine($"Das gesuchte Word {Word} kommt im Text {count} mal vor.");
        }
        public static void Upper()
        {
            Console.WriteLine("Text einfügen: ");
            string? Text = Console.ReadLine();
            Console.WriteLine("Wort das gesucht werden soll: ");
            string? SearchWord = Console.ReadLine();
            char[] chars = { ' ', '.', ',', ';', ':', '?', '\n', '\r' };
            string[] words = Text.Split(chars);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i] == SearchWord)
                {
                    string temp = words[i].ToUpper();
                    words[i] = temp;
                }
            }
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }
        public static void Replace()
        {
            Console.WriteLine("Text einfügen: ");
            string? Text = Console.ReadLine();
            Console.WriteLine("Wort das gesucht werden soll: ");
            string? SearchWord = Console.ReadLine();
            char[] chars = { ' ', '.', ',', ';', ':', '?', '\n', '\r' };
            string[] words = Text.Split(chars);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i] == SearchWord)
                {
                    string temp = words[i].Replace(SearchWord, SearchWord.ToUpper());
                    words[i] = temp;
                }
            }
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }
    }
}