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

            string target = "https://www.google.at/";

            BrowserHistory.Push(target);
            BrowserHistory.Push("instagram.com");
            BrowserHistory.Push("vol.at");
            BrowserHistory.Push("connex.com");

            /* WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(target);

            WebProxy myProxy = new WebProxy("myproxy", 80);
            myProxy.BypassProxyOnLocal = true;

            wrGETURL.Proxy = WebProxy.GetDefaultProxy();

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Console.WriteLine("{0}:{1}", i, sLine);
            }
            Console.ReadLine();

            //Nur Ausgeben
            foreach () */

            //Zum Ausgeben und Abarbeiten
            while (BrowserHistory.Count > 0)
            {
                Console.WriteLine(BrowserHistory.Pop());
            }
        }
    }
}