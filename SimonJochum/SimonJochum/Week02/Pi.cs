using System;

namespace SimonJochum.Week02
{
    public class CalcPi
    {
        public static void Pi()
        {
         const double constant = 4.0;
         double divider = 1.0;
         double value = 0.0;
        
         for (int i = 0; i <= 500000; i++)
         {
            if (i == 0)
            {
                value = constant / divider;
            }
            
            else if (i % 2 == 0)
            {
                value = value + (constant / divider);
            }
            else
            {
                value = value - (constant / divider);
                
            }
            divider += 2;

         }
         Console.WriteLine($"Pi hat den Wert von {value}.");

        
        }
    }
}