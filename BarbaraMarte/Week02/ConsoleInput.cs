namespace BarbaraMarte.Week02;

class ConsoleInput
{
    public static int ReadNextInt()
    {
        do
        {
        } while (true);

        string tmp = Console.ReadLine();
        int tmp2 = Convert.ToInt32(tmp);
    }

    public static double ReadNextDouble(double a, double b)
    {
        return a + b;
        
    }

    public static char ReadNextChar()
    {
        return 'c';
    }
}