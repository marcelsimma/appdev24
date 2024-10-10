using System;

namespace FatmanurKeles.Week02
{
    public class Program
    {
        static void Main(string[] args)
        {


        Console.WriteLine("\nGeben Sie die Menge dann die Ware ein. \nWenn Sie Fertig sind--> Fertig \n\nEINKAUFSLISTE: \n\n");
            
            string input = Console.ReadLine();
            int menge;
            string ware;
          
            do
            {
                menge = Convert.ToInt32(Console.ReadLine());
                ware = Console.ReadLine();

                if (input == "Fertig" )
                break;

                else 
                {
                Console.WriteLine(menge + ware);
                }
                

            }

            while (true);
        }
    }
}
