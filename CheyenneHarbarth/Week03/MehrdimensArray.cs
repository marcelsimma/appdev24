using System;

namespace CheyenneHarbarth.Week03
{

    class MehrdimensArray
    {

        public static void PrintArrays()
        {

            //2D-Array
            int[,] merdimArray = new int[3, 2] {                                //3 Zeilen, 2 Spalten, der Beistrich steht für mehrdimensionales Array
                {1,2},
                {3,4},
                {5,6}
            };

            for (int i = 0; i < merdimArray.GetLength(0); i++)                  //.GetLength(0)-Methode ermittelt die Anzahl der Zeilen des Arrays
            {
                for (int j = 0; j < merdimArray.GetLength(1); j++)              //.GetLength(1) ermittelt die Anzahl der Spalten
                {
                    Console.Write(merdimArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //jagged Array
            int[][] jaggedArray = new int[3][];                 //3 Zeilen aber keine fixe Zahl für die Spalten
            jaggedArray[0] = new int[] { 1, 2 };                //jetzt wird für jede Zeile die Spalten definiert
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            for (int i = 0; i < jaggedArray.Length; i++)        //wir brauchen beide for-Schleifen um das Array drucken zu lassen, die 1. für die Zeilen die 2. für die Spalten
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}