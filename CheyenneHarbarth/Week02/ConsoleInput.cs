using System;
using System.Numerics;

namespace CheyenneHarbarth.Week02
{
    class ConsoleInput
    {
        public static void Start()
        {

            Console.WriteLine(ReadInt() * 2);
            Console.WriteLine(ReadDouble() *2);
            Console.WriteLine(ReadChar());

        }

        public static int ReadInt()
        {
            while (true)
            {
                //Console.WriteLine("Tippe eine Zahl ein!");
                string tmp = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren
                if (int.TryParse(tmp, out int tmp2))
                {
                    return tmp2;
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                    Console.WriteLine("Das war keine gültige Zahl. Bitte versuche es erneut.");
                }
            }
        }

        public static double ReadDouble() {
             while (true)
            {
                Console.WriteLine("Tippe eine Kommazahl ein!");
                string dtmp = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren
                if (double.TryParse(dtmp, out double dtmp2))
                {
                    return dtmp2;
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                    Console.WriteLine("Das war keine gültige Kommazahl. Bitte versuche es erneut.");
                }
            }
        }

        public static char ReadChar() {
             while (true)
            {
                //Console.WriteLine("Tippe ein Zeichen ein!");
                string ctmp = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren
                if (char.TryParse(ctmp, out char ctmp2))
                {
                    return ctmp2;
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                    Console.WriteLine("Das war kein gültiges Zeichen. Bitte versuche es erneut.");
                }
            }
        }
    }
}