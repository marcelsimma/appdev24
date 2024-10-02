namespace BarbaraMarte.Week01 
{
    class Deltoid 
    {
        public static void PrintDeltoid(char c, int size)
        {
           {
            for (int i = 0; i < size; i++)
                      
            if (i == 0)
            { //Erste Zeile
                Console.WriteLine(new string('.', (size-1)/2) + c + new string('.', (size-1)/2));
            }

            else if (i == (size-1)/2) //Mitte
            { 
                Console.WriteLine(c + new string('.', size - 2) + c);
            }

            else if (i == size - 1) //Letzte Zeile
            {   
                Console.WriteLine( new string('.', (size-1)/2) + c + new string('.', (size-1)/2));
            }

            else if(i > 0 && i < (size-1)/2) //Obere Hälfte
            { 
                 Console.WriteLine(new string('.',(size/2) - i) + c + new string('.', i * 2 - 1) + c + new string('.',(size/2) - i));
            }

            else if(i > (size -1)/2 && i < size -1) //Untere Hälfte
            { 
                 Console.WriteLine(new string('.',i-(size-1)/2) + c + new string('.', 2*size - 3 - 2*i) + c + new string('.',(size-1)/2));
            }
           }
        }   

    }
}
