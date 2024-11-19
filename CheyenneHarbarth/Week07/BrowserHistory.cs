using System;
using System.IO;
using System.Net;

namespace CheyenneHarbarth.Week07
{
    public class BrowseHistory
    {
        public static void Start()
        {
            Stack<string> BrowserHistory = new Stack<string>();

            BrowserHistory.Push("google.com");
            BrowserHistory.Push("instagram.com");
            BrowserHistory.Push("vol.at");
            BrowserHistory.Push("connex.com");

            while (BrowserHistory.Count > 0)
            {
                Console.WriteLine(BrowserHistory.Pop());
            }
        }
    }
}