using System;
using System.Xml.Schema;

namespace FatmanurKeles.Week04
{
    public class CountLetterList
    {
        public static void Start()
        {

            string text = GetText();
            int totalDigits = 0;
            int totalLetters = 0;
            int totalWhiteSpace = 0;
            int totalSpecialChar = 0;

            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            char[] characters = text.ToCharArray();

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
                    totalWhiteSpace++;
                }

                else
                {
                    totalSpecialChar++;
                }
            }

            Console.WriteLine($"Buchstabenanzahl: {totalLetters}");

            foreach (var pair in letterCounts)
            {
                Console.WriteLine($"'{pair.Key}': {pair.Value}");
            }



        }
        public static string GetText()
        {
            return "Hier befinden sich die Zeichen, die später gezählt und ausgegeben werden. Damit mein Text länger wird, schreibe ich jetzt zusätzlich noch ein Satz dazu.";
        }
    }

}
