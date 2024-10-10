using System;
using System.Linq;

namespace MarcelSimma.Week02
{
    public class StringIntroduction
    {
        public static void start()
        {

            Console.Write(ShuffleString("Hallo"));
        }

        static string ShuffleString(string input)
        {
            Random random = new Random();
            char[] characters = input.ToCharArray();

            // Fisher-Yates Shuffle Algorithmus
            for (int i = characters.Length - 1; i > 0; i--)
            {
                // Zufälligen Index wählen
                int j = random.Next(0, i + 1);

                // Buchstaben vertauschen
                char temp = characters[i];
                characters[i] = characters[j];
                characters[j] = temp;
            }

            return new string(characters);
        }

    }
}
