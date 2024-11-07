using System.Runtime.InteropServices;

namespace BarbaraMarte.Week02;

class ConsoleInput
{
    public static int ReadNextInt()
    {
        do
        {
            Console.WriteLine("Bitte gib eine ganze Zahl ein.");
            string tmp = Console.ReadLine();
            if (int.TryParse(tmp, out int result)) // out gibt mehrere Rückgabewerte zurück
            {
                return result; // result gibt etwas zurück und bricht die Methode an dieser Stelle ab. Break gibt nichts zurück, bricht nur die Schleife
            }
            else
            {
                Console.WriteLine("Du hast keine Zahl eingegeben");
            }
        } while (true);
    }

    public static double ReadNextDouble()
    {
        while (true)
        {
            Console.WriteLine("Bitte gib eine Komma Zahl ein.");
            string tmp = Console.ReadLine();
            if (double.TryParse(tmp, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Du hast keine Zahl eingegeben");
            }
        }
    }

    public static char ReadNextChar()
    {
        char result;
        while (true)
        {
            Console.WriteLine("Bitte gib eine Zeichen ein.");
            string tmp = Console.ReadLine();
            if (char.TryParse(tmp, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Du hast kein Zeichen eingegeben");
            }
        }
    }
}