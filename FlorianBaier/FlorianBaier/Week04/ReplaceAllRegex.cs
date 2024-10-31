using System;
using System.Text.RegularExpressions;

namespace FlorianBaier.Week04
{

    public class ReplaceAllRegex
    {

        public static void RegexWords()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string pattern = @"\bwird\b";
            string replacement = "war und ist";

            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);
        }
        public static void CharactersDeleteLowerCase()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string output = Regex.Replace(input, "[a-z]", string.Empty);

            Console.WriteLine(output);
        }
        public static void CharactersDeleteUpperCase(){
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string output = Regex.Replace(input, "[A-Z]", string.Empty);

            Console.WriteLine(output);
        }

        public static void CharactersDeleteWhitespaces(){
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string output = Regex.Replace(input, " ", string.Empty);

            Console.WriteLine(output);
        }

        public static void CharactersDeleteExclanationMark(){
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string output = Regex.Replace(input, "!", string.Empty);

            Console.WriteLine(output);
        }

        public static void DeleteNumber0To9(){
            string input = "749813247132984712039487123049871204398712039487";
            string output = Regex.Replace(input, "[0-9]", string.Empty);

            Console.WriteLine("Übrig geblieben: " + output);
        }

        
        public static void DeleteNumber1To9(){
            string input = "749813247132984712039487123049871204398712039487";
            string output = Regex.Replace(input, "[1-9]", string.Empty);

            Console.WriteLine("Übrig geblieben: " + output);
        }

        public static void DeleteNumber2To4(){
            string input = "749813247132984712039487123049871204398712039487";
            string output = Regex.Replace(input, "[2-4]", string.Empty);

            Console.WriteLine("Übrig geblieben: " + output);
        }

        public static void DeleteNumber1To3And6To9(){
            string input = "749813247132984712039487123049871204398712039487";
            string output = Regex.Replace(input, "[1-3]|[6-9]", string.Empty);

            Console.WriteLine("Übrig geblieben: " + output);
        }

    }
}