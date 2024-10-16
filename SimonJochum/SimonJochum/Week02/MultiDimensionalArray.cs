using System;

namespace SimonJochum.Week02
{
    public class MultiDimensionalArray
    {
        public static void Start(char c, char d, int size)
        {
            char[,] multiArray = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    multiArray[i, j] = d; // beide Arrays werden erst mit Leerzeichen gefüllt

                    if (i == j) // für die Diagonale von links oben nach rechts unten
                    {
                        multiArray[i, j] = c;  
                    }
                    else if (j == size - i - 1) //für die Diagonale von rechts oben nach links unten
                    {
                        multiArray[i, j] = c;
                    }
                    Console.Write(multiArray[i,j]);
                }
                Console.WriteLine();   
            }
        }
    }
}