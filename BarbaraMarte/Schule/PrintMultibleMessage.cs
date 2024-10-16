namespace BarbaraMarte.Schule;

class PrintMultibleMesseges()
{
    public static void Print()
    {
        Console.WriteLine("Enter a Messege and how often I shall repead it");
        string messege = Console.ReadLine();
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(messege);
        }

    }
}