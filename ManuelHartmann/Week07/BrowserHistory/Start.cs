using System.Security.Cryptography.X509Certificates;

namespace ManuelHartmann.Week07.BrowserHistory
{
    public class Start
    {
        /*

        1. Grundannahmen definieren und Context abstecken
        Grundannahme: Highend Kamera wo Objektiv und Speicherkarte tauschbar sind. 

        2. Klassendiagramm erstellen mit allen Klassen(, Interfaces, Beziehungen, etc.)

        3. Klassen programmieren
        */

        public static void Launch()
        {
            var browserHistory = new BrowserHistory();

            // Predefined website visits
            browserHistory.WebSites.Push(new CallWebsite("YouTube", DateTime.Now));
            browserHistory.WebSites.Push(new CallWebsite("DarkNet", DateTime.Now));
            browserHistory.WebSites.Push(new CallWebsite("Instagram", DateTime.Now));
            browserHistory.WebSites.Push(new CallWebsite("Facebook", DateTime.Now));
            browserHistory.WebSites.Push(new CallWebsite("Wiki", DateTime.Now));

            UserInput(browserHistory);
        }
        public static void UserInput(BrowserHistory browserHistory)
        {
            string respond;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter 'forward' to visit a new website, 'back' to return to the last website, or 'overview' to view the history.\n" +
                                  "Type 'exit' to quit.");
                respond = Console.ReadLine()?.ToLower();

                switch (respond)
                {
                    case "forward":
                        Console.WriteLine("Enter the website name:");
                        string? websiteName = Console.ReadLine();
                        browserHistory.WebSites.Push(new CallWebsite(websiteName, DateTime.Now));
                        Console.WriteLine($"Visited {websiteName}.");
                        Console.ReadLine();
                        break;

                    case "back":
                        if (browserHistory.WebSites.Count > 0)
                        {
                            var lastWebsite = browserHistory.WebSites.Pop();
                            Console.WriteLine($"Returned from {lastWebsite.WebsiteName}.");
                        }
                        else
                        {
                            Console.WriteLine("No websites in history.");
                        }
                        Console.ReadLine();
                        break;

                    case "overview":
                        Console.WriteLine("Browser History:");
                        Console.WriteLine(browserHistory);
                        Console.ReadLine();
                        break;

                    case "exit":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
