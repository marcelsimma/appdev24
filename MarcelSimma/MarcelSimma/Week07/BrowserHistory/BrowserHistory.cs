using System;

namespace MarcelSimma.Week07.BrowserHistory {
    public class BrowserHistory {
        public static void Start() {

            Stack<string> browserHistory = new Stack<string>();

            // Website hinzufügen
            browserHistory.Push("vol.at");

            browserHistory.Push("google.com");

            // Website entfernen = zurück gehen in der History

            System.Console.WriteLine(browserHistory.Pop());
            // Pop entspricht Dequeue

            // Länge/Höhe des Stack ausgeben

            System.Console.WriteLine(browserHistory.Count());

            // Vorschau
            if (browserHistory.Peek() == "vol.at") {
                System.Console.WriteLine("Beste Nachrichten aus Vorarlberg!");
            } else {
                System.Console.WriteLine("vol.at nicht besucht.");
            }

            System.Console.WriteLine(browserHistory.Count());
            
            // Push entspricht Enqueue
            browserHistory.Push("tiktok.com");
            browserHistory.Push("instagram.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("digitalcampus.com");

            // Elemente nur ausgeben
            foreach (string item in browserHistory) {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            // Elemente vom Stack entfernen und auf der Console ausgeben           
            while (browserHistory.Count() > 0) {
                System.Console.WriteLine(browserHistory.Pop());
            }
            System.Console.WriteLine(browserHistory.Count());
            
            
            
            
            
            
            
            
            
            
            /*
            
            System.ConsoleKeyInfo key = Console.ReadKey();

            if(key.Key == ConsoleKey.LeftArrow) {
                System.Console.WriteLine("Lesen");
            } else {
                System.Console.WriteLine("schreiben");
            }

            */
        }
    }
}