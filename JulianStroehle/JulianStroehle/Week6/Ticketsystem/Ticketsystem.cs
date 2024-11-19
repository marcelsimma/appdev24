using System;
namespace JulianStroehle.Week6.Ticketsystem
{
    internal class TicketSystem
    {
        internal static List<Konzert> Concerts = new List<Konzert>();
        internal static Queue<string> Listeners = new Queue<string>();
        internal static Dictionary<string, Konzert> BoughtTickets = new Dictionary<string, Konzert>();
        internal static void Start()
        {
            try
            {
                Konzert concert1 = new Konzert(1);
                Konzert concert2 = new Konzert(2);
                Konzert concert3 = new Konzert(3);
                Konzert concert4 = new Konzert(4);
                Konzert concert5 = new Konzert(5);
                Konzert concert6 = new Konzert(6);
                Concerts.Add(concert1);
                Concerts.Add(concert2);
                Concerts.Add(concert3);
                Concerts.Add(concert4);
                Concerts.Add(concert5);
                Concerts.Add(concert6);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();
                    Listeners.Enqueue(name);
                }
                for (int i = 0; i < Concerts.Count; i++)
                {
                    while (Listeners.Count > 0)
                    {
                        string listener = Listeners.Dequeue();
                        Console.WriteLine("Welches Konzert " + listener + $"? (1 = {concert1}, 2 = {concert2}, 3 = {concert3}, 4 = {concert4}, 5 = {concert5}, 6 = {concert6})");
                        int concert = Convert.ToInt32(Console.ReadLine());
                        switch (concert)
                        {
                            case 1: BoughtTickets.Add(listener, concert1); break;
                            case 2: BoughtTickets.Add(listener, concert2); break;
                            case 3: BoughtTickets.Add(listener, concert3); break;
                            case 4: BoughtTickets.Add(listener, concert4); break;
                            case 5: BoughtTickets.Add(listener, concert5); break;
                            case 6: BoughtTickets.Add(listener, concert6); break;
                            default: Console.WriteLine("Für dieses Konzert sind keine Tickets verfügbar"); break;
                        }
                    }
                }
                Anbieter anbieter = new Anbieter(BoughtTickets);
                anbieter.Info();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ungültige eingabe");
                Start();
            }
        }
    }
}