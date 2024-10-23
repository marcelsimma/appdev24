using System;

namespace MarcelSimma.Week04
{

    public class ReplaceAll
    {

        public static void Start(int intervallStart, int intervallEnde)
        {
            string input = "123456789123456789123456789";

            // char c = '0' wird repräsentiert durch den ASCII-Code 48
            // char c = '9' wird repräsentiert durch den ASCII-Code 57
            /*
            0: 48
            1: 49
            2: 50
            3: 51
            4: 52
            5: 53
            */

            string result = input;

            for (int i = intervallStart; i <= intervallEnde; i++)
            {
                char numberToReplace = (char)(i+48);
                result = result.Replace(numberToReplace, ' ');
            }



            Console.WriteLine(result);
        }

        public static void ReplaceAll3(int intervallStart, int intervallEnde)
        {
            string input = "123456789";

            // char c = '0' wird repräsentiert durch den ASCII-Code 48
            // char c = '9' wird repräsentiert durch den ASCII-Code 57
            /*
            0: 48
            1: 49
            2: 50
            3: 51
            4: 52
            5: 53
            */

            char[] inputArray = input.ToCharArray();

            foreach (char elem in inputArray)
            {
                if (!((int)elem >= intervallStart + 48 && (int)elem <= intervallEnde + 48))
                {
                    Console.WriteLine(elem);
                }
            }
        }

        public static void ReplaceAll2()
        {

            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            char[] inputArray = input.ToCharArray();

            string lowerResult = "", higherResult = "", spaceResult = "", markResult = "";

            foreach (char elem in inputArray)
            {
                if (char.IsLower(elem) == true)
                {
                    lowerResult += elem;
                }
                if (char.IsUpper(elem) == true)
                {
                    higherResult += elem;
                }
                if (char.IsWhiteSpace(elem) == true)
                {
                    spaceResult += elem;
                }
                if (elem == '!')
                {
                    markResult += elem;
                }
            }

            Console.WriteLine(lowerResult);
            Console.WriteLine(higherResult);
            Console.WriteLine(spaceResult);
            Console.WriteLine(markResult);
        }


        public static void Replace1()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            string result = input.Replace("wird", "war und ist");

            Console.WriteLine(result);

            string example = "Frachtschiffcontaineretikettiergerät!";

            Console.WriteLine(example.ToUpper());
            Console.WriteLine(example.ToLower());
            Console.WriteLine(example.Trim());
            Console.WriteLine(example.Substring(3, 5));
            char[] exampleAsChar = example.ToCharArray();


        }
    }
}