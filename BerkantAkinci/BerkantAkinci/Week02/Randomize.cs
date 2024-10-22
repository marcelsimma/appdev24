using System;

namespace BerkantAkinci.Week02
{

    class Randomize
    {

        public static void PrintRandomize(string input)
        {
            Random random = new Random();

            char[] charInput = input.ToCharArray();

            for (int i = 0; i < input.Length - 2; i++)
            {
                int rand = random.Next(i + 1, input.Length - 1);

                char tmp = charInput[i]; //H
                charInput[i] = charInput[rand]; //H mit a ersetzten
                charInput[rand] = tmp; // alten Speicherort von a mit H aus tmp ersetzen
            }

            string result = new string(charInput);

            Console.WriteLine(result);
        }
    }
}