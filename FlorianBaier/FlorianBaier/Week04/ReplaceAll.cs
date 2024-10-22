using System;

namespace FlorianBaier.Week04
{

    public class ReplaceAll
    {

        public static void ReplaceWords()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string replacedText = text.Replace("wird", "war").Replace("wird", "ist");
            Console.WriteLine(replacedText);
        }

        public static void ReplaceDelete()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string output = "";

            foreach (char c in input)
            {
                if (char.IsLower(c) || char.IsUpper(c) || char.IsWhiteSpace(c) || c == '!')
                {
                    output += c;
                }
            }
            Console.WriteLine(output);
        }
    }
}