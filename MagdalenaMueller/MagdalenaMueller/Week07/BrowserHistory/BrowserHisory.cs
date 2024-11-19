using System;
using System.Collections.Generic;

namespace MagdalenaMueller.Week07
{
    public class BrowserHistory
    {
        static Stack<string> history = new Stack<string>();

        public static void LookBrowserHistory()
        {
            history.Push("google.com");
            history.Push("hallo.at");
            history.Push("GuteFrage.de");
            history.Push("Microsoft.at");
            history.Push("TikTok.com");  
            history.Push("Instagram.com");
            history.Push("google.com");

            while(history.Count - 1 >= 0)
            {
                Console.WriteLine("Drücke Pfeil nach unten:");
                ConsoleKey key = Console.ReadKey().Key;

                if(key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine(history.Pop());
                }
            }
            Console.WriteLine("BrowserHistory ist leer!");
        }
            
        
    }
}