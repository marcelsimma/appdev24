namespace BarbaraMarte.Schule;

class FizBuzz
{
    public static void Print(string[] args)
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("Fizbuss");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Fizz");
            }
        }
    }
}