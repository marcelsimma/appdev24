using System.Runtime.InteropServices;

namespace BarbaraMarte.Week02;

class ConsoleInput
{
    public static int ReadNextInt()
    {
        Console.WriteLine("Bitte gib eine ganze Zahl ein.");
        string tmp = Console.ReadLine();
        if (int.TryParse(tmp, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Du hast keine Zahl eingegeben");
            return -1;
        }
    }

    public static double ReadNextDouble()
    {
        return 0.0;

    }

    public static char ReadNextChar()
    {
        return 'c';
    }
}