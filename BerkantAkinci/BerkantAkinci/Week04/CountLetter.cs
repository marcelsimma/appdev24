using System;

namespace BerkantAkinci.Week04
{

    class CountLetter
    {

        public static void PrintLetter()
        {
            /*char c = 'H';
            int charAsInt = (int)c;

            Console.WriteLine(charAsInt);

            int j = 97;
            char iAsChar = (char)j;

            Console.WriteLine(iAsChar);*/

            string input = "Hallo Welt";
            char[] inputAsCharArray = input.ToCharArray();

            int[] counter = new int[65535];


            foreach (char zeichen in inputAsCharArray)
            {
                //int counterIndex = (int)zeichen;
                counter[zeichen]++;
            }

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    Console.WriteLine("Zeichen: " + (char)i + " ASCII-Wert" + i + " Anzahl:" + counter[i]);
                }
            }
        }
    }
}