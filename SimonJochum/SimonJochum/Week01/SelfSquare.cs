using System;
 
 namespace SimonJochum.Week01
 {
class SelfSquare
{
    public static void EmptySquare()
    {
   
          PrintEmptySquare1('x', 10);
        }
 
        public static void PrintEmptySquare1(char character, int size)
        {
            for (int i = 0; i < size; i++) //Ausgabe der ersten vollen Reihe
            {
                Console.Write(character);
            }
            Console.WriteLine();
 
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write(character);
                for (int j = 0; j < size - 2; j++) //Ausgabe der mittleren Zeilen welche nur den ersten und letzten Punkt setzen
                {
                    Console.Write(' ');
                }
                Console.Write(character);
                Console.WriteLine();
            }
             for (int i = 0; i < size; i++) //Ausgabe der letzten vollen Reihe
            {
                Console.Write(character);
            }
            Console.WriteLine();
         }
     }  
 }