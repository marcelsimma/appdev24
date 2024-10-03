using System;

namespace OliverBedogg.Week01
{

    public class ChristmasTree
    {

        public static void Print(int height)
        {
            int width = height / 2;
            char c = '*';
            int trunkHeight = 2;
            int globesHeight = 1;

            // Körper PrintBody(...)
            int bodyHeight = height - globesHeight - trunkHeight;

            for (int i = 0; i < bodyHeight; i++)
            {
                Console.WriteLine(c);
            }

            // Kugeln PrintGlobes(...)
            PrintGlobes(width);

            // Stamm PrintTrunk(...)
            int trunkWidth = 2;
            int trunkSpace = (width - trunkWidth) / 2;
            Console.WriteLine(
                new string(' ', trunkSpace) + new string('|', trunkWidth));

        }

        public static void PrintGlobes(int width)
        {
            PrintTimes("0 ", width);
            Console.WriteLine();
        }

        public static void PrintTimes(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(text);
            }
        }
    }
}