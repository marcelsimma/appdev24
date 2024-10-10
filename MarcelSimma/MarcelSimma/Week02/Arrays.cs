using System;

namespace MarcelSimma.Week02
{
    public class Arrays
    {
        public static void Start()
        {
            string manuel = "manuel",
            simon = "simon",
            barbara = "barbara",
            florian = "florian";

            Console.WriteLine($"{manuel}, {simon}, {barbara} und {florian}");

            string[] teilnehmer = new string[4];
            teilnehmer[0] = "stefan";
            teilnehmer[1] = "manuel";
            teilnehmer[2] = "Cheyenne";
            teilnehmer[3] = "Berkant";

            teilnehmer[1] = "simon";

            string[] teilnehmer2 = { "stefan", "manuel", "cheyenne", "berkant" };
            teilnehmer2[3] = "florian";


            for (int i = 0; i <= teilnehmer.Length - 1; i++)
            {
                Console.WriteLine(teilnehmer[i]);
            }

            for (int i = 0; i <= teilnehmer2.Length - 1; i++)
            {
                Console.WriteLine(teilnehmer2[i]);
            }

            // 2D Array, Matrix
            int[,] mehrdimArray = new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

        }
    }
}