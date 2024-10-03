using System;

namespace SimonJochum.Week01
{

    public class PrintChristmasTree
    {

        public static void ChristmasTree(char c, char d, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (i == 0) //Christbaumstern wird am Index 0 erstellt
                {

                    Console.WriteLine(new string(' ', size) + d + new string(' ', size));


                }
                else if (i > 0 && i < (size - 1)) //Christbaumnadeln werden ab Index 1 (da i > 0) generiert bis die && Bedingung erfüllt ist
                {

                    Console.WriteLine(new string(' ', size - i) + c + new string(c, i * 2 - 1) + c + new string(' ', size - i));
                }

                else if (i == size - 1) //Christbaumkugeln
                {
                    for (int j = -1; j < size * 2; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('0');

                        }
                        else
                        {
                            Console.Write(' ');
                        }

                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < size / 3; i++) //Baumstamm
            {
                Console.WriteLine(new string(' ', size - 1) + new string('+', size / 3));
            }
        }
    }
}

