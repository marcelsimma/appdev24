using System;
namespace NicoDobler.Week02
{


class Factorial
{
    public static void factorialCalc()
    {
        CountAndPrint();
    }

    public static void CountAndPrint()
    {
        for (int x = 0; x <= 20; x++)
        {
            Console.WriteLine($"{x} / 5 = {x / 5}");
            Console.WriteLine($"{x} / 5.0 = {x / 5.0}");
        }
    }
}
}