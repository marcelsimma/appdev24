using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace BarbaraMarte.Week01
{
    class Christbaum
    {
        public static void PrintChristbaum (char c, int size)
        {   Console.Write("Enter the height of the Chrismas tree:");
        int height = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
                      
            if (i == 0)
            { //Erste Zeile
                Console.WriteLine(new string(' ', (size-1)/2) + c + new string(' ', (size-1)/2));
            }
            else if (i == size - 3) //Ende
            {
                Console.WriteLine(c + new string('*', size - 2) + c);
            }
             else if(i > 0 && i < (size-1)/2) //Baum
            { 
                 Console.WriteLine(new string(' ',(size/2) - i) + c + new string('*', i * 2 - 1) + c + new string(' ',(size/2) - i));
            }
            else if(i == size - 2) // Kugeln/ 00
            {
                Console.WriteLine(c + new string('0', size -2));
            }
            int trunkWidth = height / 3;
            int trunkHeight = height / 4;
            if (trunkWidth < 1) trunkWidth = 1;
            if (trunkHeight < 1) trunkHeight = 1;

            for(int i = 0; i < height - trunkHeight; i++) //Stamm
            { 
                 Console.Write("k");
            }

          
            
        }
    }
}