using System;

namespace JonasWehinger.Week02
{
    public class Factorial
    {
        public static void Start()
        {
        Teilen();
        
        }

    public static void Teilen()
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
}