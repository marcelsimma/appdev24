using System.Data;
using System.Globalization;

namespace BarbaraMarte.Week02;

class Count
{
    public static void PrintCount()
    {
        // the m treats the 0.1 as a decimal. For example, 0,1 in double might not be stored exactly as 0,1 due to rounding issues inherent in floating-point arithmetic.
        decimal number = 0.1m;
        for (decimal i = 0.0m; i <= 100.01m; i += 0.1m)
        {
            number += i;
            Console.WriteLine(i);
        }
    }


    // "orginal code" didn't work properly. The numbers after the comma were not propperly roundet doug to the foating issue in double. So instead of 98,8 you get 98,89999999999866  
    //double number = 0.1;
    //  for (double i = 0.0; i <= 100.01; i += 0.1)
    //{
    //  number += i;
    //Console.WriteLine(i);

    //}

}



