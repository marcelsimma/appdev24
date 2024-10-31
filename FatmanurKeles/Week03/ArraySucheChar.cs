using System;

namespace FatmanurKeles.Week02
{
    public class ArraySucheChar
    {
        public static void Start()
        {

            char[] letter = {'a', 'e', 'f', 'g', 'm' };

            int index = -1;

            do
            {
                Console.WriteLine("Bitte gebe eine Buchstabe ein: ");
                int input = ConsoleInput.ReadNextChar();

                for (int i = 0; i < letter.Length; i++)
                {
                    if (input == letter[i])
                    {
                        index = i;
                        break;
                    }

                }

                if (index == -1)
                {
                    Console.WriteLine("Die Buchstabe wurde nicht gefunden.");
                }
                else
                {
                    Console.WriteLine($"Der Index lautet: {index}");
                }
            } while (index == -1);
        }
    }
}