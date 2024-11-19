using System;
namespace JulianStroehle.Week7
{
    internal class BrowserHistory
    {
        static ConsoleKeyInfo input;
        internal static void Start()
        {
            Stack<string> links = new Stack<string>();
            do
            {
                if (input.Key == ConsoleKey.DownArrow || links.Count == 0)
                {
                    Console.WriteLine("Website:");
                    links.Push(Console.ReadLine());
                    Console.WriteLine("Pfeiltaste nach Oben für vorherige Website, Pfeiltaste nach Unten um eine neue Website aufzumachen.");
                }
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine(links.Pop());
                }
            }
            while (links.Count > 0);
        }
    }
}