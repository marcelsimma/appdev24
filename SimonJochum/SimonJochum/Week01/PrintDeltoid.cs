using System;

namespace SimonJochum.Week01 
{

    public class PrintDeltoid 
    {

        public static void EmptyDeltoid(char c, int size) 
        {
            for (int i = 0; i < size; i++)
            {
                if (i == 0) //Erste Zeile
                {

                    Console.WriteLine(new string('.', (size -1)/2) + c + new string('.', (size -1)/2));
                }

                else if (i == (size-1)/2) //mittlere Zeile
                {

                    Console.WriteLine(c + new string('.', size - 2) + c);
                }
                else if (i == size - 1) //letzte Zeile
                {

                    Console.WriteLine(new string('.', (size -1)/2) + c + new string('.', (size -1)/2));
                }
                else if (i > 0 && i < (size-1)/2) //oberer Teil zwischen erster und mittlerer Zeile
                {

                    Console.WriteLine(new string('.', (size/2) - i) + c + new string('.', i * 2 - 1) + c + new string('.', (size/2) - i));
                }
                else if (i > size/2 && i < size - 1) //unterer Teil zwischen mittlerer und letzter Zeile
                {

                    Console.WriteLine(new string('.', i - (size-1)/2) + c + new string('.', 2*size-3-2*i) + c + new string('.', i - (size-1)/2));
                }
            }
        
        }
    }
}