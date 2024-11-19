using System;
namespace JulianStroehle.Week6.Ticketsystem
{
    public class Anbieter
    {
        internal Dictionary<string, Konzert> BoughtTickets;
        internal Anbieter(Dictionary<string, Konzert> boughtTickets)
        {
            BoughtTickets = boughtTickets;
        }
        internal void Info()
        {
            foreach (KeyValuePair<string,Konzert> ticket in BoughtTickets)
            {
                Console.WriteLine(ticket.Key + " geht auf das Konzert " + ticket.Value);
            }
        }
    }
}