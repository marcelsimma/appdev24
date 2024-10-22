using System;

namespace FlorianBaier.Week04
{

    public class Buchstabenzaehlen
    {

        public static void Start()
        {
            {
                string userInput = GetText();

                int totalLetters = 0;
                int totalDigits = 0;
                int totalWhitespaces = 0;
                int totalSpecialChars = 0;
                Dictionary<char, int> letterCounts = new Dictionary<char, int>();

                char[] characters = userInput.ToCharArray();

                foreach (char c in characters)
                {
                    if (char.IsLetter(c))
                    {
                        totalLetters++;
                        char lowerC = char.ToLower(c);
                        if (letterCounts.ContainsKey(lowerC))
                        {
                            letterCounts[lowerC]++;
                        }
                        else
                        {
                            letterCounts[lowerC] = 1;
                        }
                    }
                    else if (char.IsDigit(c))
                    {
                        totalDigits++;
                    }
                    else if (char.IsWhiteSpace(c))
                    {
                        totalWhitespaces++;
                    }
                    else
                    {
                        totalSpecialChars++;
                    }
                }

                Console.WriteLine($"Number of letters: {totalLetters}");
                Console.WriteLine($"Number count: {totalDigits}");
                Console.WriteLine($"Whitespaces: {totalWhitespaces}");
                Console.WriteLine($"Special characters: {totalSpecialChars}");

                Console.WriteLine("\nLetter frequency:");
                foreach (var pair in letterCounts)
                {
                    Console.WriteLine($"'{pair.Key}': {pair.Value}");
                }
            }
        }
        public static string GetText()
        {
            return "Hallo, ich bin 26 Jahre alt, lebe in Wolfurt und lerne das Programmieren von C# im Digital Campus.";
        }
    }
}

