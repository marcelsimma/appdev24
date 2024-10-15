namespace BarbaraMarte.Schule;

class Methode
{
    public static void Print(string[] arg)
    {
        Console.WriteLine("Give me a number");
        int number = Convert.ToInt32(Console.ReadLine());

        number++;
        Console.WriteLine(number);
    }
}