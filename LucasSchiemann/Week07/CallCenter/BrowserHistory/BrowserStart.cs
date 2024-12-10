using System;

namespace LucasSchiemann.Week07.BrowserHistory;


class Program
{
    static void StartOfBrowser(string[] args)
    {
        Browser browser = new Browser();

        while (browser.IsRunning())
        {
            Console.WriteLine("Eingabe Optionen:\n1. Neue Website besuchen \n2. Zurück zur letzten Website\n3. Beenden");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
            case 1:
                Console.Write("Website-Name eingeben: ");
                string site = Console.ReadLine();
                browser.Visit(site);
                continue;
            
            case 2:
                browser.BackOnePage();
                continue;
            case 3:
            
                Console.WriteLine("Browser beendet sich...");
                break;
            
            default:
            
                Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine der Optionen.");
                continue;
            }
        }

    }
}

