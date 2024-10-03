using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;
namespace FlorianBaier.Week01
{


    public class FunctionWithReturn
    {


        public static void Start(int minValue, int maxValue)
        {
            int result = 0;
            Console.WriteLine($"Summe von {minValue} bis {maxValue} addiert: ");
            Console.WriteLine(new string('-', 30));

            for (int i = minValue; i <= maxValue; i++)
            {
                Console.Write($"Rechenweg: {result} + {i} = ");
                result = Addition(result, i);
                Console.WriteLine(result);
            }
            Console.WriteLine("Gesamtsumme: " + result);
            Console.WriteLine(new string('-', 30));
        }

        public static int Addition(int a, int b)
        {
            int result = a + b;

            return result;
        }

        public static int Result(int minValue, int maxValue)
        {
            int result = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                result += i;
            }
            return result;
        }
    }
}