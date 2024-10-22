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

        public static void DeleteLowercase()
        {
            string stringExample = GetText();
            string output = new string(stringExample.Where(Char.IsUpper).ToArray());
            Console.WriteLine("1." + output);
        }
 
        public static void DeleteUppercase()
        {
            string stringExample = GetText();
            string output = new string(stringExample.Where(Char.IsLower).ToArray());
            Console.WriteLine("2." + output);
        }
 
        public static void DeleteWhitespaces()
        {
            string stringExample = GetText();
            string output = new string(stringExample.Where(c => !Char.IsWhiteSpace(c)).ToArray());
            Console.WriteLine("3." + output);
        }
 
        public static void DeleteExclamationMark()
        {
            string stringExample = GetText();
            string toDelete = "!";
            string forDelete = "";
            int pos = 0;
            int count = 0;
            string? replacedText;
 
            pos = stringExample.IndexOf(toDelete, 0);
            replacedText = stringExample.Replace(toDelete, forDelete);
 
            while (pos >= 0)
            {
                count++;
                pos = stringExample.IndexOf(toDelete, pos + 1);
                replacedText = stringExample.Replace(toDelete, forDelete);
            }
            Console.WriteLine("4." + replacedText);
 
        }

        }
    }