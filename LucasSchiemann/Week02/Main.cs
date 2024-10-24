using System;
using LucasSchiemann.Week02;

namespace LucasSchiemann.Week02;

    class Mainer
    {
    static void Start()
    {
        //int CounterPiCalc = 0;
        //LucasSchiemann.Week02.PiCalc.CalcMethod();
       // Week02.PiCalc.CalcMethod();
        //BubbleSorter.Processor();
    }
 


    public static void HochZähler()
    {

        double x = 0.0;

        while (x < 100)
        {

            x += 0.1;
            double.Round(x,2);
            Console.WriteLine(x);
        }
    }
    static void Teilen()
    {
        int x = 0;
        while (x <= 20)
        {
            Console.WriteLine($"{x} / 5 = {x / 5}");
            Console.WriteLine($"{x} / 5.0 = {x / 5.0}");
            Console.WriteLine("");
            x++;
        }
    }
    }

