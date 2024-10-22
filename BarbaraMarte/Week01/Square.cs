using System;
    public class PrintSquareA
    {
        // Funtioniert nicht!
        // Print the top line
        public static void PrintSquare(char character, int size)
        {   
                for (int i = 0; i < size; i++)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine();
        // Print the middle rows (left boundary, spaces, right boundary)
        for (int i = 0; i < size -2; i++)
        {
            Console.Write(character); // Left boundary
            for(int j = 0; j < size - 2; j++) 
            {
                Console.WriteLine(' '); // Print spaces
            }        
            
        }
             Console.Write(character); // Right boundary
             Console.WriteLine();
        
            // Print the bottom line
            for (int i = 0; i < size; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        
        }   
    }

     public class PrintSquare
    {
        public static void PrintEmptySquare(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                //Schreibt die erste Zeile mit Sternen
                if (i == 0)
                {
                    for (int j = 0; j < size; j++)
                        Console.Write(c);
                }
                //Schreibt Letzte Zeile mit Sternen
                else if(i == size - 1)
                {
                    for ( int j = 0; j < size; j++){
                        Console.Write(c);
                    }
                }
                else
                {
                    Console.Write(c);

                    for (int j = 0; j < size -2; j++){
                        Console.Write(' ');
                    }
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        

        }
    }