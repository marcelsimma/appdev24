using System;


namespace BerkantAkinci
{


    class EmptySquare
    {


        public static void PrintEmptySquare(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                // Schreibt die erste Zeile mit Sternen.
                if (i == 0)
                {

                    for (int j = 0; j < size; j++)
                    {

                        Console.Write(c);
                    }
                }
                // Schreibt die letzte Zeile mit Sternen.
                else if (i == 6)
                {

                    for (int j = 0; j < size; j++)
                    {

                        Console.Write(c);

                    }
                }
                else
                {
                    Console.Write(c);

                    for (int j = 0; j < size - 2; j++)
                    {

                        Console.Write(' ');
                    }
                    Console.Write(c);
                }
                Console.WriteLine();


            }


        }
    }
}

