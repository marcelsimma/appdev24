using System;
using System.Diagnostics;
using System.Xml;

namespace CheyenneHarbarth.Week02
{

    class Einkaufsliste
    {

        public static void PrintList()
        {
            string List = "Deine Einkaufsliste: \n";
            int NumberOfItems = 0;

            while (true)
            {
                Console.WriteLine("Was musst du noch einkaufen?");
                string item = Console.ReadLine();

                if (item == "Liste")
                {
                    break;                                                  //bricht die while-Schleife ab
                }

                NumberOfItems++;                                            //damit erhöhen wir die Anzahl der Elemente am Schluss der Liste

                while (true)
                {
                    Console.WriteLine($"Wieviel brauchst du von {item}?");
                    string muchness = Console.ReadLine();

                    // Versuche, die Eingabe als Integer zu konvertieren, gibt dann true oder false zurück
                    if (int.TryParse(muchness, out int quantity))
                    {
                        if (quantity == 0)
                        {

                            Console.WriteLine("Das ist keine gültige Zahl. Bitte gib eine andere Zahl ein.");
                        }
                        else
                        {


                            List += $"{quantity, 5} {item}\n";
                            break;
                        }
                    }
                    else
                    {
                        // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                        Console.WriteLine($"Das ist keine gültige Zahl. Bitte gib eine andere Zahl ein.");
                    }
                }

            }
            Console.WriteLine(List);
            Console.Write($"-------------------------- \n Anzahl der Elemente: {NumberOfItems}");
        }
    }
}