using System;

namespace CheyenneHarbarth.Basics
{

    class Arrays
    {
        //Alles zum Thema Arrays

        public static void ArrayGrundlagen()
        {
            //Ein Array ist eine Liste

        }

        public static void MehrdimensionaleArrays()                 //auch 2D-Arrays genannt
        {

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

        //Welche Methoden kann ich mit Arrays verwenden?

        public static void ArrayMethoden()
        {   //Array.Fill, um ein Array zu füllen
            int[] Test = { 2, 8, 46, 75, 13, 64, 27 };
            
                Console.Write("unsortiert: ");
                foreach (int p in Test) 
                Console.WriteLine(p + " ");
                //Console.WriteLine();
            
            Array.Fill(Test, 2);
            Console.WriteLine($"befülltes Array: {Test}");

            //Array.Find, damit kann ich etwas suchen
            string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            string stringToFind = "Bill";
            string result = Array.Find(names, element => element == stringToFind); // gibt "Bill" zurück

            //Array.FindIndex, damit kann ich den Index von einem Element im Array ausgeben
            Array.FindIndex(names, element => element == stringToFind);             //element bleibt immer, die anderen sind variabel

            //Array.IndexOf, selbes Spiel wie FindIndex
            int ergebnis = Array.IndexOf(names, stringToFind);
            Console.WriteLine(ergebnis);


        }
    }

}

