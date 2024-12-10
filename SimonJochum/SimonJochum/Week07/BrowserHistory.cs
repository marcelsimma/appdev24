using System;
using System.Collections;

namespace SimonJochum.Week07
{
    public class BrowserHistory
    {
        static Stack<string> historyList = new Stack<string>();
        public static void Start()
        {
            Console.WriteLine("Willkommen in Ihrem Browserverlauf.\nWelche Website möchten Sie besuchen? Bitte den Link einfügen.");
            string firstEntry = Console.ReadLine();
            historyList.Push(firstEntry);
            Console.WriteLine(new string('-', 30) + $"\nAktuelle Seite: {firstEntry}\n" + new string('-', 30));
            Choice();
        }
        public static void Choice()
        {
            Console.WriteLine("Was möchten Sie tun?\n1. eine neue Seite besuchen\n2. einen Schritt zurück im Verlauf.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    OneStepAhead();
                    break;
                case "2":
                    OneStepBack();
                    break;
                default:
                    Console.WriteLine("Bitte geben Sie eine gültige Anweisung ein.");
                    Choice();
                    break;
            }
        }
        public static void OneStepAhead()
        {
            Console.WriteLine("Welche Webseite möchtest du besuchen?");
            string nextEntry = Console.ReadLine();
            historyList.Push(nextEntry);
            Console.WriteLine(new string('-', 30) + $"\nAktuelle Seite: {nextEntry}\n" + new string('-', 30));
            Choice();
        }
        public static void OneStepBack()
        {
            if (historyList.Count > 1)
            {
                historyList.Pop();
                Console.WriteLine(new string('-', 30) + "\nAktuelle Seite: " + historyList.Peek() + "\n" + new string('-', 30));
                Choice();
            }
            else
            {
                Console.WriteLine(new string('-', 30) +"\nBrowserverlauf leer.\n" + new string('-', 30));
                return;
            }
        }
    }
}