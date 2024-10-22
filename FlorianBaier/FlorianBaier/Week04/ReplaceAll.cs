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

        public static string CountingCharacter()
    {
        string textString = GetText();

        char[] textArray = textString.ToCharArray();
        int[] counter = new int[65536];

        foreach (char c in textArray)
        {
            counter[c]++;
        }
        for (int i = 0; i < counter.Length; i++)
        {
            if (counter[i] > 0)
            {
                Console.WriteLine($"Der Character {(char)i} kommt {counter[i]} vor. ");
            }
        }
        return "Ende";
    }

         public static string GetText()
        {
            return "Hallo, ich bin 26 Jahre alt, lebe in Wolfurt und lerne das Programmieren von C# im Digital Campus.";
        }

        }
    }