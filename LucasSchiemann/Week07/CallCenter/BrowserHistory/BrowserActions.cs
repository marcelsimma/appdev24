using System;

namespace LucasSchiemann.Week07.BrowserHistory;

public class Browser
{
    
    public static Stack<string> history = new Stack<string>();
    public static string currentSite;

    public void Visit(string site)
    {
        if (currentSite != null)
        {
            history.Push(currentSite); 
            
        }
        currentSite = site;
        Console.WriteLine($"Du bist bei der Webseite: {currentSite}");
        
    }

    public void BackOnePage()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("Keine vorherige Seite vorhanden. Browser beendet sich...");
            currentSite = null;
            return;
        }

        history.Pop(); 
        currentSite = history.Peek();
        Console.WriteLine($"Zurück zu: {currentSite}");
    }

    public bool IsRunning()
    {
        return  history.Count > 0;
    }
}
 