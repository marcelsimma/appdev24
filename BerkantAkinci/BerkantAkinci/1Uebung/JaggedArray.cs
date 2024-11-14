using System;

namespace BerkantAkinci.Ubueng
{

    class JaggedArray
    {

        public static void PrintJaggedArray()
        {
            string[] regal = { "Regal A: ", "Regal B: ", "Regal C: ", "Regal D: ", "Regal E: " };
            string[][] sortiment = new string[5][];

            sortiment[0] = ["Wasser", "Apfelsaft", "Orangensaft"];
            sortiment[1] = ["Brot"];
            sortiment[2] = ["Salat", "Tomaten", "Paprika", "Kürbis", "Gurke", "Aubergine"];
            sortiment[3] = [" - leer -"];
            sortiment[4] = ["Cheddar", "Edamer", "Würstle"];

            for (int i = 0; i < sortiment.Length; i++)
            {
                System.Console.Write($"{regal[i],-10}");
                for (int j = 0; j < sortiment[i].Length; j++)
                {
                    System.Console.Write($"{sortiment[i][j],-14}");
                }
                System.Console.WriteLine();
            }
        }
    }
}