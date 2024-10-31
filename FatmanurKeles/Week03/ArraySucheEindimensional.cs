using System;

namespace FatmanurKeles.Week02
{
    public class ArraySucheEindimensional
    {
        public static void Start()
        {

            int[] numbers = { 0, 61, 48, 8, 20, 3, 25, 4, 19, 60, 42, 54, 34, 7 };

            int index = -1;

            do
            {
                Console.WriteLine("Bitte gebe eine Zahl zwischen 0 - 100 ein: ");
                int input = ConsoleInput.ReadNextInt();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (input == numbers[i])
                    {
                        index = i;
                        break;
                    }

                }

                if (index == -1)
                {
                    Console.WriteLine("Die Zahl wurde nicht gefunden.");
                }
                else
                {
                    Console.WriteLine($"Der Index lautet: {index}");
                }
            } while (index == -1);
        }
    }
}