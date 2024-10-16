using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace BarbaraMarte.Week01
{
    class Christbaum
    {
        public static void PrintChristbaum (char c, int size)
       
        {                         
            for(int i = 0; i < size; i++)
            
            {
                int half = (size - 1) / 2;
                if(i > 0 && i < (half - 1)) //Tanne
                {                    
                Console.WriteLine(new string(' ',half - i) + c + new string('*', i * 2 - 1) + c + new string(' ', half - i));   
                }
                else if(i == size - half ) // Kugeln
                {                   
                    for(int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                else if( i > size - half + 1 && i < size - (size/4)) // Stamm
                {
                    Console.WriteLine();
                    Console.Write(new string(' ', (size - (size / 4)) / 2) + new string ('+', size / 4) + new string(' ',(size-(size/4)) / 2));
                }
                         
            }
                   
        }
    }
}
