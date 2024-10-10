using System;

namespace CheyenneHarbarth.Week02
{

    class Einkaufsliste
    {

        public static void PrintList()
        {
            while (true)
            {
                Console.WriteLine(AskWhat());
                Console.WriteLine(AskHowmany());
            }
        }

        public static string AskWhat()
        {
            Console.WriteLine("Was musst du noch einkaufen?");
            string userinput = Console.ReadLine();
            return userinput;

        }
        public static int AskHowmany()
        {
            while (true)
            {
                Console.WriteLine($"Wieviel brauchst du davon?");
                string muchness = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren, gibt dann true oder false zurück
                if (int.TryParse(muchness, out int muchness2) /*|| muchness == 0*/)
                {
                    return muchness2;
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                    Console.WriteLine($"Das war keine gültige Zahl.");
                }
            }
        }
    }
}