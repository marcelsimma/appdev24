using System;

namespace BarbaraMarte.Schule;
class BinaryRechner
{
    public static void Print()
    {
        string? binary = Console.ReadLine();
        int count = 0;
        int powerOfTwo = 1;


        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                count += powerOfTwo;
            }
            powerOfTwo *= 2;
        }
        Console.WriteLine(count);
    }
}