using System;

namespace BerkantAkinci.Week02
{

    class Reverse
    {

        public static void PrintReverse()
        {
            string UserInput = Console.ReadLine();
            string reversedText = Reverser(UserInput);
            Console.WriteLine("The reversed text is :" + reversedText);
        }

        public static string Reverser(string UserInput)
        {
            string reversedText = "";
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                 reversedText += UserInput[i];
            }
            return reversedText;
        }
    }
}