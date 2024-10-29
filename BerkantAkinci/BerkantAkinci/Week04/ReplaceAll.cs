using System;

namespace BerkantAkinci.Week04
{

    class ReplaceAll
    {

        public static void PrintAll()
        {
            Replace1();
            Replace2();
            Replace3();
        }

        public static void Replace1()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string neuText = input.Replace("wird", "war und ist");

            Console.WriteLine(neuText);
        }

        public static void Replace2()
        {
            string charLower = "", charUpper = "", charSpace = "", charMark = "";
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            char[] inputArray = input.ToCharArray();

            foreach (char elem in inputArray)
            {
                if (char.IsLower(elem))
                {
                    charLower += (elem);
                }

                if (char.IsUpper(elem))
                {
                    charUpper += (elem);
                    //charUpper = string.Concat(charUpper, elem); --> genauso möglich
                }

                if (char.IsWhiteSpace(elem))
                {
                    charSpace += (elem);
                    //charSpace = string.Concat(charSpace, elem); --> genauso möglich
                }

                if (elem == '!')
                {
                    charMark += (elem);
                }
            }
            System.Console.WriteLine(charLower);
            System.Console.WriteLine(charUpper);
            System.Console.WriteLine(charSpace);
            System.Console.WriteLine(charMark);


        }

        public static void Replace3()
        {
            //Zahlen definieren und in ein Char Array umspeichern
            string input = "749813247132984712039487123049871204398712039487";
            char[] inputAsChar = input.ToCharArray();

            //Schleife wo durch jedes char (jede Zahl einzeln) durchlauft
            foreach (char nummer in inputAsChar)
            {
                if (nummer >= 2 || nummer <= 6) {
                    System.Console.WriteLine(nummer);
                }
            }
        }
    }
}