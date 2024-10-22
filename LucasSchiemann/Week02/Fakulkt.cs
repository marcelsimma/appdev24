using System;
 
 namespace LucasSchiemann.Week02;
public class Test
{

    public static void Zähler()
    {
        double x = 0.0;
        while (x<100)
        {
            x = x + 0.1;
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

