using System;

namespace FlorianBaier.Week02
{

    class Randomizer
    {

        public static void RandomizerChar(string input)
        {

            Random random = new Random();

            char[] charInput = input.ToCharArray();

            for (int i = 0; i < input.Length-2; i++)
            {
             int rand = random.Next(i+1, input.Length-1);

             char temp = charInput[i];//H
             charInput[i]= charInput[rand];//H mit a ersetzen
             charInput[rand]= temp;//alten Speicherort von a mit H aus tmp ersetzen
            }
            string result = new string(charInput);
            Console.WriteLine(result);
        }
    }
}