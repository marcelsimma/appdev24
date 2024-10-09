namespace BarbaraMarte.Week02;

class Pi
{
    public static void PrintPi()
    {
        double pi = 0.0;
        double a = 1.0;
        bool add = true;

        for (double i = 0; i < 10; i++)
        {
            if (add)
            {
                pi += 4 / a;
                Console.WriteLine($"4 / {a} = {4 / a} --");
            }
            else
            {
                pi -= 4 / a;
                Console.WriteLine($"- 4 / {a} = {-4 / a} .. ");
            }

            a += 2;
            add = !add;
        }
        Console.WriteLine($"Approximated Pi: {pi}");
        Console.WriteLine();
        {
            // first try. Didn't work as assumed
            double A = 1;
            double b = 3;

            for (decimal i = 0; i <= 10; i++)
            {
                Console.WriteLine($"+ 4 / {A} - 4 / {b}  = {+4 / A - 4 / b}");
                A += 2;
                b += 2;
            }
        }

    }
}