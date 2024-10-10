using System;

namespace FatmanurKeles.Week02
{
    public class Reverse
    {
        public static void ReverseHallo(string input)
        {
            Reverse words = new Reverse();

            char[] charInput = input.ToCharArray();

            for (int i = input.Length - 1; i >= 0; i++)
            {
                // string reverse = (input.Length - 1, i + 1);
/*
                charInput = stringToReverse.ToCharArray();
                Array.Reverse(charInput);

                return new string(charInput);
*/
            }
        }
    }
}
