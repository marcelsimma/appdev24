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
        public static void Numbers()
    {
        Console.WriteLine("Enter numbers: ");
        string? numbers = Console.ReadLine();

        string withoutAllNumbers = numbers;
        for (int i = 0; i <= 9; i++)
        {
            withoutAllNumbers = withoutAllNumbers.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without Numbers 0-9 {withoutAllNumbers}");

        string without1to9 = numbers;
        for (int i = 1; i <= 9; i++)
        {
            without1to9 = without1to9.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without 1-9 {without1to9}");

        string without2to4 = numbers;
        for (int i = 2; i <= 4; i++)
        {
            without2to4 = without2to4.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without Numbers 2-4 {without2to4}");

        string without1to3and6to9 = numbers;
        for (int i = 1; i <= 3; i++)
        {
            without1to3and6to9 = without1to3and6to9.Replace(i.ToString(), "");
        }
        for (int i = 6; i <= 9; i++)
        {
            without1to3and6to9 = without1to3and6to9.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without Numbers 1-3 and 6-9 {without1to3and6to9}");
    }
        public static string GetText()
        {
            return "Hallo, ich bin 26 Jahre alt, lebe in Wolfurt und lerne das Programmieren von C# im Digital Campus.";
        }

    }
}