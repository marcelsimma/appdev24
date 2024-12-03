using System;

namespace JonasWehinger.Week07
{
    public class BrowserHistory
    {
        public static void Browser()
        {
            Stack<string> browserHistory = new Stack<string>();

            while (true)
            {
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1) Neue Website besuchen");
                Console.WriteLine("2) Zurück zur vorherigen Website");
                Console.WriteLine("3) Beenden");
                Console.Write("Deine Auswahl: ");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    Console.Write("Gebe den Namen der Website ein: ");
                    string website = Console.ReadLine();
                    browserHistory.Push(website);
                    Console.WriteLine($"Du hast {website} besucht.");
                }
                else if (action == "2")
                {
                if (browserHistory.Count > 0)
                {
                string lastWebsite = browserHistory.Pop();
                Console.WriteLine($"Du hast die Website {lastWebsite} verlassen und bist zurückgegangen.");
                }
                else
                {
                Console.WriteLine("Die Browser-Historie ist leer.");
                }
                }

                else if (action == "3")
                {
                    Console.WriteLine("Programm wird beendet.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle 1, 2 oder 3.");
                }
            }
        }
    }
}
