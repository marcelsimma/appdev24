using System;

namespace SimonJochum.Week01
{

    public class PrintChristmasTreeParts
    {
        public static void ChristmasTreeParts(char c, char d, int height)
        {
            int width = height / 2;
            int balls = height / height;
            int trunk = height / 3;

            ChristmasTreeBody(c, d, height);
            ChristmasTreeBalls(height);
            ChristmasTreeTrunk(height);

        }
        public static void ChristmasTreeBody(char c, char d, int height)
        {
            //für den oberen Bereich des Baumes
            for (int i = 0; i < height; i++)
            {
                // Christbaumstern
                if (i == 0)
                {
                    Console.WriteLine(new string(' ', height) + d + new string(' ', height));
                }
                // Christbaumnadeln
                else
                {
                    Console.WriteLine(new string(' ', height - i) + c + new string(c, i * 2 - 1) + c + new string(' ', height - i));
                }

            }

        }
        public static void ChristmasTreeBalls(int height)
        {
            for (int j = -1; j < height * 2; j++)
            {
                if (j % 2 == 0)
                {
                    //Christbaumkugeln
                    Console.Write('0');
                }
                else
                {
                    // Leerzeichen zwischen den Kugeln
                    Console.Write(' ');
                }
            }
            // Neue Zeile nach den Kugeln
            Console.WriteLine();
        }
        public static void ChristmasTreeTrunk(int height)
        {
            // Höhe des Baumstamms
            int trunkHeight = height / 3; 

            // Breite des Baumstamms (ungerade Breite)
            int trunkWidth = height % 2 == 0 ? height / 3 : height / 3 + 1; 

            // Leerzeichen für Zentrierung
            int trunkSpace = (height * 2 - trunkWidth) / 2; 

            for (int i = 0; i < trunkHeight; i++)
            {
                Console.WriteLine(new string(' ', trunkSpace) + new string('+', trunkWidth));
            }
        }
    }
}

