using System;

namespace SimonJochum.Week04
{
    public class StringReplaceAll
    {
        public static void Start()
        {
            ReplaceWord();
            DeleteLowercase();
            DeleteUppercase();
            DeleteWhitespaces();
            DeleteExclamationMark();
            DeleteAllDigits();
            DeleteDigitsExclusive0();
            DeleteDigitsFrom2To4();
            KeepDigits0AndFrom4to5();
        }

        public static void ReplaceWord()
        {
            string stringExample = GetText();
            string toReplace = "wird";
            string forReplace = "war";
            string forReplace2 = "ist";
            int pos = 0;
            int count = 0;
            string? replacedText;

            Console.WriteLine("Hier ist der ursprüngliche String: " + stringExample + "\n");
            pos = stringExample.IndexOf(toReplace, 0);
            replacedText = stringExample.Replace(toReplace, forReplace);

            while (pos >= 0)
            {
                count++;
                pos = stringExample.IndexOf(toReplace, pos + 1);
                replacedText = stringExample.Replace(toReplace, forReplace);
            }
            Console.WriteLine("Hier ist der ausgetauschte String: " + replacedText + "\n");

            pos = stringExample.IndexOf(toReplace, 0);
            replacedText = stringExample.Replace(toReplace, forReplace2);

            while (pos >= 0)
            {
                count++;
                pos = stringExample.IndexOf(toReplace, pos + 1);
                replacedText = stringExample.Replace(toReplace, forReplace2);
            }
            Console.WriteLine("Hier ist der nochmals ausgetauschte String: " + replacedText + "\n");
        }

        public static void DeleteLowercase()
        {
            string stringExample = GetText(); //.Where fungiert ähnlich einer foreach Schleife
            string output = new string(stringExample.Where(c => !Char.IsLower(c)).ToArray());
            Console.WriteLine("1." + output);
        }

        public static void DeleteUppercase()
        {
            string stringExample = GetText();
            string output = new string(stringExample.Where(c => !Char.IsUpper(c)).ToArray());
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

        public static string GetText()
        {
            return "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
        }

        public static void DeleteAllDigits()
        {
            Console.WriteLine(GetText2() + " ursprüngliche Zahlenkette");

            string stringExample = GetText2();     // "Lambda-Ausdruck =>" wird bei LINQ verwendet
            string output = new string(stringExample.Where(c => !Char.IsDigit(c)).ToArray()); // da !Char.IsDigit negiert ist, werden keine Zahlen aufgeschrieben.
            Console.WriteLine("1. " + output);
        }

        public static void DeleteDigitsExclusive0()
        {
            string stringExample = GetText2();
            string output = new string(stringExample.Where(c => c == '0').ToArray());
            Console.WriteLine("2. " + output);
        }

        public static void DeleteDigitsFrom2To4()
        {
            string stringExample = GetText2();
            string output = new string(stringExample.Where(c => c == '0' || c == '1' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9').ToArray());
            Console.WriteLine("3. " + output);
        }

        public static void KeepDigits0AndFrom4to5()
        {
            string stringExample = GetText2();
            string output = new string(stringExample.Where(c => c == '0' || c == '4' || c == '5').ToArray());
            Console.WriteLine("4. " + output);
        }

        public static string GetText2()
        {
            return "749813247132984712039487123049871204398712039487";
        }
    }
}