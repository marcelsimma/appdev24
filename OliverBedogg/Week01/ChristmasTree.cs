using System;

namespace OliverBedogg.Week01
{

    public class ChristmasTree
    {

        public static void Print(int height)
        {
            // Ablauf Blueprint ----
            // 1: Initiale Berechnungen
            int width = height * 2;
            char c = '*';
            int trunkHeight = 2;
            int globesHeight = 1;

            // 2: Körper PrintBody(...)
            int bodyHeight = height - trunkHeight;
            int leavesCount;

            for (int i = 0; i <= bodyHeight; i++)
            {
                leavesCount = i * 2 + 1;
                Console.WriteLine(
                    new string(' ', (width - leavesCount) / 2) +
                    new string(c, leavesCount));
            }

            // 3: Kugeln PrintGlobes(...)
            PrintGlobes(width);

            // 4: Stamm PrintTrunk(...)
            int trunkWidth = 2;
            int trunkSpace = (width - trunkWidth) / 2;
            Console.WriteLine(new string(' ', trunkSpace) + new string('|', trunkWidth));
            Console.WriteLine(new string(' ', trunkSpace) + new string('|', trunkWidth));
        }

        public static void PrintGlobes(int width)
        {
            // PrintTimes ersetzt new string 
            // new string ist nur für einzelne Character
            PrintTimes("0 ", width / 2);
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